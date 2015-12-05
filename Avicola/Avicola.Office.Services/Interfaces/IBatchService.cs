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
    public interface IBatchService : IService
    {
        IList<BatchDto> GetAllActive();

        BatchDto GetActiveById(Guid batchId);

        IList<Batch> GetAllActiveComplete();

        Batch GetByIdComplete(Guid batchId);

        int GetBirdsAmount(Guid batchId, DateTime date);

        decimal GetCurrentStageFoodEntry(Guid batchId, DateTime date, Guid toStageId);

        void MoveNextStage(MoveNextStageDto nextStageDto);

        int GetNextNumber();

        void Create(Batch batch);

        void Delete(Guid batchId);

        Batch GetById(Guid batchId);

        void EndBatch(Batch batch, DateTime endDate);

        string AssignBarn(Guid batchId, Guid barnId);

        IQueryable<Batch> GetAll();

        DateTime GetEndDateById(Guid batchId);

        IList<BatchBarnDetailDto> GetBarnsDetails(Guid batchId);

        void RecalculateFoodEntry(Guid guid);

        void RecalculateBirds(Guid guid);
    }
}
