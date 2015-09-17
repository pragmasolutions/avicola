using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Avicola.Common.Win;
using Avicola.Office.Entities;
using Avicola.Office.Services.Dtos;
using Avicola.Office.Services.Interfaces;
using Avicola.Production.Win.Forms.Batchs;
using Avicola.Production.Win.Forms.Measure;
using Avicola.Production.Win.Forms.Measure.History;
using Telerik.WinControls;
using Telerik.WinControls.UI;

namespace Avicola.Production.Win.Forms
{
    public partial class FrmPrincipal : FrmBase
    {
        private readonly IServiceFactory _serviceFactory;
        private BatchDto _selectedBatch;
        private IList<LoadMeasureModel> _newMeasures;

        public FrmPrincipal(IFormFactory formFactory, IServiceFactory serviceFactory)
        {
            FormFactory = formFactory;
            _serviceFactory = serviceFactory;
            InitializeComponent();
        }


        private void miCreateMeasures_Click(object sender, EventArgs e)
        {
            OpenCreateMeasureWizard();
        }

        private void miMeasuresHistory_Click(object sender, EventArgs e)
        {
            OpenMeasuresHistory();
        }

        private void OpenCreateMeasureWizard()
        {
            var form = Application.OpenForms.OfType<FrmCreateMeasureWizard>().FirstOrDefault();
            if (form != null)
            {
                form.Activate();
            }
            else
            {
                var meassureWizard = FormFactory.Create<FrmCreateMeasureWizard>();
                meassureWizard.Show();
            }
        }
        private void OpenMeasuresHistory()
        {
            var form = Application.OpenForms.OfType<FrmMeasureHistory>().FirstOrDefault();
            if (form != null)
            {
                form.Activate();
            }
            else
            {
                var meassureHistory = FormFactory.Create<FrmMeasureHistory>();
                meassureHistory.Show();
            }
        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {
            LoadActiveBatches();

            this.wizard.HelpButton.Visibility = ElementVisibility.Collapsed;
        }

        private void LoadActiveBatches()
        {
            using (var batchService = _serviceFactory.Create<IBatchService>())
            {
                var allActiveBatches = batchService.GetAllActive().OrderBy(x => x.Number);

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
                }

                wizard.SelectNextPage();
            }
        }

        private void wizzard_SelectedPageChanging(object sender, SelectedPageChangingEventArgs e)
        {
            if (e.NextPage == wizardPage1)
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
        }

        private void wizard_SelectedPageChanged(object sender, SelectedPageChangedEventArgs e)
        {
            if (e.SelectedPage == wizardPage1)
            {
                wizardPage1.Title = "Lote " + _selectedBatch.Number;
                txtEtapa.Text = _selectedBatch.StageName;
                txtFechaIngresoGalpon.Text = _selectedBatch.PostureStartDate == null
                    ? string.Empty
                    : _selectedBatch.PostureStartDate.GetValueOrDefault().ToShortDateString();
                txtGalpon.Text = _selectedBatch.BarnNumber == null ? string.Empty : _selectedBatch.BarnNumber.ToString();
                txtLineaGenetica.Text = _selectedBatch.GeneticLineName;
                txtNumero.Text = _selectedBatch.Number.ToString();
                txtSemanaActual.Text = _selectedBatch.Week.ToString();
            }

            if (e.SelectedPage == wpSelectStandard)
            {
                LoadBatchStandards();
            }
        }

        private void LoadBatchStandards()
        {
            using (var batchService = _serviceFactory.Create<IStandardService>())
            {
                var standards = batchService.GetByBatchId(_selectedBatch.Id).ToList();

                //ucStandardSelecction.Standards = standards;
            }
        }

        private void ucStandardSelecction_StandardSelected(object sender, Office.Entities.Standard e)
        {

        }

        private void btnEstandares_Click(object sender, EventArgs e)
        {
            wizard.SelectNextPage();
        }

        private void btnCreateBatch_Click(object sender, EventArgs e)
        {
            OpenCreateBatchForm();
        }

        private void OpenCreateBatchForm()
        {
            var form = Application.OpenForms.OfType<FrmCreateBatch>().FirstOrDefault();
            if (form != null)
            {
                form.Activate();
            }
            else
            {
                var frm = FormFactory.Create<FrmCreateBatch>();
                frm.BatchCreated += FrmOnBatchCreated;
                frm.Show();
            }
        }

        private void FrmOnBatchCreated(object sender, Batch batch)
        {
            LoadActiveBatches();
        }

        private void btnFinalizar_Click(object sender, EventArgs e)
        {
            OpenEndBatchForm();
        }

        private void OpenEndBatchForm()
        {
            var form = Application.OpenForms.OfType<FrmEndBatch>().FirstOrDefault();
            if (form != null)
            {
                form.Activate();
            }
            else
            {
                var frm = FormFactory.Create<FrmEndBatch>(_selectedBatch.Id);
                frm.BatchEnded += FrmOnBatchEnded;
                frm.Show();
            }
        }

        private void FrmOnBatchEnded(object sender, Batch batch)
        {
            LoadActiveBatches();
        }

        private void btnEliminarLote_Click(object sender, EventArgs e)
        {
            DialogResult ds = RadMessageBox.Show(this, "Si elimina el lote se perderán todos los datos cargados asociados al mismo. \n\nEstá seguro que desea continuar?", "Confirmación", MessageBoxButtons.YesNo, RadMessageIcon.Question);
            if (ds.ToString() == "Yes")
            {
                using (var batchService = _serviceFactory.Create<IBatchService>())
                {
                    batchService.Delete(_selectedBatch.Id);
                    wizard.SelectPreviousPage();
                    LoadActiveBatches();
                }
            }
        }
    }
}
