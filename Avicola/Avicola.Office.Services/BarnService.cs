using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using AutoMapper.QueryableExtensions;
using Avicola.Office.Data.Interfaces;
using Avicola.Office.Entities;
using Avicola.Office.Services.Dtos;
using Avicola.Office.Services.Interfaces;
using Framework.Common.Utility;
using Framework.Data.Helpers;

namespace Avicola.Office.Services
{
    public class BarnService : ServiceBase, IBarnService
    {
        private readonly IClock _clock;

        public BarnService(IOfficeUow uow, IClock clock)
        {
            _clock = clock;
            Uow = uow;
        }

        public IQueryable<Barn> GetAll()
        {
            return Uow.Barns.GetAll();
        }

        public List<BarnDto> GetAll(string sortBy, string sortDirection, string criteria, int pageIndex, int pageSize, out int pageTotal)
        {
            var pagingCriteria = new PagingCriteria();

            pagingCriteria.PageNumber = pageIndex;
            pagingCriteria.PageSize = pageSize;
            pagingCriteria.SortBy = !string.IsNullOrEmpty(sortBy) ? sortBy : "CreatedDate";
            pagingCriteria.SortDirection = !string.IsNullOrEmpty(sortDirection) ? sortDirection : "DESC";

            Expression<Func<Barn, bool>> where = x => ((string.IsNullOrEmpty(criteria) 
                || x.Number.ToString().Contains(criteria)));

            var results = Uow.Barns.GetAll(pagingCriteria, where);

            pageTotal = results.PagedMetadata.TotalItemCount;

            return results.Entities.Project().To<BarnDto>().ToList();
        }

        public Barn GetById(Guid id)
        {
            return Uow.Barns.Get(x => x.Id == id);
        }

        public Barn GetByNumber(int number)
        {
            return Uow.Barns.Get(x => x.Number == number && !x.IsDeleted);
        }

        public void Create(Barn barn)
        {
            if (!IsNumberAvailable(barn.Number, barn.Id))
            {
                throw new ApplicationException("Un galpón con el mismo numero ya ha sido creado");
            }

            Uow.Barns.Add(barn);
            Uow.Commit();
        }

        public void Edit(Barn barn)
        {
            var currentBarn = this.GetById(barn.Id);

            currentBarn.Capacity = barn.Capacity;
            currentBarn.Number = barn.Number;

            Uow.Barns.Edit(currentBarn);
            Uow.Commit();
        }

        public void Delete(Guid barnId)
        {
            Uow.Barns.Delete(barnId);
            Uow.Commit();
        }

        public bool IsNumberAvailable(int number, Guid id)
        {
            var currentBarn = this.GetByNumber(number);

            if (currentBarn == null)
            {
                return true;
            }

            return currentBarn.Id == id;
        }
    }
}
