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
        private Batch _batch;

        public FrmCreateBatchObservation(Guid Id, IFormFactory formFactory, IServiceFactory serviceFactory)
        {
            FormFactory = formFactory;
            _serviceFactory = serviceFactory;
            _batchId = Id;
            InitializeComponent();
        }

        private void FrmCreateBatchObservation_Load(object sender, EventArgs e)
        {
            using (var batchService = _serviceFactory.Create<IBatchService>())
            {
                var _batch = batchService.GetById(_batchId);
                txtWeek.Text = _batch.CurrentWeek.ToString();
                txtDay.Text = _batch.CurrentWeek.ToString();
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
            if (_batch.DateOfBirth > dtpObservationDate.Value || _batch.EndDate < dtpObservationDate.Value)
            {
                this.FormErrorProvider.SetError(dtpObservationDate, "La fecha de Observación tiene que estar comprendida en la fecha de nacimiento y la fecha de fin.");
            }
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
