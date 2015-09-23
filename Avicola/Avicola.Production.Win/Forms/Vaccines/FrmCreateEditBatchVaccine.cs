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
using Avicola.Production.Win.Models.BatchVaccines;
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
        private BatchVaccine _batchVaccine;

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
                formTitle = string.Format("Lote {0} - Crear Vacuna", _batch.Number.ToString());
            }

            if (_vaccineId != Guid.Empty)
            {
                using (var batchVaccineService = _serviceFactory.Create<IBatchVaccineService>())
                {
                    _batchVaccine = batchVaccineService.GetById(_vaccineId);
                    dtpRecommendedDate.Value = _batchVaccine.RecommendedDate.Value;
                    dtpStartDate.Value = _batchVaccine.StartDate;
                    dtpEndDate.Value = _batchVaccine.EndDate.Value;
                    formTitle = string.Format("Lote {0} - Editar Vacuna", _batch.Number.ToString());
                }
            }

            this.Text = formTitle;
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
                    var batchVaccinenModel = GetBatchVaccineCreate();
                    var batchVaccine = batchVaccinenModel.ToBatchVaccine();

                    using (var service = _serviceFactory.Create<IBatchVaccineService>())
                    {
                        service.Create(batchVaccine);
                    }

                    OnBatchVaccineCreated(batchVaccine);
                }
                else
                {
                    GetBatchVaccineEdit();
                    using (var service = _serviceFactory.Create<IBatchVaccineService>())
                    {
                        service.Edit(_batchVaccine);
                    }

                    OnBatchVaccineCreated(_batchVaccine);
                }

                this.Close();
            }
        }

        private void GetBatchVaccineEdit()
        {
            _batchVaccine.VaccineId = (Guid)ddlVaccines.SelectedValue;
            _batchVaccine.RecommendedDate = dtpRecommendedDate.Value;
            _batchVaccine.EndDate = dtpEndDate.Value;
            _batchVaccine.StartDate = dtpStartDate.Value;
        }

        private CreateBatchVaccineModel GetBatchVaccineCreate()
        {
            var batchVaccine = new CreateBatchVaccineModel
            {
                Id = new Guid(),
                VaccineId = (Guid)ddlVaccines.SelectedValue;
                RecommendedDate = dtpRecommendedDate.Value;
                EndDate = dtpEndDate.Value;
                StartDate = dtpStartDate.Value;
                CreatedDate = DateTime.Now,
                IsDelete = false,
                BatchId = _stateController.CurrentSelectedBatch.Id
            };

            return batchVaccine;
        }

        protected override void ValidateControls()
        {
            this.ValidateControl(dtpStartDate, "StartDate");
            this.ValidateControl(ddlVaccines, "VaccineId");
            if (_batch.DateOfBirth > dtpStartDate.Value || _batch.EndDate < dtpStartDate.Value)
            {
                this.FormErrorProvider.SetError(dtpStartDate, "La fecha de vacunación tiene que estar comprendida en la fecha de nacimiento y la fecha de fin.");
            }
        }

        protected override object GetEntity()
        {
            return GetBatchVaccineCreate();
        }

        public event EventHandler<BatchVaccine> BatchVaccineCreated;
        private void OnBatchVaccineCreated(BatchVaccine batchVaccine)
        {
            if (BatchVaccineCreated != null)
            {
                BatchVaccineCreated(this, batchVaccine);
            }
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dtpObservationDate_ValueChanged(object sender, EventArgs e)
        {
            
        }

    }
}
