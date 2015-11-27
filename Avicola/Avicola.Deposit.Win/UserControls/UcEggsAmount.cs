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

namespace Avicola.Deposit.Win.UserControls
{
    public partial class UcEggsAmount : UserControl
    {
        public UcEggsAmount()
        {
            InitializeComponent();
        }

        public int Boxes
        {
            get { return (int)(txtBoxes.NullableValue ?? 0); }
        }

        public int Mapples
        {
            get { return (int)(txtMapples.NullableValue ?? 0); }
        }

        public int Eggs
        {
            get { return (int)(txtEggsUnits.NullableValue ?? 0); }
        }

        public int TotalEggs
        {
            get
            {
                var boxesEggs = Boxes * DepositStock.EggsPerBox;
                var mapplesEggs = Mapples * DepositStock.EggsPerMapple;
                var eggs = Eggs;

                return boxesEggs + mapplesEggs + eggs;
            }
        }

        public decimal TotalDozens
        {
            get { return TotalEggs / 12M; }
        }

        private void txtBoxes_ValueChanged(object sender, EventArgs e)
        {
            UpdateTotals();
        }

        private void txtMapples_ValueChanged(object sender, EventArgs e)
        {
            UpdateTotals();
        }

        private void txtEggsUnits_ValueChanged(object sender, EventArgs e)
        {
            UpdateTotals();
        }

        private void UpdateTotals()
        {
            txtTotalEggs.Text = TotalEggs.ToString();
            txtTotalDozens.Text = TotalDozens.ToString("n2");
        }

        public void ResetControls()
        {
            txtBoxes.NullableValue = null;
            txtMapples.NullableValue = null;
            txtEggsUnits.NullableValue = null;
            txtTotalDozens.Text = null;
            txtTotalEggs.Text = null;
        }

        public bool IsValid()
        {
            return (this.TotalEggs != 0);
        }
    }
}
