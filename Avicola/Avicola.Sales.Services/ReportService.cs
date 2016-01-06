using System;
using System.Collections.Generic;
using System.Linq;
using Avicola.Sales.Data.Interfaces;
using Avicola.Sales.Entities;
using Avicola.Sales.Services.Interfaces;

namespace Avicola.Sales.Services
{
    public class ReportService : ServiceBase, IReportService
    {
        public ReportService(ISalesUow uow)
        {
            Uow = uow;
        }

        public List<ReportOrderDispatchNoteRow> OrderDispatchNote(Guid orderId)
        {
            return Uow.DbContext.ReportOrderDispatchNote(orderId).ToList();
        }
    }
}
