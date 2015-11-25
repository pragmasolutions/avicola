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
    public partial class FrmFinishOrder : EditFormBase
    {
        private readonly IServiceFactory _serviceFactory;
        private readonly IMessageBoxDisplayService _messageBoxDisplayService;

        public FrmFinishOrder(IServiceFactory serviceFactory, IMessageBoxDisplayService messageBoxDisplayService)
        {
            _serviceFactory = serviceFactory;
            _messageBoxDisplayService = messageBoxDisplayService;

            InitializeComponent();
        }

        public OrderDto Order { get; set; }

        private void btnFinishOrder_Click(object sender, EventArgs e)
        {
            if (ucEggsAmount.TotalDozens != Order.Dozens)
            {
                _messageBoxDisplayService.ShowError("El total de docenas debe ser igual al solicitado en el pedido");
                return;
            }

            _messageBoxDisplayService.ShowConfirmationDialog("Esta seguro que desea finalizar el armado este pedido?", "Finalizar Pedido",
                () =>
                {
                    using (var service = _serviceFactory.Create<IOrderService>())
                    {
                        service.FinishOrder(Order.Id, ucEggsAmount.Boxes, ucEggsAmount.Mapples, ucEggsAmount.Eggs);

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
