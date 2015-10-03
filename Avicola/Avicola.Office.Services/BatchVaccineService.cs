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
    public class BatchVaccineService : ServiceBase, IBatchVaccineService
    {
        private readonly IClock _clock;

        public BatchVaccineService(IOfficeUow uow, IClock clock)
        {
            _clock = clock;
            Uow = uow;
        }

        public IQueryable<BatchVaccine> GetAll()
        {
            return Uow.BatchVaccines.GetAll();
        }

        public IQueryable<BatchVaccine> GetAllActive()
        {
            return Uow.BatchVaccines.GetAll().Where(e => !e.IsDeleted);
        }

        public BatchVaccine GetById(Guid id)
        {
            return Uow.BatchVaccines.Get(g => g.Id == id, bv => bv.Vaccine);
        }

        public List<BatchVaccineDto> GetByBatchId(Guid batchId)
        {
            return Uow.BatchVaccines.GetAll(whereClause: null, includes: x => x.Vaccine).Where(e => e.BatchId == batchId && !e.IsDeleted)
                    .Project()
                    .To<BatchVaccineDto>()
                    .ToList();
        }

        public void Create(BatchVaccine batchVaccine)
        {
            Uow.BatchVaccines.Add(batchVaccine);
            Uow.Commit();
        }

        public void Edit(BatchVaccine batchVaccine)
        {
            var currentbatchVaccine = this.GetById(batchVaccine.Id);

            currentbatchVaccine.VaccineId = batchVaccine.VaccineId;            
            currentbatchVaccine.StartDate = batchVaccine.StartDate;
            currentbatchVaccine.EndDate = batchVaccine.EndDate;

            Uow.BatchVaccines.Edit(currentbatchVaccine);
            Uow.Commit();
        }

        public void Delete(Guid batchVaccineId)
        {
            Uow.BatchVaccines.Delete(batchVaccineId);
            Uow.Commit();
        }
    }
}
