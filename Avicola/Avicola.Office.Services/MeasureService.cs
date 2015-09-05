using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using AutoMapper.QueryableExtensions;
using Avicola.Office.Data.Interfaces;
using Avicola.Office.Entities;
using Avicola.Office.Services.Dtos;
using Avicola.Office.Services.Interfaces;
using Framework.Common.Utility;
using Framework.Data.Helpers;

namespace Avicola.Office.Services
{
    public class MeasureService : ServiceBase, IMeasureService
    {
        public MeasureService(IOfficeUow uow)
        {
            Uow = uow;
        }

        public void CreateMeasures(IEnumerable<Measure> measures, Guid batchId)
        {
            var batch = Uow.Batches.Get(batchId);

            foreach (var measure in measures)
            {
                if (measure.StandardItemId == default(Guid))
                {
                    var sequence = CalculateSequence(batch.CreatedDate, measure.CreatedDate);
                    var standardItem = Uow.StandardItems.Get(x => x.Sequence == sequence &&
                                                                  x.StandardGeneticLine.GeneticLineId ==
                                                                  batch.GeneticLineId &&
                                                                  x.StandardGeneticLine.StandardId == Guid.Empty);

                    measure.StandardItemId = standardItem.Id;
                }

                Uow.Measures.Add(measure);
            }

            Uow.Commit();
        }

        private int CalculateSequence(DateTime batchCreatedDate, DateTime measureCreateDate)
        {
             int weeks = (int) ((batchCreatedDate - measureCreateDate).TotalDays / 7);

            return weeks;
        }
    }
}
