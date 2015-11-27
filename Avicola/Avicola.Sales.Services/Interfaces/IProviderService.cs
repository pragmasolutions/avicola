using System;
using System.Collections.Generic;
using System.Linq;
using Avicola.Sales.Entities;
using Avicola.Sales.Services.Dtos;
using Avicola.Services.Common;

namespace Avicola.Sales.Services.Interfaces
{
    public interface IProviderService : IService
    {
        IQueryable<Provider> GetAll();

        Provider GetById(Guid id);

        Provider GetByName(string name);

        List<ProviderDto> GetAll(string sortBy, string sortDirection, string criteria, 
                        int pageIndex, int pageSize, out int pageTotal);

        void Create(Provider provider);

        void Edit(Provider provider);

        void Delete(Guid providerId);

        bool IsNameAvailable(string numberPlate, Guid id);
    }
}
