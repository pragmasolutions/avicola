using System;
using System.Linq;
using System.Windows.Forms;
using Avicola.Sales.Services.Interfaces;
using Avicola.Deposit.Win.Model;

namespace Avicola.Deposit.Win.Forms.Stock
{
    public partial class FrmAddStock : EditFormBase
    {
        private readonly IServiceFactory _serviceFactory;

        public FrmAddStock(IServiceFactory serviceFactory)
        {
            _serviceFactory = serviceFactory;

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
                ddlProducts.DataSource = products;
            }

            using (var providerService = _serviceFactory.Create<IProviderService>())
            {
                var providers = providerService.GetAll().OrderBy(x => x.Name).ToList();
                ddlProviders.ValueMember = "Id";
                ddlProviders.DisplayMember = "Name";
                ddlProviders.DataSource = providers;
            }

            using (var shiftService = _serviceFactory.Create<IShiftService>())
            {
                var shifts = shiftService.GetAll().OrderBy(x => x.Name).ToList();
                ddlShifts.ValueMember = "Id";
                ddlShifts.DisplayMember = "Name";
                ddlShifts.DataSource = shifts;
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
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
                var stockEntryModel = GetStockEntry();
                var stockEntry = stockEntryModel.ToStockEntry();

                using (var service = _serviceFactory.Create<IStockEntryService>())
                {
                    service.Create(stockEntry, ucDepositSelection.SelectedDeposit.Id, Guid.Parse(ddlProducts.SelectedValue.ToString()));
                }
            }
        }
        
        private CreateStockEntryModel GetStockEntry()
        {
            var stockEntry = new CreateStockEntryModel
            {
                Boxes = string.IsNullOrEmpty(txtBoxes.Text)
                                    ? (int?)null
                                    : Convert.ToInt32(txtBoxes.Text),
                Maples = string.IsNullOrEmpty(txtMaples.Text)
                                    ? (int?)null
                                    : Convert.ToInt32(txtMaples.Text),
                Eggs = string.IsNullOrEmpty(txtEggs.Text)
                                    ? (int?)null
                                    : Convert.ToInt32(txtEggs.Text),
                ShiftId = ddlShifts.SelectedValue == null
                                ? (Guid?)null
                                : Guid.Parse(ddlShifts.SelectedValue.ToString()),
                ProviderId = ckdOwn.IsChecked
                                ? (Guid?)null
                                : Guid.Parse(ddlProviders.SelectedValue.ToString())

            };

            return stockEntry;
        }

        protected override void ValidateControls()
        {
            if (ucDepositSelection.SelectedDeposit == null)
            {
                this.FormErrorProvider.SetError(ucDepositSelection, "El campo deposito es requerido");
                return;
            }

            if (ddlProducts.SelectedValue == null)
            {
                this.FormErrorProvider.SetError(ddlProducts, "El campo producto es requerido");
                return;
            }

            if (ckdProvider.IsChecked && ddlProviders.SelectedValue == null)
            {
                this.FormErrorProvider.SetError(ddlProviders, "El campo proveedor es requerido");
                return;
            }

            this.ValidateControl(ddlShifts, "ShiftId");
            this.ValidateControl(txtBoxes, "Boxes");
            this.ValidateControl(txtMaples, "Maples");
            this.ValidateControl(txtEggs, "Eggs");
        }

        private void btnBackToDepositManager_Click(object sender, EventArgs e)
        {
            TransitionManager.LoadDepositManagerView();
        }

    }
}
