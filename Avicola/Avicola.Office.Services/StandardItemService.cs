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
                            x.StandardGeneticLine.GeneticLineId == geneticLineId &&
                            x.StandardGeneticLine.StageId == stageId, 
                    includes: x => x.StandardGeneticLine.Standard)
                    .Where(e => !e.IsDeleted)
                    .OrderBy(x => x.Sequence)
                    .ToList();


            var geneticLine = Uow.GeneticLines.Get(geneticLineId);

            if (stageId == Stage.BREEDING && items.Count != geneticLine.WeeksInBreeding)
            {
                throw new ApplicationException("La cantidad de standard items de semanas no puede ser differente a la cantidad de semanas en cria");
            }

            if (stageId == Stage.POSTURE && items.Count != geneticLine.ProductionWeeks - geneticLine.WeeksInBreeding)
            {
                throw new ApplicationException("La cantidad de standard items de semanas no puede ser differente a la cantidad de semanas en postura");
            }

            return items;
        }

    }
}
