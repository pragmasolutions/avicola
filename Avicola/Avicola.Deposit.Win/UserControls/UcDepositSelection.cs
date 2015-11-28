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

namespace Avicola.Deposit.Win.UserControls
{
    public partial class UcDepositSelection : UserControl
    {
        public UcDepositSelection()
        {
            InitializeComponent();
        }

        public EventHandler<Sales.Entities.Deposit> DepositSelected;

        public IList<Sales.Entities.Deposit> Deposits
        {
            set
            {
                Sales.Entities.Deposit item = new Sales.Entities.Deposit();
                item.Name = "Seleccione un depósito..";
                item.Id = Guid.Empty;
                value.Insert(0, item);

                ddlDeposits.ValueMember = "Id";
                ddlDeposits.DisplayMember = "Name";
                ddlDeposits.DataSource = value;
            }
        }

        public Sales.Entities.Deposit SelectedDeposit
        {
            get { return ddlDeposits.SelectedItem != null ? ddlDeposits.SelectedItem.DataBoundItem as Sales.Entities.Deposit : null; }
        }

        protected void OnDepositSelected(Sales.Entities.Deposit item)
        {
            if (DepositSelected != null)
            {
                DepositSelected(this, item);
            }
        }

        private void ddlDeposits_SelectedIndexChanged(object sender, Telerik.WinControls.UI.Data.PositionChangedEventArgs e)
        {
            OnDepositSelected(SelectedDeposit);
        }

        public bool ValidateControl()
        {
           return this.SelectedDeposit.Id != Guid.Empty;
        }

        public void Reset()
        {
            ddlDeposits.SelectedIndex = 0;
        }
    }
}
