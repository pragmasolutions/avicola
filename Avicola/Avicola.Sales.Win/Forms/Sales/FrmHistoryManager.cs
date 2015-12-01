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

namespace Avicola.Sales.Win.Forms
{
    public partial class FrmHistoryManager : FrmSalesBase
    {
        private readonly IServiceFactory _serviceFactory;
        private IList<OrderStatus> _orderStatuses;
        private IDictionary<Guid, IList<OrderDto>> _ordersCached;

        public FrmHistoryManager(IServiceFactory serviceFactory)
        {
            _serviceFactory = serviceFactory;
            InitializeComponent();

            gvOrders.TableElement.RowHeight = Avicola.Common.Win.GlobalConstants.DefaultRowHeight;
        }

        public IList<OrderStatus> OrderStatuses
        {
            get
            {
                if (_orderStatuses == null)
                {
                    LoadOrderStatus();
                }

                return _orderStatuses;
            }
        }

        public IDictionary<Guid, IList<OrderDto>> OrderCached
        {
            get
            {
                if (_ordersCached == null)
                {
                    LoadOrders();
                }

                return _ordersCached;
            }
        }

        private void btnBackToSalesManager_Click(object sender, EventArgs e)
        {
            TransitionManager.LoadSalesManagerView();
        }

        private void FrmPendingOrders_Load(object sender, EventArgs e)
        {
            LoadOrderStatus();

            LoadOrders();

            LoadOrdersByStatus(OrderStatus.SENT);
        }

        private void LoadOrdersByStatus(Guid status)
        {
            gvOrders.DataSource = OrderCached[status];

            lbTitle.Text = OrderStatuses.First(x => x.Id == status).Name;
        }

        private void LoadOrders()
        {
            _ordersCached = new Dictionary<Guid, IList<OrderDto>>();

            using (var service = _serviceFactory.Create<IOrderService>())
            {
                var orders = service.GetActiveOrders();

                foreach (var status in OrderStatuses)
                {
                    if (!_ordersCached.ContainsKey(status.Id))
                    {
                        _ordersCached.Add(status.Id, orders.Where(x => x.OrderStatusId == status.Id).ToList());
                    }
                }
            }
        }

        private void LoadOrderStatus()
        {
            using (var service = _serviceFactory.Create<IOrderStatusService>())
            {
                _orderStatuses = service.GetActiveStatus();
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

                if (e.CellElement.ColumnInfo.Name == GlobalConstants.FinishOrderColumnName)
                {
                    e.CellElement.ColumnInfo.IsVisible = order.OrderStatusId == OrderStatus.IN_PROGESS;
                }

                if (e.CellElement.ColumnInfo.Name == GlobalConstants.SendOrderColumnName)
                {
                    e.CellElement.ColumnInfo.IsVisible = order.OrderStatusId == OrderStatus.FINISHED;
                }
            }
        }
    }
}
