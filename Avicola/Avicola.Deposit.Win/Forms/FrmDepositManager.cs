using System;
using System.Windows.Forms;
using Avicola.Common.Win;
using Avicola.Deposit.Win.Infrastructure;
using Avicola.Services.Common.Interfaces;
using Framework.Sync;
using Framework.WinForm.Comun.Notification;


namespace Avicola.Deposit.Win.Forms
{
    public partial class FrmDepositManager : FrmDepositBase
    {
        private readonly IServiceFactory _serviceFactory;

        public FrmDepositManager(IFormFactory formFactory, IMessageBoxDisplayService messageBoxDisplayService, IServiceFactory serviceFactory)
        {
            FormFactory = formFactory;
            MessageBoxDisplayService = messageBoxDisplayService;
            _serviceFactory = serviceFactory;

            InitializeComponent();
        }

        private void FrmDepositManager_Load(object sender, EventArgs e)
        {
        }

        private void btnStock_Click(object sender, EventArgs e)
        {
        }

        private void btnOrders_Click(object sender, EventArgs e)
        {
            TransitionManager.LoadOrdersManagerView();
        }

        private void btnHistory_Click(object sender, EventArgs e)
        {
            TransitionManager.LoadHistoryManagerView();
        }

    }
}
