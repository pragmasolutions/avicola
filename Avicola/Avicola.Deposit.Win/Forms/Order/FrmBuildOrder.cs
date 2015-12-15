using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Avicola.Common.Win;
using Avicola.Sales.Services.Dtos;
using Avicola.Sales.Services.Interfaces;
using Framework.WinForm.Comun.Notification;
using IServiceFactory = Avicola.Services.Common.Interfaces.IServiceFactory;

namespace Avicola.Deposit.Win.Forms
{
    public partial class FrmBuildOrder : EditFormBase
    {
        private readonly IServiceFactory _serviceFactory;
        private readonly IMessageBoxDisplayService _messageBoxDisplayService;

        public FrmBuildOrder(IServiceFactory serviceFactory, IMessageBoxDisplayService messageBoxDisplayService)
        {
            _serviceFactory = serviceFactory;
            _messageBoxDisplayService = messageBoxDisplayService;

            InitializeComponent();
        }

        public OrderDto Order { get; set; }

        private void btnBuildOrder_Click(object sender, EventArgs e)
        {
            this.FormErrorProvider.Clear();

            _messageBoxDisplayService.ShowConfirmationDialog("Esta seguro que desea armar este pedido?", "Armar Pedido",
                () =>
                {
                    using (var service = _serviceFactory.Create<IOrderService>())
                    {
                        service.BuildOrder(Order.Id, AppSettings.DepositId);

                        TransitionManager.LoadOrdersManagerView();
                    }
                });
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            TransitionManager.LoadOrdersManagerView();
        }

        private void FrmBuildOrder_Load(object sender, EventArgs e)
        {
            if (Order == null)
            {
                throw new ArgumentNullException("Se debe establecer una orden a armar");
            }

            ucOrderDetails.Order = Order;
        }

        private void btnBackToDepositManager_Click(object sender, EventArgs e)
        {
            TransitionManager.LoadOrdersManagerView();
        }
    }
}
