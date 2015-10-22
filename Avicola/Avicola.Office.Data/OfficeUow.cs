using System;
using System.Configuration;
using System.Data.Entity.Core.EntityClient;
using System.Threading.Tasks;
using Framework.Data.EntityFramework.Helpers;
using Framework.Data.Repository;
using Avicola.Office.Data.Interfaces;
using Avicola.Office.Entities;
using Framework.Data.Interfaces;

namespace Avicola.Office.Data
{
    public class OfficeUow : IOfficeUow
    {
        public OfficeUow(IRepositoryProvider repositoryProvider)
        {
            CreateDbContext();

            repositoryProvider.DbContext = DbContext;
            RepositoryProvider = repositoryProvider;
        }

        public IRepository<Barn> Barns { get { return GetStandardRepo<Barn>(); } }
        public IRepository<Batch> Batches { get { return GetStandardRepo<Batch>(); } }
        public IRepository<BatchObservation> BatchObservations { get { return GetStandardRepo<BatchObservation>(); } }
        public IRepository<BatchVaccine> BatchVaccines { get { return GetStandardRepo<BatchVaccine>(); } }
        public IRepository<BatchMedicine> BatchMedicines { get { return GetStandardRepo<BatchMedicine>(); } }
        public IRepository<DataLoadType> DataLoadTypes { get { return GetStandardRepo<DataLoadType>(); } }
        public IRepository<FoodClass> FoodClasses { get { return GetStandardRepo<FoodClass>(); } }
        public IRepository<GeneticLine> GeneticLines { get { return GetStandardRepo<GeneticLine>(); } }
        public IRepository<Measure> Measures { get { return GetStandardRepo<Measure>(); } }
        public IRepository<Standard> Standards { get { return GetStandardRepo<Standard>(); } }
        public IRepository<StandardGeneticLine> StandardGeneticLines { get { return GetStandardRepo<StandardGeneticLine>(); } }
        public IRepository<StandardItem> StandardItems { get { return GetStandardRepo<StandardItem>(); } }
        public IRepository<Vaccine> Vaccines { get { return GetStandardRepo<Vaccine>(); } }
        public IRepository<Medicine> Medicines { get { return GetStandardRepo<Medicine>(); } }
        public IRepository<BatchBarn> BatchBarns { get { return GetStandardRepo<BatchBarn>(); } }
        public IRepository<Stage> Stages { get { return GetStandardRepo<Stage>(); } }
        public IRepository<StageChange> StageChanges { get { return GetStandardRepo<StageChange>(); } }
        public IRepository<SiloEmptying> SiloEmptyings { get { return GetStandardRepo<SiloEmptying>(); } }


        public string ConnectionString
        {
            get
            {
                var builder = new EntityConnectionStringBuilder();
                builder.Metadata = @"res://*/OfficeModel.csdl|res://*/OfficeModel.ssdl|res://*/OfficeModel.msl";
                builder.Provider = "System.Data.SqlClient";
                builder.ProviderConnectionString = ConfigurationManager.ConnectionStrings["OfficeEntities"].ConnectionString;
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
            DbContext = new OfficeEntities(ConnectionString);

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

        private T GetRepo<T>() where T : class
        {
            return RepositoryProvider.GetRepository<T>();
        }

        public OfficeEntities DbContext { get; set; }

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
