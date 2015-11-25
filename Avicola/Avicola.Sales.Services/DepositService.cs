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
    public class DepositService : ServiceBase, IDepositService
    {
        private readonly IClock _clock;

        public DepositService(ISalesUow uow, IClock clock)
        {
            _clock = clock;
            Uow = uow;
        }

        public IList<Deposit> GetAll()
        {
            return Uow.Deposits.GetAll().ToList();
        }

        public List<DepositDto> GetAll(string sortBy, string sortDirection, string criteria, int pageIndex, int pageSize, out int pageTotal)
        {
            var pagingCriteria = new PagingCriteria();

            pagingCriteria.PageNumber = pageIndex;
            pagingCriteria.PageSize = pageSize;
            pagingCriteria.SortBy = !string.IsNullOrEmpty(sortBy) ? sortBy : "CreatedDate";
            pagingCriteria.SortDirection = !string.IsNullOrEmpty(sortDirection) ? sortDirection : "DESC";

            Expression<Func<Deposit, bool>> where = x => ((string.IsNullOrEmpty(criteria) 
                || x.Name.Contains(criteria)));

            var results = Uow.Deposits.GetAll(pagingCriteria, where);

            pageTotal = results.PagedMetadata.TotalItemCount;

            return results.Entities.Project().To<DepositDto>().ToList();
        }

        public Deposit GetById(Guid id)
        {
            return Uow.Deposits.Get(x => x.Id == id);
        }

        public Deposit GetByName(string name)
        {
            return Uow.Deposits.Get(x => x.Name == name && !x.IsDeleted);
        }

        public void Create(Deposit deposit)
        {
            if (!IsNameAvailable(deposit.Name, deposit.Id))
            {
                throw new ApplicationException("Un deposito con el mismo nombre ya ha sido creado");
            }

            Uow.Deposits.Add(deposit);
            Uow.Commit();
        }

        public void Edit(Deposit deposit)
        {
            var currentDeposit = this.GetById(deposit.Id);

            currentDeposit.Name = deposit.Name;

            Uow.Deposits.Edit(currentDeposit);
            Uow.Commit();
        }

        public void Delete(Guid depositId)
        {
            Uow.Deposits.Delete(depositId);
            Uow.Commit();
        }

        public bool IsNameAvailable(string name, Guid id)
        {
            var currentDeposit = this.GetByName(name);

            if (currentDeposit == null)
            {
                return true;
            }

            return currentDeposit.Id == id;
        }
    }
}
