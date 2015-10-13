using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using AutoMapper.QueryableExtensions;
using Avicola.Office.Data.Interfaces;
using Avicola.Office.Entities;
using Avicola.Office.Entities.DTO;
using Avicola.Office.Services.Dtos;
using Avicola.Office.Services.Interfaces;
using Framework.Common.Utility;
using Framework.Data.Helpers;

namespace Avicola.Office.Services
{
    public class BatchMedicineService : ServiceBase, IBatchMedicineService
    {
        private readonly IClock _clock;

        public BatchMedicineService(IOfficeUow uow, IClock clock)
        {
            _clock = clock;
            Uow = uow;
        }

        public IQueryable<BatchMedicine> GetAll()
        {
            return Uow.BatchMedicines.GetAll();
        }

        public IQueryable<BatchMedicine> GetAllActive()
        {
            return Uow.BatchMedicines.GetAll().Where(e => !e.IsDeleted);
        }

        public BatchMedicine GetById(Guid id)
        {
            return Uow.BatchMedicines.Get(g => g.Id == id, bm => bm.Medicine);
        }

        public List<BatchMedicineDto> GetByBatchId(Guid batchId)
        {
            return Uow.BatchVaccines.GetAll(whereClause: null, includes: x => x.Vaccine).Where(e => e.BatchId == batchId && !e.IsDeleted)
                    .Project()
                    .To<BatchMedicineDto>()
                    .ToList();
        }

        public void Create(BatchMedicine batchMedicine)
        {
            Uow.BatchMedicines.Add(batchMedicine);
            Uow.Commit();
        }

        public void Edit(BatchMedicine batchMedicine)
        {
            var currentBatchMedicine = this.GetById(batchMedicine.Id);

            currentBatchMedicine.MedicineId = batchMedicine.MedicineId;
            currentBatchMedicine.StartDate = batchMedicine.StartDate;
            currentBatchMedicine.EndDate = batchMedicine.EndDate;

            Uow.BatchMedicines.Edit(currentBatchMedicine);
            Uow.Commit();
        }

        public void Delete(Guid batchMedicineId)
        {
            Uow.BatchMedicines.Delete(batchMedicineId);
            Uow.Commit();
        }
    }
}
