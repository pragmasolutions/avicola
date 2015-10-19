using System;
using System.Linq;
using System.Windows.Forms;
using Avicola.Common.Win;
using Avicola.Office.Entities;
using Avicola.Office.Services.Dtos;
using Avicola.Office.Services.Interfaces;
using Avicola.Production.Win.Infrastructure;
using Telerik.WinControls.UI;

namespace Avicola.Production.Win.Forms.Batchs
{
    public partial class FrmBatchSelection : FrmBase
    {
        private readonly IServiceFactory _serviceFactory;
        private readonly IStateController _stateController;
        private readonly ITransitionManager _transitionManager;

        public FrmBatchSelection(IFormFactory formFactory , IServiceFactory serviceFactory,IStateController stateController)
        {
            FormFactory = formFactory;

            _serviceFactory = serviceFactory;
            _stateController = stateController;

            InitializeComponent();

            gvBatches.TableElement.RowHeight = GlobalConstants.DefaultRowHeight;
        }

        private void btnCreateBatch_Click(object sender, EventArgs e)
        {
            OpenCreateBatchForm();
        }

        private void FrmBatchSelection_Load(object sender, EventArgs e)
        {
            LoadActiveBatches();
        }

        private void LoadActiveBatches()
        {
            using (var batchService = _serviceFactory.Create<IBatchService>())
            {
                var allActiveBatches = batchService.GetAllActive().OrderBy(x => x.Number);

                gvBatches.DataSource = allActiveBatches;
            }
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
                using (var frm = FormFactory.Create<FrmCreateBatch>())
                {
                    frm.BatchCreated += FrmOnBatchCreated;
                    frm.ShowDialog();
                }
            }
        }

        private void FrmOnBatchCreated(object sender, Batch batch)
        {
            LoadActiveBatches();
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
                _stateController.CurrentSelectedBatch = batch;

                TransitionManager.LoadBatchManagerView();
            }
        }   
    }
}
