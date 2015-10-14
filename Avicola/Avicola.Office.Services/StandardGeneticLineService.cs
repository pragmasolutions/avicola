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
    public class StandardGeneticLineService : ServiceBase, IStandardGeneticLineService
    {
        private readonly IClock _clock;

        public StandardGeneticLineService(IOfficeUow uow, IClock clock)
        {
            _clock = clock;
            Uow = uow;
        }

        public IList<StandardGeneticLine> GetByGeneticLine(Guid geneticLineId)
        {
            var list = Uow.StandardGeneticLines.GetAll(x => x.GeneticLineId == geneticLineId, x => x.Standard).ToList();
            return list;
        }


        public StandardGeneticLine GetById(Guid standardGeneticLineId)
        {
            var item = Uow.StandardGeneticLines.Get(x => x.Id == standardGeneticLineId, 
                                                                    x => x.StandardItems, 
                                                                    x => x.GeneticLine, 
                                                                    x => x.Standard);
            return item;
        }

        public void Create(StandardGeneticLine item)
        {
            foreach (var standardItem in item.StandardItems)
            {
                standardItem.Id = Guid.NewGuid();
                standardItem.IsDeleted = false;
                standardItem.CreatedDate = _clock.Now;
            }
            Uow.StandardGeneticLines.Add(item);
            Uow.Commit();
        }

        public bool CheckExistance(Guid geneticLineId, Guid? standardId)
        {
            var list = Uow.StandardGeneticLines.GetAll().Where(x => x.StandardId == standardId
                                                                    && x.GeneticLineId == geneticLineId
                                                                    && !x.IsDeleted);
            return list.Any();
        }


        public void Delete(Guid id)
        {
            Uow.DbContext.StandardGeneticLineDelete(id);
        }


        public void Edit(StandardGeneticLine item)
        {
            foreach (var standardItem in item.StandardItems)
            {
                standardItem.StandardGeneticLineId = item.Id;
                Uow.StandardItems.Edit(standardItem);
            }
            Uow.Commit();
        }
    }
}
