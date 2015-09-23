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
using Framework.Common.Helpers;
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
            var formTitle = "";

            using (var batchService = _serviceFactory.Create<IBatchService>())
            {
                _batch = batchService.GetById(_stateController.CurrentSelectedBatch.Id);
                SetWeekAndDay(_batch.DateOfBirth,DateTime.Now);
                dtpObservationDate.Value = DateTime.Now;
                formTitle = string.Format("Lote {0} - Crear Observación", _batch.Number.ToString());
            }

            if (_observationId != Guid.Empty)
            {
                using (var batchObservationService = _serviceFactory.Create<IBatchObservationService>())
                {
                    _batchObservation = batchObservationService.GetById(_observationId);
                    SetWeekAndDay(_batch.DateOfBirth, _batchObservation.ObservationDate);
                    txtObservation.Text = _batchObservation.Content;
                    dtpObservationDate.Value = _batchObservation.ObservationDate;
                    formTitle = string.Format("Lote {0} - Editar Observación", _batch.Number.ToString());
                }
            }

            this.Text = formTitle;
            txtDay.Enabled = false;
            txtWeek.Enabled = false;
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            var esValido = this.ValidarForm();
            if (FormErrorProvider.GetError(dtpObservationDate) != "")
                esValido = false;

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

        private void SetWeekAndDay(DateTime dateFrom, DateTime dateTo)
        {
            var weekDays = DateHelper.DateDiffInWeek(dateFrom, dateTo);
            txtWeek.Text = weekDays.Weeks.ToString();
            txtDay.Text = weekDays.Days.ToString(); ;
        }

        private void dtpObservationDate_ValueChanged(object sender, EventArgs e)
        {
            SetWeekAndDay(_batch.DateOfBirth, dtpObservationDate.Value);
        }

    }
}
