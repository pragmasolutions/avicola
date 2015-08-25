using System;
using System.Collections.Generic;
using System.Linq;
using Avicola.Sales.Entities;
using Avicola.Sales.Services.Dtos;

namespace Avicola.Sales.Services.Interfaces
{
    public interface IDepositService
    {
        IQueryable<Deposit> GetAll();

        Deposit GetById(Guid id);

        Deposit GetByName(string name);

        List<DepositDto> GetAll(string sortBy, string sortDirection, string criteria, int pageIndex, int pageSize,
            out int pageTotal);

        void Create(Deposit deposit);

        void Edit(Deposit deposit);

        void Delete(Guid depositId);

        bool IsNameAvailable(string numberPlate, Guid id);
    }
}
