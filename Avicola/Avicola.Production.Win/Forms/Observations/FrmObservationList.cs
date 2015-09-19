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

namespace Avicola.Production.Win.Forms.Observations
{
    public partial class FrmObservationList : EditFormBase
    {
        private readonly IStateController _stateController;
        private readonly IServiceFactory _serviceFactory;

        public FrmObservationList(IFormFactory formFactory, IStateController stateController, IServiceFactory serviceFactory)
        {
            FormFactory = formFactory;
            _stateController = stateController;
            _serviceFactory = serviceFactory;
            
            InitializeComponent();
        }

        private void FrmObservationList_Load(object sender, EventArgs e)
        {
            using (var batchObservationService = _serviceFactory.Create<IBatchObservationService>())
            {
                var batchObservations = batchObservationService.GetByBatchId(_stateController.CurrentSelectedBatch.Id).OrderBy(x => x.CreatedDate).ToList();
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
                frm.BatchObservationCreated += BatchObservationCreated;
                frm.ShowDialog();
            }
        }
        
        public event EventHandler<BatchObservation> BatchObservationCreated;
        private void OnBatchObservationCreated(BatchObservation batchObservation)
        {
            if (BatchObservationCreated != null)
            {
                BatchObservationCreated(this, batchObservation);
            }
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
            frm.BatchObservationCreated += BatchObservationCreated;
            frm.ShowDialog();
        }

        private void Delete(Guid observationId)
        {

        }
    }
}
