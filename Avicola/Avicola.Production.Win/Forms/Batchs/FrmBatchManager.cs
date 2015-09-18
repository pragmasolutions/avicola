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
            txtFechaIngresoGalpon.Text = _stateController.CurrentSelectedBatch.PostureStartDate == null
                ? string.Empty
                : _stateController.CurrentSelectedBatch.PostureStartDate.GetValueOrDefault().ToShortDateString();
            txtGalpon.Text = _stateController.CurrentSelectedBatch.BarnNumber == null ? string.Empty : _stateController.CurrentSelectedBatch.BarnNumber.ToString();
            txtLineaGenetica.Text = _stateController.CurrentSelectedBatch.GeneticLineName;
            txtNumero.Text = _stateController.CurrentSelectedBatch.Number.ToString();
            txtSemanaActual.Text = _stateController.CurrentSelectedBatch.Week.ToString();
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
    }
}
