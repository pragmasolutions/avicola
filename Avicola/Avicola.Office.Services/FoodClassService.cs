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
    public class FoodClassService : ServiceBase, IFoodClassService
    {
        private readonly IClock _clock;

        public FoodClassService(IOfficeUow uow, IClock clock)
        {
            _clock = clock;
            Uow = uow;
        }

        public IQueryable<FoodClass> GetAll()
        {
            return Uow.FoodClasses.GetAll().Where(e => !e.IsDeleted);
        }

        public FoodClass GetById(Guid id)
        {
            return Uow.FoodClasses.Get(g => g.Id == id);
        }

        public FoodClass GetByName(string name)
        {
            return Uow.FoodClasses.Get(e => e.Name == name && !e.IsDeleted);
        }

        public void Create(FoodClass foodClass)
        {
            if (!IsNameAvailable(foodClass.Name, foodClass.Id))
            {
                throw new ApplicationException("Ya existe un tipo de alimento con el mismo nombre");
            }

            Uow.FoodClasses.Add(foodClass);
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
