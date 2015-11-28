using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
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
        private IDictionary<Guid, IList<OrderDto>> _ordersCached;
        private Timer _refreshOrdersTimer;

        public FrmOrdersManager(IServiceFactory serviceFactory)
        {
            _serviceFactory = serviceFactory;
            InitializeComponent();

            gvOrders.TableElement.RowHeight = Avicola.Common.Win.GlobalConstants.DefaultRowHeight;

            StartRefreshTimer();
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

        private void btnBackToDepositManager_Click(object sender, EventArgs e)
        {
            TransitionManager.LoadDepositManagerView();
        }

        private void FrmPendingOrders_Load(object sender, EventArgs e)
        {
            LoadOrderStatus();

            LoadOrders();

            BindStatusTreeView();
        }

        private void BindStatusTreeView()
        {
            var orderStatus = OrderStatuses.Select(x => new OrderStatus()
                                                        {
                                                            Id = x.Id,
                                                            Name = x.Name + string.Format(" ({0})", OrderCached[x.Id].Count)
                                                        }).ToList();

            var currentSelectedNodeIndex = tvOrderStatus.SelectedNode != null ? tvOrderStatus.SelectedNode.Index : 0;

            tvOrderStatus.DataSource = orderStatus;

            tvOrderStatus.SelectedNode = tvOrderStatus.Nodes[currentSelectedNodeIndex];
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

        private void LoadOrdersByStatus(Guid status)
        {
            SetCommandColumnVisibility(status);

            gvOrders.DataSource = OrderCached[status];
            
            lbTitle.Text = OrderStatuses.First(x => x.Id == status).Name;
        }

        private void SetCommandColumnVisibility(Guid status)
        {
            if (status == OrderStatus.PENDING)
            {
                gvOrders.Columns[GlobalConstants.BuildOrderColumnName].IsVisible = true;

                gvOrders.Columns[GlobalConstants.FinishOrderColumnName].IsVisible = false;
                gvOrders.Columns[GlobalConstants.CancelBuildedOrderColumnName].IsVisible = false;
                gvOrders.Columns[GlobalConstants.SendOrderColumnName].IsVisible = false;
            }
            else if (status == OrderStatus.IN_PROGESS)
            {
                gvOrders.Columns[GlobalConstants.FinishOrderColumnName].IsVisible = true;
                gvOrders.Columns[GlobalConstants.CancelBuildedOrderColumnName].IsVisible = true;

                gvOrders.Columns[GlobalConstants.BuildOrderColumnName].IsVisible = false;
                gvOrders.Columns[GlobalConstants.SendOrderColumnName].IsVisible = false;
            }
            else if (status == OrderStatus.FINISHED)
            {
                gvOrders.Columns[GlobalConstants.SendOrderColumnName].IsVisible = true;

                gvOrders.Columns[GlobalConstants.BuildOrderColumnName].IsVisible = false;
                gvOrders.Columns[GlobalConstants.FinishOrderColumnName].IsVisible = false;
                gvOrders.Columns[GlobalConstants.CancelBuildedOrderColumnName].IsVisible = false;
            }
        }

        private void LoadOrderStatus()
        {
            using (var service = _serviceFactory.Create<IOrderStatusService>())
            {
                _orderStatuses = service.GetActiveStatus();
            }
        }

        private void tvOrders_SelectedNodeChanged(object sender, RadTreeViewEventArgs e)
        {
            if (e.Node != null)
            {
                var statusSelected = e.Node.DataBoundItem as OrderStatus;

                if (statusSelected != null)
                {
                    LoadOrdersByStatus(statusSelected.Id);
                }
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
                TransitionManager.LoadBuildOrderView(order);
            }
            else if (commandCell.ColumnInfo.Name == GlobalConstants.CancelBuildedOrderColumnName)
            {
                TransitionManager.LoadCancelBuildedOrderView(order);
            }
            else if (commandCell.ColumnInfo.Name == GlobalConstants.FinishOrderColumnName)
            {
                TransitionManager.LoadFinishOrderView(order);
            }
            else if (commandCell.ColumnInfo.Name == GlobalConstants.SendOrderColumnName)
            {
                TransitionManager.LoadSendOrderView(order);
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

                if (e.CellElement.ColumnInfo.Name == GlobalConstants.CancelBuildedOrderColumnName)
                {
                    e.CellElement.ColumnInfo.IsVisible = order.OrderStatusId == OrderStatus.IN_PROGESS;
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

        private void StartRefreshTimer()
        {
            _refreshOrdersTimer = new Timer();
            _refreshOrdersTimer.Interval = 1 * 60 * 1000;
            _refreshOrdersTimer.Tick += RefreshOrdersTimer_Tick;
            _refreshOrdersTimer.Start();
        }

        private void RefreshOrdersTimer_Tick(object sender, EventArgs eventArgs)
        {
            var lastPendingOrderCount = OrderCached[OrderStatus.PENDING].Count();

            LoadOrders();

            BindStatusTreeView();

            var newPendingOrderCount = OrderCached[OrderStatus.PENDING].Count();

            if (newPendingOrderCount > lastPendingOrderCount)
            {
                ShowNewOrdersAlert();
            }
        }

        private void ShowNewOrdersAlert()
        {
            this.NewOrdersAlert.CaptionText = "Nuevo Pedido";
            this.NewOrdersAlert.ContentText = "Se ha ingresado un nuevo pedido y esta listo para ser armado";
            this.NewOrdersAlert.PlaySound = true;
            this.NewOrdersAlert.SoundToPlay = SystemSounds.Asterisk;

            this.NewOrdersAlert.Show();
        }
    }
}
