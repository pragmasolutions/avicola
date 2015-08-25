using System;
using System.Collections.Generic;
using System.Linq;
using Avicola.Sales.Entities;
using Avicola.Sales.Services.Dtos;

namespace Avicola.Sales.Services.Interfaces
{
    public interface IClientService
    {
        IQueryable<Client> GetAll();

        Client GetById(Guid id);

        Client GetByName(string name);

        List<ClientDto> GetAll(string sortBy, string sortDirection, string criteria, int pageIndex, int pageSize,
            out int pageTotal);

        void Create(Client geneticLine);

        void Edit(Client geneticLine);

        void Delete(Guid geneticLineId);

        bool IsNameAvailable(string numberPlate, Guid id);
    }
}
