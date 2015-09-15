using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Avicola.Common.Win;
using Avicola.Office.Services.Dtos;
using Avicola.Office.Services.Interfaces;
using Framework.Data.Helpers;
using Telerik.WinControls;
using System.Linq;

namespace Avicola.Production.Win.Forms.Batch
{
    public partial class FrmCreateBatch : FrmBase
    {
        private readonly IServiceFactory _serviceFactory;
        private BatchDto _selectedBatch;
        private IList<LoadMeasureModel> _newMeasures;

        public FrmCreateBatch(IFormFactory formFactory, IServiceFactory serviceFactory)
        {
            FormFactory = formFactory;
            _serviceFactory = serviceFactory;
            InitializeComponent();
        }

        private void FrmCreateBatch_Load(object sender, EventArgs e)
        {
            using (var geneticLineService = _serviceFactory.Create<IGeneticLineService>())
            {
                var geneticLine = geneticLineService.GetAll().OrderBy(x => x.Name).ToList();
                ddlGeneticLine.ValueMember = "Id";
                ddlGeneticLine.DisplayMember = "Name";
                ddlGeneticLine.DataSource = geneticLine;
            }

            using (var foodClassService = _serviceFactory.Create<IFoodClassService>())
            {
                var foodClass = foodClassService.GetAll().OrderBy(x => x.Name).ToList();
                ddlFoodClass.ValueMember = "Id";
                ddlFoodClass.DisplayMember = "Name";
                ddlFoodClass.DataSource = foodClass;
            }
        }
    }
}
