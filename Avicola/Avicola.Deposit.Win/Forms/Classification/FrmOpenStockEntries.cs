using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Avicola.Common.Win.Forms;
using Avicola.Sales.Entities;
using Avicola.Sales.Services.Dtos;
using Avicola.Sales.Services.Interfaces;
using Telerik.WinControls;
using Telerik.WinControls.UI;

namespace Avicola.Deposit.Win.Forms
{
    public partial class FrmOpenStockEntries : FrmDepositBase
    {
        private readonly IServiceFactory _serviceFactory;

        public FrmOpenStockEntries(IServiceFactory serviceFactory)
        {
            _serviceFactory = serviceFactory;

            InitializeComponent();

            gvStockEntries.TableElement.RowHeight = Avicola.Common.Win.GlobalConstants.DefaultRowHeight;
        }

        private void btnBackToDepositManager_Click(object sender, EventArgs e)
        {
            TransitionManager.LoadDepositManagerView();
        }

        private void FrmOpenStockEntries_Load(object sender, EventArgs e)
        {
            LoadStockEntries();
        }

        private void LoadStockEntries()
        {
            using (var service = _serviceFactory.Create<IStockEntryService>())
            {
                var openStockEntries = service.GetAllOpen();

                gvStockEntries.DataSource = openStockEntries;
            }
        }

        private void gvStockEntries_CommandCellClick(object sender, EventArgs e)
        {
            var commandCell = (GridCommandCellElement)sender;

            var selectedRow = this.gvStockEntries.SelectedRows.FirstOrDefault();

            if (selectedRow == null)
                return;

            var stockEntry = selectedRow.DataBoundItem as StockEntryDto;

            if (stockEntry == null)
                return;

            if (commandCell.ColumnInfo.Name == GlobalConstants.DetailsColumnName)
            {
                TransitionManager.LoadStockEntryDetailsView(stockEntry);
            }
        }
    }
}
