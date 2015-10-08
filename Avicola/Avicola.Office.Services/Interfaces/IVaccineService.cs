using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Avicola.Office.Entities;
using Avicola.Office.Entities.DTO;
using Avicola.Services.Common;
using Avicola.Office.Services.Dtos;

namespace Avicola.Office.Services.Interfaces
{
    public interface IVaccineService : IService
    {
        IQueryable<Vaccine> GetAll();

        IQueryable<Vaccine> GetAllActive();

        Vaccine GetById(Guid id);

        void Create(Vaccine vaccine);

        void Edit(Vaccine vaccine);

        void Delete(Guid vaccineId);

        bool IsNameAvailable(string name, Guid id);

        List<VaccineDto> GetAll(string sortBy, string sortDirection, string criteria, int pageIndex, int pageSize,
            out int pageTotal);
    }
}
