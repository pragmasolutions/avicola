using System;
using System.Collections.Generic;
using System.Linq;
using Avicola.Sales.Entities;
using Avicola.Sales.Services.Dtos;

namespace Avicola.Sales.Services.Interfaces
{
    public interface IDriverService
    {
        IQueryable<Driver> GetAll();

        Driver GetById(Guid id);

        List<DriverDto> GetAll(string sortBy, string sortDirection, string criteria, int pageIndex, int pageSize,
            out int pageTotal);

        void Create(Driver driver);

        void Edit(Driver driver);

        void Delete(Guid driverId);
    }
}
