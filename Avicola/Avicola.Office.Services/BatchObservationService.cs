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
using Avicola.Office.Services.Interfaces;
using Framework.Common.Utility;
using Framework.Data.Helpers;

namespace Avicola.Office.Services
{
    public class BatchObservationService : ServiceBase, IBatchObservationService
    {
        private readonly IClock _clock;

        public BatchObservationService(IOfficeUow uow, IClock clock)
        {
            _clock = clock;
            Uow = uow;
        }

        public IQueryable<BatchObservation> GetAll()
        {
            return Uow.BatchObservations.GetAll().Where(e => !e.IsDeleted);
        }

        public BatchObservation GetById(Guid id)
        {
            return Uow.BatchObservations.Get(g => g.Id == id);
        }

        public IQueryable<BatchObservation> GetByBatchId(Guid batchId)
        {
            return Uow.BatchObservations.GetAll().Where(e => e.BatchId == batchId && !e.IsDeleted);
        }

        public void Create(BatchObservation batchObservation)
        {
            Uow.BatchObservations.Add(batchObservation);
            Uow.Commit();
        }

        public void Edit(BatchObservation batchObservation)
        {
            
        }

        public void Delete(Guid batchObservationId)
        {
            Uow.BatchObservations.Delete(batchObservationId);
            Uow.Commit();
        }
    }
}
