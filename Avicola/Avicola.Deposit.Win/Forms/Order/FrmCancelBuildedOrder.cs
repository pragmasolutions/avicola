using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Avicola.Sales.Services.Dtos;
using Avicola.Sales.Services.Interfaces;
using Framework.WinForm.Comun.Notification;
using IServiceFactory = Avicola.Services.Common.Interfaces.IServiceFactory;

namespace Avicola.Deposit.Win.Forms
{
    public partial class FrmCancelBuildedOrder : EditFormBase
    {
        private readonly IServiceFactory _serviceFactory;
        private readonly IMessageBoxDisplayService _messageBoxDisplayService;

        public FrmCancelBuildedOrder(IServiceFactory serviceFactory, IMessageBoxDisplayService messageBoxDisplayService)
        {
            _serviceFactory = serviceFactory;
            _messageBoxDisplayService = messageBoxDisplayService;

            InitializeComponent();
        }

        public OrderDto Order { get; set; }

        private void btnCancelBuildedOrder_Click(object sender, EventArgs e)
        {
            _messageBoxDisplayService.ShowConfirmationDialog("Esta seguro que desea cancelar el armado de este pedido?", "Cancelar Armado de Pedido",
                () =>
                {
                    using (var service = _serviceFactory.Create<IOrderService>())
                    {
                        service.CancelBuildedOrder(Order.Id);

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
                throw new ArgumentNullException("Se debe establecer una orden a finalizar");
            }

            ucOrderDetails.Order = Order;
        }
    }
}
