using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Avicola.Common.Win;
using Avicola.Sales.Services.Dtos;
using Avicola.Sales.Services.Interfaces;
using Framework.WinForm.Comun.Notification;
using Telerik.WinControls.UI;
using IServiceFactory = Avicola.Services.Common.Interfaces.IServiceFactory;

namespace Avicola.Deposit.Win.Forms
{
    public partial class FrmStockEntryDetails : EditFormBase
    {
        private readonly IServiceFactory _serviceFactory;
        private readonly IMessageBoxDisplayService _messageBoxDisplayService;

        public FrmStockEntryDetails(IServiceFactory serviceFactory, IMessageBoxDisplayService messageBoxDisplayService,IFormFactory formFactory)
        {
            FormFactory = formFactory;

            _serviceFactory = serviceFactory;
            _messageBoxDisplayService = messageBoxDisplayService;

            InitializeComponent();

            gvClassifications.CellFormatting += base.Grilla_CellFormatting;
        }

        public StockEntryDto StockEntry { get; set; }

        private void FrmStockEntryDetails_Load(object sender, EventArgs e)
        {
            if (StockEntry == null)
            {
                throw new ArgumentNullException("Se debe establecer una partida");
            }

            LoadDetails();

            LoadClassifications();
        }

        private void LoadDetails()
        {
            txtClassificationDate.Text = StockEntry.CreatedDate.ToShortDateString();
            txtSwift.Text = StockEntry.ShiftName;
            txtBarn.Text = StockEntry.BarnName;

            txtBoxes.Text = StockEntry.Boxes.ToString();
            txtMapples.Text = StockEntry.Maples.ToString();
            txtEggs.Text = StockEntry.Eggs.ToString();

            txtTotalEggs.Text = StockEntry.TotalEggs.ToString();
            txtRemainingEggs.Text = StockEntry.CurrentEggs.ToString();
        }

        private void btnBackToDepositManager_Click(object sender, EventArgs e)
        {
            TransitionManager.LoadOpenStockEntriesView();
        }

        private void btnAddClassification_Click(object sender, EventArgs e)
        {
            using (var form = FormFactory.Create<FrmCreateEditClassification>())
            {
                form.StockEntry = this.StockEntry;

                form.ClassificationSaved += (o, classification) =>
                                            {
                                                form.Close();

                                                LoadClassifications();
                                            };
                form.ShowDialog();
            }
        }

        private void LoadClassifications()
        {
            using (var service = _serviceFactory.Create<IClassificationService>())
            {
                var classifications = service.GetByStockEntryId(StockEntry.Id);

                gvClassifications.DataSource = classifications;
            }
        }

        private void gvClassifications_CommandCellClick(object sender, EventArgs e)
        {
            var commandCell = (GridCommandCellElement)sender;

            var selectedRow = this.gvClassifications.SelectedRows.FirstOrDefault();

            if (selectedRow == null)
                return;

            var classification = selectedRow.DataBoundItem as ClassificationDto;

            if (classification == null)
                return;

            if (commandCell.ColumnInfo.Name == GlobalConstants.EditColumnName)
            {
                using (var form = FormFactory.Create<FrmCreateEditClassification>())
                {
                    form.StockEntry = this.StockEntry;
                    form.ClassificationId = classification.Id;

                    form.ClassificationSaved += (o, c) =>
                    {
                        form.Close();

                        LoadClassifications();
                    };
                    form.ShowDialog();
                }
            }
            else if (commandCell.ColumnInfo.Name == GlobalConstants.DeleteColumnName)
            {
                _messageBoxDisplayService.ShowConfirmationDialog("Esta seguro que desea eliminar esta clasificación","Eliminar Clasificación",
                    () =>
                    {
                        using (var service = _serviceFactory.Create<IClassificationService>())
                        {
                            service.Delete(classification.Id);

                            LoadClassifications();
                        }
                    });
            }
        }
    }
}
