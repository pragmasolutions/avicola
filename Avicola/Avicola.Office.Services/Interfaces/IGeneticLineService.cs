using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Avicola.Office.Entities;
using Avicola.Office.Entities.DTO;
using Avicola.Services.Common;

namespace Avicola.Office.Services.Interfaces
{
    public interface IGeneticLineService: IService
    {
        IQueryable<GeneticLine> GetAll();

        GeneticLine GetById(Guid id);

        List<GeneticLineDto> GetAll(string sortBy, string sortDirection, string criteria, 
                                int pageIndex, int pageSize, out int pageTotal);

        void Create(GeneticLine geneticLine);

        void Edit(GeneticLine geneticLine);

        void Delete(Guid geneticLineId);

        bool IsNameAvailable(string name, Guid id);
    }
}
