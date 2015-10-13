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
    public interface IBatchMedicineService : IService
    {
        IQueryable<BatchMedicine> GetAll();

        IQueryable<BatchMedicine> GetAllActive();

        BatchMedicine GetById(Guid id);

        List<BatchMedicineDto> GetByBatchId(Guid batchId);

        void Create(BatchMedicine batchMedicine);

        void Edit(BatchMedicine batchMedicine);

        void Delete(Guid batchMedicineId);
    }
}
