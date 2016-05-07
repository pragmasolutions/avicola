using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace De.Provision.Databases
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void bgwProvisionProgress_DoWork(object sender, DoWorkEventArgs e)
        {
            SyncManager syncManager = new SyncManager(txtProvisionLocalDatabase.Text, txtProvisionRemoteDatabase.Text);
            syncManager.Setup(txtTables.Text, txtProvisionScopeName.Text);
        }

        private void bgwProvisionProgress_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {

        }

        private void bgwProvisionProgress_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            MessageBox.Show("Termino proceso provision");
        }

        private void btnProvision_Click(object sender, EventArgs e)
        {
            bgwProvisionProgress.RunWorkerAsync();
        }

        private void btnDeprovision_Click(object sender, EventArgs e)
        {
            bgwDeprovisionProgress.RunWorkerAsync();
        }

        private void bgwDeprovisionProgress_DoWork(object sender, DoWorkEventArgs e)
        {
            SyncManager syncManager = new SyncManager(txtDeprovisionLocalDatabase.Text, txtDeprovisionRemoteDatabase.Text);
            syncManager.Deprovision(txtDeprovisionScopeName.Text);
        }

        private void bgwDeprovisionProgress_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            MessageBox.Show("Termino proceso de deprovision");
        }

        private void bgwDeprovisionProgress_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {

        }
    }
}
