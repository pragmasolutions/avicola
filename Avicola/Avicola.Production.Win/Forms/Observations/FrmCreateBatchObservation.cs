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
using Avicola.Production.Win.Models.BatchObservations;

namespace Avicola.Production.Win.Forms.Observations
{
    public partial class FrmCreateBatchObservation : EditFormBase
    {
        private readonly IServiceFactory _serviceFactory;
        private Guid _batchId = Guid.Empty;

        public FrmCreateBatchObservation(IServiceFactory serviceFactory, Guid batchId)
        {
            _serviceFactory = serviceFactory;
            _batchId = batchId;
            InitializeComponent();
        }

        private void FrmCreateBatchObservation_Load(object sender, EventArgs e)
        {
            using (var geneticLineService = _serviceFactory.Create<IGeneticLineService>())
            {
                var geneticLine = geneticLineService.GetAll().OrderBy(x => x.Name).ToList();
                
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
                var batchObservationModel = GetBatchObservation();
                var batchObservation = batchObservationModel.ToBatchObservation();
                
                using (var service = _serviceFactory.Create<IBatchObservationService>())
                {
                    service.Create(batchObservation);
                }

                OnBatchObservationCreated(batchObservation);
                this.Close();
            }
        }

        private CreateBatchObservationModel GetBatchObservation()
        {
            var batch = new CreateBatchObservationModel
            {
                Content = txtObservation.Text,
                ObservationDate = dtpObservationDate.Value,
                BatchId = _batchId
            };
            
            return batch;
        }

        protected override void ValidateControls()
        {
            
            this.ValidateControl(dtpObservationDate, "ObservationDate");
            this.ValidateControl(txtObservation, "Content");
        }

        protected override object GetEntity()
        {
            return GetBatchObservation();
        }

        public event EventHandler<BatchObservation> BatchObservationCreated;
        private void OnBatchObservationCreated(BatchObservation batchObservation)
        {
            if (BatchObservationCreated != null)
            {
                BatchObservationCreated(this, batchObservation);
            }
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
