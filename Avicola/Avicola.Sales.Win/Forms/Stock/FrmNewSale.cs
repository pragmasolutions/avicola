using System;
using System.Linq;
using System.Windows.Forms;
using Avicola.Sales.Services.Interfaces;
using Avicola.Sales.Win.Model;
using Avicola.Sales.Entities;
using Avicola.Sales.Services;
using Framework.WinForm.Comun.Notification;
using Telerik.WinControls.UI;

namespace Avicola.Sales.Win.Forms.Stock
{
    public partial class FrmNewSale : EditFormBase
    {
        private readonly IServiceFactory _serviceFactory;
        private readonly IMessageBoxDisplayService _messageBoxDisplayService;

        public FrmNewSale(IServiceFactory serviceFactory, IMessageBoxDisplayService messageBoxDisplayService)
        {
            _serviceFactory = serviceFactory;
            _messageBoxDisplayService = messageBoxDisplayService;

            InitializeComponent();
        }

        private void FrmAddStock_Load(object sender, EventArgs e)
        {
            using (var clientService = _serviceFactory.Create<IClientService>())
            {
                var clients = clientService.GetAll().OrderBy(x => x.Name).ToList();
                ddlClient.ValueMember = "Id";
                ddlClient.DisplayMember = "Name";
                clients.Insert(0, new Client{ Name = "(SELECCIONE CLIENTE)"});
                ddlClient.DataSource = clients;
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            var esValido = this.ValidateControls();

            if (!esValido)
            {
                this.DialogResult = DialogResult.None;
            }
            else
            {
                var stockEntryModel = GetStockEntry();
                var stockEntry = stockEntryModel.ToStockEntry();

                using (var service = _serviceFactory.Create<IStockEntryService>())
                {
                    try
                    {
                        
                        ResetControls();
                    }
                    catch (Exception)
                    {
                        _messageBoxDisplayService.ShowError("La venta se realizó correctamente.");
                    }
                }
            }
        }

        private void ResetControls()
        {
            //ucEggsAmount.ResetControls();
            //ddlProducts.SelectedIndex = 0;
            //ddlProviders.SelectedIndex = 0;
            //ddlShifts.SelectedIndex = 0;
            //ckdOwn.IsChecked = true;
            pbvStockEntry.Clear();
        }
        
        private CreateStockEntryModel GetStockEntry()
        {
            var stockEntry = new CreateStockEntryModel
            {
                //Boxes = ucEggsAmount.Boxes,
                //Maples = ucEggsAmount.Mapples,
                //Eggs = ucEggsAmount.Eggs,
                //ShiftId = ddlShifts.SelectedValue == null
                //                ? (Guid?)null
                //                : Guid.Parse(ddlShifts.SelectedValue.ToString()),
                //ProviderId = ckdOwn.IsChecked
                //                ? (Guid?)null
                //                : Guid.Parse(ddlProviders.SelectedValue.ToString())
            };

            return stockEntry;
        }

        private bool ValidateControls()
        {
            this.FormErrorProvider.Dispose();

            

            return true;
        }

        private void btnBackToSalesManager_Click(object sender, EventArgs e)
        {
            TransitionManager.LoadSalesManagerView();
        }

        private void ddlClient_SelectedIndexChanged(object sender, Telerik.WinControls.UI.Data.PositionChangedEventArgs e)
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
}
