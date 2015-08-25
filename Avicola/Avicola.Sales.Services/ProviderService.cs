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
    public class ProviderService : ServiceBase, IProviderService
    {
        private readonly IClock _clock;

        public ProviderService(ISalesUow uow, IClock clock)
        {
            _clock = clock;
            Uow = uow;
        }

        public IQueryable<Provider> GetAll()
        {
            return Uow.Providers.GetAll();
        }

        public List<ProviderDto> GetAll(string sortBy, string sortDirection, string criteria, int pageIndex, int pageSize, out int pageTotal)
        {
            var pagingCriteria = new PagingCriteria();

            pagingCriteria.PageNumber = pageIndex;
            pagingCriteria.PageSize = pageSize;
            pagingCriteria.SortBy = !string.IsNullOrEmpty(sortBy) ? sortBy : "CreatedDate";
            pagingCriteria.SortDirection = !string.IsNullOrEmpty(sortDirection) ? sortDirection : "DESC";

            Expression<Func<Provider, bool>> where = x => ((string.IsNullOrEmpty(criteria) 
                || x.Name.Contains(criteria) 
                || x.Address.Contains(criteria)
                || x.Referent.Contains(criteria)));

            var results = Uow.Providers.GetAll(pagingCriteria, where);

            pageTotal = results.PagedMetadata.TotalItemCount;

            return results.Entities.Project().To<ProviderDto>().ToList();
        }

        public Provider GetById(Guid id)
        {
            return Uow.Providers.Get(x => x.Id == id);
        }

        public Provider GetByName(string name)
        {
            return Uow.Providers.Get(x => x.Name == name && !x.IsDeleted);
        }

        public void Create(Provider provider)
        {
            Uow.Providers.Add(provider);
            Uow.Commit();
        }

        public void Edit(Provider provider)
        {
            var currentProvider = this.GetById(provider.Id);

            currentProvider.Name = provider.Name;
            currentProvider.Address = provider.Address;
            currentProvider.City = provider.City;
            currentProvider.Referent = provider.Referent;
            currentProvider.Tel1 = provider.Tel1;
            currentProvider.Tel2 = provider.Tel2;
            currentProvider.CellPhone = provider.CellPhone;
            currentProvider.Email = provider.Email;

            Uow.Providers.Edit(currentProvider);
            Uow.Commit();
        }

        public void Delete(Guid providerId)
        {
            Uow.Providers.Delete(providerId);
            Uow.Commit();
        }

        public bool IsNameAvailable(string name, Guid id)
        {
            var currentProvider = this.GetByName(name);

            if (currentProvider == null)
            {
                return true;
            }

            return currentProvider.Id == id;
        }
    }
}
