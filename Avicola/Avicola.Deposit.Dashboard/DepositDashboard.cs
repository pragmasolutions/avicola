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
using Avicola.Deposit.Dashboard.UserControls;
using Avicola.Sales.Entities;
using Avicola.Sales.Services.Dtos;
using Avicola.Sales.Services.Interfaces;
using Framework.Data.Repository;
using Framework.WinForm.Comun.Notification;
using Ninject.Infrastructure.Language;
using Telerik.WinControls.UI;

namespace Avicola.Deposit.Dashboard
{
    public partial class DepositDashboard : FrmBase
    {
        private IServiceFactory _serviceFactory;
        private Timer _refreshTimer;

        public DepositDashboard(IServiceFactory serviceFactory,IMessageBoxDisplayService messageBoxDisplayService)
        {
            InitializeComponent();

            _serviceFactory = serviceFactory;

            MessageBoxDisplayService = messageBoxDisplayService;
        }

        private void DepositDashboard_Load(object sender, EventArgs e)
        {
            this.dgvPreparedOrders.AutoSizeColumnsMode = GridViewAutoSizeColumnsMode.Fill;
            this.dgvPreparedOrders.Columns[1].BestFit();
            this.dgvPreparedOrders.ShowGroupPanel = false;

            _refreshTimer = new Timer();
            _refreshTimer.Interval = 10000; //One minute
            _refreshTimer.Tick += RefreshTimerOnTick;
            _refreshTimer.Start();
            RefreshDashboard();
            
        }

        private void RefreshTimerOnTick(object sender, EventArgs eventArgs)
        {
            RefreshDashboard();
        }

        private void RefreshDashboard()
        {
            using (var stockService = _serviceFactory.Create<IStockService>())
            {
                //TODO: get egg classes stock
                var stocks = stockService.GetByEggClass(Configuration.AppSettings.DepositId).Where(x => x.Id != EggClass.BROKEN).ToList();
                flpStock.Controls.Clear();
                foreach (var stock in stocks)
                {
                    flpStock.Controls.Add(new UcEggClassStock()
                    {
                        EggClassName = stock.Name,
                        Stock = stock.EggsCount.GetValueOrDefault()
                    });
                }
                

                using (var orderService = _serviceFactory.Create<IOrderService>())
                {
                    var pending = orderService.GetOrdersByStatus(new Guid[] {OrderStatus.IN_PROGESS, OrderStatus.PENDING})
                        .Where(x => (x.OrderStatusId == OrderStatus.IN_PROGESS && x.DepositId == Configuration.AppSettings.DepositId)
                                    || x.OrderStatusId == OrderStatus.PENDING)
                        .OrderBy(x => x.OrderStatusId)
                        .ThenBy(x => x.CreatedDate).Take(9).ToList();

                    foreach (var order in pending)
                    {
                        if (order.OrderStatusId == OrderStatus.PENDING)
                        {
                            //order.CanStartPreparing = (eggs != null && eggs.TotalEggs >= order.Dozens * 12)
                            //    ? "LISTO"
                            //    : "FALTA";
                        }
                    }

                    var finished = orderService.GetOrdersByStatus(new Guid[] { OrderStatus.FINISHED, OrderStatus.SENT })
                        .Where(x => x.DepositId == Configuration.AppSettings.DepositId)
                        .OrderBy(x => x.OrderStatusId)
                        .ThenBy(x => x.CreatedDate).ToList();


                    dgvPreparedOrders.DataSource = finished;

                    LoadMainBlock(pending, stocks);
                }
            }
        }

        private void LoadMainBlock(List<OrderDto> currentOrders, List<EggClassStock> stocks)
        {
            foreach (UcOrderBlock orderControl in flpCurrentOrders.Controls)
            {
                if (!orderControl.IsConfirmationPending)
                {
                    orderControl.OrderFinished -= OrderControl_OrderFinished;
                    orderControl.OrderBuilt -= OrderControl_OrderBuilt;
                }
            }

            flpCurrentOrders.Controls.Clear();

            if (currentOrders.Any())
            {
                var mainWidth = flpCurrentOrders.Width - 10;
                var mainHeight = flpCurrentOrders.Height - 10;
                int blockWidth;
                int blockHeight;

                if (currentOrders.Count == 1)
                {
                    blockWidth = mainWidth;
                    blockHeight = mainHeight;
                }
                else if (currentOrders.Count < 3)
                {
                    blockWidth = mainWidth / 2;
                    blockHeight = mainHeight;
                }
                else if (currentOrders.Count < 5)
                {
                    blockWidth = mainWidth / 2;
                    blockHeight = mainHeight / 2;
                }
                else if (currentOrders.Count < 7)
                {
                    blockWidth = mainWidth / 3 - 4;
                    blockHeight = mainHeight / 2 - 4;
                }
                else 
                {
                    blockWidth = mainWidth / 3 - 4;
                    blockHeight = mainHeight / 3 - 4;
                }

                foreach (var dto in currentOrders.OrderBy(x => x.LoadDate))
                {
                    var orderControl = new UcOrderBlock()
                                       {
                                           OrderId = dto.Id,
                                           LoadDate = dto.LoadDate,
                                           ClientName = dto.ClientName,
                                           Address = dto.ClientAddress,
                                           OrderStatusId = dto.OrderStatusId,
                                           Status = dto.OrderStatusName,
                                           EggClasses = dto.OrderEggClasses,
                                           CurrentStocks = stocks,
                                           Width = blockWidth,
                                           Height = blockHeight
                                       };

                    orderControl.MessageBoxDisplayService = MessageBoxDisplayService;
                    orderControl.OrderFinished += OrderControl_OrderFinished;
                    orderControl.OrderBuilt += OrderControl_OrderBuilt;

                    flpCurrentOrders.Controls.Add(orderControl);
                }
            }
        }

        private void OrderControl_OrderFinished(object sender, Guid orderId)
        {
            var orderControl = sender as UcOrderBlock;

            if (orderControl != null)
            {
                orderControl.OrderFinished -= OrderControl_OrderFinished;
            }

            using (var orderService = _serviceFactory.Create<IOrderService>())
            {
                orderService.FinishOrder(orderId);

                RefreshDashboard();
            }
        }

        private void OrderControl_OrderBuilt(object sender, Guid orderId)
        {
            var orderControl = sender as UcOrderBlock;

            if (orderControl != null)
            {
                orderControl.OrderBuilt -= OrderControl_OrderBuilt;
            }

            using (var orderService = _serviceFactory.Create<IOrderService>())
            {
                orderService.BuildOrder(orderId, AppSettings.DepositId);

                RefreshDashboard();
            }
        }
    }
}
