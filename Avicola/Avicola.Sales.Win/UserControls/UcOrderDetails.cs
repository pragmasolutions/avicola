using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Avicola.Sales.Services.Dtos;

namespace Avicola.Sales.Win.UserControls
{
    public partial class UcOrderDetails : UserControl
    {
        public UcOrderDetails()
        {
            InitializeComponent();
        }

        public OrderDto Order
        {
            set
            {
                var order = value;

                txtCreatedDate.Text = order.CreatedDate.ToString(Avicola.Common.Win.GlobalConstants.DefaultDatetimeFormatString);
                txtClient.Text = order.ClientName;
                txtStatus.Text = order.OrderStatusName;
                txtDozens.Text = order.Dozens.ToString();

                if (order.Boxes.HasValue || order.Maples.HasValue || order.Eggs.HasValue)
                {
                    gbOrderBuildDetails.Visible = true;

                    txtBoxes.Text = order.Boxes.GetValueOrDefault().ToString();
                    txtMapples.Text = order.Maples.GetValueOrDefault().ToString();
                    txtEggsUnits.Text = order.Eggs.GetValueOrDefault().ToString();
                }
                else
                {
                    gbOrderBuildDetails.Visible = false;
                }
            }
        }
    }
}
