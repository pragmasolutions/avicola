using System;
using System.Collections.Generic;
using System.Linq;
using Avicola.Sales.Entities;
using Avicola.Sales.Services.Dtos;
using Avicola.Services.Common;

namespace Avicola.Sales.Services.Interfaces
{
    public interface IShiftService : IService
    {
        IQueryable<Shift> GetAll();

        Stock GetById(Guid id);

        void Create(Shift shift);
    }
}
