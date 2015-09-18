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
using Avicola.Office.Entities;
using Avicola.Production.Win.Models.BatchObservations;

namespace Avicola.Production.Win.Forms.Observations
{
    public partial class FrmObservationList : EditFormBase
    {
        private readonly IServiceFactory _serviceFactory;
        private Guid _batchId;

        public FrmObservationList(IFormFactory formFactory, IServiceFactory serviceFactory, Guid batchId)
        {
            FormFactory = formFactory;
            _serviceFactory = serviceFactory;
            _batchId = batchId;
            InitializeComponent();
        }

        private void FrmObservationList_Load(object sender, EventArgs e)
        {
            using (var batchObservationService = _serviceFactory.Create<IBatchObservationService>())
            {
                var geneticLine = batchObservationService.GetAll().Where(b => b.BatchId == _batchId).OrderBy(x => x.CreatedDate).ToList();
                
            }
        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            //var form = new FrmCreateBatchObservation(_serviceFactory, _batchId);
        }

        private CreateBatchObservationModel GetBatchObservation()
        {
            var batchObservation = new CreateBatchObservationModel
            {
                
            };

            return batchObservation;
        }

        protected override void ValidateControls()
        {
            
        }

        protected override object GetEntity()
        {
            return GetBatchObservation();
        }

        public event EventHandler<BatchObservation> BatchObservationCreated;
        private void OnBatchObservationCreated(BatchObservation batchObservation)
        {
            if (BatchObservationCreated != null)
            {
                BatchObservationCreated(this, batchObservation);
            }
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
