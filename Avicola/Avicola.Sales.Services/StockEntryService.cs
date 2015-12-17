using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Security.Cryptography.X509Certificates;
using AutoMapper;
using AutoMapper.QueryableExtensions;
using Avicola.Sales.Data.Interfaces;
using Avicola.Sales.Entities;
using Avicola.Sales.Services.Dtos;
using Avicola.Sales.Services.Interfaces;
using Framework.Common.Utility;
using Framework.Data.Helpers;

namespace Avicola.Sales.Services
{
    public class StockEntryService : ServiceBase, IStockEntryService
    {
        private readonly IClock _clock;
        private readonly IStockService _stockService;

        public StockEntryService(ISalesUow uow, IClock clock, IStockService stockService)
        {
            _clock = clock;
            _stockService = stockService;
            Uow = uow;
        }

        public StockEntry GetById(Guid id)
        {
            return Uow.StockEntries.Get(x => x.Id == id);
        }

        public void Create(StockEntry stockEntry)
        {
            Uow.StockEntries.Add(stockEntry);
            Uow.Commit();
        }

        public void Create(StockEntry stockEntry, Guid depositId, Guid productId)
        {
            var stock = _stockService.GetExistStock(depositId, productId);
            if (stock == null)
            {
                var stockCreate = new Stock();
                stockCreate.Id = new Guid();
                stockCreate.ProductId = productId;
                stockCreate.DepositId = depositId;
                stockCreate.CreatedDate = DateTime.Now;
                stockCreate.IsDeleted = false;

                _stockService.Create(stockCreate);

                stockEntry.StockId = stockCreate.Id;
            }
            else
            {
                stockEntry.StockId = stock.Id;
            }

            this.Create(stockEntry);
        }

        IQueryable<StockEntry> IStockEntryService.GetAll()
        {
            return Uow.StockEntries.GetAll();
        }


        public IList<StockEntryDto> GetAllOpen()
        {
            return
                Uow.StockEntries.GetAll(whereClause: x => x.CurrentEggs > 0,includes: x => x.Shift)
                    .OrderByDescending(x => x.CreatedDate)
                   .AsEnumerable().Select(Mapper.Map<StockEntry, StockEntryDto>)
                   .ToList();
        }
    }
}
