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
using Avicola.Production.Win.Forms.Standards;
using Avicola.Production.Win.Infrastructure;
using Telerik.WinControls;

namespace Avicola.Production.Win.Forms
{
    public partial class FrmMain : FrmBase , ITransitionManager
    {
        public FrmMain(IFormFactory formFactory)
        {
            FormFactory = formFactory;

            InitializeComponent();
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            LoadBatchSelectionView();
        }

        public void LoadView(FrmBase form)
        {
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
            var view = FormFactory.Create<FrmEnterDailyMeasures>();
            LoadView(view);
        }
    }
}
