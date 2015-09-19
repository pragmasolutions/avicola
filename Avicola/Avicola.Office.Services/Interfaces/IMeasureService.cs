using System;
using System.Collections.Generic;
using Avicola.Office.Entities;
using Avicola.Office.Services.Dtos;
using Avicola.Services.Common;

namespace Avicola.Office.Services.Interfaces
{
    public interface IMeasureService : IService
    {
        void CreateMeasures(IEnumerable<LoadMeasureModel> measures, Guid batchId);

        DateTime MaxDateAllowed(Guid standardId, Guid geneticLineId, DateTime batchCreatedDate);

        IList<Measure> GetByStandardAndBatch(Guid standardId, Guid batchId);

        void UpdateMeasures(IEnumerable<UpdateMeasureDto> measures);
    }
}
