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
    public class DriverService : ServiceBase, IDriverService
    {
        private readonly IClock _clock;

        public DriverService(ISalesUow uow, IClock clock)
        {
            _clock = clock;
            Uow = uow;
        }

        public IQueryable<Driver> GetAll()
        {
            return Uow.Drivers.GetAll(whereClause: null, includes: x => x.Truck);
        }

        public List<DriverDto> GetAll(string sortBy, string sortDirection, string criteria, int pageIndex, int pageSize, out int pageTotal)
        {
            var pagingCriteria = new PagingCriteria();

            pagingCriteria.PageNumber = pageIndex;
            pagingCriteria.PageSize = pageSize;
            pagingCriteria.SortBy = !string.IsNullOrEmpty(sortBy) ? sortBy : "CreatedDate";
            pagingCriteria.SortDirection = !string.IsNullOrEmpty(sortDirection) ? sortDirection : "DESC";

            Expression<Func<Driver, bool>> where = x => ((string.IsNullOrEmpty(criteria) || x.Name.Contains(criteria)));

            var results = Uow.Drivers.GetAll(pagingCriteria, where, x => x.Truck);

            pageTotal = results.PagedMetadata.TotalItemCount;

            return results.Entities.Project().To<DriverDto>().ToList();
        }

        public Driver GetById(Guid id)
        {
            return Uow.Drivers.Get(x => x.Id == id);
        }

        public Driver GetByName(string name)
        {
            return Uow.Drivers.Get(e => e.Name == name);
        }

        public void Create(Driver driver)
        {
            Uow.Drivers.Add(driver);
            Uow.Commit();
        }

        public void Edit(Driver driver)
        {
            var currentDriver = this.GetById(driver.Id);

            currentDriver.Name = driver.Name;
            currentDriver.Tel1 = driver.Tel1;
            currentDriver.Tel2 = driver.Tel2;
            currentDriver.Address = driver.Address;
            currentDriver.CellPhone = driver.CellPhone;
            currentDriver.TruckId = driver.TruckId;

            Uow.Drivers.Edit(currentDriver);
            Uow.Commit();
        }

        public void Delete(Guid driverId)
        {
            Uow.Drivers.Delete(driverId);
            Uow.Commit();
        }
    }
}
