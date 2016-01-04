using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Avicola.Common.Win;
using Avicola.Deposit.Win.Forms;
using Avicola.Sales.Entities;
using Framework.WinForm.Comun.Notification;

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

        public IFormFactory FormFactory { get; set; }

        public IMessageBoxDisplayService MessageBoxDisplayService { get; set; }

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

        private void btnCalculateEggsAmount_Click(object sender, EventArgs e)
        {
            using (var form = FormFactory.Create<FrmCalculateEggs>())
            {
                form.EggsCalculated += (o, totalEggs) =>
                {
                    if (totalEggs == 0 && txtAmount.Value != 0)
                    {
                        MessageBoxDisplayService.ShowConfirmationDialog(
                            "La cantidad calculada de huevos es 0. ¿Desea establecer esta cantidad?",
                            "Calcular Huevos", () =>
                                               {
                                                   form.Close();

                                                   SetEggsAmount(totalEggs);
                                               });

                        return;
                    }

                    form.Close();

                    SetEggsAmount(totalEggs);

                };
                form.ShowDialog();
            }
        }

        private void SetEggsAmount(int totalEggs)
        {
            txtAmount.NullableValue = totalEggs;

            ddlEggEquivalences.SelectedValue = EggEquivalence.EGGS;
        }
    }
}
