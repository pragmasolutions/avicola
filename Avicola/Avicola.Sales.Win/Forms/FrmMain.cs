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
        private bool isSyncRunning = false;

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
            timSynchronization.Interval = AppSettings.SyncPeriod;
            timSynchronization.Start();
        }

        public void LoadView(FrmSalesBase form)
        {
            foreach (IDisposable control in MainContenPanel.Controls)
            {
                control.Dispose();
            }

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
            if (!isSyncRunning)
            {
                isSyncRunning = true;

                timSynchronization.Stop();

                SyncManager syncManager = new SyncManager(_logger);

                WaitingBar.Visible = true;

                WaitingBar.StartWaiting();

                btnSync.Enabled = false;

                await syncManager.Sync(AppSettings.ScopeName, AppSettings.Schema);

                isSyncRunning = false;

                btnSync.Enabled = true;

                WaitingBar.StopWaiting();

                WaitingBar.Visible = false;

                MessageBoxDisplayService.ShowSuccess("Sincronizacion Finalizada con Exito");

                timSynchronization.Start();
            }
            else
            {
                MessageBoxDisplayService.ShowInfo("Actualmente se está realizando la sincronización automática.");
            }
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

        public void LoadClientsView()
        {
            var view = FormFactory.Create<FrmClientsList>();
            LoadView(view);
        }

        private void bgwSynchronization_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {
            timSynchronization.Stop();
            SyncManager syncManager = new SyncManager(_logger);
            syncManager.Sync(AppSettings.ScopeName, AppSettings.Schema);
        }

        private void timSynchronization_Tick(object sender, EventArgs e)
        {
            if (!isSyncRunning)
            {
                isSyncRunning = true;
                bgwSynchronization.RunWorkerAsync();
            }
        }

        private void bgwSynchronization_RunWorkerCompleted(object sender, System.ComponentModel.RunWorkerCompletedEventArgs e)
        {
            isSyncRunning = false;
            timSynchronization.Start();
        }
    }
}
