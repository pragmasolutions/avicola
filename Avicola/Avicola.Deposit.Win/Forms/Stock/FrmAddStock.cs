using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Avicola.Deposit.Win.Forms.Stock
{
    public partial class FrmAddStock : EditFormBase
    {
        public FrmAddStock()
        {
            InitializeComponent();
        }

        private void radButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ckdProvider_ToggleStateChanged(object sender, Telerik.WinControls.UI.StateChangedEventArgs args)
        {
            ddlProviders.Visible = true;
        }

        private void ckdOwn_ToggleStateChanged(object sender, Telerik.WinControls.UI.StateChangedEventArgs args)
        {
            ddlProviders.Visible = false;
        }

        private void FrmAddStock_Load(object sender, EventArgs e)
        {

        }

    }
}
