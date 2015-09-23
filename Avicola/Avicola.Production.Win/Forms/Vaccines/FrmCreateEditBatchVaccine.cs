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
namespace Avicola.Production.Win.Forms.Vaccines
{
    public partial class FrmCreateEditBatchVaccine : EditFormBase
    {
        private readonly IStateController _stateController;
        private readonly IServiceFactory _serviceFactory;
        private Guid _vaccineId = Guid.Empty;
        private Batch _batch;
        private BatchObservation _batchObservation;

        public FrmCreateEditBatchVaccine(Guid id, IFormFactory formFactory, IStateController stateController, IServiceFactory serviceFactory)
        {
            FormFactory = formFactory;
            _serviceFactory = serviceFactory;
            _stateController = stateController;
            _vaccineId = id;
            InitializeComponent();
        }

        private void FrmCreateEditVaccine_Load(object sender, EventArgs e)
        {
            var formTitle = "";

            using (var batchService = _serviceFactory.Create<IBatchService>())
            {
                _batch = batchService.GetById(_stateController.CurrentSelectedBatch.Id);
                SetWeekAndDay(_batch.DateOfBirth,DateTime.Now);
                dtpStartDate.Value = DateTime.Now;
                formTitle = string.Format("Lote {0} - Crear Observación", _batch.Number.ToString());
            }

            if (_vaccineId != Guid.Empty)
            {
                using (var batchObservationService = _serviceFactory.Create<IBatchObservationService>())
                {
                    _batchObservation = batchObservationService.GetById(_vaccineId);
                    SetWeekAndDay(_batch.DateOfBirth, _batchObservation.ObservationDate);
                    txtObservation.Text = _batchObservation.Content;
                    dtpStartDate.Value = _batchObservation.ObservationDate;
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

            if (!esValido)
            {
                this.DialogResult = DialogResult.None;
            }
            else
            {
                if (_vaccineId == Guid.Empty)
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
            _batchObservation.ObservationDate = dtpStartDate.Value;
            _batchObservation.Content = txtObservation.Text;
        }

        private CreateBatchObservationModel GetBatchObservationCreate()
        {
            var batchObservation = new CreateBatchObservationModel
            {
                Id = new Guid(),
                Content = txtObservation.Text,
                CreatedDate = DateTime.Now,
                ObservationDate = dtpStartDate.Value,
                IsDelete = false,
                BatchId = _stateController.CurrentSelectedBatch.Id
            };

            return batchObservation;
        }

        protected override void ValidateControls()
        {
            this.ValidateControl(dtpStartDate, "ObservationDate");
            this.ValidateControl(txtObservation, "Content");
            if (_batch.DateOfBirth > dtpStartDate.Value || _batch.EndDate < dtpStartDate.Value)
            {
                this.FormErrorProvider.SetError(dtpStartDate, "La fecha de Observación tiene que estar comprendida en la fecha de nacimiento y la fecha de fin.");
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
            SetWeekAndDay(_batch.DateOfBirth, dtpStartDate.Value);
        }

    }
}
