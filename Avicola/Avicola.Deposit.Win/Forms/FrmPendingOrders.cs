using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Avicola.Common.Win.Forms;
using Telerik.WinControls;

namespace Avicola.Deposit.Win.Forms
{
    public partial class FrmPendingOrders : FrmDepositBase
    {
        public FrmPendingOrders()
        {
            InitializeComponent();
        }

        private void btnBackToDepositManager_Click(object sender, EventArgs e)
        {
            TransitionManager.LoadPendingOrdersView();
        }
    }
}
