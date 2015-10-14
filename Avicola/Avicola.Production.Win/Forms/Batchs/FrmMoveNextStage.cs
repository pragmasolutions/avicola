using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Avicola.Common.Win;
using Avicola.Office.Entities;
using Avicola.Production.Win.Infrastructure;
using Framework.WinForm.Comun.Notification;
using Telerik.WinControls;

namespace Avicola.Production.Win.Forms.Batchs
{
    public partial class FrmMoveNextStage : EditFormBase
    {
        private readonly IStateController _stateController;

        public FrmMoveNextStage(IFormFactory formFactory, IMessageBoxDisplayService messageBoxDisplayService, IStateController stateController)
        {
            _stateController = stateController;

            FormFactory = formFactory;
            MessageBoxDisplayService = messageBoxDisplayService;

            InitializeComponent();
        }

        private void FrmMoveNextStage_Load(object sender, EventArgs e)
        {
            dtpDate.Value = DateTime.Today;

            txtCurrentStage.Text = _stateController.CurrentSelectedBatch.StageName;
            txtNextStage.Text = Stage.NextStage(_stateController.CurrentSelectedBatch.StageId.GetValueOrDefault());

            ucAssignBarns.FormFactory = this.FormFactory;
            ucAssignBarns.MessageBoxDisplayService = this.MessageBoxDisplayService;
            ucAssignBarns.StageId = Stage.NextStageId(_stateController.CurrentSelectedBatch.StageId.GetValueOrDefault());
        }
    }
}
