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
            return Uow.FoodClasses.Get(g => g.Id == id);
        }

        public BatchObservation GetByName(string name)
        {
            return Uow.FoodClasses.Get(e => e.Name == name && !e.IsDeleted);
        }

        public void Create(BatchObservation batchObservation)
        {
            if (!IsNameAvailable(batchObservation.Name, batchObservation.Id))
            {
                throw new ApplicationException("Ya existe un tipo de alimento con el mismo nombre");
            }

            Uow.FoodClasses.Add(batchObservation);
            Uow.Commit();
        }

        public void Edit(FoodClass foodClass)
        {
            
        }

        public void Delete(Guid foodClassId)
        {
            Uow.FoodClasses.Delete(foodClassId);
            Uow.Commit();
        }

        public bool IsNameAvailable(string name, Guid id)
        {
            var currentFoodClass = this.GetByName(name);

            if (currentFoodClass == null)
            {
                return true;
            }

            return currentFoodClass.Id == id;
        }
    }
}
