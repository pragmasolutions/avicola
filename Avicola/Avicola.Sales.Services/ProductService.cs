using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Security.Cryptography.X509Certificates;
using AutoMapper.QueryableExtensions;
using Avicola.Sales.Data.Interfaces;
using Avicola.Sales.Entities;
using Avicola.Sales.Services.Dtos;
using Avicola.Sales.Services.Interfaces;
using Framework.Common.Utility;
using Framework.Data.Helpers;

namespace Avicola.Sales.Services
{
    public class ProductService : ServiceBase, IProductService
    {
        private readonly IClock _clock;

        public ProductService(ISalesUow uow, IClock clock)
        {
            _clock = clock;
            Uow = uow;
        }
        public Product GetById(Guid id)
        {
            return Uow.Products.Get(x => x.Id == id);
        }

        public void Create(Product product)
        {
            Uow.Products.Add(product);
            Uow.Commit();
        }

        IQueryable<Product> IProductService.GetAll()
        {
            return Uow.Products.GetAll();
        }
    }
}
