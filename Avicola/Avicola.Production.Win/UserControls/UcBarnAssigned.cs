using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Avicola.Production.Win.Properties;
using Castle.Core.Internal;

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
                _barnAssigned.BirdsAmount = (int)txtBirdsAmount.Value;
                _barnAssigned.InitialFood = (int)txtInitialFood.Value;

                return _barnAssigned;
            }
            set
            {
                _barnAssigned = value;

                txtBarnCapacity.Text = _barnAssigned.BarnCapacity.ToString();
                txtBirdsAmount.Text = _barnAssigned.BirdsAmount.ToString();
                txtBirdsAmount.Maximum = _barnAssigned.BarnCapacity;
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

        public bool ValidateControl()
        {
            this.ErrorProvider.Clear();

            if (txtBirdsAmount.Text.IsNullOrEmpty())
            {
                this.ErrorProvider.SetError(txtBirdsAmount, string.Format(Resources.RequiredField, lbBirdsAmount.Text));
                return false;
            }

            if (txtInitialFood.Text.IsNullOrEmpty())
            {
                this.ErrorProvider.SetError(txtInitialFood, string.Format(Resources.RequiredField, lbInitialFood.Text));
                return false;
            }

            if (txtBirdsAmount.Value < 1)
            {
                this.ErrorProvider.SetError(txtBirdsAmount, string.Format(Resources.GreatherThan, lbBirdsAmount.Text, 0));
                return false;
            }

            return true;
        }
    }

    public class BarnAssigned
    {
        public Guid BarnId { get; set; }
        public int BarnCapacity { get; set; }
        public string BarnName { get; set; }

        [Required]
        [Range(1, int.MaxValue)]
        public int BirdsAmount { get; set; }

        [Required]
        [Range(0, int.MaxValue)]
        public int InitialFood { get; set; }
    }
}
