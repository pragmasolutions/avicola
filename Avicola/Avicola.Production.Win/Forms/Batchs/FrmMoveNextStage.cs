using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Avicola.Common.Win;
using Avicola.Office.Entities;
using Avicola.Office.Services.Dtos;
using Avicola.Office.Services.Interfaces;
using Avicola.Production.Win.Infrastructure;
using Castle.Core.Internal;
using Castle.DynamicProxy.Generators.Emitters;
using Framework.WinForm.Comun.Notification;
using Telerik.WinControls;

namespace Avicola.Production.Win.Forms.Batchs
{
    public partial class FrmMoveNextStage : EditFormBase
    {
        private readonly IStateController _stateController;
        private readonly IServiceFactory _serviceFactory;
        private readonly IBatchService _batchService;
        private decimal _currentBirdsAmount;
        private decimal _currentFoodEntry;

        public FrmMoveNextStage(IFormFactory formFactory, IMessageBoxDisplayService messageBoxDisplayService,
            IStateController stateController, IServiceFactory serviceFactory)
        {
            _stateController = stateController;
            _serviceFactory = serviceFactory;

            FormFactory = formFactory;
            MessageBoxDisplayService = messageBoxDisplayService;

            InitializeComponent();
        }

        public event EventHandler BatchStageChanged;

        private void OnBatchStageChanged()
        {
            if (BatchStageChanged != null)
            {
                BatchStageChanged(this, new EventArgs());
            }
        }

        private void FrmMoveNextStage_Load(object sender, EventArgs e)
        {
            dtpDate.Value = DateTime.Today;

            txtCurrentStage.Text = _stateController.CurrentSelectedBatch.StageName;
            txtNextStage.Text = Stage.NextStage(_stateController.CurrentSelectedBatch.StageId.GetValueOrDefault());

            using (var service = _serviceFactory.Create<IBatchService>())
            {
                _currentBirdsAmount = service.GetBirdsAmount(_stateController.CurrentSelectedBatch.Id);
                _currentFoodEntry = service.GetCurrentStageFoodEntry(_stateController.CurrentSelectedBatch.Id);

                txtBatchBirdsAmount.Text = _currentBirdsAmount.ToString("n0");
                txtFoodEntry.Text = _currentFoodEntry.ToString("n0");

                txtCurrentStockFood.Maximum = _currentFoodEntry;
            }

            ucAssignBarns.FormFactory = this.FormFactory;
            ucAssignBarns.MessageBoxDisplayService = this.MessageBoxDisplayService;
            ucAssignBarns.StageId = Stage.NextStageId(_stateController.CurrentSelectedBatch.StageId.GetValueOrDefault());
            ucAssignBarns.CurrentBatchBirds = _currentBirdsAmount;
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            if (!ValidateForm())
            {
                this.DialogResult = DialogResult.None;
                return;
            }

            using (var service = _serviceFactory.Create<IBatchService>())
            {
                var moveNextStageDto = new MoveNextStageDto();

                moveNextStageDto.BatchId = _stateController.CurrentSelectedBatch.Id;
                moveNextStageDto.NextStageStartDate = dtpDate.Value;
                moveNextStageDto.CurrentFoodStock = txtCurrentStockFood.Value;
                
                foreach (var barnAssigned in ucAssignBarns.BarnsAssigned)
                {
                    moveNextStageDto.BarnsAssigned.Add(new BarnsAssignedDto()
                                          {
                                              BarnId = barnAssigned.BarnId,
                                              InitialBirds = barnAssigned.BirdsAmount,
                                              StartingFood = barnAssigned.InitialFood
                                          });
                }

                service.MoveNextStage(moveNextStageDto);

                OnBatchStageChanged();
            }
        }

        private bool ValidateForm()
        {
            this.FormErrorProvider.Clear();

            if (dtpDate.Text.IsNullOrEmpty())
            {
                this.FormErrorProvider.SetError(dtpDate, "Debe ingresar una fecha");
                return false;
            }

            if (!ucAssignBarns.BarnsAssigned.Any())
            {
                MessageBoxDisplayService.ShowError("Debe asignar al menos un galpón para pasar a la siguiente etapa");
                return false;
            }

            if (_currentBirdsAmount != ucAssignBarns.BirdsAmountDecimal)
            {
                MessageBoxDisplayService.ShowError(
                    "La cantidad de aves del lote no puede ser diferente a la asiganada a los galpones");
                return false;
            }

            return true;
        }
    }
}
