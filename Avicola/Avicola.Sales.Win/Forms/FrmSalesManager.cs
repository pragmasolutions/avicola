using System;
using System.Windows.Forms;
using Avicola.Common.Win;
using Avicola.Sales.Win.Infrastructure;
using Avicola.Services.Common.Interfaces;
using Framework.Sync;
using Framework.WinForm.Comun.Notification;


namespace Avicola.Sales.Win.Forms
{
    public partial class FrmSalesManager : FrmSalesBase
    {
        private readonly IServiceFactory _serviceFactory;

        public FrmSalesManager(IFormFactory formFactory, IMessageBoxDisplayService messageBoxDisplayService, IServiceFactory serviceFactory)
        {
            FormFactory = formFactory;
            MessageBoxDisplayService = messageBoxDisplayService;
            _serviceFactory = serviceFactory;

            InitializeComponent();
        }

        private void FrmSalesManager_Load(object sender, EventArgs e)
        {
        }

        private void btnNewSale_Click(object sender, EventArgs e)
        {
            TransitionManager.LoadNewSaleView();
        }
        
        private void btnHistory_Click(object sender, EventArgs e)
        {
            TransitionManager.LoadHistoryManagerView();
        }

    }
}
