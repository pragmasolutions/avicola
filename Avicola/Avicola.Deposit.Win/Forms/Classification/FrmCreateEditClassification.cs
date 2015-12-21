using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Avicola.Common.Win;
using Avicola.Deposit.Win.Properties;
using Avicola.Deposit.Win.UserControls;
using Avicola.Sales.Entities;
using Avicola.Sales.Services.Dtos;
using Avicola.Sales.Services.Interfaces;
using Framework.WinForm.Comun.Notification;
using IServiceFactory = Avicola.Services.Common.Interfaces.IServiceFactory;

namespace Avicola.Deposit.Win.Forms
{
    public partial class FrmCreateEditClassification : EditFormBase
    {
        private readonly IServiceFactory _serviceFactory;
        private readonly IMessageBoxDisplayService _messageBoxDisplayService;

        public FrmCreateEditClassification(IServiceFactory serviceFactory, IMessageBoxDisplayService messageBoxDisplayService)
        {
            _serviceFactory = serviceFactory;
            _messageBoxDisplayService = messageBoxDisplayService;

            InitializeComponent();
        }

        public EventHandler<Classification> ClassificationSaved;

        public Guid ClassificationId { get; set; }
        public Classification Classification { get; set; }
        public StockEntryDto StockEntry { get; set; }

        private void FrmCreateEditClassification_Load(object sender, EventArgs e)
        {
            Classification = new Classification();

            if (ClassificationId != Guid.Empty)
            {
                using (var classificationService = _serviceFactory.Create<IClassificationService>())
                {
                    Classification = classificationService.GetById(ClassificationId);
                }

                this.Text = Resources.EditClassification;
                this.lbTitle.Text = Resources.EditClassification;

                dpClassificationDate.Value = Classification.ClassificationDate;
            }
            else
            {
                this.Text = Resources.CreateClassification;
                this.lbTitle.Text = Resources.CreateClassification;

                dpClassificationDate.Value = DateTime.Today;
            }

            LoadClassificationEggClasses();
        }

        private void LoadClassificationEggClasses()
        {
            using (var classificationEggClassService = _serviceFactory.Create<IEggClassService>())
            {
                var classificationEggClasses = classificationEggClassService.GetAll();

                using (var eggEquivalenceService = _serviceFactory.Create<IEggEquivalenceService>())
                {
                    var eggEquivalences = eggEquivalenceService.GetAll();

                    foreach (var eggClass in classificationEggClasses)
                    {
                        var control = new UcClassificationEggClassEditor();

                        control.EggEquivalences = eggEquivalences;

                        control.EggClass = eggClass;

                        var currentClassificationClass =
                            Classification.ClassificationEggClasses.FirstOrDefault(x => x.EggClassId == eggClass.Id);

                        if (currentClassificationClass != null)
                        {
                            control.ClassificationEggClass = currentClassificationClass;
                        }

                        ClassificationEggClassesesContainer.Controls.Add(control);
                    }
                }
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            //Validation.
            foreach (UcClassificationEggClassEditor control in ClassificationEggClassesesContainer.Controls)
            {
                if (control.Amount > 0)
                {
                    Classification.ClassificationEggClasses.Add(control.ClassificationEggClass);
                }
            }

            if (Classification.ClassificationEggClasses.Sum(x => x.Amount) == 0)
            {
                Classification.ClassificationEggClasses.Clear();

                _messageBoxDisplayService.ShowWarning("La cantidad de huevos a clasificar no puede ser 0. por favor verifique los valores ingresados");

                return;
            }

            Classification.ClassificationDate = dpClassificationDate.Value;

            Classification.StockEntryId = StockEntry.Id;

            using (var service = _serviceFactory.Create<IClassificationService>())
            {
                service.Save(Classification);

                OnClassificationSaved(Classification);
            }
        }

        private void OnClassificationSaved(Classification classification)
        {
            if (ClassificationSaved != null)
            {
                ClassificationSaved(this, classification);
            }
        }
    }
}
