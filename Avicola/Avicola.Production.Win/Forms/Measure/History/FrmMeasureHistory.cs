using System;
using System.Linq;
using Avicola.Office.Services.Dtos;
using Avicola.Office.Services.Interfaces;
using Avicola.Production.Win.Models.Measures;
using Telerik.WinControls.UI;

namespace Avicola.Production.Win.Forms.Measure.History
{
    public partial class FrmMeasureHistory : FrmBase
    {
        private readonly IServiceFactory _serviceFactory;
        private BatchDto _selectedBatch;

        public FrmMeasureHistory(IServiceFactory serviceFactory)
        {
            _serviceFactory = serviceFactory;

            InitializeComponent();
        }

        private void FrmCreateMeasureWizard_Load(object sender, EventArgs e)
        {
            LoadActiveBatches();
        }

        private void LoadActiveBatches()
        {
            using (var batchService = _serviceFactory.Create<IBatchService>())
            {
                var allActiveBatches = batchService.GetAllActive();

                gvBatches.DataSource = allActiveBatches;
            }
        }

        private void gvBatches_CommandCellClick(object sender, EventArgs e)
        {
            var commandCell = (GridCommandCellElement)sender;

            var selectedRow = this.gvBatches.SelectedRows.FirstOrDefault();

            if (selectedRow == null)
                return;

            var batch = selectedRow.DataBoundItem as BatchDto;

            if (batch == null)
                return;

            if (commandCell.ColumnInfo.Name == GlobalConstants.SelectColumnName)
            {
                _selectedBatch = batch;

                createMeasureWizard.SelectNextPage();
            }
        }

        private void createMeasureWizard_SelectedPageChanged(object sender, SelectedPageChangedEventArgs e)
        {
            if (e.SelectedPage == wizardPage2)
            {
                if (_selectedBatch != null)
                {
                    using (var standardService = _serviceFactory.Create<IStandardService>())
                    {
                        var standars = standardService.GetByBatchId(_selectedBatch.Id);

                        var newMeasures = standars.Select(x => new LoadMeasureModel()
                        {
                            BatchId = _selectedBatch.Id,
                            CreatedDate = DateTime.Now,
                            MeasureUnity = x.MeasureUnity,
                            Name = x.Name
                        }).ToList();

                        gvMeasures.DataSource = newMeasures;
                    }
                }
            }
        }
    }
}
