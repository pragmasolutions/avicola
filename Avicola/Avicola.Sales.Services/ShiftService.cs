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
    public class ShiftService : ServiceBase, IShiftService
    {
        private readonly IClock _clock;

        public ShiftService(ISalesUow uow, IClock clock)
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

        public void Create(Shift shift)
        {
            Uow.Shifts.Add(shift);
            Uow.Commit();
        }
        
        IQueryable<Shift> IShiftService.GetAll()
        {
            return Uow.Shifts.GetAll();
        }
    }
}
