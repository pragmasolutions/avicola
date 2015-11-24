using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Avicola.Common.Win;
using Avicola.Common.Win.Forms;
using Avicola.Sales.Entities;
using Avicola.Sales.Services.Interfaces;
using Framework.Data.Repository;
using Ninject.Infrastructure.Language;
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
                var stocks = stockService.GetByDeposit(Configuration.AppSettings.DepositId);

                var eggs = stocks.FirstOrDefault(s => s.ProductId == Product.EGG);
                txtEgg.Text = (eggs != null) ? eggs.TotalEggs.ToString() : string.Empty;

                var brokenEggs = stocks.FirstOrDefault(s => s.ProductId == Product.BROKEN_EGG);
                txtBrokenEgg.Text = (brokenEggs != null) ? brokenEggs.TotalEggs.ToString() : string.Empty;

                var noShellEggs = stocks.FirstOrDefault(s => s.ProductId == Product.NO_SHELL_EGG);
                txtEggWithNoShell.Text = (noShellEggs != null) ? noShellEggs.TotalEggs.ToString() : string.Empty;

                using (var orderService = _serviceFactory.Create<IOrderService>())
                {
                    var pending = orderService.GetOrdersByStatus(new Guid[] {OrderStatus.IN_PROGESS, OrderStatus.PENDING})
                        .Where(x => (x.OrderStatusId == OrderStatus.IN_PROGESS && x.DepositId == Configuration.AppSettings.DepositId)
                                    || x.OrderStatusId == OrderStatus.PENDING)
                        .OrderBy(x => x.OrderStatusId)
                        .ThenBy(x => x.CreatedDate).ToList();

                    foreach (var order in pending)
                    {
                        if (order.OrderStatusId == OrderStatus.PENDING)
                        {
                            order.CanStartPreparing = (eggs != null && eggs.TotalEggs >= order.Dozens * 12)
                                ? "LISTO"
                                : "FALTA";
                        }
                    }

                    var finished = orderService.GetOrdersByStatus(new Guid[] { OrderStatus.FINISHED, OrderStatus.SENT })
                        .Where(x => x.DepositId == Configuration.AppSettings.DepositId)
                        .OrderBy(x => x.OrderStatusId)
                        .ThenBy(x => x.CreatedDate).ToList();

                    dgvPendingOrders.DataSource = pending;
                    dgvPreparedOrders.DataSource = finished;
                }
            }

            
        }

        private void dgvPendingOrders_CellFormatting(object sender, CellFormattingEventArgs e)
        {
            if (e.CellElement.ColumnInfo.FieldName == "CanStartPreparing")
            {
                e.CellElement.Font = new Font(e.CellElement.Font, FontStyle.Bold);
                if (e.CellElement.Value == "LISTO")
                {
                    e.CellElement.ForeColor = Color.Green;
                } 
                else if (e.CellElement.Value == "FALTA")
                {
                    e.CellElement.ForeColor = Color.Red;
                }
            }
        }
    }
}
