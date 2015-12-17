using System;
using System.Collections.Generic;
using System.Linq;
using Avicola.Sales.Entities;
using Avicola.Sales.Services.Dtos;
using Avicola.Services.Common;

namespace Avicola.Sales.Services.Interfaces
{
    public interface IStockService : IService
    {
        IQueryable<Stock> GetAll();

        Stock GetById(Guid id);

        List<DepositStock> GetByDeposit(Guid depositId);

        Stock GetExistStock(Guid depositId, Guid productId);

        void Create(Stock stock);

        List<EggClassStock> GetByEggClass(Guid depositId);
    }
}
