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

namespace Avicola.Production.Win.Forms.Observations
{
    public partial class FrmObservationList : EditFormBase
    {
        private readonly IServiceFactory _serviceFactory;
        private Guid _batchId;

        public FrmObservationList(IFormFactory formFactory, IServiceFactory serviceFactory, Guid batchId)
        {
            FormFactory = formFactory;
            _serviceFactory = serviceFactory;
            _batchId = batchId;
            InitializeComponent();
        }

        private void FrmObservationList_Load(object sender, EventArgs e)
        {
            using (var batchObservationService = _serviceFactory.Create<IBatchObservationService>())
            {
                var geneticLine = batchObservationService.GetAll().Where(b => b.BatchId == _batchId).OrderBy(x => x.CreatedDate).ToList();
                
            }
        }

        private int GetNextNumber()
        {
            using (var service = _serviceFactory.Create<IBatchService>())
            {
                return service.GetNextNumber();
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
                var batchModel = GetBatch();
                var batch = batchModel.ToBatch();
                batch.Number = GetNextNumber();

                using (var service = _serviceFactory.Create<IBatchService>())
                {
                    service.Create(batch);
                }

                OnBatchCreated(batch);
                this.Close();
            }
        }

        private CreateBatchModel GetBatch()
        {
            var batch = new CreateBatchModel
            {
                InitialBirds = string.IsNullOrEmpty(txtInitialBirds.Text) 
                                    ? (int?)null
                                    : Convert.ToInt32(txtInitialBirds.Text),
                DateOfBirth = dtpDateOfBirth.Value,
                StartingFood = string.IsNullOrEmpty(txtInitialFood.Text)
                                    ? (decimal?)null
                                    : Convert.ToDecimal(txtInitialFood.Text),
                FoodClassId = ddlFoodClass.SelectedValue == null
                                ? (Guid?)null
                                : Guid.Parse(ddlFoodClass.SelectedValue.ToString()),
                GeneticLineId = ddlGeneticLine.SelectedValue == null
                                ? (Guid?)null
                                : Guid.Parse(ddlGeneticLine.SelectedValue.ToString())
            };
            
            return batch;
        }

        protected override void ValidateControls()
        {
            this.ValidateControl(txtInitialBirds, "InitialBirds");
            this.ValidateControl(txtInitialFood, "StartingFood");
            this.ValidateControl(ddlFoodClass, "FoodClassId");
            this.ValidateControl(ddlGeneticLine, "GeneticLineId");
            this.ValidateControl(dtpDateOfBirth, "DateOfBirth");
        }

        protected override object GetEntity()
        {
            return GetBatch();
        }

        public event EventHandler<Batch> BatchCreated;
        private void OnBatchCreated(Batch batch)
        {
            if (BatchCreated != null)
            {
                BatchCreated(this, batch);
            }
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
