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
    public class StandardItemService : ServiceBase, IStandardItemService
    {
        public StandardItemService(IOfficeUow uow)
        {
            Uow = uow;
        }

        public IList<StandardItem> GetByStandardAndGeneticLine(Guid standardId, Guid stageId, Guid geneticLineId)
        {
            var items =
                Uow.StandardItems.GetAll(
                    whereClause:
                        x =>
                            x.StandardGeneticLine.StandardId == standardId &&
                            x.StandardGeneticLine.GeneticLineId == geneticLineId,
                    includes: x => x.StandardGeneticLine.Standard)
                    .Where(e => !e.IsDeleted && !e.StandardGeneticLine.IsDeleted && !e.StandardGeneticLine.Standard.IsDeleted)
                    .OrderBy(x => x.Sequence)
                    .ToList();

            return items;
        }
    }
}
