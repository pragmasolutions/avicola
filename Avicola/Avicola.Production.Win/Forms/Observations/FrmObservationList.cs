using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Avicola.Common.Win;
using Avicola.Office.Services.Dtos;
using Avicola.Office.Services.Interfaces;
using Framework.Data.Helpers;
using Telerik.WinControls;
using System.Linq;
using Avicola.Office.Entities;
using Avicola.Production.Win.Models.BatchObservations;
using Telerik.WinControls.UI;
using Avicola.Production.Win.Infrastructure;
using Framework.Common.Helpers;
using Framework.WinForm.Comun.Notification;
using Avicola.Production.Win.Properties;
using Framework.Common.Win.CustomProviders;
using Telerik.WinControls.UI.Localization;

namespace Avicola.Production.Win.Forms.Observations
{
    public partial class FrmObservationList : EditFormBase
    {
        private readonly IStateController _stateController;
        private readonly IServiceFactory _serviceFactory;
        private readonly IMessageBoxDisplayService _messageBoxDisplayService;
        private Batch batch;

        public FrmObservationList(IFormFactory formFactory, 
            IStateController stateController, 
            IServiceFactory serviceFactory,
            IMessageBoxDisplayService messageBoxDisplayService)
        {
            FormFactory = formFactory;
            _stateController = stateController;
            _serviceFactory = serviceFactory;
            _messageBoxDisplayService = messageBoxDisplayService;
            RadGridLocalizationProvider.CurrentProvider = new CustomRadGridViewLocalizationProvider();
            
            InitializeComponent();

            this.gvBatchObservations.CellFormatting += Grilla_CellFormatting;
        }

        private void FrmObservationList_Load(object sender, EventArgs e)
        {
            using (var batchService = _serviceFactory.Create<IBatchService>())
            {
                batch = batchService.GetById(_stateController.CurrentSelectedBatch.Id);
            }

            UpdateGrid();
        }

        private void UpdateGrid()
        {
            using (var batchObservationService = _serviceFactory.Create<IBatchObservationService>())
            {
                var batchObservations = batchObservationService.GetByBatchId(_stateController.CurrentSelectedBatch.Id).OrderBy(x => x.CreatedDate).ToList();
                foreach (var batchObservation in batchObservations)
                {
                    var weeksDays = DateHelper.DateDiffInWeek(batch.DateOfBirth, batchObservation.ObservationDate);
                    batchObservation.Week = weeksDays.Weeks;
                    batchObservation.Day = weeksDays.Days;
                }

                gvBatchObservations.DataSource = batchObservations;
            }
        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            OpenCreateBatchForm();
        }

        private void OpenCreateBatchForm()
        {
            var form = Application.OpenForms.OfType<FrmCreateEditBatchObservation>().FirstOrDefault();
            if (form != null)
            {
                form.Activate();
            }
            else
            {
                var frm = FormFactory.Create<FrmCreateEditBatchObservation>(Guid.Empty);
                frm.ShowDialog();
            }

            UpdateGrid();
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void gvBatchObservations_CommandCellClick(object sender, EventArgs e)
        {
            var commandCell = (GridCommandCellElement)sender;

            var selectedRow = this.gvBatchObservations.SelectedRows.FirstOrDefault();

            if (selectedRow == null)
                return;

            var observation = selectedRow.DataBoundItem as BatchObservationDto;

            if (observation == null)
                return;

            switch (commandCell.ColumnInfo.Name)
            {
                case "btnEdit":
                    Edit(observation.Id);
                    break;
                case "btnDelete":
                    Delete(observation.Id);
                    break;
            }
        }

        private void Edit(Guid observationId)
        {
            var frm = FormFactory.Create<FrmCreateEditBatchObservation>(observationId);
            frm.ShowDialog();
            UpdateGrid();
        }

        private void Delete(Guid observationId)
        {
            DialogResult ds = RadMessageBox.Show(this, "Si elimina la observación se perderán todos los datos. \n\nEstá seguro que desea continuar?", "Confirmación", MessageBoxButtons.YesNo, RadMessageIcon.Question);
            if (ds.ToString() == "Yes")
            {
                using (var service = _serviceFactory.Create<IBatchObservationService>())
                {
                    service.Delete(observationId);
                    UpdateGrid();
                }
            }
        }
    }
}
