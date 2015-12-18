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

namespace Avicola.Deposit.Dashboard.UserControls
{
    public partial class UcEggClassStock : UserControl
    {
        public UcEggClassStock()
        {
            InitializeComponent();
        }

        public string EggClassName
        {
            get { return lblName.Text; }
            set { lblName.Text = value; }
        }

        private int? _stock;
        public int Stock
        {
            get
            {
                return _stock ?? 0;
            }
            set
            {
                _stock = value;
                lblStock.Text = String.Format("[{0}]", _stock);
            }
        }

        private void UcEggClassStock_Load(object sender, EventArgs e)
        {
            lblStock.Location = new Point(lblName.Location.X + lblName.Width + 10, lblStock.Location.Y);
        }
    }
}
