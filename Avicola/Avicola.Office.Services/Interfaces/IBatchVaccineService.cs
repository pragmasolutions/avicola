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
    public interface IBatchVaccineService : IService
    {
        IQueryable<BatchVaccine> GetAll();

        IQueryable<BatchVaccine> GetAllActive();

        BatchVaccine GetById(Guid id);

        List<BatchVaccineDto> GetByBatchId(Guid batchId);

        void Create(BatchVaccine batchVaccine);

        void Edit(BatchVaccine batchVaccine);

        void Delete(Guid batchVaccineId);
    }
}
