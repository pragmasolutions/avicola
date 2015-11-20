using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Avicola.Common.Win;
using Avicola.Office.Entities;
using Avicola.Office.Services.Dtos;
using Avicola.Office.Services.Interfaces;
using Avicola.Production.Win.Infrastructure;
using Avicola.Production.Win.Models.Measures;
using Avicola.Production.Win.Properties;
using Framework.WinForm.Comun.Notification;
using Telerik.WinControls;

namespace Avicola.Production.Win.Forms.Measure
{
    public partial class FrmEnterDailyMeasures : FrmProductionBase
    {
        private readonly IServiceFactory _serviceFactory;
        private readonly IStateController _stateController;
        private readonly IMessageBoxDisplayService _messageBoxDisplayService;

        public FrmEnterDailyMeasures(IFormFactory formFactory,
            IServiceFactory serviceFactory,
            IStateController stateController,
            IMessageBoxDisplayService messageBoxDisplayService)
        {
            FormFactory = formFactory;

            _serviceFactory = serviceFactory;
            _stateController = stateController;
            _messageBoxDisplayService = messageBoxDisplayService;

            InitializeComponent();
        }

        private void FrmEnterDailyMeasures_Load(object sender, EventArgs e)
        {
            lbCurrentStandard.Text = String.Format("Indicador: {0}: {1}   |    Etapa: {2}",
                                                Resources.Standard,
                                                _stateController.CurrentSelectedStandard.Name.ToUpper(),
                                                _stateController.CurrentSelectedBatch.StageName.ToUpper());

            var geneticLineId = _stateController.CurrentSelectedBatch.GeneticLineId;
            var stageId = _stateController.CurrentSelectedBatch.StageId;
            var standardId = _stateController.CurrentSelectedStandard.Id;
            var batchId = _stateController.CurrentSelectedBatch.Id;
            var batchDateOfBirth = _stateController.CurrentSelectedBatch.DateOfBirth;

            using (var standardItemService = _serviceFactory.Create<IStandardItemService>())
            {
                using (var measureService = _serviceFactory.Create<IMeasureService>())
                {
                    var items = standardItemService.GetByStandardAndGeneticLine(standardId, stageId.GetValueOrDefault(), geneticLineId);

                    var measures = measureService.GetByStandardAndBatch(standardId, batchId);

                    var model = new List<LoadDailyStandardMeasures>();

                    DateTime endDate;

                    using (var batchService = _serviceFactory.Create<IBatchService>())
                    {
                        endDate = batchService.GetEndDateById(batchId);
                    }

                    foreach (var item in items)
                    {
                        var dailyLoad = new LoadDailyStandardMeasures();

                        dailyLoad.Week = item.Sequence;
                        dailyLoad.DailyStandardMeasures = new List<DailyStandardMeasure>();

                        for (var i = 0; i < 7; i++)
                        {
                            var measureDate = batchDateOfBirth.AddDays((item.Sequence - 1) * 7 + i);
                            if (measureDate.Date < endDate.Date)
                            {
                                var measure = measures.Where(m => !m.StandardItem.IsDeleted)
                                            .FirstOrDefault(x => x.StandardItemId == item.Id
                                                            && x.Date == measureDate.Date);

                                var measureModel = new DailyStandardMeasure()
                                {
                                    StandardItemId = item.Id,
                                    MeasureId = measure == null ? Guid.Empty : measure.Id,
                                    Date = measureDate,
                                    Day = (item.Sequence - 1) * 7 + i + 1,
                                    Value = measure == null ? (decimal?)null : measure.Value,
                                    FoodClassId = measure == null ? (Guid?)null : measure.FoodClassId
                                };

                                dailyLoad.DailyStandardMeasures.Add(measureModel);
                            }
                        }

                        model.Add(dailyLoad);
                    }

                    ucLoadDailyMeasures.Standard = _stateController.CurrentSelectedStandard;
                    ucLoadDailyMeasures.LoadDailyStandardMeasures = model;
                    ucLoadDailyMeasures.CurrentWeek = _stateController.CurrentSelectedBatch.Week;
                }
            }
        }

        private void ucLoadDailyMeasures_SaveClick(object sender, EventArgs e)
        {
            if (_stateController.CurrentSelectedStandard.Id == Office.Entities.Standard.FoodEntry)
            {
                var invalid = ucLoadDailyMeasures.LoadDailyStandardMeasures.SelectMany(x => x.DailyStandardMeasures).Any(x => x.Value != null && x.FoodClassId == null);
                if (invalid)
                {
                    RadMessageBox.Show(this, "Falta ingresar la clase de alimento para uno o más valores ingresados", "Error", MessageBoxButtons.OK, RadMessageIcon.Error);
                    return;
                }
            }
            using (var measureService = _serviceFactory.Create<IMeasureService>())
            {
                var measures = ucLoadDailyMeasures.LoadDailyStandardMeasures.SelectMany(x => x.DailyStandardMeasures)
                    .Select(x => new UpdateMeasureDto()
                                 {
                                     Id = x.MeasureId,
                                     StandardItemId = x.StandardItemId,
                                     BatchId = _stateController.CurrentSelectedBatch.Id,
                                     Value = x.Value,
                                     FoodClassId = x.FoodClassId,
                                     Date = x.Date.ToZeroTime()
                                 });

                measureService.UpdateMeasures(measures);
            }

            TransitionManager.LoadStandardSelectionView();
        }

        private void btnShowStandardSelection_Click(object sender, EventArgs e)
        {
            if (ucLoadDailyMeasures.IsDirty)
            {
                _messageBoxDisplayService.ShowConfirmationDialog(
                    Resources.PendingChangesConfirmation, Resources.EnterMeasures,
                    () => TransitionManager.LoadStandardSelectionView());
            }
            else
            {
                TransitionManager.LoadStandardSelectionView();
            }
        }
    }
}
