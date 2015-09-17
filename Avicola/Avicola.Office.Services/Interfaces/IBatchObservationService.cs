using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Avicola.Office.Entities;
using Avicola.Office.Entities.DTO;
using Avicola.Services.Common;

namespace Avicola.Office.Services.Interfaces
{
    public interface IBatchObservationService : IService
    {
        IQueryable<BatchObservation> GetAll();

        BatchObservation GetById(Guid id);

        IQueryable<BatchObservation> GetByBatchId(Guid batchId);

        void Create(BatchObservation batchObservation);

        void Edit(BatchObservation batchObservation);

        void Delete(Guid batchObservationId);
    }
}
