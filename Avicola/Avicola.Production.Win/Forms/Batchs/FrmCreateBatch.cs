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
using Framework.WinForm.Comun.Notification;

namespace Avicola.Production.Win.Forms.Batchs
{
    public partial class FrmCreateBatch : EditFormBase
    {
        private readonly IServiceFactory _serviceFactory;
        private Stage _currentStageSelected;

        public FrmCreateBatch(IFormFactory formFactory, IServiceFactory serviceFactory, IMessageBoxDisplayService messageBoxDisplayService)
        {
            FormFactory = formFactory;
            MessageBoxDisplayService = messageBoxDisplayService;

            _serviceFactory = serviceFactory;

            InitializeComponent();
        }

        public Stage CurrentStageSelected
        {
            get { return _currentStageSelected; }
            set
            {
                if (_currentStageSelected != value)
                {
                    _currentStageSelected = value;

                    ucAssignBarns.StageId = _currentStageSelected.Id;
                }
            }
        }

        private void FrmCreateBatch_Load(object sender, EventArgs e)
        {
            using (var geneticLineService = _serviceFactory.Create<IGeneticLineService>())
            {
                var geneticLine = geneticLineService.GetAll().OrderBy(x => x.Name).ToList();
                ddlGeneticLine.ValueMember = "Id";
                ddlGeneticLine.DisplayMember = "Name";
                ddlGeneticLine.DataSource = geneticLine;
            }

            using (var foodClassService = _serviceFactory.Create<IFoodClassService>())
            {
                var foodClass = foodClassService.GetAll().OrderBy(x => x.Name).ToList();
                ddlFoodClass.ValueMember = "Id";
                ddlFoodClass.DisplayMember = "Name";
                ddlFoodClass.DataSource = foodClass;
            }

            dtpDateOfBirth.Value = DateTime.Now;
            dtpEntranceDate.Value = DateTime.Now;

            txtNumber.Text = GetNextNumber().ToString();
            txtNumber.ReadOnly = true;

            txtInitialBirds.Maximum = int.MaxValue;
            txtStartingFood.Maximum = int.MaxValue;

            ucAssignBarns.FormFactory = this.FormFactory;
            ucAssignBarns.MessageBoxDisplayService = this.MessageBoxDisplayService;

            using (var stageService = _serviceFactory.Create<IStageService>())
            {
                var stages = stageService.GetAll().ToList();
                ucStageSelection.Stages = stages;
            }

            ucStageSelection.StageSelected += StageSelected;

            ToggleEnableAssignBarns(ucStageSelection.SelectedStage);
        }

        private void StageSelected(object sender, Stage stage)
        {
            ToggleEnableAssignBarns(stage);
        }

        private void ToggleEnableAssignBarns(Stage stage)
        {
            
            if (CurrentStageSelected != stage && !ucAssignBarns.BarnsAssigned.Any())
            {
                CurrentStageSelected = stage;
                ucAssignBarns.Enabled = true;
            }
            else if (CurrentStageSelected != stage && ucAssignBarns.BarnsAssigned.Any())
            {
                MessageBoxDisplayService
                    .ShowConfirmationDialog(
                        "Si cambia el estado del batch perdera todos las asignaciones de galpones cargadas en este formulario. Desea Continuar?",
                        "Cambiar Estado",
                        () =>
                        {
                            ucAssignBarns.ClearAsignations();

                            CurrentStageSelected = stage;
                        });
            }
            else if (stage == null && !ucAssignBarns.BarnsAssigned.Any())
            {
                ucAssignBarns.Enabled = false;
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
                batch.StageId = ucStageSelection.SelectedStage.Id;

                if (ucStageSelection.SelectedStage.Id == Stage.BREEDING)
                {
                    batch.BreedingDate = batchModel.EntranceDate;
                }
                else if (ucStageSelection.SelectedStage.Id == Stage.REBREEDING)
                {
                    batch.ReBreedingDate = batchModel.EntranceDate;
                }
                else if (ucStageSelection.SelectedStage.Id == Stage.POSTURE)
                {
                    batch.PostureDate = batchModel.EntranceDate;
                }

                foreach (var barnAssigned in ucAssignBarns.BarnsAssigned)
                {
                    batch.BatchBarns.Add(new BatchBarn()
                                         {
                                             BatchId = batch.Id,
                                             BarnId = barnAssigned.BarnId,
                                             InitialBirds = barnAssigned.BirdsAmount
                                         });
                }

                batch.StartingFood = txtStartingFood.Value;

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
                StartingFood = txtStartingFood.Value,
                DateOfBirth = dtpDateOfBirth.Value.ToZeroTime(),
                EntranceDate = dtpEntranceDate.Value.ToZeroTime(),
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
            this.ValidateControl(ddlFoodClass, "FoodClassId");
            this.ValidateControl(ddlGeneticLine, "GeneticLineId");
            this.ValidateControl(dtpDateOfBirth, "DateOfBirth");
        }

        protected override bool ValidarForm()
        {
            if (!base.ValidarForm())
            {
                return false;
            }

            if (!ucAssignBarns.BarnsAssigned.Any())
            {
                MessageBoxDisplayService.ShowError("Debe asignar al menos un galpón al lote");
                return false;
            }

            if (!ucAssignBarns.ValidateControl())
            {
                return false;
            }

            if (txtInitialBirds.Value != ucAssignBarns.BirdsAmountDecimal)
            {
                MessageBoxDisplayService.ShowError(
                    "La cantidad de aves del lote no puede ser diferente a la asiganada a los galpones");
                return false;
            }

            return true;
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

        private void txtInitialBirds_ValueChanged(object sender, EventArgs e)
        {
            ucAssignBarns.CurrentBatchBirds = txtInitialBirds.Value;
        }
    }
}
