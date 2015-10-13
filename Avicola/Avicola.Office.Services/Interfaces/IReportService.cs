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
    public interface IReportService: IService
    {

        List<ReportBreedingMeasuresFollowUpRow> BreedingMeasuresFollowUp(Guid batchId, DateTime? dateFrom, DateTime? dateTo);
        List<ReportBatchObservations> BatchObservation(Guid batchId, Guid stageId);
        List<ReportBatchVaccines> BatchVaccine(Guid batchId, Guid stageId);
        List<ReportBatchMedicines> BatchMedicine(Guid batchId, Guid stageId);

    }
}
