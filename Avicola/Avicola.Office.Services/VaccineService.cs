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
    }
}
