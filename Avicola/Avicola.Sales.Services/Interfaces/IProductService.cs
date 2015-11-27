using System;
using System.Collections.Generic;
using System.Linq;
using Avicola.Sales.Entities;
using Avicola.Sales.Services.Dtos;
using Avicola.Services.Common;

namespace Avicola.Sales.Services.Interfaces
{
    public interface IProductService : IService
    {
        IQueryable<Product> GetAll();

        Product GetById(Guid id);

        void Create(Product product);
    }
}
