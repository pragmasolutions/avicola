using System;
using System.Configuration;
using System.Data.Entity.Core.EntityClient;
using System.Threading.Tasks;
using Framework.Data.EntityFramework.Helpers;
using Framework.Data.Repository;
using Avicola.Sales.Data.Interfaces;
using Avicola.Sales.Entities;
using Framework.Data.Interfaces;

namespace Avicola.Sales.Data
{
    public class SalesUow : ISalesUow
    {
        public SalesUow(IRepositoryProvider repositoryProvider)
        {
            CreateDbContext();

            repositoryProvider.DbContext = DbContext;
            RepositoryProvider = repositoryProvider;
        }

        public IRepository<Client> Clients { get { return GetStandardRepo<Client>(); } }
        public IRepository<Deposit> Deposits { get { return GetStandardRepo<Deposit>(); } }
        public IRepository<Driver> Drivers { get { return GetStandardRepo<Driver>(); } }
        public IRepository<Order> Orders { get { return GetStandardRepo<Order>(); } }
        public IRepository<OrderStatus> OrderStatuses { get { return GetStandardRepo<OrderStatus>(); } }
        public IRepository<Product> Products { get { return GetStandardRepo<Product>(); } }
        public IRepository<Provider> Providers { get { return GetStandardRepo<Provider>(); } }
        public IRepository<Shift> Shifts { get { return GetStandardRepo<Shift>(); } }
        public IRepository<Stock> Stocks { get { return GetStandardRepo<Stock>(); } }
        public IRepository<StockEntry> StockEntries { get { return GetStandardRepo<StockEntry>(); } }
        public IRepository<Truck> Trucks { get { return GetStandardRepo<Truck>(); } }
        public IRepository<EggClass> EggClasses { get { return GetStandardRepo<EggClass>(); } }
        public IRepository<OrderEggClass> OrderEggClasses { get { return GetStandardRepo<OrderEggClass>(); } }
        public IRepository<Classification> Classifications { get { return GetStandardRepo<Classification>(); } }
        public IRepository<ClassificationEggClass> ClassificationEggClasses { get { return GetStandardRepo<ClassificationEggClass>(); } }
        public IRepository<EggEquivalence> EggEquivalences { get { return GetStandardRepo<EggEquivalence>(); } }
        public ISimpleRepository<User> Users { get { return GetSimpleRepo<User>(); } }

        public string ConnectionString
        {   
            get
            {
                var builder = new EntityConnectionStringBuilder();
                builder.Metadata = @"res://*/SalesModel.csdl|res://*/SalesModel.ssdl|res://*/SalesModel.msl";
                builder.Provider = "System.Data.SqlClient";
                builder.ProviderConnectionString = ConfigurationManager.ConnectionStrings["SalesEntities"].ConnectionString;
                return builder.ToString();
            }
        }

        /// <summary>
        /// Save pending changes to the database
        /// </summary>
        public void Commit()
        {
            DbContext.SaveChanges();
        }

        public Task CommitAsync()
        {
            return DbContext.SaveChangesAsync();
        }

        protected void CreateDbContext()
        {
            DbContext = new SalesEntities(ConnectionString);

            // Do NOT enable proxied entities, else serialization fails
            DbContext.Configuration.ProxyCreationEnabled = false;

            // Load navigation properties explicitly (avoid serialization trouble)
            DbContext.Configuration.LazyLoadingEnabled = false;

            // Because Web API will perform validation, we don't need/want EF to do so
            DbContext.Configuration.ValidateOnSaveEnabled = false;

            //DbContext.Configuration.AutoDetectChangesEnabled = false;
            // We won't use this performance tweak because we don't need 
            // the extra performance and, when autodetect is false,
            // we'd have to be careful. We're not being that careful.
        }

        protected IRepositoryProvider RepositoryProvider { get; set; }

        private IRepository<T> GetStandardRepo<T>() where T : class, IEntity
        {
            return RepositoryProvider.GetRepositoryForEntityType<T>();
        }

        private ISimpleRepository<T> GetSimpleRepo<T>() where T : class
        {
            return RepositoryProvider.GetSimpleRepositoryForEntityType<T>();
        }

        private T GetRepo<T>() where T : class, IEntity
        {
            return RepositoryProvider.GetRepository<T>();
        }

        public SalesEntities DbContext { get; set; }

        #region IDisposable

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (disposing)
            {
                if (DbContext != null)
                {
                    DbContext.Dispose();
                }
            }
        }

        #endregion
    }
}
