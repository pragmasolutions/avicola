using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Avicola.Common.Win;
using Avicola.Office.Entities;
using Avicola.Office.Services.Dtos;
using Avicola.Office.Services.Interfaces;
using Avicola.Production.Win.Forms.Batchs;
using Avicola.Production.Win.Infrastructure;
using Avicola.Production.Win.Models.Measures;
using Avicola.Production.Win.Properties;
using Framework.WinForm.Comun.Notification;
using Telerik.WinControls.UI;

namespace Avicola.Production.Win.Forms.Measure
{
    public partial class FrmEnterWeeklyMeasures : FrmBase
    {
        private readonly IServiceFactory _serviceFactory;
        private readonly IStateController _stateController;
        private readonly IMessageBoxDisplayService _messageBoxDisplayService;

        public FrmEnterWeeklyMeasures(IFormFactory formFactory, 
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

                    var model = new List<LoadWeeklyStandardMeasures>();

                    foreach (var item in items)
                    {
                        var measureDateFrom = batchCreatedDate.AddDays(item.Sequence);
                        var measureDateTo = batchCreatedDate.AddDays(item.Sequence * 7);
                        var measure = measures.FirstOrDefault(x => x.StandardItemId == item.Id);

                        var weekMeasureModel = new LoadWeeklyStandardMeasures()
                        {
                            StandardItemId = item.Id,
                            MeasureId = measure == null ? Guid.Empty : measure.Id,
                            DateFrom = measureDateFrom,
                            DateTo = measureDateTo,
                            Week = item.Sequence,
                            Value = measure == null ? (decimal?)null : measure.Value
                        };


                        model.Add(weekMeasureModel);
                    }

                    ucLoadWeeklyMeasures.LoadWeeklyStandardMeasures = model;
                }
            }
        }

        private void ucLoadWeeklyMeasures_SaveClick(object sender, EventArgs e)
        {
            using (var measureService = _serviceFactory.Create<IMeasureService>())
            {
                var measures = ucLoadWeeklyMeasures.LoadWeeklyStandardMeasures
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
            if (ucLoadWeeklyMeasures.IsDirty)
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
