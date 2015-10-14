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
using Avicola.Production.Win.Infrastructure;
using Framework.Common.Helpers;
using Telerik.WinControls.UI;
using Avicola.Production.Win.Models.BatchMedicines;
namespace Avicola.Production.Win.Forms.Medicines
{
    public partial class FrmCreateEditBatchMedicine : EditFormBase
    {
        private readonly IStateController _stateController;
        private readonly IServiceFactory _serviceFactory;
        private Guid _batchMedicineId = Guid.Empty;
        private Batch _batch;
        private BatchMedicine _batchMedicine;

        public FrmCreateEditBatchMedicine(Guid id, IFormFactory formFactory, IStateController stateController, IServiceFactory serviceFactory)
        {
            FormFactory = formFactory;
            _serviceFactory = serviceFactory;
            _stateController = stateController;
            _batchMedicineId = id;
            InitializeComponent();
        }

        private void FrmCreateEditBatchMedicine_Load(object sender, EventArgs e)
        {
            var formTitle = "";

            using (var batchService = _serviceFactory.Create<IBatchService>())
            {
                _batch = batchService.GetById(_stateController.CurrentSelectedBatch.Id);

                dtpStartDate.Value = _batch.DateOfBirth;
                dtpEndDate.Value = _batch.DateOfBirth.AddDays(_batch.GeneticLine.ProductionWeeks * 7);
                txtObservation.Text = "";
                formTitle = string.Format("Lote {0} - Crear Medicamento", _batch.Number.ToString());
            }

            using (var medicineService = _serviceFactory.Create<IMedicineService>())
            {
                var vaccines = medicineService.GetAllActive().OrderBy(x => x.Name).ToList();
                ddlMedicines.ValueMember = "Id";
                ddlMedicines.DisplayMember = "Name";
                Medicine item = new Medicine();
                item.Name = "Selecciona un medicamento..";
                item.Id = Guid.Empty;
                vaccines.Insert(0,item);
                ddlMedicines.DataSource = vaccines;
            }
                        
            if (_batchMedicineId != Guid.Empty)
            {
                //Editar
                using (var batchMedicineService = _serviceFactory.Create<IBatchMedicineService>())
                {
                    _batchMedicine = batchMedicineService.GetById(_batchMedicineId);
                    txtObservation.Text = _batchMedicine.Observation;
                    dtpStartDate.Value = _batchMedicine.StartDate;
                    if (_batchMedicine.EndDate != null) dtpEndDate.Value = _batchMedicine.EndDate.Value;
                    ddlMedicines.SelectedValue = _batchMedicine.MedicineId;
                    formTitle = string.Format("Lote {0} - Editar Medicamento", _batch.Number.ToString());
                }
            }

            this.Text = formTitle;
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            var esValido = this.ValidarForm();
            if (FormErrorProvider.GetError(dtpStartDate) != "")
                esValido = false;

            if (!esValido)
            {
                this.DialogResult = DialogResult.None;
            }
            else
            {
                if (_batchMedicineId == Guid.Empty)
                {
                    var batchVaccinenModel = GetBatchMedicineCreate();
                    var batchVaccine = batchVaccinenModel.ToBatchMedicine();

                    using (var service = _serviceFactory.Create<IBatchMedicineService>())
                    {
                        service.Create(batchVaccine);
                    }

                    OnBatchMedicineCreated(batchVaccine);
                }
                else
                {
                    GetBatchMedicineEdit();
                    using (var service = _serviceFactory.Create<IBatchMedicineService>())
                    {
                        service.Edit(_batchMedicine);
                    }

                    OnBatchMedicineCreated(_batchMedicine);
                }

                this.Close();
            }
        }

        private void GetBatchMedicineEdit()
        {
            _batchMedicine.MedicineId = (Guid)ddlMedicines.SelectedValue;
            _batchMedicine.EndDate = dtpEndDate.Value;
            _batchMedicine.StartDate = dtpStartDate.Value;
            _batchMedicine.Observation = txtObservation.Text;
        }

        private CreateBatchMedicineModel GetBatchMedicineCreate()
        {
            var batchMedicine = new CreateBatchMedicineModel
            {
                Id = new Guid(),
                MedicineId = (Guid)ddlMedicines.SelectedValue == Guid.Empty
                            ? (Guid?)null
                            : Guid.Parse(ddlMedicines.SelectedValue.ToString()),                
                EndDate = dtpEndDate.Value,
                StartDate = dtpStartDate.Value,
                CreatedDate = DateTime.Now,
                IsDelete = false,
                Observation = txtObservation.Text,
                BatchId = _stateController.CurrentSelectedBatch.Id
            };

            return batchMedicine;
        }

        protected override void ValidateControls()
        {
            this.ValidateControl(dtpStartDate, "StartDate");
            this.ValidateControl(ddlMedicines, "MedicineId");
            if (_batch.DateOfBirth > dtpStartDate.Value || _batch.EndDate < dtpStartDate.Value)
            {
                this.FormErrorProvider.SetError(dtpStartDate, "La fecha de medicamento tiene que estar comprendida en la fecha de nacimiento y la fecha de fin.");
            }
        }

        protected override object GetEntity()
        {
            return GetBatchMedicineCreate();
        }

        public event EventHandler<BatchMedicine> BatchMedicineCreated;
        private void OnBatchMedicineCreated(BatchMedicine batchMedicine)
        {
            if (BatchMedicineCreated != null)
            {
                BatchMedicineCreated(this, batchMedicine);
            }
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
