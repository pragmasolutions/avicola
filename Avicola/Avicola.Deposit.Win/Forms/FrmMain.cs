using System;
using System.Windows.Forms;
using Avicola.Common.Win;
using Avicola.Deposit.Win.Forms.Order;
using Avicola.Deposit.Win.Forms.Stock;
using Avicola.Deposit.Win.Infrastructure;
using Avicola.Sales.Services.Dtos;
using Avicola.Services.Common.Interfaces;
using Framework.Logging;
using Framework.Sync;
using Framework.WinForm.Comun.Notification;
using log4net;


namespace Avicola.Deposit.Win.Forms
{
    public partial class FrmMain : FrmDepositBase, ITransitionManager
    {
        private readonly IServiceFactory _serviceFactory;
        private readonly ILogger _logger;

        public FrmMain(IFormFactory formFactory, IMessageBoxDisplayService messageBoxDisplayService, IServiceFactory serviceFactory,ILogger logger)
        {
            FormFactory = formFactory;
            MessageBoxDisplayService = messageBoxDisplayService;
            _serviceFactory = serviceFactory;
            _logger = logger;

            InitializeComponent();
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            LoadDepositManagerView();
        }

        public void LoadView(FrmDepositBase form)
        {
            form.TopLevel = false;

            foreach (IDisposable control in MainContenPanel.Controls)
            {
                control.Dispose();
            }

            MainContenPanel.Controls.Clear();
            MainContenPanel.Controls.Add(form);
            form.FormBorderStyle = FormBorderStyle.None;
            form.Dock = DockStyle.Fill;
            form.TransitionManager = this;
            form.Show();
        }

        private async void btnSync_Click(object sender, EventArgs e)
        {
            SyncManager syncManager = new SyncManager(_logger);

            WaitingBar.Visible = true;

            WaitingBar.StartWaiting();

            btnSync.Enabled = false;

            await syncManager.Sync();

            btnSync.Enabled = true;

            WaitingBar.StopWaiting();

            WaitingBar.Visible = false;

            MessageBoxDisplayService.ShowSuccess("Sincronizacion Finalizada con Exito");
        }

        public void LoadDepositManagerView()
        {
            var view = FormFactory.Create<FrmDepositManager>();
            LoadView(view);
        }

        public void LoadOrdersManagerView()
        {
            var view = FormFactory.Create<FrmOrdersManager>();
            LoadView(view);
        }

        public void LoadBuildOrderView(OrderDto order)
        {
            var view = FormFactory.Create<FrmBuildOrder>();
            view.Order = order;
            LoadView(view);
        }

        public void LoadCancelBuildedOrderView(OrderDto order)
        {
            var view = FormFactory.Create<FrmCancelBuildedOrder>();
            view.Order = order;
            LoadView(view);
        }

        public void LoadFinishOrderView(OrderDto order)
        {
            var view = FormFactory.Create<FrmFinishOrder>();
            view.Order = order;
            LoadView(view);
        }

        public void LoadSendOrderView(OrderDto order)
        {
            var view = FormFactory.Create<FrmSendOrder>();
            view.Order = order;
            LoadView(view);
        }

        public void LoadHistoryManagerView()
        {
            var view = FormFactory.Create<FrmHistoryManager>();
            LoadView(view);
        }

        public void LoadAddStockView()
        {
            var view = FormFactory.Create<FrmAddStock>();
            LoadView(view);
        }

        public void LoadOpenStockEntriesView()
        {
            var view = FormFactory.Create<FrmOpenStockEntries>();
            LoadView(view);
        }

        public void LoadStockEntryDetailsView(StockEntryDto stockEntry)
        {
            var view = FormFactory.Create<FrmStockEntryDetails>();
            view.StockEntry = stockEntry;
            LoadView(view);
        }

        public void LoadEditOrderView(OrderDto order)
        {
            var view = FormFactory.Create<FrmEditOrder>();
            view.OrderId = order.Id;
            LoadView(view);
        }
    }
}
