using System;
using System.Linq;
using System.Windows.Forms;
using Avicola.Sales.Services.Interfaces;
using Avicola.Deposit.Win.Model;
using Avicola.Sales.Entities;
using Framework.WinForm.Comun.Notification;

namespace Avicola.Deposit.Win.Forms.Stock
{
    public partial class FrmAddStock : EditFormBase
    {
        private readonly IServiceFactory _serviceFactory;
        private readonly IMessageBoxDisplayService _messageBoxDisplayService;

        public FrmAddStock(IServiceFactory serviceFactory, IMessageBoxDisplayService messageBoxDisplayService)
        {
            _serviceFactory = serviceFactory;
            _messageBoxDisplayService = messageBoxDisplayService;

            InitializeComponent();
        }
        
        private void ckdProvider_ToggleStateChanged(object sender, Telerik.WinControls.UI.StateChangedEventArgs args)
        {
            ddlProviders.Visible = true;
        }

        private void ckdOwn_ToggleStateChanged(object sender, Telerik.WinControls.UI.StateChangedEventArgs args)
        {
            ddlProviders.Visible = false;
        }

        private void FrmAddStock_Load(object sender, EventArgs e)
        {
            using (var depositService = _serviceFactory.Create<IDepositService>())
            {
                var deposits = depositService.GetAll().OrderBy(x => x.Name).ToList();
                ucDepositSelection.Deposits = deposits;
            }

            using (var productService = _serviceFactory.Create<IProductService>())
            {
                var products = productService.GetAll().OrderBy(x => x.Name).ToList();
                ddlProducts.ValueMember = "Id";
                ddlProducts.DisplayMember = "Name";

                var product = new Product();
                product.Id = Guid.Empty;
                product.Name = "Seleccione un producto..";
                products.Insert(0, product);

                ddlProducts.DataSource = products;
            }

            using (var providerService = _serviceFactory.Create<IProviderService>())
            {
                var providers = providerService.GetAll().OrderBy(x => x.Name).ToList();
                ddlProviders.ValueMember = "Id";
                ddlProviders.DisplayMember = "Name";

                var provider = new Provider();
                provider.Id = Guid.Empty;
                provider.Name = "Seleccione un proveedor..";
                providers.Insert(0, provider);

                ddlProviders.DataSource = providers;
            }

            using (var shiftService = _serviceFactory.Create<IShiftService>())
            {
                var shifts = shiftService.GetAll().OrderBy(x => x.Name).ToList();
                ddlShifts.ValueMember = "Id";
                ddlShifts.DisplayMember = "Name";

                var shift = new Shift();
                shift.Id = Guid.Empty;
                shift.Name = "Seleccione un turno..";
                shifts.Insert(0, shift);

                ddlShifts.DataSource = shifts;
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
                        service.Create(stockEntry, ucDepositSelection.SelectedDeposit.Id, Guid.Parse(ddlProducts.SelectedValue.ToString()));
                        _messageBoxDisplayService.ShowInfo("El stock se agregó correctamente.");
                        ResetControls();
                    }
                    catch (Exception)
                    {
                        _messageBoxDisplayService.ShowError("El stock no se agregó correctamente.");
                    }
                }
            }
        }

        private void ResetControls()
        {
            ucEggsAmount.ResetControls();
            ddlProducts.SelectedIndex = 0;
            ddlProviders.SelectedIndex = 0;
            ddlShifts.SelectedIndex = 0;
            ckdOwn.IsChecked = true;
            pbvStockEntry.Clear();
        }
        
        private CreateStockEntryModel GetStockEntry()
        {
            var stockEntry = new CreateStockEntryModel
            {
                Boxes = ucEggsAmount.Boxes,
                Maples = ucEggsAmount.Mapples,
                Eggs = ucEggsAmount.Eggs,
                ShiftId = ddlShifts.SelectedValue == null
                                ? (Guid?)null
                                : Guid.Parse(ddlShifts.SelectedValue.ToString()),
                ProviderId = ckdOwn.IsChecked
                                ? (Guid?)null
                                : Guid.Parse(ddlProviders.SelectedValue.ToString())
            };

            return stockEntry;
        }

        private bool ValidateControls()
        {
            this.FormErrorProvider.Dispose();

            if (!ucDepositSelection.ValidateControl())
            {
                this.FormErrorProvider.SetError(ucDepositSelection, "El campo depósito es requerido");
                return false;
            }

            if (Guid.Parse(ddlProducts.SelectedValue.ToString()) == Guid.Empty)
            {
                this.FormErrorProvider.SetError(ddlProducts, "El campo producto es requerido");
                return false;
            }

            if (ckdProvider.IsChecked && Guid.Parse(ddlProviders.SelectedValue.ToString()) == Guid.Empty)
            {
                this.FormErrorProvider.SetError(ddlProviders, "El campo proveedor es requerido");
                return false;
            }

            if (Guid.Parse(ddlShifts.SelectedValue.ToString()) == Guid.Empty)
            {
                this.FormErrorProvider.SetError(ddlShifts, "El campo turno es requerido");
                return false;
            }
           
            if (!ucEggsAmount.IsValid())
            {
                _messageBoxDisplayService.ShowWarning("La cantidad de huevos no puede ser 0.");
                return false;
            }

            return true;
        }

        private void btnBackToDepositManager_Click(object sender, EventArgs e)
        {
            TransitionManager.LoadDepositManagerView();
        }

    }
}
