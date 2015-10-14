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

namespace Avicola.Production.Win.Forms.Batchs
{
    public partial class FrmAssignBarn : EditFormBase
    {
        private readonly IServiceFactory _serviceFactory;
        private Guid _batchId;

        public FrmAssignBarn(Guid id, IFormFactory formFactory, IServiceFactory serviceFactory)
        {
            FormFactory = formFactory;
            _serviceFactory = serviceFactory;
            _batchId = id;
            InitializeComponent();
        }

        private void FrmAssignBarn_Load(object sender, EventArgs e)
        {
            using (var service = _serviceFactory.Create<IBatchService>())
            {
                var batch = service.GetById(_batchId);
                //dtpArrivedToBarn.Value = batch.CalculatedPostureStartDate; //TODO: ARREGLAR

                dtpArrivedToBarn.MinDate = batch.DateOfBirth.AddDays(1);
                dtpArrivedToBarn.MaxDate = batch.DateOfBirth.AddDays((batch.GeneticLine.ProductionWeeks * 7) - 1);
            }

            using (var barnService = _serviceFactory.Create<IBarnService>())
            {
                var barns = barnService.GetAllAvailable().OrderBy(x => x.Name).ToList();
                ddlBarns.ValueMember = "Id";
                ddlBarns.DisplayMember = "Name";
                ddlBarns.DataSource = barns;
            }
        }

        
        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            var esValido = this.ValidarForm();

            if (!esValido)
            {
                this.DialogResult = DialogResult.None;
            }
            else
            {
                var dc = RadMessageBox.Show(this, "Está seguro que desea continuar? Esta operación no se puede deshacer", "Confirmación", MessageBoxButtons.YesNo, RadMessageIcon.Question);
                if (dc.ToString() == "Yes")
                {
                    var model = GetModel();
                    using (var service = _serviceFactory.Create<IBarnService>())
                    {
                        var barn = service.GetById(model.BarnId.GetValueOrDefault());
                    }
                    using (var service = _serviceFactory.Create<IBatchService>())
                    {
                        var errorMessage = service.AssignBarn(_batchId, model.BarnId.GetValueOrDefault());
                        if (!string.IsNullOrEmpty(errorMessage))
                        {
                            RadMessageBox.Show(this, String.Format("ERROR \n\n{0}", errorMessage), "Atención", MessageBoxButtons.OK, RadMessageIcon.Question);
                        }
                        else
                        {
                            //OnBarnAssigned(new BarnAssignedEventModel(barnNumber, model.ArrivedToBarn.GetValueOrDefault()));
                            this.Close();
                        }
                    }
                }
            }
        }


        public event EventHandler<BarnAssignedEventModel> BarnAssigned;
        private void OnBarnAssigned(BarnAssignedEventModel e)
        {
            if (BarnAssigned != null)
            {
                BarnAssigned(this, e);
            }
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        

        private AssignBarnModel GetModel()
        {
            var model = new AssignBarnModel
            {
                ArrivedToBarn = dtpArrivedToBarn.Value,
                BarnId = ddlBarns.SelectedValue == null
                                ? (Guid?)null
                                : Guid.Parse(ddlBarns.SelectedValue.ToString())
            };

            return model;
        }

        protected override void ValidateControls()
        {
            this.ValidateControl(dtpArrivedToBarn, "ArrivedToBarn");
            this.ValidateControl(ddlBarns, "BarnId");
        }

        protected override object GetEntity()
        {
            return GetModel();
        }
    }

    public class BarnAssignedEventModel
    {
        public int BarnNumber { get; set; }
        public DateTime ArrivedToBarn { get; set; }

        public BarnAssignedEventModel(int barnNumber, DateTime arrivedToBarn)
        {
            BarnNumber = barnNumber;
            ArrivedToBarn = arrivedToBarn;
        }
    }
}
