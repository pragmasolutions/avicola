using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Avicola.Sales.Entities;
using Avicola.Sales.Services.Dtos;

namespace Avicola.Sales.Services.Interfaces
{
    public interface IClientService : IDisposable
    {
        IQueryable<Client> GetAll();

        Client GetById(Guid id);

        Client GetByName(string name);

        Task<List<ClientDto>> GetAll(string sortBy, string sortDirection, string criteria, int pageIndex, int pageSize,
            out int pageTotal);

        void Create(Client geneticLine);

        void Edit(Client geneticLine);

        void Delete(Guid geneticLineId);
    }
}
