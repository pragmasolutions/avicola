﻿using System;
using System.Linq;
using System.Windows.Forms;
using Avicola.Common.Win;
using Avicola.Office.Entities;
using Avicola.Office.Services.Dtos;
using Avicola.Office.Services.Interfaces;
using Avicola.Production.Win.Infrastructure;
using Avicola.Production.Win.Properties;
using Telerik.WinControls;
using Telerik.WinControls.UI;
using Avicola.Production.Win.Forms.Observations;
using Avicola.Production.Win.Forms.Vaccines;
using Avicola.Production.Win.Forms.Medicines;
using Avicola.Production.Win.UserControls;

namespace Avicola.Production.Win.Forms.Batchs
{
    public partial class FrmBatchManager : FrmProductionBase
    {
        private readonly IStateController _stateController;
        private readonly IServiceFactory _serviceFactory;

        public FrmBatchManager(IFormFactory formFactory, IStateController stateController, IServiceFactory serviceFactory)
        {
            FormFactory = formFactory;

            _stateController = stateController;
            _serviceFactory = serviceFactory;

            InitializeComponent();

            btnMoveNextStage.RootElement.UseDefaultDisabledPaint = true;
        }

        private void FrmBatchManager_Load(object sender, EventArgs e)
        {
            if (_stateController.CurrentSelectedBatch == null)
            {
                return;
            }

            lbBatchTitle.Text = Resources.Batch + " " + _stateController.CurrentSelectedBatch.Number;
            txtEtapa.Text = _stateController.CurrentSelectedBatch.StageName;
            txtFechaNacimiento.Text = _stateController.CurrentSelectedBatch.DateOfBirth.ToShortDateString();
            txtLineaGenetica.Text = _stateController.CurrentSelectedBatch.GeneticLineName;
            txtNumero.Text = _stateController.CurrentSelectedBatch.Number.ToString();
            txtSemanaActual.Text = _stateController.CurrentSelectedBatch.Week.ToString();

            btnMoveNextStage.Enabled = _stateController.CurrentSelectedBatch.StageId != Stage.POSTURE;

            LoadBatchProgress();
        }

        private void LoadBatchProgress()
        {
            using (var batchService = _serviceFactory.Create<IBatchService>())
            {
                var batchBarnsDetails = batchService.GetBarnsDetails(_stateController.CurrentSelectedBatch.Id);

                foreach (var batchBarnDetailDto in batchBarnsDetails)
                {
                    StageProgressContainer.Controls.Add(new UcBatchBarnDetails()
                                            {
                                                BatchBarnDetail = batchBarnDetailDto
                                            });
                }
            }
        }

        private void btnEstandares_Click(object sender, EventArgs e)
        {
            TransitionManager.LoadStandardSelectionView();
        }

        private void btnEndBatch_Click(object sender, EventArgs e)
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
                var frm = FormFactory.Create<FrmEndBatch>(_stateController.CurrentSelectedBatch.Id);
                frm.BatchEnded += FrmOnBatchEnded;
                frm.Show();
            }
        }

        private void FrmOnBatchEnded(object sender, Batch batch)
        {
            TransitionManager.LoadBatchSelectionView();
        }

        private void btnEliminarLote_Click(object sender, EventArgs e)
        {
            DialogResult ds = RadMessageBox.Show(this, "Si elimina el lote se perderán todos los datos cargados asociados al mismo. \n\nEstá seguro que desea continuar?", "Confirmación", MessageBoxButtons.YesNo, RadMessageIcon.Question);
            if (ds.ToString() == "Yes")
            {
                using (var batchService = _serviceFactory.Create<IBatchService>())
                {
                    batchService.Delete(_stateController.CurrentSelectedBatch.Id);
                    TransitionManager.LoadBatchSelectionView();
                }
            }
        }

        private void btnGalpon_Click(object sender, EventArgs e)
        {
            var form = Application.OpenForms.OfType<FrmAssignBarn>().FirstOrDefault();
            if (form != null)
            {
                form.Activate();
            }
            else
            {
                var frm = FormFactory.Create<FrmAssignBarn>(_stateController.CurrentSelectedBatch.Id);
                frm.BarnAssigned += FrmOnBarnAssigned;
                frm.Show();
            }
        }

        private void FrmOnBarnAssigned(object sender, BarnAssignedEventModel e)
        {
            _stateController.CurrentSelectedBatch.ArrivedToBarn = e.ArrivedToBarn;
            TransitionManager.LoadBatchManagerView();
        }

        private void btnObservaciones_Click(object sender, EventArgs e)
        {
            var frm = FormFactory.Create<FrmObservationList>();
            frm.ShowDialog();
        }

        private void btnVacunas_Click(object sender, EventArgs e)
        {
            var frm = FormFactory.Create<FrmBatchVaccinesList>();
            frm.ShowDialog();
        }

        private void btnShowBatchSelectionView_Click(object sender, EventArgs e)
        {
            TransitionManager.LoadBatchSelectionView();
        }

        private void btnMedicine_Click(object sender, EventArgs e)
        {
            var frm = FormFactory.Create<FrmBatchMedicinesList>();
            frm.ShowDialog();
        }

        private void btnMoveNextStage_Click(object sender, EventArgs e)
        {
            using (var frm = FormFactory.Create<FrmMoveNextStage>())
            {
                frm.BatchStageChanged += FrmOnBatchStageChanged;
                frm.ShowDialog();
            }
        }

        private void FrmOnBatchStageChanged(object sender, EventArgs eventArgs)
        {
            using (var service = _serviceFactory.Create<IBatchService>())
            {
                var updatedBatch = service.GetActiveById(_stateController.CurrentSelectedBatch.Id);

                _stateController.CurrentSelectedBatch = updatedBatch;

                TransitionManager.LoadBatchManagerView();
            }
        }
    }
}
