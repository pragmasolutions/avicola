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
using Ninject.Infrastructure.Language;
using Telerik.WinControls.UI;

namespace Avicola.Deposit.Dashboard
{
    public partial class DepositDashboard : FrmBase
    {
        private IServiceFactory _serviceFactory;
        private Timer _refreshTimer;

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

            _refreshTimer = new Timer();
            _refreshTimer.Interval = 60000; //One minute
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
                var stocks = stockService.GetByEggClass(Configuration.AppSettings.DepositId);
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
                        .ThenBy(x => x.CreatedDate).ToList();

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
            flpCurrentOrders.Controls.Clear();

            foreach (var dto in currentOrders)
            {
                flpCurrentOrders.Controls.Add(new UcOrderBlock()
                {
                    CreatedDate = dto.CreatedDate,
                    ClientName = dto.ClientName,
                    Address = dto.ClientAddress,
                    Status = dto.OrderStatusName,
                    EggClasses = dto.OrderEggClasses,
                    CurrentStocks = stocks
                });
            }
        }
    }
}
