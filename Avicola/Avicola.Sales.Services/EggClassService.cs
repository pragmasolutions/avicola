using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using AutoMapper.QueryableExtensions;
using Avicola.Sales.Data.Interfaces;
using Avicola.Sales.Entities;
using Avicola.Sales.Services.Dtos;
using Avicola.Sales.Services.Interfaces;
using Framework.Common.Utility;
using Framework.Data.Helpers;

namespace Avicola.Sales.Services
{
    public class EggClassService : ServiceBase, IEggClassService
    {
        private readonly IClock _clock;

        public EggClassService(ISalesUow uow, IClock clock)
        {
            _clock = clock;
            Uow = uow;
        }

        public IQueryable<EggClass> GetAll()
        {
            return Uow.EggClasses.GetAll();
        }
        
        public EggClass GetById(Guid id)
        {
            return Uow.EggClasses.Get(x => x.Id == id);
        }
    }
}
