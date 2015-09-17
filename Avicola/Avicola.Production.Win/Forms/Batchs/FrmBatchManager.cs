using System;
using System.Linq;
using System.Windows.Forms;
using Avicola.Common.Win;
using Avicola.Office.Entities;
using Avicola.Office.Services.Dtos;
using Avicola.Office.Services.Interfaces;
using Avicola.Production.Win.Infrastructure;
using Avicola.Production.Win.Properties;
using Telerik.WinControls.UI;

namespace Avicola.Production.Win.Forms.Batchs
{
    public partial class FrmBatchManager : FrmBase
    {
        private readonly IStateController _stateController;

        public FrmBatchManager(IFormFactory formFactory, IStateController stateController)
        {
            FormFactory = formFactory;

            _stateController = stateController;

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
    }
}
