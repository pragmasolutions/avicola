using System;
using System.Collections.Generic;
using System.Linq;
using Avicola.Common.Win;
using Avicola.Office.Services.Dtos;
using Avicola.Office.Services.Interfaces;
using Avicola.Production.Win.Infrastructure;
using Avicola.Production.Win.Models.Measures;
using Avicola.Production.Win.Properties;
using Framework.WinForm.Comun.Notification;

namespace Avicola.Production.Win.Forms.Measure
{
    public partial class FrmEnterDailyMeasures : FrmBase
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
            lbCurrentStandard.Text = Resources.Standard + ": " + _stateController.CurrentSelectedStandard.Name; 
            
            var geneticLineId = _stateController.CurrentSelectedBatch.GeneticLineId;
            var stageId = _stateController.CurrentSelectedBatch.StageId;
            var standardId = _stateController.CurrentSelectedStandard.Id;
            var batchId = _stateController.CurrentSelectedBatch.Id;
            var batchCreatedDate = _stateController.CurrentSelectedBatch.CreatedDate;

            using (var standardItemService = _serviceFactory.Create<IStandardItemService>())
            {
                using (var measureService = _serviceFactory.Create<IMeasureService>())
                {
                    var items = standardItemService.GetByStandardAndGeneticLine(standardId, stageId, geneticLineId);
                    var measures = measureService.GetByStandardAndBatch(standardId, batchId);

                    var itemsGroupedByWeek = items.GroupBy(x => x.Week);

                    var model = new List<LoadDailyStandardMeasures>();

                    foreach (var weekGroup in itemsGroupedByWeek)
                    {
                        var dailyLoad = new LoadDailyStandardMeasures();

                        dailyLoad.Week = weekGroup.Key;
                        dailyLoad.DailyStandardMeasures = new List<DailyStandardMeasure>();

                        foreach (var weekDays in weekGroup)
                        {
                            if (!weekDays.Day.HasValue)
                            {
                                continue;
                            }

                            var measureDate = batchCreatedDate.AddDays(weekDays.Sequence);
                            var measure = measures.FirstOrDefault(x => x.StandardItemId == weekDays.Id);

                            var measureModel = new DailyStandardMeasure()
                            {
                                StandardItemId = weekDays.Id,
                                MeasureId = measure == null ? Guid.Empty : measure.Id,
                                Date = measureDate,
                                Day = weekDays.Sequence,
                                Value = measure == null ? (decimal?)null : measure.Value
                            };

                            dailyLoad.DailyStandardMeasures.Add(measureModel);
                        }

                        model.Add(dailyLoad);
                    }

                    ucLoadDailyMeasures.Standard = _stateController.CurrentSelectedStandard;
                    ucLoadDailyMeasures.LoadDailyStandardMeasures = model;
                }
            }
        }

        private void ucLoadDailyMeasures_SaveClick(object sender, EventArgs e)
        {
            using (var measureService = _serviceFactory.Create<IMeasureService>())
            {
                var measures = ucLoadDailyMeasures.LoadDailyStandardMeasures.SelectMany(x => x.DailyStandardMeasures)
                    .Select(x => new UpdateMeasureDto()
                                 {
                                     Id = x.MeasureId,
                                     StandardItemId = x.StandardItemId,
                                     BatchId = _stateController.CurrentSelectedBatch.Id,
                                     Value = x.Value
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
