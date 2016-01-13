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
    public partial class UcOrderStatusSelection : UserControl
    {
        public UcOrderStatusSelection()
        {
            InitializeComponent();
        }

        public event EventHandler<OrderStatus> OrderStatusSelected;

        public IList<OrderStatus> OrderStatus
        {
            set
            {
                ddlOrderStatus.ValueMember = "Id";
                ddlOrderStatus.DisplayMember = "Name";

                value.Insert(0, new OrderStatus() { Name = "SELECCIONE ESTADO", Id = Guid.Empty });

                ddlOrderStatus.DataSource = value;
            }
        }

        public OrderStatus SelectedOrderStatus
        {
            get
            {
                if (ddlOrderStatus.SelectedItem == null)
                {
                    return null;
                }

                var orderStatus = ddlOrderStatus.SelectedItem.DataBoundItem as OrderStatus;
                return orderStatus != null && orderStatus.Id != Guid.Empty ? orderStatus : null;
            }
            set
            {
                ddlOrderStatus.SelectedValue = value != null ? value.Id : Guid.Empty;
            }
        }

        protected void OnOrderStatusSelected(OrderStatus item)
        {
            if (OrderStatusSelected != null)
            {
                OrderStatusSelected(this, item);
            }
        }

        private void ddlOrderStatus_SelectedIndexChanged(object sender, Telerik.WinControls.UI.Data.PositionChangedEventArgs e)
        {
            OnOrderStatusSelected(SelectedOrderStatus);
        }
    }
}
