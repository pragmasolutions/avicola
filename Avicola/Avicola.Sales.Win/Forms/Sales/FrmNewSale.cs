using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Avicola.Common.Win;
using Avicola.Common.Win.Forms.Clients;
using Avicola.Sales.Services.Interfaces;
using Avicola.Sales.Win.Model;
using Avicola.Sales.Entities;
using Avicola.Sales.Services;
using Avicola.Sales.Win.UserControls;
using Framework.Data.Repository;
using Framework.WinForm.Comun.Notification;
using Org.BouncyCastle.Utilities.IO;
using Telerik.WinControls.UI;

namespace Avicola.Sales.Win.Forms.Sales
{
    public partial class FrmNewSale : EditFormBase
    {
        private readonly IServiceFactory _serviceFactory;
        private readonly IMessageBoxDisplayService _messageBoxDisplayService;

        public FrmNewSale(IServiceFactory serviceFactory, IMessageBoxDisplayService messageBoxDisplayService,
                            IFormFactory formFactory)
        {
            _serviceFactory = serviceFactory;
            _messageBoxDisplayService = messageBoxDisplayService;
            FormFactory = formFactory;

            InitializeComponent();
        }

        private void FrmNewSale_Load(object sender, EventArgs e)
        {
            RefreshClientsDropdown();
            LoadEggClasses();
        }

        private void LoadEggClasses()
        {
            using (var service = _serviceFactory.Create<IEggClassService>())
            {
                var classes = service.GetAll().OrderBy(x => x.Sequence);
                foreach (var eggClass in classes)
                {
                    flpProducts.Controls.Add(new UcEggClassSale()
                    {
                        EggClassId = eggClass.Id,
                        Dozens = 0,
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
            TransitionManager.LoadSalesManagerView();
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
                    CompleteEggClasses(order);
                    using (var service = _serviceFactory.Create<IOrderService>())
                    {

                        service.Create(order);
                        ResetControls();
                        _messageBoxDisplayService.ShowSuccess("La venta se realizó correctamente.");
                    }
                }
                
            }
        }

        private void CompleteEggClasses(Order order)
        {
            order.OrderEggClasses = new List<OrderEggClass>();
            foreach (UcEggClassSale control in flpProducts.Controls)
            {
                if (control.Dozens > 0)
                {
                    order.OrderEggClasses.Add(new OrderEggClass()
                    {
                        Dozens = control.Dozens,
                        CreatedDate = DateTime.Now,
                        EggClassId = control.EggClassId,
                        Id = Guid.NewGuid(),
                        IsDeleted = false
                    });
                }
            }
        }

        private void ResetControls()
        {
            ddlClient.SelectedIndex = 0;
            txtAddress.Text = string.Empty;
            txtCity.Text = string.Empty;
            txtPhone.Text = string.Empty;
            foreach (UcEggClassSale control in flpProducts.Controls)
            {
                control.Dozens = 0;
            }
        }
        
        private CreateOrderModel GetOrder()
        {
            var order = new CreateOrderModel
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

        private void btnBack_Click(object sender, EventArgs e)
        {
            TransitionManager.LoadSalesManagerView();
        }
    }
}
