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
using Avicola.Office.Services.Dtos;
using Avicola.Office.Services.Interfaces;
using Framework.Common.Utility;
using Framework.Data.Helpers;

namespace Avicola.Office.Services
{
    public class StandardService : ServiceBase, IStandardService
    {
        private readonly IClock _clock;

        public StandardService(IOfficeUow uow, IClock clock)
        {
            _clock = clock;
            Uow = uow;
        }

        public IQueryable<Standard> GetAll()
        {
            return Uow.Standards.GetAll(whereClause: null, includes: x => x.StandardGeneticLines).Where(e => !e.IsDeleted);
        }

        public List<StandardDto> GetAll(string sortBy, string sortDirection, string criteria, int pageIndex, int pageSize, out int pageTotal)
        {
            var pagingCriteria = new PagingCriteria();

            pagingCriteria.PageNumber = pageIndex;
            pagingCriteria.PageSize = pageSize;
            pagingCriteria.SortBy = !string.IsNullOrEmpty(sortBy) ? sortBy : "CreatedDate";
            pagingCriteria.SortDirection = !string.IsNullOrEmpty(sortDirection) ? sortDirection : "DESC";

            Expression<Func<Standard, bool>> where = x => !x.IsDeleted &&
                                                        ((string.IsNullOrEmpty(criteria) || x.Name.Contains(criteria)));

            var results = Uow.Standards.GetAll(pagingCriteria,
                                                    where,
                                                    x => x.StandardGeneticLines);

            pageTotal = results.PagedMetadata.TotalItemCount;

            return results.Entities.Project().To<StandardDto>().ToList();
        }

        public Standard GetById(Guid id)
        {
            return Uow.Standards.Get(id);
        }

        public Standard GetByName(string name)
        {
            return Uow.Standards.Get(e => e.Name == name && !e.IsDeleted);
        }

        public void Create(Standard standard)
        {
            if (!IsNameAvailable(standard.Name, standard.Id))
            {
                throw new ApplicationException("Ya existe un estandar con el mismo nombre");
            }

            Uow.Standards.Add(standard);
            Uow.Commit();
        }

        public void Edit(Standard standard)
        {
            var currentStandard = this.GetById(standard.Id);

            currentStandard.Name = standard.Name;
            currentStandard.DataLoadTypeId = standard.DataLoadTypeId;

            Uow.Standards.Edit(currentStandard);
            Uow.Commit();
        }

        public void Delete(Guid standardId)
        {
            Uow.Standards.Delete(standardId);
            Uow.Commit();
        }

        public bool IsNameAvailable(string name, Guid id)
        {
            var currentStandard = this.GetByName(name);

            if (currentStandard == null)
            {
                return true;
            }

            return currentStandard.Id == id;
        }
    }
}
