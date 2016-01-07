using System;
using System.Windows.Forms;
using Avicola.Common.Win.Model;
using Avicola.Sales.Entities;
using Avicola.Sales.Services.Interfaces;

namespace Avicola.Common.Win.Forms.Clients
{
    public partial class FrmCreateEditClient : EditFormBase
    {
        private readonly IServiceFactory _serviceFactory;
        private readonly Guid _clientId;
        private Client _client;

        public FrmCreateEditClient(Guid id, IFormFactory formFactory, IServiceFactory serviceFactory)
        {
            FormFactory = formFactory;
            _serviceFactory = serviceFactory;
            _clientId = id;
            InitializeComponent();
        }

        private void FrmCreateEditClient_Load(object sender, EventArgs e)
        {
            if (_clientId != Guid.Empty)
            {
                using (var service = _serviceFactory.Create<IClientService>())
                {
                    _client = service.GetById(_clientId);

                    txtAddress.Text = _client.Address;
                    txtCellPhone.Text = _client.CellPhone;
                    txtCity.Text = _client.City;
                    Name = txtName.Text = _client.Name;
                    txtEmail.Text = _client.Email;
                    txtReferent.Text = _client.Referent;
                    txtPhoneNumber1.Text = _client.Tel1;
                    txtPhoneNumber2.Text = _client.Tel2;
                    txtWebsite.Text = _client.WebSite;

                    this.Text = "Editar Cliente";
                }
            }
            else
            {
                this.Text = "Crear Cliente";
            }
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            var esValido = this.ValidarForm();

            if (!esValido)
            {
                this.DialogResult = DialogResult.None;
            }
            else
            {
                using (var service = _serviceFactory.Create<IClientService>())
                {

                    var model = GetClientCreate();

                    var client = model.ToClient();

                    if (_clientId == Guid.Empty)
                    {
                        service.Create(client);

                        OnClientSaved(client);
                    }
                    else
                    {
                        service.Edit(client);

                        OnClientSaved(client);
                    }
                    this.Close();

                }
            }
        }

        private ClientModel GetClientCreate()
        {
            var client = new ClientModel()
            {
                Id = _clientId == Guid.Empty ? Guid.NewGuid() : _clientId,
                Address = txtAddress.Text,
                CellPhone = txtCellPhone.Text,
                City = txtCity.Text,
                Name = txtName.Text,
                Email = txtEmail.Text,
                Referent = txtReferent.Text,
                Tel1 = txtPhoneNumber1.Text,
                Tel2 = txtPhoneNumber2.Text,
                WebSite = txtWebsite.Text
            };

            return client;
        }

        protected override void ValidateControls()
        {
            this.ValidateControl(txtAddress, "Address");
            this.ValidateControl(txtCity, "City");
            this.ValidateControl(txtCellPhone, "CellPhone");
            this.ValidateControl(txtName, "Name");
            this.ValidateControl(txtEmail, "Email");
            this.ValidateControl(txtReferent, "Referent");
            this.ValidateControl(txtPhoneNumber1, "Tel1");
            this.ValidateControl(txtPhoneNumber2, "Tel2");
            this.ValidateControl(txtWebsite, "WebSite");
        }

        protected override object GetEntity()
        {
            return GetClientCreate();
        }

        public event EventHandler<Client> ClientSaved;
        private void OnClientSaved(Client client)
        {
            if (ClientSaved != null)
            {
                ClientSaved(this, client);
            }
        }
        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
