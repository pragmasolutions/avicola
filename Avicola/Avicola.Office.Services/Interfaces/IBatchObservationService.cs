using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Avicola.Office.Entities;
using Avicola.Office.Entities.DTO;
using Avicola.Services.Common;
using Avicola.Office.Services.Dtos;

namespace Avicola.Office.Services.Interfaces
{
    public interface IBatchObservationService : IService
    {
        IQueryable<BatchObservation> GetAll();

        IQueryable<BatchObservation> GetAllActive();

        BatchObservation GetById(Guid id);

        IList<BatchObservationDto> GetByBatchId(Guid batchId);

        void Create(BatchObservation batchObservation);

        void Edit(BatchObservation batchObservation);

        void Delete(Guid batchObservationId);
    }
}
