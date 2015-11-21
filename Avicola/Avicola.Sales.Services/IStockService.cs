﻿using System;
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
    public class StockService : ServiceBase, IStockService
    {
        private readonly IClock _clock;

        public StockService(ISalesUow uow, IClock clock)
        {
            _clock = clock;
            Uow = uow;
        }
        public Stock GetById(Guid id)
        {
            return Uow.Stocks.Get(x => x.Id == id);
        }

        public Provider GetByName(string name)
        {
            return Uow.Providers.Get(x => x.Name == name && !x.IsDeleted);
        }

        public void Create(Stock stock)
        {
            Uow.Stocks.Add(stock);
            Uow.Commit();
        }
        
        IQueryable<Stock> IStockService.GetAll()
        {
            return Uow.Stocks.GetAll();
        }

        public List<StockDto> GetByDeposit(Guid depositId)
        {
            throw new NotImplementedException();
            //var list = Uow.StockEntries.GetAll(x => x.Stock.DepositId == depositId && !x.IsDeleted);
            //return list.GroupBy(x => x.StockId).Select(item => new StockDto()
            //{
            //    Id = item.
            //})
        }
    }
}
