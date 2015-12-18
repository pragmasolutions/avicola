using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Avicola.Common.Win;
using Avicola.Sales.Services.Dtos;
using Avicola.Sales.Services.Interfaces;
using Framework.WinForm.Comun.Notification;
using IServiceFactory = Avicola.Services.Common.Interfaces.IServiceFactory;

namespace Avicola.Deposit.Win.Forms
{
    public partial class FrmStockEntryDetails : EditFormBase
    {
        private readonly IServiceFactory _serviceFactory;
        private readonly IMessageBoxDisplayService _messageBoxDisplayService;

        public FrmStockEntryDetails(IServiceFactory serviceFactory, IMessageBoxDisplayService messageBoxDisplayService)
        {
            _serviceFactory = serviceFactory;
            _messageBoxDisplayService = messageBoxDisplayService;

            InitializeComponent();
        }

        public StockEntryDto StockEntry { get; set; }

        private void FrmStockEntryDetails_Load(object sender, EventArgs e)
        {
            if (StockEntry == null)
            {
                throw new ArgumentNullException("Se debe establecer una partida");
            }
        }

        private void btnBackToDepositManager_Click(object sender, EventArgs e)
        {
            TransitionManager.LoadOpenStockEntriesView();
        }

        private void btnAddClassification_Click(object sender, EventArgs e)
        {

        }

        private void LoadClassifications()
        {
            using (var service = _serviceFactory.Create<IStockEntryService>())
            {
                var openStockEntries = service.GetAllOpen();

                gvStockEntries.DataSource = openStockEntries;
            }
        }
    }
}
