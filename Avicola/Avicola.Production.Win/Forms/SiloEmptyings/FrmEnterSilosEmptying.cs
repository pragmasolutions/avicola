using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Avicola.Common.Win;
using Avicola.Office.Entities;
using Avicola.Office.Services.Dtos;
using Avicola.Office.Services.Interfaces;
using Avicola.Production.Win.Forms.Observations;
using Avicola.Production.Win.Infrastructure;
using Avicola.Production.Win.Models.Measures;
using Avicola.Production.Win.Properties;
using Framework.WinForm.Comun.Notification;
using Telerik.WinControls;
using Telerik.WinControls.UI;

namespace Avicola.Production.Win.Forms.SiloEmptyings
{
    public partial class FrmEnterSilosEmptying : FrmProductionBase
    {
        private readonly IServiceFactory _serviceFactory;
        private readonly IStateController _stateController;
        private readonly IMessageBoxDisplayService _messageBoxDisplayService;

        public FrmEnterSilosEmptying(IFormFactory formFactory,
            IServiceFactory serviceFactory,
            IStateController stateController,
            IMessageBoxDisplayService messageBoxDisplayService)
        {
            FormFactory = formFactory;

            _serviceFactory = serviceFactory;
            _stateController = stateController;
            _messageBoxDisplayService = messageBoxDisplayService;

            InitializeComponent();

            this.gvSilos.CellFormatting += Grilla_CellFormatting;
        }

        private void FrmEnterSilosEmptying_Load(object sender, EventArgs e)
        {
            lbCurrentStandard.Text = String.Format("Lote {0} - Vaciamiento de Silos", _stateController.CurrentSelectedBatch.Number);
            UpdateGrid();
        }

        private void btnShowStandardSelection_Click(object sender, EventArgs e)
        {
            TransitionManager.LoadStandardSelectionView();
        }

        private void btnCrearVaciamiento_Click(object sender, EventArgs e)
        {
            OpenCreateBatchForm();
        }

        private void UpdateGrid()
        {
            using (var siloEmptyingService = _serviceFactory.Create<ISiloEmptyingService>())
            {
                var items = siloEmptyingService.GetByBatch(_stateController.CurrentSelectedBatch.Id);
                gvSilos.DataSource = items;
            }
        }


        private void OpenCreateBatchForm()
        {
            var form = Application.OpenForms.OfType<FrmCreateEditSiloEmptying>().FirstOrDefault();
            if (form != null)
            {
                form.Activate();
            }
            else
            {
                var frm = FormFactory.Create<FrmCreateEditSiloEmptying>(Guid.Empty);
                frm.ShowDialog();
            }

            UpdateGrid();
        }

        private void gvSilos_CommandCellClick(object sender, EventArgs e)
        {
            var commandCell = (GridCommandCellElement)sender;

            var selectedRow = this.gvSilos.SelectedRows.FirstOrDefault();

            if (selectedRow == null)
                return;

            var emptying = selectedRow.DataBoundItem as SiloEmptying;

            if (emptying == null)
                return;

            switch (commandCell.ColumnInfo.Name)
            {
                case "btnEdit":
                    Edit(emptying.Id);
                    break;
                case "btnDelete":
                    Delete(emptying.Id);
                    break;
            }
        }

        private void Edit(Guid emptyingId)
        {
            var frm = FormFactory.Create<FrmCreateEditSiloEmptying>(emptyingId);
            frm.ShowDialog();
            UpdateGrid();
        }

        private void Delete(Guid emptyingId)
        {
            DialogResult ds = RadMessageBox.Show(this, "Está seguro que desea eliminar el vaciamiento?", "Confirmación", MessageBoxButtons.YesNo, RadMessageIcon.Question);
            if (ds.ToString() == "Yes")
            {
                using (var siloEmptyingService = _serviceFactory.Create<ISiloEmptyingService>())
                {
                    siloEmptyingService.Delete(emptyingId);
                    UpdateGrid();
                }
            }
        }
    }
}
