using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using AutoMapper.QueryableExtensions;
using Avicola.Office.Data.Interfaces;
using Avicola.Office.Entities;
using Avicola.Office.Entities.DTO;
using Avicola.Office.Services.Dtos;
using Avicola.Office.Services.Interfaces;
using Framework.Common.Utility;
using Framework.Data.Helpers;

namespace Avicola.Office.Services
{
    public class VaccineService : ServiceBase, IVaccineService
    {
        private readonly IClock _clock;

        public VaccineService(IOfficeUow uow, IClock clock)
        {
            _clock = clock;
            Uow = uow;
        }

        public IQueryable<Vaccine> GetAll()
        {
            return Uow.Vaccines.GetAll();
        }

        public IQueryable<Vaccine> GetAllActive()
        {
            return Uow.Vaccines.GetAll().Where(e => !e.IsDeleted);
        }

        public Vaccine GetById(Guid id)
        {
            return Uow.Vaccines.Get(g => g.Id == id);
        }

        public void Create(Vaccine vaccine)
        {
            Uow.Vaccines.Add(vaccine);
            Uow.Commit();
        }

        public void Edit(Vaccine vaccine)
        {
            var currentVaccine = this.GetById(vaccine.Id);

            currentVaccine.Name = vaccine.Name;
            currentVaccine.RecommendedDay = vaccine.RecommendedDay;

            Uow.Vaccines.Edit(currentVaccine);
            Uow.Commit();
        }

        public void Delete(Guid vaccineId)
        {
            Uow.Vaccines.Delete(vaccineId);
            Uow.Commit();
        }

        public Vaccine GetByName(string name)
        {
            return Uow.Vaccines.Get(e => e.Name == name && !e.IsDeleted);
        }

        public bool IsNameAvailable(string name, Guid id)
        {
            var currentVaccine = this.GetByName(name);

            if (currentVaccine == null)
            {
                return true;
            }

            return currentVaccine.Id == id;
        }

        public List<VaccineDto> GetAll(string sortBy, string sortDirection, string criteria, int pageIndex, int pageSize, out int pageTotal)
        {
            var pagingCriteria = new PagingCriteria();

            pagingCriteria.PageNumber = pageIndex;
            pagingCriteria.PageSize = pageSize;
            pagingCriteria.SortBy = !string.IsNullOrEmpty(sortBy) ? sortBy : "CreatedDate";
            pagingCriteria.SortDirection = !string.IsNullOrEmpty(sortDirection) ? sortDirection : "DESC";

            Expression<Func<Vaccine, bool>> where = x => !x.IsDeleted &&
                                                        ((string.IsNullOrEmpty(criteria) || x.Name.Contains(criteria)));

            var results = Uow.Vaccines.GetAll(pagingCriteria,
                                                    where);

            pageTotal = results.PagedMetadata.TotalItemCount;

            return results.Entities.Project().To<VaccineDto>().ToList();
        }
    }
}
