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

        IList<Barn> GetAllByStage(Guid stageId);

        Barn GetById(Guid id);

        List<BarnDto> GetAll(string sortBy, string sortDirection, string criteria, 
                                int pageIndex, int pageSize, out int pageTotal);

        Barn GetByNumber(int number);

        void Create(Barn barn);

        void Edit(Barn barn);

        void Delete(Guid barnId);

        bool IsNumberAvailable(int number, Guid id);

        List<Barn> GetAllAvailable();
    }
}
