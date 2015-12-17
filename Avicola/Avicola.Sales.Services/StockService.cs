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

        public List<DepositStock> GetByDeposit(Guid depositId)
        {
            return Uow.DbContext.StockGetByDeposit(depositId).ToList();
        }

        internal void UpdateStock(Guid depositId,Guid productId , int boxes, int mapples, int eggsUnit)
        {
            var stock = Uow.Stocks.Get(x => x.DepositId == depositId && x.ProductId == productId);

            if (stock == null)
            {
                throw new ApplicationException(
                    "Debe exister una entidad stock para el producto antes de actualizar el stock");
            }

            var stockEntry = new StockEntry();

            stockEntry.Id = Guid.NewGuid();
            stockEntry.StockId = productId;

            stockEntry.Boxes = boxes;
            stockEntry.Maples = mapples;
            stockEntry.Eggs = eggsUnit;
            stockEntry.CreatedDate = _clock.Now;
            stockEntry.ShiftId = Guid.Empty;
        }

        public Stock GetExistStock(Guid depositId, Guid productId)
        {
            return Uow.Stocks.Get(x => x.DepositId == depositId && x.ProductId == productId);
        }


        public List<EggClassStock> GetByEggClass(Guid depositId)
        {
            return Uow.DbContext.StockGetByEggClass(depositId).ToList();
        }
    }
}
