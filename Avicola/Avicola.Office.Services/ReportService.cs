using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using AutoMapper.QueryableExtensions;
using Avicola.Office.Data.Interfaces;
using Avicola.Office.Entities;
using Avicola.Office.Services.Dtos;
using Avicola.Office.Services.Interfaces;
using Framework.Common.Utility;
using Framework.Data.Helpers;

namespace Avicola.Office.Services
{
    public class ReportService : ServiceBase, IReportService
    {
        public ReportService(IOfficeUow uow)
        {
            Uow = uow;
        }

        public List<ReportBreedingMeasuresFollowUpRow> BreedingMeasuresFollowUp(Guid batchId, DateTime? dateFrom, DateTime? dateTo)
        {
            return Uow.DbContext.ReportBreedingMeasuresFollowUpRow(batchId, dateFrom, dateTo).ToList();
        }

        public List<ReportBatchObservations> BatchObservation(Guid batchId, DateTime? from, DateTime? to)
        {
            return Uow.DbContext.ReportBatchObservation(batchId, from, to).ToList();
        }

        public List<ReportBatchVaccines> BatchVaccine(Guid batchId, DateTime? from, DateTime? to)
        {
            return Uow.DbContext.ReportBatchVaccine(batchId, from, to).ToList();
        }

        public List<ReportBatchMedicines> BatchMedicine(Guid batchId, DateTime? from, DateTime? to)
        {
            return Uow.DbContext.ReportBatchMedicine(batchId, from, to).ToList();
        }

        public List<ReportOrderDispatchNoteRow> OrderDispatchNote(Guid orderId)
        {
            return Uow.DbContext.ReportOrderDispatchNote(orderId).ToList();
        }
    }
}
