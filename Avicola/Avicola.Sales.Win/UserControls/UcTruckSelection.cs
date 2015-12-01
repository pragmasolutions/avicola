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
    public partial class UcTruckSelection : UserControl
    {
        public UcTruckSelection()
        {
            InitializeComponent();
        }

        public EventHandler<Truck> TruckSelected;

        public IList<Truck> Trucks
        {
            set
            {
                ddlTrucks.ValueMember = "Id";
                ddlTrucks.DisplayMember = "Name";
                ddlTrucks.DataSource = value;
            }
        }

        public Truck SelectedTruck
        {
            get { return ddlTrucks.SelectedItem != null ? ddlTrucks.SelectedItem.DataBoundItem as Truck : null; }
        }

        protected void OnTruckSelected(Truck item)
        {
            if (TruckSelected != null)
            {
                TruckSelected(this, item);
            }
        }

        private void ddlTrucks_SelectedIndexChanged(object sender, Telerik.WinControls.UI.Data.PositionChangedEventArgs e)
        {
            OnTruckSelected(SelectedTruck);
        }
    }
}
