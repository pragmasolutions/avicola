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
    public interface IFoodClassService: IService
    {
        IQueryable<FoodClass> GetAll();

        List<FoodClassDto> GetAll(string sortBy, string sortDirection, string criteria,
                               int pageIndex, int pageSize, out int pageTotal);

        FoodClass GetById(Guid id);

        void Create(FoodClass geneticLine);

        void Edit(FoodClass geneticLine);

        void Delete(Guid geneticLineId);

        bool IsNameAvailable(string name, Guid id);
    }
}
