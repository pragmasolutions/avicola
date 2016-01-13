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

        public event EventHandler<Driver> DriverSelected;

        public IList<Driver> Drivers
        {
            set
            {
                ddlDrivers.ValueMember = "Id";
                ddlDrivers.DisplayMember = "Name";

                value.Insert(0, new Driver() { Name = "SELECCIONE CONDUCTOR", Id = Guid.Empty });

                ddlDrivers.DataSource = value;
            }
        }

        public Driver SelectedDriver
        {
            get
            {
                if (ddlDrivers.SelectedItem == null)
                {
                    return null;
                }

                var driver = ddlDrivers.SelectedItem.DataBoundItem as Driver;
                return driver != null && driver.Id != Guid.Empty ? driver : null;
            }
            set
            {
                ddlDrivers.SelectedValue = value != null ? value.Id : Guid.Empty;
            }
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
