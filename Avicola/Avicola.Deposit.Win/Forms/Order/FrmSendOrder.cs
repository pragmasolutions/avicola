using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;
using Avicola.Common.Win;
using Avicola.Common.Win.Helpers;
using Avicola.Office.Entities;
using Avicola.Office.Services.Interfaces;
using Avicola.Reports;
using Avicola.Sales.Services.Dtos;
using Avicola.Sales.Services.Interfaces;
using Framework.WinForm.Comun.Notification;
using Microsoft.Reporting.WinForms;
using IServiceFactory = Avicola.Services.Common.Interfaces.IServiceFactory;

namespace Avicola.Deposit.Win.Forms
{
    public partial class FrmSendOrder : EditFormBase
    {
        private const string OrderDispatchNoteTemporalFileName = "OrderDispatchNote.pdf";

        private readonly IServiceFactory _serviceFactory;
        private readonly IMessageBoxDisplayService _messageBoxDisplayService;

        public FrmSendOrder(IServiceFactory serviceFactory, IMessageBoxDisplayService messageBoxDisplayService)
        {
            _serviceFactory = serviceFactory;
            _messageBoxDisplayService = messageBoxDisplayService;

            InitializeComponent();
        }

        public OrderDto Order { get; set; }

        private void btnSendOrder_Click(object sender, EventArgs e)
        {
            this.FormErrorProvider.Clear();

            if (ucDriverSelection.SelectedDriver == null)
            {
                this.FormErrorProvider.SetError(ucDriverSelection, "El campo conductor es requerido");
                return;
            }

            if (ucTruckSelection.SelectedTruck == null)
            {
                this.FormErrorProvider.SetError(ucTruckSelection, "El campo camión es requerido");
                return;
            }

            _messageBoxDisplayService.ShowConfirmationDialog("Esta seguro que desea enviar este pedido?", "Armar Pedido",
                () =>
                {
                    using (var service = _serviceFactory.Create<IOrderService>())
                    {
                        service.SendOrder(Order.Id, ucDriverSelection.SelectedDriver.Id, ucTruckSelection.SelectedTruck.Id);

                        if (AppSettings.PrintOrderDispatchNote)
                        {
                            PrintDispatchNote(Order.Id);
                        }

                        TransitionManager.LoadOrdersManagerView();
                    }
                });
        }

        private void PrintDispatchNote(Guid orderId)
        {
            using (var rptOrderDispatcNote = new ReportViewer())
            {
                using (var service = _serviceFactory.Create<Avicola.Sales.Services.Interfaces.IReportService>())
                {
                    var orderDispatchNoteData = service.OrderDispatchNote(orderId);

                    SaveTemporalPdf(rptOrderDispatcNote, orderDispatchNoteData);

                    //Send the pdf to the printer
                    DirectPrintHelper.SendToPrinter(string.Format(@"{0}\" + OrderDispatchNoteTemporalFileName, Application.StartupPath));

                    RemoveTemporalPdf();
                }
            }
        }

        private static void RemoveTemporalPdf()
        {
            //Remove pdf
            if (File.Exists(string.Format(@"{0}\" + OrderDispatchNoteTemporalFileName, Application.StartupPath)))
            {
                File.Delete(string.Format(@"{0}\" + OrderDispatchNoteTemporalFileName, Application.StartupPath));
            }
        }

        private static void SaveTemporalPdf(ReportViewer rptOrderDispatcNote, List<Avicola.Sales.Entities.ReportOrderDispatchNoteRow> orderDispatchNoteData)
        {
            rptOrderDispatcNote.LocalReport.DataSources.Clear();
            rptOrderDispatcNote.ProcessingMode = ProcessingMode.Local;
            string appPath = Application.StartupPath.Replace("\\bin\\Debug", "");
            string reportPath = @"\Resources\Reports\OrderDespatchNote.rdl";
            rptOrderDispatcNote.LocalReport.ReportPath = appPath + reportPath;

            rptOrderDispatcNote.LocalReport.DataSources.Add(new ReportDataSource("OrderDispatchNoteDataSet",
                orderDispatchNoteData));
            rptOrderDispatcNote.RefreshReport();

            //Export to PDF
            Microsoft.Reporting.WinForms.Warning[] warnings;
            string[] streamids;
            string mimeType;
            string encoding;
            string extension;

            byte[] bytes = rptOrderDispatcNote.LocalReport.Render(
                "PDF", null, out mimeType, out encoding,
                out extension,
                out streamids, out warnings);

            //Save pdf
            FileStream fs = new FileStream(string.Format(@"{0}\OrderDispatchNote.pdf", Application.StartupPath),
                FileMode.Create);
            fs.Write(bytes, 0, bytes.Length);
            fs.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            TransitionManager.LoadOrdersManagerView();
        }

        private void FrmSendOrder_Load(object sender, EventArgs e)
        {
            if (Order == null)
            {
                throw new ArgumentNullException("Se debe establecer una orden a enviar");
            }

            ucOrderDetails.Order = Order;


            using (var service = _serviceFactory.Create<IDriverService>())
            {
                ucDriverSelection.Drivers = service.GetAll();
            }

            using (var service = _serviceFactory.Create<ITruckService>())
            {
                ucTruckSelection.Trucks = service.GetAll();
            }
        }
        private void btnBackToDepositManager_Click(object sender, EventArgs e)
        {
            TransitionManager.LoadOrdersManagerView();
        }
    }
}
