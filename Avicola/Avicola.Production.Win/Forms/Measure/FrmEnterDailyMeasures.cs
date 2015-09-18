using System;
using System.Linq;
using System.Windows.Forms;
using Avicola.Common.Win;
using Avicola.Office.Entities;
using Avicola.Office.Services.Dtos;
using Avicola.Office.Services.Interfaces;
using Avicola.Production.Win.Forms.Batchs;
using Avicola.Production.Win.Infrastructure;
using Telerik.WinControls.UI;

namespace Avicola.Production.Win.Forms.Measure
{
    public partial class FrmEnterDailyMeasures : FrmBase
    {
        private readonly IServiceFactory _serviceFactory;
        private readonly IStateController _stateController;

        public FrmEnterDailyMeasures(IFormFactory formFactory, IServiceFactory serviceFactory, IStateController stateController)
        {
            FormFactory = formFactory;

            _serviceFactory = serviceFactory;
            _stateController = stateController;

            InitializeComponent();
        }
    }
}
