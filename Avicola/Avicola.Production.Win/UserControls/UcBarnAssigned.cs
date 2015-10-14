using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Avicola.Production.Win.UserControls
{
    public partial class UcBarnAssigned : UcBase
    {
        private BarnAssigned _barnAssigned;

        public UcBarnAssigned()
        {
            InitializeComponent();
        }

        public event EventHandler<UcBarnAssigned> BarnRemoved;

        public BarnAssigned BarnAssigned
        {
            get
            {
                int birdsAmount;
                _barnAssigned.BirdsAmount = int.TryParse(txtBirdsAmount.Text, out birdsAmount) ? birdsAmount : 0;

                return _barnAssigned;
            }
            set
            {
                _barnAssigned = value;

                txtBarnCapacity.Text = _barnAssigned.BarnCapacity.ToString();
                txtBirdsAmount.Text = _barnAssigned.BirdsAmount.ToString();
                lbBarnName.Text = _barnAssigned.BarnName;
            }
        }

        private void btnRemoveBarn_Click(object sender, EventArgs e)
        {
            MessageBoxDisplayService.ShowConfirmationDialog("Esta seguro que desea remover el galpón?", "Remover Galpon", OnBarnRemoved);
        }

        private void OnBarnRemoved()
        {
            if (BarnRemoved != null)
            {
                BarnRemoved(this, this);
            }
        }
    }

    public class BarnAssigned
    {
        public Guid BarnId { get; set; }
        public int BarnCapacity { get; set; }
        public string BarnName { get; set; }
        public int BirdsAmount { get; set; }
    }
}
