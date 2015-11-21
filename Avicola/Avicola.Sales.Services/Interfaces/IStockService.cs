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

        List<StockDto> GetByDeposit(Guid depositId);

        void Create(Stock stock);
    }
}
