using System;
using System.Collections.Generic;
using Avicola.Office.Entities;
using Avicola.Services.Common;

namespace Avicola.Office.Services.Interfaces
{
    public interface IMeasureService : IService
    {
        void CreateMeasures(IEnumerable<Measure> measures, Guid batchId);
    }
}
