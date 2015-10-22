using System;
using System.Collections.Generic;
using Avicola.Office.Entities;
using Avicola.Office.Services.Dtos;
using Avicola.Services.Common;

namespace Avicola.Office.Services.Interfaces
{
    public interface ISiloEmptyingService : IService
    {
        List<SiloEmptying> GetByBatch(Guid batchId);

        SiloEmptying GetById(Guid _emptyingId);

        void Create(SiloEmptying siloEmptying);

        void Edit(SiloEmptying _siloEmptying);

        void Delete(Guid emptyingId);
    }
}
