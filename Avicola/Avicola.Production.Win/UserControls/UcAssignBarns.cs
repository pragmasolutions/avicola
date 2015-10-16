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

        private void btnAddBarn_Click(object sender, EventArgs e)
        {
            using (var form = FormFactory.Create<FrmBarnSelection>())
            {
                form.StageId = StageId;
                form.ExcludedBarns = BarnsAssignedControls.Select(x => x.BarnAssigned.BarnId).ToList();
                form.BarnSelected += FormOnBarnSelected;
                form.ShowDialog();
            }
        }

        private void FormOnBarnSelected(object sender, Barn barn)
        {
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

            ucBarnAssigned.Dock = DockStyle.Top;

            BarnsAssignedControls.Add(ucBarnAssigned);
            BarnsContainer.Controls.Add(ucBarnAssigned);
        }

        private void UcBarnAssignedOnBarnRemoved(object sender, UcBarnAssigned ucBarnAssigned)
        {
            BarnsAssignedControls.Remove(ucBarnAssigned);
            BarnsContainer.Controls.Remove(ucBarnAssigned);
        }
    }
}
