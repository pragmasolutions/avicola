﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Avicola.Common.Win.Forms;
using Avicola.Sales.Entities;
using Avicola.Sales.Services.Interfaces;
using Framework.Data.Repository;
using Telerik.WinControls.UI;

namespace Avicola.Deposit.Dashboard
{
    public partial class DepositDashboard : FrmBase
    {
        private IServiceFactory _serviceFactory;

        public DepositDashboard(IServiceFactory serviceFactory)
        {
            InitializeComponent();
            _serviceFactory = serviceFactory;
        }

        private void DepositDashboard_Load(object sender, EventArgs e)
        {
            this.dgvPreparedOrders.AutoSizeColumnsMode = GridViewAutoSizeColumnsMode.Fill;
            this.dgvPreparedOrders.Columns[1].BestFit();
            this.dgvPreparedOrders.ShowGroupPanel = false;

            this.dgvPendingOrders.AutoSizeColumnsMode = GridViewAutoSizeColumnsMode.Fill;
            this.dgvPendingOrders.Columns[1].BestFit();
            this.dgvPendingOrders.ShowGroupPanel = false;

            RefreshDashboard();
        }

        private void RefreshDashboard()
        {
            using (var stockService = _serviceFactory.Create<IStockService>())
            {
                int total;
            }
        }
    }
}
