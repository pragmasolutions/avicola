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
    public class MedicineService : ServiceBase, IMedicineService
    {
        private readonly IClock _clock;

        public MedicineService(IOfficeUow uow, IClock clock)
        {
            _clock = clock;
            Uow = uow;
        }

        public IQueryable<Medicine> GetAll()
        {
            return Uow.Medicines.GetAll();
        }

        public IQueryable<Medicine> GetAllActive()
        {
            return Uow.Medicines.GetAll().Where(e => !e.IsDeleted);
        }

        public Medicine GetById(Guid id)
        {
            return Uow.Medicines.Get(g => g.Id == id);
        }

        public void Create(Medicine medicine)
        {
            Uow.Medicines.Add(medicine);
            Uow.Commit();
        }

        public void Edit(Medicine medicine)
        {
            var currentMedicine = this.GetById(medicine.Id);

            currentMedicine.Name = medicine.Name;
            currentMedicine.Observation = medicine.Observation;

            Uow.Medicines.Edit(currentMedicine);
            Uow.Commit();
        }

        public void Delete(Guid vaccineId)
        {
            Uow.Medicines.Delete(vaccineId);
            Uow.Commit();
        }

        public Medicine GetByName(string name)
        {
            return Uow.Medicines.Get(e => e.Name == name && !e.IsDeleted);
        }

        public bool IsNameAvailable(string name, Guid id)
        {
            var currentMedicine = this.GetByName(name);

            if (currentMedicine == null)
            {
                return true;
            }

            return currentMedicine.Id == id;
        }

        public List<MedicineDto> GetAll(string sortBy, string sortDirection, string criteria, int pageIndex, int pageSize, out int pageTotal)
        {
            var pagingCriteria = new PagingCriteria();

            pagingCriteria.PageNumber = pageIndex;
            pagingCriteria.PageSize = pageSize;
            pagingCriteria.SortBy = !string.IsNullOrEmpty(sortBy) ? sortBy : "CreatedDate";
            pagingCriteria.SortDirection = !string.IsNullOrEmpty(sortDirection) ? sortDirection : "DESC";

            Expression<Func<Medicine, bool>> where = x => !x.IsDeleted &&
                                                        ((string.IsNullOrEmpty(criteria) || x.Name.Contains(criteria)));

            var results = Uow.Medicines.GetAll(pagingCriteria,
                                                    where);

            pageTotal = results.PagedMetadata.TotalItemCount;

            return results.Entities.Project().To<MedicineDto>().ToList();
        }
    }
}
