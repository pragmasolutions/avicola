using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Avicola.Office.Entities;
using Avicola.Office.Entities.DTO;
using Avicola.Office.Services.DTO;

namespace Avicola.Office.Services.Interfaces
{
    public interface IStandardService
    {
        IQueryable<Standard> GetAll();

        Standard GetById(Guid id);

        List<StandardDto> GetAll(string sortBy, string sortDirection, string criteria, 
                                int pageIndex, int pageSize, out int pageTotal);

        void Create(Standard standard);

        void Edit(Standard standard);

        void Delete(Guid standardId);

        bool IsNameAvailable(string name, Guid id);
    }
}
