using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using AutoMapper.QueryableExtensions;
using Avicola.Sales.Data.Interfaces;
using Avicola.Sales.Entities;
using Avicola.Sales.Services.Dtos;
using Avicola.Sales.Services.Interfaces;
using Framework.Common.Utility;
using Framework.Data.Helpers;

namespace Avicola.Sales.Services
{
    public class TruckService : ServiceBase, ITruckService
    {
        private readonly IClock _clock;

        public TruckService(ISalesUow uow, IClock clock)
        {
            _clock = clock;
            Uow = uow;
        }

        public IList<Truck> GetAll()
        {
            return Uow.Trucks.GetAll().ToList();
        }

        public List<TruckDto> GetAll(string sortBy, string sortDirection, string criteria, int pageIndex, int pageSize, out int pageTotal)
        {
            var pagingCriteria = new PagingCriteria();

            pagingCriteria.PageNumber = pageIndex;
            pagingCriteria.PageSize = pageSize;
            pagingCriteria.SortBy = !string.IsNullOrEmpty(sortBy) ? sortBy : "CreatedDate";
            pagingCriteria.SortDirection = !string.IsNullOrEmpty(sortDirection) ? sortDirection : "DESC";

            Expression<Func<Truck, bool>> where = x => ((string.IsNullOrEmpty(criteria) || x.Description.Contains(criteria)));

            var results = Uow.Trucks.GetAll(pagingCriteria, where);

            pageTotal = results.PagedMetadata.TotalItemCount;

            return results.Entities.Project().To<TruckDto>().ToList();
        }

        public Truck GetById(Guid id)
        {
            return Uow.Trucks.Get(x => x.Id == id);
        }

        public Truck GetByDescription(string description)
        {
            return Uow.Trucks.Get(e => e.Description == description);
        }

        public Truck GetByNumberPlate(string numberPlate)
        {
            return Uow.Trucks.Get(x => x.NumberPlate == numberPlate && !x.IsDeleted);
        }

        public void Create(Truck truck)
        {
            if (!IsNumberPlateAvailable(truck.NumberPlate, truck.Id))
            {
                throw new ApplicationException("Un camion con la misma patente ya ha sido creado");
            }

            Uow.Trucks.Add(truck);
            Uow.Commit();
        }

        public void Edit(Truck truck)
        {
            var currentTruck = this.GetById(truck.Id);

            currentTruck.Description = truck.Description;
            currentTruck.NumberPlate = truck.NumberPlate;
            
            Uow.Trucks.Edit(currentTruck);
            Uow.Commit();
        }

        public void Delete(Guid truckId)
        {
            Uow.Trucks.Delete(truckId);
            Uow.Commit();
        }

        public bool IsNumberPlateAvailable(string numberPlate, Guid id)
        {
            var currentTruck = this.GetByNumberPlate(numberPlate);

            if (currentTruck == null)
            {
                return true;
            }

            return currentTruck.Id == id;
        }
    }
}
