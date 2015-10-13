using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Avicola.Office.Entities;
using Avicola.Office.Entities.DTO;
using Avicola.Office.Services.Dtos;
using Avicola.Services.Common;

namespace Avicola.Office.Services.Interfaces
{
    public interface IBarnService: IService
    {
        IQueryable<Barn> GetAll();

        Barn GetById(Guid id);

        List<BarnDto> GetAll(string sortBy, string sortDirection, string criteria, 
                                int pageIndex, int pageSize, out int pageTotal);

        Barn GetByName(string name);

        void Create(Barn barn);

        void Edit(Barn barn);

        void Delete(Guid barnId);

        bool IsNameAvailable(string name, Guid id);

        List<Barn> GetAllAvailable();
    }
}
