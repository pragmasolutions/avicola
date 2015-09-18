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
using Avicola.Office.Services.Dtos;
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

        public List<FoodClassDto> GetAll(string sortBy, string sortDirection, string criteria, int pageIndex, int pageSize, out int pageTotal)
        {
            var pagingCriteria = new PagingCriteria();

            pagingCriteria.PageNumber = pageIndex;
            pagingCriteria.PageSize = pageSize;
            pagingCriteria.SortBy = !string.IsNullOrEmpty(sortBy) ? sortBy : "CreatedDate";
            pagingCriteria.SortDirection = !string.IsNullOrEmpty(sortDirection) ? sortDirection : "DESC";

            Expression<Func<FoodClass, bool>> where = x => !x.IsDeleted &&
                                                        ((string.IsNullOrEmpty(criteria) || x.Name.Contains(criteria)));

            var results = Uow.FoodClasses.GetAll(pagingCriteria,
                                                    where);

            pageTotal = results.PagedMetadata.TotalItemCount;

            return results.Entities.Project().To<FoodClassDto>().ToList();
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
            var currentFoodClass = this.GetById(foodClass.Id);

            currentFoodClass.Name = foodClass.Name;

            Uow.FoodClasses.Edit(currentFoodClass);
            Uow.Commit();
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
