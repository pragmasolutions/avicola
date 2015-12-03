using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Avicola.Common.Win;
using Framework.Data.Helpers;
using Telerik.WinControls;
using System.Linq;
using Avicola.Sales.Entities;
using Framework.Common.Helpers;
using Avicola.Sales.Services.Interfaces;
using Avicola.Sales.Win.Model;

namespace Avicola.Sales.Win.Forms.Clients
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
                    
                    if (_clientId == Guid.Empty)
                    {
                        var model = GetClientCreate();
                        var client = model.ToClient();
                        service.Create(client);

                        OnClientCreated(client);
                    }
                    else
                    {
                        GetClientEdit();
                        service.Edit(_client);
                        OnClientCreated(_client);
                    }
                    this.Close();
                    
                }
            }
        }

        private void GetClientEdit()
        {
            //_client.Date = dtpDate.Value.ToZeroTime();
        }

        private ClientModel GetClientCreate()
        {
            var client = new ClientModel()
            {
                Id = Guid.NewGuid(),
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

        public event EventHandler<Client> ClientCreated;
        private void OnClientCreated(Client Client)
        {
            if (ClientCreated != null)
            {
                ClientCreated(this, Client);
            }
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
