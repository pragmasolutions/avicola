using System;
using System.Windows.Forms;
using Avicola.Sales.Services.Interfaces;
using Microsoft.Reporting.WinForms;
using IServiceFactory = Avicola.Services.Common.Interfaces.IServiceFactory;

namespace Avicola.Deposit.Win.Forms
{
    public partial class FrmPrintDispatchNote : EditFormBase
    {
        private readonly IServiceFactory _serviceFactory;

        public FrmPrintDispatchNote(IServiceFactory serviceFactory)
        {
            _serviceFactory = serviceFactory;

            InitializeComponent();
        }

        public Guid OrderId { get; set; }
        private void FrmPrintDispatchNote_Load(object sender, EventArgs e)
        {
            GenerateDispatchNote();
        }

        private void GenerateDispatchNote()
        {
            this.Cursor = Cursors.WaitCursor;

            using (var service = _serviceFactory.Create<IReportService>())
            {
                rvOrderDispatchNote.LocalReport.DataSources.Clear();
                rvOrderDispatchNote.ProcessingMode = ProcessingMode.Local;
                string appPath = Application.StartupPath.Replace("\\bin\\Debug", "");
                string reportPath = @"\Resources\Reports\OrderDespatchNote.rdl";
                rvOrderDispatchNote.LocalReport.ReportPath = appPath + reportPath;

                var orderDispatchNoteData = service.OrderDispatchNote(OrderId);

                rvOrderDispatchNote.LocalReport.DataSources.Add(new ReportDataSource("OrderDispatchNoteDataSet",
                orderDispatchNoteData));
                rvOrderDispatchNote.RefreshReport();
            }

            this.Cursor = Cursors.Default;
        }
    }
}
