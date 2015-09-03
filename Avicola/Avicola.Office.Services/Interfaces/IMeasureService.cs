using System.Collections.Generic;
using Avicola.Office.Entities;

namespace Avicola.Office.Services.Interfaces
{
    public interface IMeasureService
    {
        void CreateMeasures(IEnumerable<Measure> measures);
    }
}
