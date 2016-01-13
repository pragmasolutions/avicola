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

        public event EventHandler<Truck> TruckSelected;

        public IList<Truck> Trucks
        {
            set
            {
                ddlTrucks.ValueMember = "Id";
                ddlTrucks.DisplayMember = "Name";

                value.Insert(0, new Truck() { Description = "SELECCIONE CAMIÓN", Id = Guid.Empty });

                ddlTrucks.DataSource = value;
            }
        }

        public Truck SelectedTruck
        {
            get
            {
                if (ddlTrucks.SelectedItem == null)
                {
                    return null;
                }

                var driver = ddlTrucks.SelectedItem.DataBoundItem as Truck;
                return driver != null && driver.Id != Guid.Empty ? driver : null;
            }
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
