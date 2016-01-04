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

        public string EggClassName { get; set; }

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
            }
        }

        private void UcEggClassStock_Load(object sender, EventArgs e)
        {
            int result;
            var dozens = Convert.ToDecimal(_stock) / 12;
            lblStock.Text = int.TryParse(dozens.ToString(), out result)
                    ? String.Format("[{0}]", dozens)
                    : String.Format("[{0}]", dozens.ToString("N2"));
            lblName.Text = EggClassName;

            var timer = new Timer { Interval = 100 };
            timer.Tick += TimerOnTick;
            timer.Start();
        }

        private void TimerOnTick(object sender, EventArgs eventArgs)
        {
            lblStock.Location = new Point(lblName.Location.X + lblName.Width + 10, lblStock.Location.Y);
            (sender as Timer).Stop();
        }
    }
}
