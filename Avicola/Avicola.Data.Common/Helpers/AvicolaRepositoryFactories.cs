using System;
using System.Collections.Generic;
using System.Data.Entity;
using Framework.Data.EntityFramework.Helpers;

namespace Avicola.Data.Common.Helpers
{
    public class AvicolaRepositoryFactories : RepositoryFactories
    {
        protected override IDictionary<Type, Func<DbContext, object>> GetFactories()
        {
            return new Dictionary<Type, Func<DbContext, object>>
             {
                  //{typeof(IReportRepository), dbContext => new ReportRepository(dbContext)}
              };
        }
    }
}
