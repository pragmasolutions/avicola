using System;
using System.Windows.Forms;
using Avicola.Common.Win;
using Avicola.Sales.Win.Infrastructure;
using Avicola.Sales.Services.Dtos;
using Avicola.Sales.Win.Forms.Sales;
using Avicola.Services.Common.Interfaces;
using Framework.Sync;
using Framework.WinForm.Comun.Notification;
using Framework.Logging;


namespace Avicola.Sales.Win.Forms
{
    public partial class FrmMain : FrmSalesBase, ITransitionManager
    {
        private readonly ILogger _logger;
        private readonly IServiceFactory _serviceFactory;

        public FrmMain(IFormFactory formFactory, IMessageBoxDisplayService messageBoxDisplayService,
            IServiceFactory serviceFactory, ILogger logger)
        {
            FormFactory = formFactory;
            MessageBoxDisplayService = messageBoxDisplayService;
            _serviceFactory = serviceFactory;
            _logger = logger;

            InitializeComponent();
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            LoadSalesManagerView();
        }

        public void LoadView(FrmSalesBase form)
        {
            form.TopLevel = false;
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

        public void LoadSalesManagerView()
        {
            var view = FormFactory.Create<FrmSalesManager>();
            LoadView(view);
        }

        public void LoadHistoryManagerView()
        {
            var view = FormFactory.Create<FrmHistoryManager>();
            LoadView(view);
        }
        
        public void LoadNewSaleView()
        {
            var view = FormFactory.Create<FrmNewSale>();
            LoadView(view);
        }
    }
}
