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
        private Guid _batchVaccineId = Guid.Empty;
        private Batch _batch;
        private BatchVaccine _batchVaccine;

        public FrmCreateEditBatchVaccine(Guid id, IFormFactory formFactory, IStateController stateController, IServiceFactory serviceFactory)
        {
            FormFactory = formFactory;
            _serviceFactory = serviceFactory;
            _stateController = stateController;
            _batchVaccineId = id;
            InitializeComponent();
        }

        private void FrmCreateEditVaccine_Load(object sender, EventArgs e)
        {
            var formTitle = "";

            using (var batchService = _serviceFactory.Create<IBatchService>())
            {
                _batch = batchService.GetById(_stateController.CurrentSelectedBatch.Id);

                dtpStartDate.Value = _batch.DateOfBirth;
                dtpEndDate.Value = _batch.DateOfBirth.AddDays(_batch.GeneticLine.ProductionWeeks * 7);
                dtpRecommendedDate.Value = DateTime.Now;
                formTitle = string.Format("Lote {0} - Crear Vacunación", _batch.Number.ToString());
            }

            using (var vaccineService = _serviceFactory.Create<IVaccineService>())
            {
                var vaccines = vaccineService.GetAllActive().OrderBy(x => x.Name).ToList();
                ddlVaccines.ValueMember = "Id";
                ddlVaccines.DisplayMember = "Name";
                ddlVaccines.DataSource = vaccines;
            }
                        
            if (_batchVaccineId != Guid.Empty)
            {
                //Editar
                using (var batchVaccineService = _serviceFactory.Create<IBatchVaccineService>())
                {
                    _batchVaccine = batchVaccineService.GetById(_batchVaccineId);
                    if (_batchVaccine.Vaccine.RecommendedDay.HasValue)
                    {                        
                        txtRecommendedDate.Text = _batch.DateOfBirth.AddDays(_batchVaccine.Vaccine.RecommendedDay.Value).ToString();
                        txtRecommendedDate.ReadOnly = true;                    
                    }
                    else
                    {
                        txtRecommendedDate.Visible = false;
                        lblRecommendedDate.Visible = false;
                    }    
                    
                    dtpStartDate.Value = _batchVaccine.StartDate;
                    dtpEndDate.Value = _batchVaccine.EndDate.Value;
                    ddlVaccines.SelectedValue = _batchVaccine.VaccineId;
                    formTitle = string.Format("Lote {0} - Editar Vacunación", _batch.Number.ToString());
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
                if (_batchVaccineId == Guid.Empty)
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
            _batchVaccine.EndDate = dtpEndDate.Value;
            _batchVaccine.StartDate = dtpStartDate.Value;
        }

        private CreateBatchVaccineModel GetBatchVaccineCreate()
        {
            var batchVaccine = new CreateBatchVaccineModel
            {
                Id = new Guid(),
                VaccineId = ddlVaccines.SelectedValue == null
                            ? (Guid?)null
                            : Guid.Parse(ddlVaccines.SelectedValue.ToString()),                
                EndDate = dtpEndDate.Value,
                StartDate = dtpStartDate.Value,
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

        private void ddlVaccines_SelectedValueChanged(object sender, EventArgs e)
        {
            if (ddlVaccines.SelectedValue != null)
            {
                using (var vaccineService = _serviceFactory.Create<IVaccineService>())
                {
                    var vaccine = vaccineService.GetById((Guid)ddlVaccines.SelectedValue);
                    if (vaccine.RecommendedDay.HasValue)
                    {
                        txtRecommendedDate.Text = _batch.DateOfBirth.AddDays(vaccine.RecommendedDay.Value).ToString("dd/MM/yyyy");
                        txtRecommendedDate.ReadOnly = true;
                        txtRecommendedDate.Visible = true;
                        lblRecommendedDate.Visible = true;
                    }
                    else
                    {
                        txtRecommendedDate.Visible = false;
                        lblRecommendedDate.Visible = false;
                    }      
                }
            }            
        }
    }
}
