using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Avicola.Common.Win.Forms;
using Framework.Sync;
using Telerik.WinControls.UI;
using Framework.Logging;

namespace Avicola.Production.Dashboard
{
    public partial class Form1 : FrmBase
    {
        private readonly ILogger _logger;

        public Form1(ILogger logger)
        {
            _logger = logger;
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            HtmlDocument doc = this.webBrowser.Document;
            webBrowser.Navigate(new Uri(ConfigurationManager.AppSettings["ProductionDashboardUrl"]));
            timSynchronization.Interval = AppSettings.SyncPeriod;
            timSynchronization.Start();
        }

        private void bgwSynchronization_DoWork(object sender, DoWorkEventArgs e)
        {
            timSynchronization.Stop();
            SyncManager syncManager = new SyncManager(_logger);
            syncManager.Sync(AppSettings.ScopeName, AppSettings.Schema);
        }

        private void bgwSynchronization_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            webBrowser.Refresh();
            timSynchronization.Start();
        }

        private void timSynchronization_Tick(object sender, EventArgs e)
        {
            bgwSynchronization.RunWorkerAsync();
        }
    }
}
