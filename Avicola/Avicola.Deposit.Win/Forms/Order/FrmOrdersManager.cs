using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Avicola.Common.Win.Forms;
using Avicola.Sales.Entities;
using Avicola.Sales.Services.Dtos;
using Avicola.Sales.Services.Interfaces;
using Telerik.WinControls;
using Telerik.WinControls.UI;
using IServiceFactory = Avicola.Services.Common.Interfaces.IServiceFactory;

namespace Avicola.Deposit.Win.Forms
{
    public partial class FrmOrdersManager : FrmDepositBase
    {
        private readonly IServiceFactory _serviceFactory;
        private IList<OrderStatus> _orderStatuses;

        public FrmOrdersManager(IServiceFactory serviceFactory)
        {
            _serviceFactory = serviceFactory;
            InitializeComponent();
        }

        public IList<OrderStatus> OrderStatuses
        {
            get
            {
                if (_orderStatuses == null)
                {
                    using (var service = _serviceFactory.Create<IOrderStatusService>())
                    {
                        _orderStatuses = service.GetActiveStatus();
                    }
                }

                return _orderStatuses;
            } 
        }  

        private void btnBackToDepositManager_Click(object sender, EventArgs e)
        {
            TransitionManager.LoadDepositManagerView();
        }

        private void FrmPendingOrders_Load(object sender, EventArgs e)
        {
            LoadOrderStatus();

            tvOrderStatus.SelectedNode = tvOrderStatus.Nodes.First();
        }

        private void LoadOrdersByStatus(Guid status)
        {
            using (var service = _serviceFactory.Create<IOrderService>())
            {
                var orders = service.GetOrdersByStatus(status);

                gvOrders.DataSource = orders;
            }

            lbTitle.Text = OrderStatuses.First(x => x.Id == status).Name;
        }

        private void LoadOrderStatus()
        {
            tvOrderStatus.DataSource = OrderStatuses;
        }
        
        private void tvOrders_SelectedNodeChanged(object sender, RadTreeViewEventArgs e)
        {
            var statusSelected = e.Node.DataBoundItem as OrderStatus;

            if (statusSelected != null)
            {
                LoadOrdersByStatus(statusSelected.Id);
            }
        }

        private void gvOrders_CommandCellClick(object sender, EventArgs e)
        {
            var commandCell = (GridCommandCellElement)sender;

            var selectedRow = this.gvOrders.SelectedRows.FirstOrDefault();

            if (selectedRow == null)
                return;

            var order = selectedRow.DataBoundItem as OrderDto;

            if (order == null)
                return;

            if (commandCell.ColumnInfo.Name == GlobalConstants.BuildOrderColumnName)
            {
                TransitionManager.LoadBuildOrderView();
            }
        }

        private void gvOrders_CellFormatting(object sender, CellFormattingEventArgs e)
        {
            var order = e.Row.DataBoundItem as OrderDto;

            if (order != null)
            {
                if (e.CellElement.ColumnInfo.Name == GlobalConstants.BuildOrderColumnName)
                {
                    e.CellElement.ColumnInfo.IsVisible = order.OrderStatusId == OrderStatus.PENDING;
                }

                if (e.CellElement.ColumnInfo.Name == GlobalConstants.SendOrderColumnName)
                {
                    e.CellElement.ColumnInfo.IsVisible = order.OrderStatusId == OrderStatus.IN_PROGESS;
                }

                if (e.CellElement.ColumnInfo.Name == GlobalConstants.FinishOrderColumnName)
                {
                    e.CellElement.ColumnInfo.IsVisible = order.OrderStatusId == OrderStatus.SENT;
                }
            }
        }
    }
}
