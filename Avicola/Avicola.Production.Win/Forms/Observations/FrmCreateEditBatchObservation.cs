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
using Avicola.Production.Win.Infrastructure;

namespace Avicola.Production.Win.Forms.Observations
{
    public partial class FrmCreateEditBatchObservation : EditFormBase
    {
        private readonly IStateController _stateController;
        private readonly IServiceFactory _serviceFactory;
        private Guid _observationId = Guid.Empty;
        private Batch _batch;
        private BatchObservation _batchObservation;

        public FrmCreateEditBatchObservation(Guid id, IFormFactory formFactory, IStateController stateController, IServiceFactory serviceFactory)
        {
            FormFactory = formFactory;
            _serviceFactory = serviceFactory;
            _stateController = stateController;
            _observationId = id;
            InitializeComponent();
        }

        private void FrmCreateBatchObservation_Load(object sender, EventArgs e)
        {
            using (var batchService = _serviceFactory.Create<IBatchService>())
            {
                _batch = batchService.GetById(_stateController.CurrentSelectedBatch.Id);
                txtWeek.Text = _batch.CurrentWeek.ToString();
                //Falta CuurentDay
                txtDay.Text = _batch.CurrentWeek.ToString();
                dtpObservationDate.Value = DateTime.Now;
            }

            if (_observationId != Guid.Empty)
            {
                using (var batchObservationService = _serviceFactory.Create<IBatchObservationService>())
                {
                    _batchObservation = batchObservationService.GetById(_observationId);
                    //txtWeek.Text = _batchObservation.CurrentWeek.ToString();
                    //txtDay.Text = _batchObservation.CurrentWeek.ToString();
                    txtObservation.Text = _batchObservation.Content;
                    dtpObservationDate.Value = _batchObservation.ObservationDate;
                }
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
                if (_observationId == Guid.Empty)
                {
                    var batchObservationModel = GetBatchObservationCreate();
                    var batchObservation = batchObservationModel.ToBatchObservation();

                    using (var service = _serviceFactory.Create<IBatchObservationService>())
                    {
                        service.Create(batchObservation);
                    }

                    OnBatchObservationCreated(batchObservation);
                }
                else
                {
                    GetBatchObservationEdit();
                    using (var service = _serviceFactory.Create<IBatchObservationService>())
                    {
                        service.Edit(_batchObservation);
                    }

                    OnBatchObservationCreated(_batchObservation);
                }

                this.Close();
            }
        }

        private void GetBatchObservationEdit()
        {
            _batchObservation.ObservationDate = dtpObservationDate.Value;
            _batchObservation.Content = txtObservation.Text;
        }

        private CreateBatchObservationModel GetBatchObservationCreate()
        {
            var batchObservation = new CreateBatchObservationModel
            {
                Id = new Guid(),
                Content = txtObservation.Text,
                CreatedDate = DateTime.Now,
                ObservationDate = dtpObservationDate.Value,
                IsDelete = false,
                BatchId = _stateController.CurrentSelectedBatch.Id
            };

            return batchObservation;
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
            return GetBatchObservationCreate();
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
