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
                || x.Name.Contains(criteria)));

            var results = Uow.Barns.GetAll(pagingCriteria, where);

            pageTotal = results.PagedMetadata.TotalItemCount;

            return results.Entities.Project().To<BarnDto>().ToList();
        }

        public Barn GetById(Guid id)
        {
            return Uow.Barns.Get(x => x.Id == id);
        }

        public Barn GetByName(string name)
        {
            return Uow.Barns.Get(x => x.Name == name && !x.IsDeleted);
        }

        public void Create(Barn barn)
        {
            if (!IsNameAvailable(barn.Name, barn.Id))
            {
                throw new ApplicationException("Un galpón con el mismo nombre ya ha sido creado");
            }

            Uow.Barns.Add(barn);
            Uow.Commit();
        }

        public void Edit(Barn barn)
        {
            var currentBarn = this.GetById(barn.Id);

            currentBarn.Capacity = barn.Capacity;
            currentBarn.Name = barn.Name;
            currentBarn.StageId = barn.StageId;

            Uow.Barns.Edit(currentBarn);
            Uow.Commit();
        }

        public void Delete(Guid barnId)
        {
            Uow.Barns.Delete(barnId);
            Uow.Commit();
        }

        public bool IsNameAvailable(string name, Guid id)
        {
            var currentBarn = this.GetByName(name);

            if (currentBarn == null)
            {
                return true;
            }

            return currentBarn.Id == id;
        }


        public List<Barn> GetAllAvailable()
        {
            var barns = Uow.Barns.GetAll().ToList();
            var activeBatches = Uow.Batches.GetAll().Where(b => b.EndDate == null && b.BarnId != null).ToList();

            return barns.Where(b => !activeBatches.Any(ab => ab.BarnId == b.Id)).ToList();
        }
    }
}
