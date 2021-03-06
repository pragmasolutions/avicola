﻿
using Framework.Data.Repository;
using Avicola.Sales.Entities;

namespace Avicola.Sales.Data.Interfaces
{
    public interface ISalesUow : IUow
    {
        IRepository<Client> Clients { get; }
        IRepository<Deposit> Deposits { get; }
        IRepository<Driver> Drivers { get; }
        IRepository<Order> Orders { get; }
        IRepository<OrderStatus> OrderStatuses { get; }
        IRepository<Product> Products { get; }
        IRepository<Provider> Providers { get; }
        IRepository<Shift> Shifts { get; }
        IRepository<Stock> Stocks { get; }
        IRepository<StockEntry> StockEntries { get; }
        IRepository<Truck> Trucks { get; }

        SalesEntities DbContext { get; }
    }
}
