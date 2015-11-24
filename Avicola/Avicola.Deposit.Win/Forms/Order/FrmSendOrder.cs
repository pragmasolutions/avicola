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
    public partial class FrmSendOrder : EditFormBase
    {
        private readonly IServiceFactory _serviceFactory;
        private readonly IMessageBoxDisplayService _messageBoxDisplayService;

        public FrmSendOrder(IServiceFactory serviceFactory, IMessageBoxDisplayService messageBoxDisplayService)
        {
            _serviceFactory = serviceFactory;
            _messageBoxDisplayService = messageBoxDisplayService;

            InitializeComponent();
        }

        public OrderDto Order { get; set; }

        private void btnSendOrder_Click(object sender, EventArgs e)
        {
            this.FormErrorProvider.Clear();

            if (ucDriverSelection.SelectedDriver == null)
            {
                this.FormErrorProvider.SetError(ucDriverSelection, "El campo conductor es requerido");
                return;
            }

            if (ucTruckSelection.SelectedTruck == null)
            {
                this.FormErrorProvider.SetError(ucTruckSelection, "El campo camión es requerido");
                return;
            }

            _messageBoxDisplayService.ShowConfirmationDialog("Esta seguro que desea enviar este pedido?", "Armar Pedido",
                () =>
                {
                    using (var service = _serviceFactory.Create<IOrderService>())
                    {
                        service.SendOrder(Order.Id, ucDriverSelection.SelectedDriver.Id, ucTruckSelection.SelectedTruck.Id);

                        TransitionManager.LoadOrdersManagerView();
                    }
                });
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            TransitionManager.LoadOrdersManagerView();
        }

        private void FrmSendOrder_Load(object sender, EventArgs e)
        {
            if (Order == null)
            {
                throw new ArgumentNullException("Se debe establecer una orden a enviar");
            }

            ucOrderDetails.Order = Order;


            using (var service = _serviceFactory.Create<IDriverService>())
            {
                ucDriverSelection.Drivers = service.GetAll();
            }

            using (var service = _serviceFactory.Create<ITruckService>())
            {
                ucTruckSelection.Trucks = service.GetAll();
            }
        }
    }
}
