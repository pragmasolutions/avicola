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
    public partial class UcClassificationEggClassEditor : UserControl
    {
        private EggClass _eggClass;
        private ClassificationEggClass _classificationEggClass;

        public UcClassificationEggClassEditor()
        {
            InitializeComponent();

            txtAmount.Maximum = int.MaxValue;
        }

        public int Amount
        {
            get { return (int)(txtAmount.NullableValue ?? 0); }
            set { txtAmount.NullableValue = value; }
        }

        public int EggAmount
        {
            get
            {
                if (SelectedEggEquivalence == null || !SelectedEggEquivalence.EggsAmount.HasValue)
                {
                    return 0;
                }

                return SelectedEggEquivalence.EggsAmount.Value * Amount;
            }
        }

        public EggClass EggClass
        {
            get
            {
                return _eggClass;
            }
            set
            {
                _eggClass = value;
                lbClassName.Text = value.Name;
            }
        }

        public ClassificationEggClass ClassificationEggClass
        {
            get
            {
                if (_classificationEggClass == null)
                {
                    _classificationEggClass = new ClassificationEggClass();
                }

                _classificationEggClass.Amount = Amount;
                _classificationEggClass.EggEquivalenceId = SelectedEggEquivalence.Id;
                _classificationEggClass.EggClassId = EggClass.Id;

                return _classificationEggClass;
            }
            set
            {
                Amount = value.Amount;

                ddlEggEquivalences.SelectedValue = value.EggEquivalenceId;

                _classificationEggClass = value;
            }
        }

        public IList<EggEquivalence> EggEquivalences
        {
            set
            {
                ddlEggEquivalences.ValueMember = "Id";
                ddlEggEquivalences.DisplayMember = "Name";
                ddlEggEquivalences.DataSource = value;
            }
        }

        public EggEquivalence SelectedEggEquivalence
        {
            get { return ddlEggEquivalences.SelectedItem != null ? ddlEggEquivalences.SelectedItem.DataBoundItem as EggEquivalence : null; }
        }
    }
}
