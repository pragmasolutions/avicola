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
    public interface IBatchObservationService : IService
    {
        IQueryable<BatchObservation> GetAll();

        BatchObservation GetById(Guid id);

        void Create(BatchObservation geneticLine);

        void Edit(BatchObservation geneticLine);

        void Delete(Guid geneticLineId);

        bool IsNameAvailable(string name, Guid id);
    }
}
