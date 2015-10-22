using System;
using System.Linq;
using System.Windows.Forms;
using Avicola.Common.Win;
using Avicola.Office.Entities;
using Avicola.Office.Services.Dtos;
using Avicola.Office.Services.Interfaces;
using Avicola.Production.Win.Infrastructure;
using Avicola.Production.Win.Properties;
using Telerik.WinControls.UI;

namespace Avicola.Production.Win.Forms.Standards
{
    public partial class FrmStandardSelection : FrmBase
    {
        private readonly IServiceFactory _serviceFactory;
        private readonly IStateController _stateController;

        public FrmStandardSelection(IFormFactory formFactory, IServiceFactory serviceFactory, IStateController stateController)
        {
            FormFactory = formFactory;

            _serviceFactory = serviceFactory;
            _stateController = stateController;

            InitializeComponent();
        }

        private void FrmBatchManager_Load(object sender, EventArgs e)
        {
            if (_stateController.CurrentSelectedBatch == null)
            {
                return;
            }

            lbBatchTitle.Text = Resources.Batch + " " + _stateController.CurrentSelectedBatch.Number;

            LoadBatchStandards();
        }

        private void LoadBatchStandards()
        {
            using (var standardService = _serviceFactory.Create<IStandardService>())
            {
                var standards = standardService.GetByBatchId(_stateController.CurrentSelectedBatch.Id).Where(s => !s.IsDeleted).ToList();

                ucStandardSelecction.Standards = standards;
            }
        }

        private void ucStandardSelecction_StandardSelected(object sender, Standard standard)
        {
            _stateController.CurrentSelectedStandard = standard;

            if (standard.DataLoadTypeId.ToString() == Avicola.Office.Entities.GlobalConstants.DailyDataLoadType)
            {
                TransitionManager.LoadEnterDailyStandardView();
            }
            else if (standard.DataLoadTypeId.ToString() == Avicola.Office.Entities.GlobalConstants.WeeklyDataLoadType)
            {
                TransitionManager.LoadEnterWeeklyStandardView();
            }
            
        }

        private void ucStandardSelecction_SilosEmptyingSelected(object sender, EventArgs e)
        {
            TransitionManager.LoadEnterSilosEmptyingView();
        }

        private void btnShowBatchManagerView_Click(object sender, EventArgs e)
        {
            TransitionManager.LoadBatchManagerView();
        }
    }
}
