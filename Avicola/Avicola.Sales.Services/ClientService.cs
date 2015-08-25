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
    public class ClientService : ServiceBase, IClientService
    {
        private readonly IClock _clock;

        public ClientService(ISalesUow uow, IClock clock)
        {
            _clock = clock;
            Uow = uow;
        }

        public IQueryable<Client> GetAll()
        {
            return Uow.Clients.GetAll();
        }

        public List<ClientDto> GetAll(string sortBy, string sortDirection, string criteria, int pageIndex, int pageSize, out int pageTotal)
        {
            var pagingCriteria = new PagingCriteria();

            pagingCriteria.PageNumber = pageIndex;
            pagingCriteria.PageSize = pageSize;
            pagingCriteria.SortBy = !string.IsNullOrEmpty(sortBy) ? sortBy : "CreatedDate";
            pagingCriteria.SortDirection = !string.IsNullOrEmpty(sortDirection) ? sortDirection : "DESC";

            Expression<Func<Client, bool>> where = x => ((string.IsNullOrEmpty(criteria) 
                || x.Name.Contains(criteria) 
                || x.Address.Contains(criteria)
                || x.Referent.Contains(criteria)));

            var results = Uow.Clients.GetAll(pagingCriteria, where);

            pageTotal = results.PagedMetadata.TotalItemCount;

            return results.Entities.Project().To<ClientDto>().ToList();
        }

        public Client GetById(Guid id)
        {
            return Uow.Clients.Get(x => x.Id == id);
        }

        public Client GetByName(string name)
        {
            return Uow.Clients.Get(x => x.Name == name && !x.IsDeleted);
        }

        public void Create(Client client)
        {
            Uow.Clients.Add(client);
            Uow.Commit();
        }

        public void Edit(Client client)
        {
            var currentClient = this.GetById(client.Id);

            currentClient.Name = client.Name;
            currentClient.Address = client.Address;
            currentClient.City = client.City;
            currentClient.Referent = client.Referent;
            currentClient.Tel1 = client.Tel1;
            currentClient.Tel2 = client.Tel2;
            currentClient.CellPhone = client.CellPhone;
            currentClient.Email = client.Email;

            Uow.Clients.Edit(currentClient);
            Uow.Commit();
        }

        public void Delete(Guid clientId)
        {
            Uow.Clients.Delete(clientId);
            Uow.Commit();
        }
    }
}
