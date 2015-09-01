using System;
using System.Collections.Generic;
using System.Linq;
using Avicola.Sales.Entities;
using Avicola.Sales.Services.Dtos;

namespace Avicola.Sales.Services.Interfaces
{
    public interface ITruckService
    {
        IQueryable<Truck> GetAll();

        Truck GetById(Guid id);

        Truck GetByDescription(string description);

        List<TruckDto> GetAll(string sortBy, string sortDirection, string criteria, int pageIndex, int pageSize,
            out int pageTotal);

        void Create(Truck truck);

        void Edit(Truck truck);

        void Delete(Guid truckId);

        bool IsNumberPlateAvailable(string numberPlate, Guid id);
    }
}
