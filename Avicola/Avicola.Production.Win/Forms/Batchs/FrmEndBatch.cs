﻿using System;
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
using Avicola.Production.Win.Models.Batchs;

namespace Avicola.Production.Win.Forms.Batchs
{
    public partial class FrmEndBatch : EditFormBase
    {
        private readonly IServiceFactory _serviceFactory;
        private Guid _batchId;

        public FrmEndBatch(Guid id, IFormFactory formFactory, IServiceFactory serviceFactory)
        {
            FormFactory = formFactory;
            _serviceFactory = serviceFactory;
            _batchId = id;
            InitializeComponent();
        }
        
        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            var endDate = dtpEndDate.Value;
            using (var service = _serviceFactory.Create<IBatchService>())
            {
                var batch = service.GetById(_batchId);

                service.EndBatch(batch, endDate);

                OnBatchEnded(batch);
            }
            
            this.Close();
        }


        public event EventHandler<Batch> BatchEnded;
        private void OnBatchEnded(Batch batch)
        {
            if (BatchEnded != null)
            {
                BatchEnded(this, batch);
            }
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
