using System;
using System.Collections.Generic;
using Avicola.Sales.Entities;
using Avicola.Services.Common;

namespace Avicola.Sales.Services.Interfaces
{
    public interface IReportService: IService
    {
        List<ReportOrderDispatchNoteRow> OrderDispatchNote(Guid orderId);
    }
}
