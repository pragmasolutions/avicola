using System;
using System.Linq;
using System.Windows.Forms;
using Avicola.Common.Win;
using Avicola.Common.Win.Forms.Clients;
using Avicola.Sales.Services.Dtos;
using Avicola.Sales.Services.Interfaces;
using Framework.Common.Win.CustomProviders;
using Framework.WinForm.Comun.Notification;
using Telerik.WinControls;
using Telerik.WinControls.UI;
using Telerik.WinControls.UI.Localization;

namespace Avicola.Sales.Win.Forms
{
    public partial class FrmClientsList : EditFormBase
    {
        private readonly IServiceFactory _serviceFactory;
        private readonly IMessageBoxDisplayService _messageBoxDisplayService;

        public FrmClientsList(IFormFactory formFactory,
            IServiceFactory serviceFactory,
            IMessageBoxDisplayService messageBoxDisplayService)
        {
            FormFactory = formFactory;

            _serviceFactory = serviceFactory;
            _messageBoxDisplayService = messageBoxDisplayService;

            InitializeComponent();

            this.gvClients.CellFormatting += Grilla_CellFormatting;
        }

        private async void FrmBatchMedicineList_Load(object sender, EventArgs e)
        {
            LoadClients();
        }

        private async void LoadClients()
        {
            wbClients.Visible = true;

            wbClients.StartWaiting();

            using (var service = _serviceFactory.Create<IClientService>())
            {
                int pageTotal;
                var clients = await service.GetAll("Name", "ASC", null, 1, gvClients.PageSize, out pageTotal);
                gvClients.DataSource = clients;
            }

            wbClients.StopWaiting();

            wbClients.Visible = false;
        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            OpenCreateClientForm();
        }

        private void OpenCreateClientForm()
        {
            var form = Application.OpenForms.OfType<FrmCreateEditClient>().FirstOrDefault();

            if (form != null)
            {
                form.Activate();
            }
            else
            {
                using (var frm = FormFactory.Create<FrmCreateEditClient>(Guid.Empty))
                {
                    frm.ShowDialog();
                }
            }

            LoadClients();
        }

        private void gvClients_CommandCellClick(object sender, EventArgs e)
        {
            var commandCell = (GridCommandCellElement)sender;

            var selectedRow = this.gvClients.SelectedRows.FirstOrDefault();

            if (selectedRow == null)
                return;

            var client = selectedRow.DataBoundItem as ClientDto;

            if (client == null)
                return;

            switch (commandCell.ColumnInfo.Name)
            {
                case "btnEdit":
                    Edit(client.Id);
                    break;
                case "btnDelete":
                    Delete(client.Id);
                    break;
            }
        }

        private void Edit(Guid clientId)
        {
            using (var frm = FormFactory.Create<FrmCreateEditClient>(clientId))
            {
                frm.ShowDialog();
                LoadClients();
            }
        }

        private void Delete(Guid clientId)
        {
            _messageBoxDisplayService.ShowConfirmationDialog("¿Esta seguro que desea eliminar este cliente? \n\r   esta operación no se puede deshacer.",
                "Eliminar Cliente",
                () =>
                {
                    using (var service = _serviceFactory.Create<IClientService>())
                    {
                        service.Delete(clientId);
                        LoadClients();
                    }
                });
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            TransitionManager.LoadSalesManagerView();
        }

        private void gvClients_PageChanged(object sender, EventArgs e)
        {

        }
    }
}
