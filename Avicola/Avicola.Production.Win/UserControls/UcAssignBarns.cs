using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Avicola.Office.Entities;
using Avicola.Production.Win.Forms.Barns;
using Avicola.Production.Win.Forms.Batchs;

namespace Avicola.Production.Win.UserControls
{
    public partial class UcAssignBarns : UcBase
    {
        public UcAssignBarns()
        {
            InitializeComponent();
        }

        private void UcAssignBarns_Load(object sender, EventArgs e)
        {
            BarnsAssignedControls = new List<UcBarnAssigned>();
        }

        public Guid StageId { get; set; }

        public decimal CurrentBatchBirds { get; set; }

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)] 
        public IList<UcBarnAssigned> BarnsAssignedControls { get; set; }

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)] 
        public IList<BarnAssigned> BarnsAssigned
        {
            get { return BarnsAssignedControls.Select(x => x.BarnAssigned).ToList(); }
        }

        public decimal BirdsAmountDecimal
        {
            get { return BarnsAssigned.Select(x => x.BirdsAmount).DefaultIfEmpty(0).Sum(); }
        }

        public decimal RemainBirdsAmount
        {
            get { return CurrentBatchBirds - BirdsAmountDecimal; }
        }

        public bool ValidateControl()
        {
            bool isValid = true;

            foreach (var ucBarnAssigned in BarnsAssignedControls)
            {
                if (!ucBarnAssigned.ValidateControl())
                {
                    isValid = false;
                }
            }

            return isValid;
        }

        private void btnAddBarn_Click(object sender, EventArgs e)
        {
            using (var form = FormFactory.Create<FrmBarnSelection>())
            {
                form.StageId = StageId;
                form.ExcludedBarns = BarnsAssignedControls.Select(x => x.BarnAssigned.BarnId).ToList();
                form.BarnSelected += FormOnBarnSelected;
                form.ShowDialog();
                BarnsControl();
            }
        }

        private void FormOnBarnSelected(object sender, Barn barn)
        {
            if (RemainBirdsAmount <= 0)
            {
                MessageBoxDisplayService.ShowError("Ya se han asignado el total de aves del lote a los galpones");
                return;
            }

            var ucBarnAssigned = new UcBarnAssigned();

            ucBarnAssigned.MessageBoxDisplayService = this.MessageBoxDisplayService;
            ucBarnAssigned.FormFactory = this.FormFactory;
            ucBarnAssigned.BarnRemoved += UcBarnAssignedOnBarnRemoved;
            
            ucBarnAssigned.BarnAssigned = new BarnAssigned()
                                          {
                                              BarnId = barn.Id,
                                              BarnCapacity = barn.Capacity ?? 0,
                                              BarnName = barn.Name,
                                              BirdsAmount = (int) (RemainBirdsAmount > barn.Capacity ? barn.Capacity.GetValueOrDefault() : RemainBirdsAmount)
                                          };

            BarnsAssignedControls.Add(ucBarnAssigned);
            BarnsContainer.Controls.Add(ucBarnAssigned);
        }

        private void UcBarnAssignedOnBarnRemoved(object sender, UcBarnAssigned ucBarnAssigned)
        {
            BarnsAssignedControls.Remove(ucBarnAssigned);
            BarnsContainer.Controls.Remove(ucBarnAssigned);
            BarnsControl();
        }

        public void ClearAsignations()
        {
            BarnsAssignedControls.Clear();
            BarnsContainer.Controls.Clear();
            BarnsControl();
        }

        public void BarnsControl()
        {
            var stageCria = new Guid("096DEBD6-C537-4569-8B97-53A3C3E82A39");
            if (StageId == stageCria)
            {
                btnAddBarn.Enabled = BarnsAssignedControls.Count == 0;
            }
        }
    }
}
