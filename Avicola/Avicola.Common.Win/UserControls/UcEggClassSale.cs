using System;
using System.Windows.Forms;
using Framework.Common.Win.Controls;

namespace Avicola.Common.Win.UserControls
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
