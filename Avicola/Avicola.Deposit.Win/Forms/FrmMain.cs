using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Avicola.Common.Win;
using Avicola.Common.Win.Forms;
using Avicola.Deposit.Win.Forms;
using Avicola.Deposit.Win.Infrastructure;
using Framework.Sync;
using Framework.WinForm.Comun.Notification;
using Telerik.WinControls;
using Telerik.WinControls.UI;

namespace Avicola.Production.Win.Forms
{
    public partial class FrmMain : FrmDepositBase, ITransitionManager
    {
        public FrmMain(IFormFactory formFactory,IMessageBoxDisplayService messageBoxDisplayService)
        {
            FormFactory = formFactory;
            MessageBoxDisplayService = messageBoxDisplayService;
            
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
