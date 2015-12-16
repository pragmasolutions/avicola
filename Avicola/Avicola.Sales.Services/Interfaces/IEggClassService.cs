using System;
using System.Collections.Generic;
using System.Linq;
using Avicola.Sales.Entities;
using Avicola.Sales.Services.Dtos;

namespace Avicola.Sales.Services.Interfaces
{
    public interface IEggClassService : IDisposable
    {
        IQueryable<EggClass> GetAll();
        EggClass GetById(Guid id);
    }
}
