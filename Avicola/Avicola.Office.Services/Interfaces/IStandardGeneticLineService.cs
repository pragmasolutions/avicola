using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Avicola.Office.Entities;
using Avicola.Office.Entities.DTO;

namespace Avicola.Office.Services.Interfaces
{
    public interface IStandardGeneticLineService
    {
        IList<StandardGeneticLine> GetByGeneticLine(Guid geneticLineId);

        StandardGeneticLine GetById(Guid standardGeneticLineId);

        void Create(StandardGeneticLine item);

        bool CheckExistance(Guid geneticLineId, Guid? standardId);
        
        void Delete(Guid id);

        void Edit(StandardGeneticLine item);
    }
}
