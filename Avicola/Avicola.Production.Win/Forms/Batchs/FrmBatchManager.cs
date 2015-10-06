using System;
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

namespace Avicola.Production.Win.Forms.Batchs
{
    public partial class FrmBatchManager : FrmBase
    {
        private readonly IStateController _stateController;
        private readonly IServiceFactory _serviceFactory;

        public FrmBatchManager(IFormFactory formFactory, IStateController stateController, IServiceFactory serviceFactory)
        {
            FormFactory = formFactory;

            _stateController = stateController;
            _serviceFactory = serviceFactory;
            InitializeComponent();
        }

        private void FrmBatchManager_Load(object sender, EventArgs e)
        {
            if (_stateController.CurrentSelectedBatch == null)
            {
                return;
            }

            lbBatchTitle.Text = Resources.Batch + " " + _stateController.CurrentSelectedBatch.Number;
            txtEtapa.Text = _stateController.CurrentSelectedBatch.StageName;
            txtFechaIngresoGalpon.Text = _stateController.CurrentSelectedBatch.ArrivedToBarn == null
                ? string.Empty
                : _stateController.CurrentSelectedBatch.ArrivedToBarn.GetValueOrDefault().ToShortDateString();
            txtFechaNacimiento.Text = _stateController.CurrentSelectedBatch.DateOfBirth.ToShortDateString();
            txtGalpon.Text = _stateController.CurrentSelectedBatch.BarnNumber == null ? string.Empty : _stateController.CurrentSelectedBatch.BarnNumber.ToString();
            txtLineaGenetica.Text = _stateController.CurrentSelectedBatch.GeneticLineName;
            txtNumero.Text = _stateController.CurrentSelectedBatch.Number.ToString();
            txtSemanaActual.Text = _stateController.CurrentSelectedBatch.Week.ToString();

            btnGalpon.Enabled = _stateController.CurrentSelectedBatch.BarnNumber == null;
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
            _stateController.CurrentSelectedBatch.BarnNumber = e.BarnNumber;
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
    }
}
