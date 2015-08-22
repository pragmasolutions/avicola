using System;
using Avicola.Sales.Data.Interfaces;
using Framework.Data.Repository;
using Avicola.Services.Common;

namespace Avicola.Sales.Services
{
    public class ServiceBase : IServive
    {
        protected ISalesUow Uow { get; set; }

        protected IUowFactory UowFactory { get; set; }

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
                if (Uow != null)
                {
                    Uow.Dispose();
                    Uow = null;
                }
            }
        }

        #endregion
    }
}
