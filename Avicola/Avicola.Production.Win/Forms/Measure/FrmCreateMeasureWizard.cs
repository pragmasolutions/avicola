using System;
using System.Collections.Generic;
using System.Linq;
using Avicola.Office.Services.Dtos;
using Avicola.Office.Services.Interfaces;
using Telerik.WinControls;
using Telerik.WinControls.UI;

namespace Avicola.Production.Win.Forms.Measure
{
    public partial class FrmCreateMeasureWizard : RadForm
    {
        private readonly IServiceFactory _serviceFactory;
        private BatchDto _selectedBatch;
        private IList<LoadMeasureModel> _newMeasures;

        public FrmCreateMeasureWizard(IServiceFactory serviceFactory)
        {
            _serviceFactory = serviceFactory;

            InitializeComponent();
        }

        private void FrmCreateMeasureWizard_Load(object sender, EventArgs e)
        {
            LoadActiveBatches();

            this.createMeasureWizard.HelpButton.Visibility = Telerik.WinControls.ElementVisibility.Collapsed;
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
                if (_selectedBatch != batch)
                {
                    _selectedBatch = batch;

                    LoadMeasures();
                }

                createMeasureWizard.SelectNextPage();
            }
        }

        private void LoadMeasures()
        {
            using (var standardService = _serviceFactory.Create<IStandardService>())
            {
                var standars = standardService.GetByBatchId(_selectedBatch.Id);

                _newMeasures = standars.Select(x => new LoadMeasureModel()
                                                    {
                                                        BatchId = _selectedBatch.Id,
                                                        CreatedDate = DateTime.Now,
                                                        MeasureUnity = x.MeasureUnity,
                                                        Name = x.Name,
                                                        StandardId = x.Id
                                                    }).ToList();

                gvMeasures.DataSource = _newMeasures;
            }
        }

        private void createMeasureWizard_SelectedPageChanged(object sender, SelectedPageChangedEventArgs e)
        {
            if (e.SelectedPage == wizardCompletionPage1)
            {
                ucLoadMeasuresSummary.Batch = _selectedBatch;
            }
        }

        private void createMeasureWizard_SelectedPageChanging(object sender, SelectedPageChangingEventArgs e)
        {
            if (e.NextPage == wizardPage2)
            {
                if (gvBatches.SelectedRows.Count == 1)
                {
                    var selectedBatch = gvBatches.SelectedRows.Single().DataBoundItem as BatchDto;

                    _selectedBatch = selectedBatch;
                }
                else
                {
                    RadMessageBox.Show("Debe seleccionar un lote para continuar");
                    e.Cancel = true;
                }
            }

            if (e.NextPage == wizardCompletionPage1)
            {
                ValidateMeasures(e);
            }
        }

        private void ValidateMeasures(SelectedPageChangingEventArgs e)
        {
            if (_newMeasures != null)
            {
                foreach (var measure in _newMeasures)
                {
                    if (!measure.CreatedDate.HasValue)
                    {
                        RadMessageBox.Show(string.Format("Debe ingresar una fecha para la medida {0}", measure.Name));
                        e.Cancel = true;
                        break;
                    }

                    if (!measure.Value.HasValue)
                    {
                        RadMessageBox.Show(string.Format("Debe ingresar un valor para la medida {0}", measure.Name));
                        e.Cancel = true;
                        break;
                    }
                }
            }
        }

        private void createMeasureWizard_Finish(object sender, EventArgs e)
        {
            using (var measureService = _serviceFactory.Create<IMeasureService>())
            {
                measureService.CreateMeasures(_newMeasures, _selectedBatch.Id);
            }

            this.Close();
        }

        private void createMeasureWizard_Cancel(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
