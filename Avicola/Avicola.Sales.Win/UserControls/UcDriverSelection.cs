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
    public partial class UcDriverSelection : UserControl
    {
        public UcDriverSelection()
        {
            InitializeComponent();
        }

        public EventHandler<Driver> DriverSelected;

        public IList<Driver> Drivers
        {
            set
            {
                ddlDrivers.ValueMember = "Id";
                ddlDrivers.DisplayMember = "Name";
                ddlDrivers.DataSource = value;
            }
        }

        public Driver SelectedDriver
        {
            get { return ddlDrivers.SelectedItem != null ? ddlDrivers.SelectedItem.DataBoundItem as Driver : null; }
        }

        protected void OnDriverSelected(Driver item)
        {
            if (DriverSelected != null)
            {
                DriverSelected(this, item);
            }
        }

        private void ddlDrivers_SelectedIndexChanged(object sender, Telerik.WinControls.UI.Data.PositionChangedEventArgs e)
        {
            OnDriverSelected(SelectedDriver);
        }
    }
}
