using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Avicola.Common.Win;
using Avicola.Common.Win.Forms.Clients;
using Avicola.Common.Win.UserControls;
using Avicola.Deposit.Win.Model;
using Avicola.Sales.Entities;
using Avicola.Sales.Services.Dtos;
using Avicola.Sales.Services.Interfaces;
using Framework.WinForm.Comun.Notification;

namespace Avicola.Deposit.Win.Forms.Order
{
    public partial class FrmEditOrder : EditFormBase
    {
        private readonly IServiceFactory _serviceFactory;
        private readonly IMessageBoxDisplayService _messageBoxDisplayService;
        private OrderDto _order;

        public FrmEditOrder(IServiceFactory serviceFactory, 
                            IMessageBoxDisplayService messageBoxDisplayService,
                            IFormFactory formFactory)
        {
            _serviceFactory = serviceFactory;
            _messageBoxDisplayService = messageBoxDisplayService;
            FormFactory = formFactory;

            InitializeComponent();
        }

        public Guid OrderId { get; set; }

        private void FrmEditOrder_Load(object sender, EventArgs e)
        {
            RefreshClientsDropdown();
            LoadOrderData();
            LoadEggClasses();
        }

        private void LoadOrderData()
        {
            using (var service = _serviceFactory.Create<IOrderService>())
            {
                _order = service.Get(OrderId);

                ddlClient.SelectedValue = _order.ClientId;

                txtAddress.Text = _order.Address;
                txtCity.Text = _order.City;
                txtPhone.Text = _order.PhoneNumber;
            }
        }

        private void LoadEggClasses()
        {
            using (var service = _serviceFactory.Create<IEggClassService>())
            {
                var classes = service.GetAll().OrderBy(x => x.Sequence);
                foreach (var eggClass in classes)
                {
                    var orderEggClass = _order.OrderEggClasses.FirstOrDefault(x => x.EggClassId == eggClass.Id);

                    flpProducts.Controls.Add(new UcEggClassSale()
                    {
                        EggClassId = eggClass.Id,
                        Dozens = orderEggClass != null ? orderEggClass.Dozens : 0,
                        Name = eggClass.Name
                    });
                }
            }
        }

        private void RefreshClientsDropdown()
        {
            using (var clientService = _serviceFactory.Create<IClientService>())
            {
                var clients = clientService.GetAll().OrderBy(x => x.Name).ToList();
                ddlClient.ValueMember = "Id";
                ddlClient.DisplayMember = "Name";
                clients.Insert(0, new Client { Name = "(SELECCIONE CLIENTE)" });
                ddlClient.DataSource = clients;
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            TransitionManager.LoadOrdersManagerView();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            var esValido = this.ValidarForm();

            if (!esValido)
            {
                this.DialogResult = DialogResult.None;
            }
            else
            {
                var eggsCount = 0;
                foreach (UcEggClassSale control in flpProducts.Controls)
                {
                    if (control.Dozens > 0)
                    {
                        eggsCount = control.Dozens;
                        break;
                    }
                }
                if (eggsCount == 0)
                {
                    _messageBoxDisplayService.ShowWarning("Debe ingresar cantidades al menos para una clase");
                }
                else
                {
                    var model = GetOrder();

                    var order = model.ToOrder();

                    order.Id = _order.Id;

                    CompleteEggClasses(order);

                    using (var service = _serviceFactory.Create<IOrderService>())
                    {
                        service.Edit(order);

                        TransitionManager.LoadOrdersManagerView();
                    }
                }
            }
        }

        private void CompleteEggClasses(Sales.Entities.Order order)
        {
            order.OrderEggClasses = new List<OrderEggClass>();

            foreach (UcEggClassSale control in flpProducts.Controls)
            {
                if (control.Dozens > 0)
                {
                    var orderEggClass = _order.OrderEggClasses.FirstOrDefault(x => x.EggClassId == control.EggClassId);

                    order.OrderEggClasses.Add(new OrderEggClass()
                    {
                        OrderId = order.Id,
                        Dozens = control.Dozens,
                        CreatedDate = DateTime.Now,
                        EggClassId = control.EggClassId,
                        Id = orderEggClass != null ? orderEggClass.Id : Guid.Empty,
                        IsDeleted = false
                    });
                }
            }
        }

        private EditOrderModel GetOrder()
        {
            var order = new EditOrderModel
            {
                ClientId = Guid.Parse(ddlClient.SelectedValue.ToString()),
                Address = txtAddress.Text,
                City = txtCity.Text,
                PhoneNumber = txtPhone.Text
            };

            return order;
        }
        protected override void ValidateControls()
        {
            this.ValidateControl(txtCity, "City");
            this.ValidateControl(txtAddress, "Address");
            this.ValidateControl(txtPhone, "PhoneNumber");
            if (ddlClient.SelectedValue.ToString() == Guid.Empty.ToString())
            {
                this.FormErrorProvider.SetError(ddlClient, "Debe seleccionar un cliente.");
            }
        }

        protected override object GetEntity()
        {
            return GetOrder();
        }

        private void ddlClient_SelectedIndexChanged(object sender, Telerik.WinControls.UI.Data.PositionChangedEventArgs e)
        {
            if (ddlClient.SelectedValue != null)
            {
                var clientId = Guid.Parse(ddlClient.SelectedValue.ToString());
                if (clientId != Guid.Empty)
                {
                    using (var service = _serviceFactory.Create<IClientService>())
                    {
                        var client = service.GetById(Guid.Parse(clientId.ToString()));
                        txtAddress.Text = client.Address;
                        txtPhone.Text = client.Tel1;
                        txtCity.Text = client.City;
                    }
                }
            }
        }

        private void btnAddClient_Click(object sender, EventArgs e)
        {
            var form = Application.OpenForms.OfType<FrmCreateEditClient>().FirstOrDefault();
            if (form != null)
            {
                form.Activate();
            }
            else
            {
                var frm = FormFactory.Create<FrmCreateEditClient>(Guid.Empty);
                frm.ClientSaved += new EventHandler<Client>(ClientCreated);
                frm.ShowDialog();
            }
        }

        private void ClientCreated(object sender, Client client)
        {
            RefreshClientsDropdown();
            
            ddlClient.SelectedValue = client.Id;
            ddlClient_SelectedIndexChanged(null, null);
        }
    }
}
