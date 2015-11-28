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
    public partial class UcSalesSelection : UserControl
    {
        public UcSalesSelection()
        {
            InitializeComponent();
        }

        public EventHandler<Sales.Entities.Deposit> DepositsSelected;

        public IList<Sales.Entities.Deposit> Deposits
        {
            set
            {
                Sales.Entities.Deposit item = new Sales.Entities.Deposit();
                item.Name = "Seleccione un depósito..";
                item.Id = Guid.Empty;
                value.Insert(0, item);

                ddlSaless.ValueMember = "Id";
                ddlSaless.DisplayMember = "Name";
                ddlSaless.DataSource = value;
            }
        }

        public Sales.Entities.Deposit SelectedSales
        {
            get { return ddlSaless.SelectedItem != null ? ddlSaless.SelectedItem.DataBoundItem as Sales.Entities.Deposit : null; }
        }

        protected void OnSalesSelected(Sales.Entities.Deposit item)
        {
            if (DepositsSelected != null)
            {
                DepositsSelected(this, item);
            }
        }

        private void ddlSaless_SelectedIndexChanged(object sender, Telerik.WinControls.UI.Data.PositionChangedEventArgs e)
        {
            OnSalesSelected(SelectedSales);
        }

        public bool ValidateControl()
        {
           return this.SelectedSales.Id != Guid.Empty;
        }

        public void Reset()
        {
            ddlSaless.SelectedIndex = 0;
        }
    }
}
