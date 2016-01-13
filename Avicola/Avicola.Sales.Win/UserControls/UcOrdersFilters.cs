using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Avicola.Sales.Entities;
using Avicola.Sales.Services.Dtos;

namespace Avicola.Sales.Win.UserControls
{
    public partial class UcOrdersFilters : UserControl
    {
        private bool _clearingFilters;

        public UcOrdersFilters()
        {
            InitializeComponent();
        }

        public event EventHandler FiltersChanged;

        public string Client
        {
            get { return txtClient.Text; }
        }

        public Guid? OrderStatusId
        {
            get { return ucOrderStatusSelection.SelectedOrderStatus != null ? ucOrderStatusSelection.SelectedOrderStatus.Id : (Guid?)null; }
        }

        public Guid? DriverId
        {
            get { return ucDriverSelection.SelectedDriver != null ? ucDriverSelection.SelectedDriver.Id : (Guid?)null; }
        }

        public Guid? TruckId
        {
            get { return ucTruckSelection.SelectedTruck != null ? ucTruckSelection.SelectedTruck.Id : (Guid?)null; }
        }

        public DateTime? From
        {
            get { return dtpFromDate.NullableValue; }
        }

        public DateTime? To
        {
            get { return dtpToDate.NullableValue; }
        }

        public IList<OrderStatus> OrderStatus
        {
            set { ucOrderStatusSelection.OrderStatus = value; }
        }

        public IList<Truck> Trucks
        {
            set { ucTruckSelection.Trucks = value; }
        }

        public IList<Driver> Drivers
        {
            set { ucDriverSelection.Drivers = value; }
        }

        protected void OnFiltersChanged()
        {
            if (FiltersChanged != null)
            {
                FiltersChanged(this, new EventArgs());
            }
        }

        private void txtClient_TextChanged(object sender, EventArgs e)
        {
            if (_clearingFilters) return;

            OnFiltersChanged();
        }

        private void dtpFromDate_ValueChanged(object sender, EventArgs e)
        {
            if (_clearingFilters) return;

            OnFiltersChanged();
        }

        private void dtpToDate_ValueChanged(object sender, EventArgs e)
        {
            if (_clearingFilters) return;

            OnFiltersChanged();
        }

        private void ucOrderStatusSelection_OrderStatusSelected(object sender, OrderStatus e)
        {
            if (_clearingFilters) return;

            OnFiltersChanged();
        }

        private void ucDriverSelection_DriverSelected(object sender, Driver e)
        {
            if (_clearingFilters) return;

            OnFiltersChanged();
        }
        private void ucTruckSelection_TruckSelected(object sender, Truck e)
        {
            if (_clearingFilters) return;

            OnFiltersChanged();
        }

        private void btnClearFilters_Click(object sender, EventArgs e)
        {
            _clearingFilters = true;

            txtClient.Text = string.Empty;
            ucOrderStatusSelection.SelectedOrderStatus = null;

            dtpFromDate.NullableValue = null;
            dtpToDate.NullableValue = null;

            ucDriverSelection.SelectedDriver = null;
            ucTruckSelection.SelectedTruck = null;

            _clearingFilters = false;

            OnFiltersChanged();
        }
    }
}
