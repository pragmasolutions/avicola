using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Avicola.Common.Win.Forms;
using Avicola.Sales.Services.Interfaces;
using Telerik.WinControls;
using IServiceFactory = Avicola.Services.Common.Interfaces.IServiceFactory;

namespace Avicola.Deposit.Win.Forms
{
    public partial class FrmPendingOrders : FrmDepositBase
    {
        private readonly IServiceFactory _serviceFactory;

        public FrmPendingOrders(IServiceFactory serviceFactory)
        {
            _serviceFactory = serviceFactory;
            InitializeComponent();
        }

        private void btnBackToDepositManager_Click(object sender, EventArgs e)
        {
            TransitionManager.LoadDepositManagerView();
        }

        private void FrmPendingOrders_Load(object sender, EventArgs e)
        {
            LoadPendingOrders();
        }

        private void LoadPendingOrders()
        {
            using (var service = _serviceFactory.Create<IOrderService>())
            {
                var orders = service.GetPendingOrders();

                gvPendingOrders.DataSource = orders;
            }
        }
    }
}
