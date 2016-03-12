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
    public partial class UcEggClassOrder : UserControl
    {
        public UcEggClassOrder()
        {
            InitializeComponent();
        }

        public string EggClassName { get; set; }

        private int? _amount;
        public int Amount
        {
            get
            {
                return _amount ?? 0;
            }
            set
            {
                _amount = value;
            }
        }

        private int? _currentStock;
        public int CurrentStock
        {
            get
            {
                return _currentStock ?? 0;
            }
            set
            {
                _currentStock = value;
                var difference = _currentStock - Amount * 12;
                difference = difference*-1;
                string formattedDifference = _currentStock%12 == 0
                    ? (difference/12).ToString()
                    : (Convert.ToDecimal(difference)/12).ToString("N2");
                lblMissingStock.Text = difference > 0
                                        ? String.Format("({0})", formattedDifference)
                                        : string.Empty;
            }
        }

        public bool ShowDifference { get; set; }

        private void UcEggClassStock_Load(object sender, EventArgs e)
        {
            lblName.Text = EggClassName;
            lblAmount.Text = String.Format("{0}", _amount);

            var timer = new Timer {Interval = 100};
            timer.Tick += TimerOnTick;
            timer.Start();
        }

        private void TimerOnTick(object sender, EventArgs eventArgs)
        {
            (sender as Timer).Stop();
            lblAmount.Location = new Point(lblName.Location.X + lblName.Width + 5, lblAmount.Location.Y);
            lblMissingStock.Location = new Point(lblAmount.Location.X + lblAmount.Width + 5, lblAmount.Location.Y);

            if (string.IsNullOrEmpty(lblMissingStock.Text))
            {
                lblAmount.ForeColor = Color.Green;
                this.Width = lblAmount.Location.X + lblAmount.Width + 10;
            }
            else
            {
                this.Width = lblMissingStock.Location.X + lblMissingStock.Width + 15;
            }

            lblMissingStock.Visible = ShowDifference;
        }
    }
}
