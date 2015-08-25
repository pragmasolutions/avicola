using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using AutoMapper.QueryableExtensions;
using Avicola.Office.Data.Interfaces;
using Avicola.Office.Entities;
using Avicola.Office.Entities.DTO;
using Avicola.Office.Services.Interfaces;
using Framework.Common.Utility;
using Framework.Data.Helpers;

namespace Avicola.Office.Services
{
    public class GeneticLineService : ServiceBase, IGeneticLineService
    {
        private readonly IClock _clock;

        public GeneticLineService(IOfficeUow uow, IClock clock)
        {
            _clock = clock;
            Uow = uow;
        }

        public IQueryable<GeneticLine> GetAll()
        {
            return Uow.GeneticLines.GetAll(whereClause: null, includes: x => x.StandardGeneticLines).Where(e => !e.IsDeleted);
        }

        public List<GeneticLineDto> GetAll(string sortBy, string sortDirection, string criteria, int pageIndex, int pageSize, out int pageTotal)
        {
            var pagingCriteria = new PagingCriteria();

            pagingCriteria.PageNumber = pageIndex;
            pagingCriteria.PageSize = pageSize;
            pagingCriteria.SortBy = !string.IsNullOrEmpty(sortBy) ? sortBy : "CreatedDate";
            pagingCriteria.SortDirection = !string.IsNullOrEmpty(sortDirection) ? sortDirection : "DESC";

            Expression<Func<GeneticLine, bool>> where = x => !x.IsDeleted &&
                                                        ((string.IsNullOrEmpty(criteria) || x.Name.Contains(criteria)));

            var results = Uow.GeneticLines.GetAll(pagingCriteria,
                                                    where,
                                                    x => x.StandardGeneticLines);

            pageTotal = results.PagedMetadata.TotalItemCount;

            return results.Entities.Project().To<GeneticLineDto>().ToList();
        }

        public GeneticLine GetById(Guid id)
        {
            return Uow.GeneticLines.Get(g => g.Id == id, 
                                    g => g.StandardGeneticLines, 
                                    g => g.StandardGeneticLines.Select(s => s.Standard),
                                    g => g.StandardGeneticLines.Select(sgl => sgl.StandardItems));
        }

        public GeneticLine GetByName(string name)
        {
            return Uow.GeneticLines.Get(e => e.Name == name && !e.IsDeleted);
        }

        public void Create(GeneticLine geneticLine)
        {
            if (!IsNameAvailable(geneticLine.Name, geneticLine.Id))
            {
                throw new ApplicationException("Ya existe una línea genética con el mismo nombre");
            }

            Uow.GeneticLines.Add(geneticLine);
            Uow.Commit();
        }

        public void Edit(GeneticLine geneticLine)
        {
            var currentGeneticLine = this.GetById(geneticLine.Id);
            var previousWeeks = currentGeneticLine.ProductionWeeks;

            currentGeneticLine.Name = geneticLine.Name;
            currentGeneticLine.ProductionWeeks = geneticLine.ProductionWeeks;

            var standards = currentGeneticLine.StandardGeneticLines.Where(x => !x.IsDeleted).ToList();
            if (standards.Any())
            {
                foreach (var standard in standards)
                {
                    if (previousWeeks < geneticLine.ProductionWeeks)
                    {
                        for (int i = previousWeeks; i < geneticLine.ProductionWeeks; i++)
                        {
                            var item = new StandardItem()
                            {
                                Sequence = i + 1,
                                Value = 0,
                                StandardGeneticLineId = standard.Id
                            };
                            Uow.StandardItems.Add(item);
                        }
                    }
                    else if (previousWeeks > geneticLine.ProductionWeeks)
                    {
                        var orderedList = standard.StandardItems.Where(x => !x.IsDeleted).OrderBy(x => x.Sequence).ToList();
                        for (int i = geneticLine.ProductionWeeks; i < previousWeeks; i++)
                        {
                            var item = orderedList.ElementAt(i);
                            Uow.StandardItems.Delete(item);
                        }
                    }
                }
            }

            Uow.GeneticLines.Edit(currentGeneticLine);
            Uow.Commit();
        }

        public void Delete(Guid geneticLineId)
        {
            Uow.GeneticLines.Delete(geneticLineId);
            Uow.Commit();
        }

        public bool IsNameAvailable(string name, Guid id)
        {
            var currentGeneticLine = this.GetByName(name);

            if (currentGeneticLine == null)
            {
                return true;
            }

            return currentGeneticLine.Id == id;
        }
    }
}
