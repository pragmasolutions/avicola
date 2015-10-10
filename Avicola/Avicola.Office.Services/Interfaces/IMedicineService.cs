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
    public interface IMedicineService : IService
    {
        IQueryable<Medicine> GetAll();

        IQueryable<Medicine> GetAllActive();

        Medicine GetById(Guid id);

        void Create(Medicine medicine);

        void Edit(Medicine medicine);

        void Delete(Guid medicineId);

        bool IsNameAvailable(string name, Guid id);

        List<MedicineDto> GetAll(string sortBy, string sortDirection, string criteria, int pageIndex, int pageSize,
            out int pageTotal);
    }
}
