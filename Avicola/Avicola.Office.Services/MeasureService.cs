using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using AutoMapper.QueryableExtensions;
using Avicola.Office.Data.Interfaces;
using Avicola.Office.Entities;
using Avicola.Office.Services.Dtos;
using Avicola.Office.Services.Interfaces;
using Framework.Common.Extentensions;
using Framework.Common.Utility;
using Framework.Data.Helpers;

namespace Avicola.Office.Services
{
    public class MeasureService : ServiceBase, IMeasureService
    {
        private readonly IClock _clock;

        public MeasureService(IOfficeUow uow, IClock clock)
        {
            _clock = clock;
            Uow = uow;
        }

        public void CreateMeasures(IEnumerable<LoadMeasureModel> measures, Guid batchId)
        {
            var batch = Uow.Batches.Get(batchId);

            foreach (var measure in measures)
            {
                var sequence = CalculateSequence(measure.StandardId, batch.CreatedDate,
                    measure.CreatedDate.GetValueOrDefault());

                var standardItem = Uow.StandardItems.Get(x => x.Sequence == sequence &&
                                                              x.StandardGeneticLine.GeneticLineId ==
                                                              batch.GeneticLineId &&
                                                              x.StandardGeneticLine.StandardId == measure.StandardId);

                if (standardItem == null)
                {
                    throw new ApplicationException("No se encontro ningun standard item para los valores indicados");
                }

                var newMeasure = new Measure()
                                 {
                                     Id = Guid.NewGuid(),
                                     BatchId = batchId,
                                     CreatedDate = _clock.Now.Date,
                                     StandardItemId = standardItem.Id,
                                     Value = measure.Value.GetValueOrDefault()
                                 };

                Uow.Measures.Add(newMeasure);
            }

            Uow.Commit();
        }

        private int CalculateSequence(Guid standardId, DateTime batchCreatedDate, DateTime measureCreateDate)
        {
            var standard = Uow.Standards.Get(standardId);

            switch (standard.DataLoadTypeId.ToString().ToUpper())
            {
                case GlobalConstants.DailyDataLoadType:
                    return GetDaySequence(batchCreatedDate, measureCreateDate);
                case GlobalConstants.WeeklyDataLoadType:
                    return GetWeekSequence(batchCreatedDate, measureCreateDate);
                default:
                    return GetDaySequence(batchCreatedDate, measureCreateDate);
            }
        }

        private static int GetWeekSequence(DateTime batchCreatedDate, DateTime measureCreateDate)
        {
            int weeks = (int)((batchCreatedDate - measureCreateDate).TotalDays / 7);
            weeks = weeks > 0 ? weeks : 1;
            return weeks;
        }

        private static int GetDaySequence(DateTime batchCreatedDate, DateTime measureCreateDate)
        {
            int days = (int)((batchCreatedDate - measureCreateDate).TotalDays);
            days = days > 0 ? days : 1;
            return days;
        }

        public DateTime MaxDateAllowed(Guid standardId, Guid geneticLineId, DateTime batchCreatedDate)
        {
            var maxSequence = Uow.StandardItems
                .GetAll(x => x.StandardGeneticLine.GeneticLineId == geneticLineId &&
                             x.StandardGeneticLine.StandardId == standardId)
                             .Max(x => x.Sequence);

            var standard = Uow.Standards.Get(standardId);

            switch (standard.DataLoadTypeId.ToString().ToUpper())
            {
                case GlobalConstants.DailyDataLoadType:
                    return batchCreatedDate.AddDays(maxSequence);
                case GlobalConstants.WeeklyDataLoadType:
                    return batchCreatedDate.AddWeeks(maxSequence);
                default:
                    return batchCreatedDate.AddDays(maxSequence);
            }
        }
    }
}
