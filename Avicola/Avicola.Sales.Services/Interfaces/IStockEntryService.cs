using System;
using System.Collections.Generic;
using System.Linq;
using Avicola.Sales.Entities;
using Avicola.Sales.Services.Dtos;
using Avicola.Services.Common;

namespace Avicola.Sales.Services.Interfaces
{
    public interface IStockEntryService : IService
    {
        IQueryable<StockEntry> GetAll();

        IList<StockEntryDto> GetAllOpen();

        StockEntry GetById(Guid id);
        
        void Create(StockEntry stockEntry);

        void Create(StockEntry stockEntry, Guid depositId, Guid productId);
    }
}
