using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Telerik.WinControls.UI;

namespace Avicola.Deposit.Dashboard
{
    public partial class DepositDashboard : Form
    {
        public DepositDashboard()
        {
            InitializeComponent();
        }

        private void DepositDashboard_Load(object sender, EventArgs e)
        {
            this.dgvPendingOrders.AutoSizeColumnsMode = GridViewAutoSizeColumnsMode.Fill;
            this.dgvPendingOrders.Columns[1].BestFit();
            this.dgvPendingOrders.ShowGroupPanel = false;
        }
    }
}
