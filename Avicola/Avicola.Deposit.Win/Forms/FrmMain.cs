using System;
using System.Windows.Forms;
using Avicola.Common.Win;
using Avicola.Deposit.Win.Infrastructure;
using Avicola.Services.Common.Interfaces;
using Framework.Sync;
using Framework.WinForm.Comun.Notification;


namespace Avicola.Deposit.Win.Forms
{
    public partial class FrmMain : FrmDepositBase, ITransitionManager
    {
        private readonly IServiceFactory _serviceFactory;

        public FrmMain(IFormFactory formFactory, IMessageBoxDisplayService messageBoxDisplayService, IServiceFactory serviceFactory)
        {
            FormFactory = formFactory;
            MessageBoxDisplayService = messageBoxDisplayService;
            _serviceFactory = serviceFactory;

            InitializeComponent();
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
        }

        public void LoadView(FrmDepositBase form)
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
            SyncManager syncManager = new SyncManager();

            WaitingBar.Visible = true;

            WaitingBar.StartWaiting();

            btnSync.Enabled = false;

            //await syncManager.Sync();

            btnSync.Enabled = true;

            WaitingBar.StopWaiting();

            WaitingBar.Visible = false;
            
            MessageBoxDisplayService.ShowSuccess("Sincronizacion Finalizada con Exito");
        }
    }
}
