using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Avicola.Common.Win.Forms;
using Avicola.Sales.Entities;
using Avicola.Sales.Services.Dtos;
using Avicola.Sales.Services.Interfaces;
using Framework.WinForm.Comun.Notification;
using Telerik.WinControls;
using Telerik.WinControls.UI;
using IServiceFactory = Avicola.Services.Common.Interfaces.IServiceFactory;

namespace Avicola.Sales.Win.Forms
{
    public partial class FrmHistoryManager : FrmSalesBase
    {
        private RadWaitingBar loadingOverlay;

        private const string DeleteColumnName = "Delete";
        private readonly IServiceFactory _serviceFactory;
        private IList<OrderStatus> _orderStatuses;
        private IDictionary<Guid, IList<OrderDto>> _ordersCached;

        public FrmHistoryManager(IServiceFactory serviceFactory, IMessageBoxDisplayService messageBoxDisplayService)
        {
            _serviceFactory = serviceFactory;

            MessageBoxDisplayService = messageBoxDisplayService;

            InitializeComponent();

            gvOrders.CellFormatting += base.Grilla_CellFormatting;

            CreateLoadingOverlay();

            UcGridPager.RefreshActionAsync = LoadOrders;

            SortColumnMappings = new Dictionary<string, string>();

            SortColumnMappings["ClientName"] = "Client.Name";
            SortColumnMappings["OrderStatusName"] = "OrderStatus.Name";
            SortColumnMappings["DriverName"] = "Driver.Name";
            SortColumnMappings["Truck"] = "Truck.NumberPlate";

            MainGrid = gvOrders;
            MainPager = UcGridPager;
            LoadingOverlay = loadingOverlay;
        }

        private void CreateLoadingOverlay()
        {
            this.loadingOverlay = new RadWaitingBar();

            this.loadingOverlay.Parent = gvOrders;
            this.loadingOverlay.Dock = DockStyle.None;
            this.loadingOverlay.WaitingStyle = Telerik.WinControls.Enumerations.WaitingBarStyles.Dash;
            this.loadingOverlay.ThemeName = this.ThemeName;
            this.loadingOverlay.Visible = false;
        }

        private void gvOrders_PageChanged(object sender, EventArgs e)
        {
            LoadOrders();
        }

        private void btnBackToSalesManager_Click(object sender, EventArgs e)
        {
            TransitionManager.LoadSalesManagerView();
        }

        private async void FrmPendingOrders_Load(object sender, EventArgs e)
        {
            LoadFiltersData();

            LoadOrders();
        }

        public override Task<int> RefreshList()
        {
            return LoadOrders();
        }

        private async void LoadFiltersData()
        {
            var orderStatus = await Task.Run(() =>
                           {
                               using (var orderStatusService = _serviceFactory.Create<IOrderStatusService>())
                               {
                                   return orderStatusService.GetActiveStatus();
                               }
                           });

            var drivers = await Task.Run(() =>
                          {
                              using (var driverService = _serviceFactory.Create<IDriverService>())
                              {
                                  return driverService.GetAll();
                              }
                          });

            var trucks = await Task.Run(() =>
                           {
                               using (var truckService = _serviceFactory.Create<ITruckService>())
                               {
                                   return truckService.GetAll();
                               }
                           });

            ucOrdersFilters.OrderStatus = orderStatus;
            ucOrdersFilters.Drivers = drivers;
            ucOrdersFilters.Trucks = trucks;
        }

        private async Task<int> LoadOrders()
        {
            StartWaiting();

            int pageTotal = 0;

            using (var service = _serviceFactory.Create<IOrderService>())
            {
                var orders = await Task.Run(() =>
                        service.GetAll(SortColumn, 
                                        SortDirection,
                                        ucOrdersFilters.Client,
                                        ucOrdersFilters.OrderStatusId.HasValue
                                            ? new Guid[] {ucOrdersFilters.OrderStatusId.Value}
                                            : new Guid[] {},
                                        ucOrdersFilters.From,
                                        ucOrdersFilters.To,
                                        ucOrdersFilters.DriverId,
                                        ucOrdersFilters.TruckId,
                                        UcGridPager.CurrentPage,
                                        UcGridPager.PageSize, 
                                        out pageTotal));

                gvOrders.DataSource = orders;
            }

            StopWaiting();

            return pageTotal;
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

            if (commandCell.ColumnInfo.Name == DeleteColumnName)
            {
                MessageBoxDisplayService.ShowConfirmationDialog("¿Esta seguro que desea eliminar este pedído?", "Eliminar Pedído",
                    () =>
                    {
                        using (var service = _serviceFactory.Create<IOrderService>())
                        {
                            service.Delete(order.Id);

                            LoadOrders();
                        }
                    });
            }
        }

        private void gvOrders_CellFormatting(object sender, CellFormattingEventArgs e)
        {
            var order = e.Row.DataBoundItem as OrderDto;

            if (order != null)
            {
                if (e.CellElement.ColumnInfo.Name == DeleteColumnName)
                {
                    e.CellElement.Enabled = order.OrderStatusId == OrderStatus.PENDING;
                }
            }
        }

        private void gvOrders_SortChanged(object sender, GridViewCollectionChangedEventArgs e)
        {

        }

        private void gvOrders_FilterChanged(object sender, GridViewCollectionChangedEventArgs e)
        {

        }

        private void ucOrdersFilters_FiltersChanged(object sender, EventArgs e)
        {
            LoadOrders();
        }
    }
}
