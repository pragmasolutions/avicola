using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Windows.Forms;
using Avicola.Common.Win;
using Avicola.Common.Win.Forms;
using Avicola.Deposit.Win.Infrastructure.Interfaces;
using Avicola.Sales.Entities;
using Avicola.Sales.Services.Dtos;
using Avicola.Sales.Services.Interfaces;
using Framework.WinForm.Comun.Notification;
using Telerik.WinControls;
using Telerik.WinControls.UI;
using IServiceFactory = Avicola.Services.Common.Interfaces.IServiceFactory;

namespace Avicola.Deposit.Win.Forms
{
    public partial class FrmOrdersManager : FrmDepositBase
    {
        private const string PrintDispatchNoteColumnName = "PrintDispatchNote";

        private readonly IServiceFactory _serviceFactory;
        private readonly IStateController _stateController;
        private IList<OrderStatus> _orderStatuses;
        private IDictionary<Guid, IList<OrderDto>> _ordersCached;
        private Timer _refreshOrdersTimer;
        private OrderStatus _selectedOrderStatus;

        public FrmOrdersManager(IServiceFactory serviceFactory,IFormFactory formFactory, IMessageBoxDisplayService messageBoxDisplayService,IStateController stateController)
        {
            _serviceFactory = serviceFactory;

            _stateController = stateController;

            FormFactory = formFactory;

            MessageBoxDisplayService = messageBoxDisplayService;

            InitializeComponent();

            gvOrders.TableElement.RowHeight = Avicola.Common.Win.GlobalConstants.DefaultRowHeight;

            gvOrders.CellFormatting += base.Grilla_CellFormatting;

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
            _stateController.CurrentOrderStatus = null;

            TransitionManager.LoadDepositManagerView();
        }

        private void FrmPendingOrders_Load(object sender, EventArgs e)
        {
            LoadViewData();

            SelectedCurrentStatus();
        }

        private void LoadViewData()
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
                gvOrders.Columns[GlobalConstants.EditColumnName].IsVisible = true;
                gvOrders.Columns[GlobalConstants.DeleteColumnName].IsVisible = true;

                gvOrders.Columns[GlobalConstants.FinishOrderColumnName].IsVisible = false;
                gvOrders.Columns[GlobalConstants.CancelBuildedOrderColumnName].IsVisible = false;
                gvOrders.Columns[GlobalConstants.SendOrderColumnName].IsVisible = false;
                gvOrders.Columns[PrintDispatchNoteColumnName].IsVisible = false;
            }
            else if (status == OrderStatus.IN_PROGESS)
            {
                gvOrders.Columns[GlobalConstants.FinishOrderColumnName].IsVisible = true;
                gvOrders.Columns[GlobalConstants.CancelBuildedOrderColumnName].IsVisible = true;
                gvOrders.Columns[GlobalConstants.EditColumnName].IsVisible = true;
                gvOrders.Columns[GlobalConstants.DeleteColumnName].IsVisible = true;

                gvOrders.Columns[GlobalConstants.BuildOrderColumnName].IsVisible = false;
                gvOrders.Columns[GlobalConstants.SendOrderColumnName].IsVisible = false;
                gvOrders.Columns[PrintDispatchNoteColumnName].IsVisible = false;
            }
            else if (status == OrderStatus.FINISHED)
            {
                gvOrders.Columns[GlobalConstants.SendOrderColumnName].IsVisible = true;

                gvOrders.Columns[GlobalConstants.BuildOrderColumnName].IsVisible = false;
                gvOrders.Columns[GlobalConstants.FinishOrderColumnName].IsVisible = false;
                gvOrders.Columns[GlobalConstants.CancelBuildedOrderColumnName].IsVisible = false;
                gvOrders.Columns[GlobalConstants.EditColumnName].IsVisible = false;
                gvOrders.Columns[GlobalConstants.DeleteColumnName].IsVisible = false;
                gvOrders.Columns[PrintDispatchNoteColumnName].IsVisible = false;
            }
            else
            {
                gvOrders.Columns[PrintDispatchNoteColumnName].IsVisible = true;

                gvOrders.Columns[GlobalConstants.SendOrderColumnName].IsVisible = false;
                gvOrders.Columns[GlobalConstants.BuildOrderColumnName].IsVisible = false;
                gvOrders.Columns[GlobalConstants.FinishOrderColumnName].IsVisible = false;
                gvOrders.Columns[GlobalConstants.CancelBuildedOrderColumnName].IsVisible = false;
                gvOrders.Columns[GlobalConstants.EditColumnName].IsVisible = false;
                gvOrders.Columns[GlobalConstants.DeleteColumnName].IsVisible = false;
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
                _selectedOrderStatus = e.Node.DataBoundItem as OrderStatus;
                    
                if (_selectedOrderStatus != null)
                {
                    LoadOrdersByStatus(_selectedOrderStatus.Id);
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

            _stateController.CurrentOrderStatus = _selectedOrderStatus;

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
            else if (commandCell.ColumnInfo.Name == GlobalConstants.EditColumnName)
            {
                TransitionManager.LoadEditOrderView(order);
            }
            else if (commandCell.ColumnInfo.Name == PrintDispatchNoteColumnName)
            {
                using (var printForm = FormFactory.Create<FrmPrintDispatchNote>())
                {
                    printForm.OrderId = order.Id;
                    printForm.ShowDialog();
                }
            }
            else if (commandCell.ColumnInfo.Name == GlobalConstants.DeleteColumnName)
            {
                MessageBoxDisplayService.ShowConfirmationDialog("¿Esta seguro que desea eliminar este pedído?", "Eliminar Pedído",
                    () =>
                    {
                        using (var service = _serviceFactory.Create<IOrderService>())
                        {
                            service.Delete(order.Id);

                            LoadViewData();
                        }
                    });
            }
        }

        private void SelectedCurrentStatus()
        {
            if (_stateController.CurrentOrderStatus != null)
            {
                var selectedNode = tvOrderStatus.Nodes.FirstOrDefault(
                    x =>
                    {
                        var status = x.DataBoundItem as OrderStatus;

                        return status != null && status.Id == _stateController.CurrentOrderStatus.Id;
                    });

                tvOrderStatus.SelectedNode = selectedNode;
            }
        }

        private void StartRefreshTimer()
        {
            _refreshOrdersTimer = new Timer();
            _refreshOrdersTimer.Interval = AppSettings.RefreshOrdersInterval * 60 * 1000;
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
            this.NewOrdersAlert.CaptionText = "Nuevo Pedidos";
            this.NewOrdersAlert.ContentText = "Se han ingresado nuevos pedidos y estan listo para ser armados";
            this.NewOrdersAlert.PlaySound = true;
            this.NewOrdersAlert.SoundToPlay = SystemSounds.Asterisk;

            this.NewOrdersAlert.Show();
        }
    }
}
