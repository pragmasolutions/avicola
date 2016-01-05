using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Avicola.Common.Win;
using Avicola.Production.Win.Forms.Batchs;
using Avicola.Production.Win.Forms.Measure;
using Avicola.Production.Win.Forms.SiloEmptyings;
using Avicola.Production.Win.Forms.Standards;
using Avicola.Production.Win.Infrastructure;
using Framework.Logging;
using Framework.Sync;
using Framework.WinForm.Comun.Notification;
using Telerik.WinControls;
using Telerik.WinControls.UI;

namespace Avicola.Production.Win.Forms
{
    public partial class FrmMain : FrmProductionBase, ITransitionManager
    {
        private readonly ILogger _logger;

        public FrmMain(IFormFactory formFactory,IMessageBoxDisplayService messageBoxDisplayService,ILogger logger)
        {
            _logger = logger;
            FormFactory = formFactory;
            MessageBoxDisplayService = messageBoxDisplayService;
            
            InitializeComponent();
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            LoadBatchSelectionView();
        }

        public void LoadView(FrmProductionBase form)
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

        public void LoadBatchSelectionView()
        {
            var view = FormFactory.Create<FrmBatchSelection>();
            LoadView(view);
        }

        public void LoadBatchManagerView()
        {
            var view = FormFactory.Create<FrmBatchManager>();
            LoadView(view);
        }

        public void LoadStandardSelectionView()
        {
            var view = FormFactory.Create<FrmStandardSelection>();
            LoadView(view);
        }
        
        public void LoadEnterDailyStandardView()
        {
            var view = FormFactory.Create<FrmEnterDailyMeasures>();
            LoadView(view);
        }

        public void LoadEnterWeeklyStandardView()
        {
            var view = FormFactory.Create<FrmEnterWeeklyMeasures>();
            LoadView(view);
        }


        public void LoadEnterSilosEmptyingView()
        {
            var view = FormFactory.Create<FrmEnterSilosEmptying>();
            LoadView(view);
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
    }
}
