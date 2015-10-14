using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Avicola.Common.Win;
using Avicola.Office.Services.Dtos;
using Avicola.Office.Services.Interfaces;
using Framework.Data.Helpers;
using Telerik.WinControls;
using System.Linq;
using Avicola.Office.Entities;
using Avicola.Production.Win.Models.Batchs;

namespace Avicola.Production.Win.Forms.Barns
{
    public partial class FrmBarnSelection : FrmBase
    {
        private readonly IServiceFactory _serviceFactory;

        public FrmBarnSelection(IServiceFactory serviceFactory)
        {
            _serviceFactory = serviceFactory;
            
            InitializeComponent();

            ExcludedBarns = new List<Guid>();
            StageId = Stage.BREEDING;
        }

        public Guid StageId { get; set; }

        public IList<Guid> ExcludedBarns { get; set; }

        private void FrmAssignBarn_Load(object sender, EventArgs e)
        {
            using (var service = _serviceFactory.Create<IBarnService>())
            {
                var barns = service.GetAllByStage(StageId)
                    .TakeWhile(x => !ExcludedBarns.Any(y => x.Id == y))
                    .ToList();

                ddlBarns.ValueMember = "Id";
                ddlBarns.DisplayMember = "Name";
                ddlBarns.DataSource = barns;
            }
        }

        
        private void BtnSelect_Click(object sender, EventArgs e)
        {
            if (ddlBarns.SelectedItem != null)
            {
                var selectedBarn = ddlBarns.SelectedItem.DataBoundItem as Barn;
                if (selectedBarn != null)
                {
                    OnBarnSelected(selectedBarn);
                }
            }
        }

        public event EventHandler<Barn> BarnSelected;
        private void OnBarnSelected(Barn e)
        {
            if (BarnSelected != null)
            {
                BarnSelected(this, e);
            }
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
