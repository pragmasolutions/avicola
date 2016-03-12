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
using Framework.Common.Win.Controls;

namespace Avicola.Sales.Win.UserControls
{
    public partial class UcEggClassSale : UserControl
    {
        public UcEggClassSale()
        {
            InitializeComponent();
        }

        public int Dozens
        {
            get { return (int)(txtDozens.NullableValue ?? 0); }
            set { txtDozens.NullableValue = value; }
        }

        public string Name
        {
            get { return lblName.Text; }
            set { lblName.Text = value; }
        }

        public Guid EggClassId { get; set; }

        public CustomSpinEditor TextBox
        {
            get
            {
                return txtDozens;
            }
        }
    }
}
