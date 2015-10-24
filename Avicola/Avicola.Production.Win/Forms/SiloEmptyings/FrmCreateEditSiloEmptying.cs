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
using Avicola.Production.Win.Infrastructure;
using Framework.Common.Helpers;
namespace Avicola.Production.Win.Forms.SiloEmptyings
{
    public partial class FrmCreateEditSiloEmptying : EditFormBase
    {
        private readonly IStateController _stateController;
        private readonly IServiceFactory _serviceFactory;
        private Guid _emptyingId = Guid.Empty;
        private Batch _batch;
        private SiloEmptying _siloEmptying;

        public FrmCreateEditSiloEmptying(Guid id, IFormFactory formFactory, IStateController stateController, IServiceFactory serviceFactory)
        {
            FormFactory = formFactory;
            _serviceFactory = serviceFactory;
            _stateController = stateController;
            _emptyingId = id;
            InitializeComponent();
        }

        private void FrmCreateEditSiloEmptying_Load(object sender, EventArgs e)
        {
            var formTitle = "";

            using (var batchService = _serviceFactory.Create<IBatchService>())
            {
                _batch = batchService.GetById(_stateController.CurrentSelectedBatch.Id);
                dtpDate.Value = DateTime.Now;
                formTitle = "Registrar Vaciamiento de Silo";
            }

            if (_emptyingId != Guid.Empty)
            {
                using (var service = _serviceFactory.Create<ISiloEmptyingService>())
                {
                    _siloEmptying = service.GetById(_emptyingId);
                    dtpDate.Value = _siloEmptying.Date;
                    formTitle = "Editar Vaciamiento de Silo";
                }
            }

            this.Text = formTitle;
            txtBatchName.Text = String.Format("Lote {0}", _stateController.CurrentSelectedBatch.Number);
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            var esValido = this.ValidarForm();
            if (FormErrorProvider.GetError(dtpDate) != "")
                esValido = false;

            if (!esValido)
            {
                this.DialogResult = DialogResult.None;
            }
            else
            {
                using (var service = _serviceFactory.Create<ISiloEmptyingService>())
                {
                    var validDate = service.VerifyDate(_batch.Id, dtpDate.Value.ToZeroTime(), _emptyingId);
                    if (!validDate)
                    {
                        this.FormErrorProvider.SetError(dtpDate, "Ya existe un vaciamiento de silo registrado para la fecha ingresada");
                        this.DialogResult = DialogResult.None;
                    }
                    else
                    {
                        if (_emptyingId == Guid.Empty)
                        {
                            var siloEmptying = GetSiloEmptyingCreate();
                            service.Create(siloEmptying);

                            OnSiloEmptyingCreated(siloEmptying);
                        }
                        else
                        {
                            GetSiloEmptyingEdit();
                            service.Edit(_siloEmptying);
                            OnSiloEmptyingCreated(_siloEmptying);
                        }
                        this.Close();
                    }
                }
            }
        }

        private void GetSiloEmptyingEdit()
        {
            _siloEmptying.Date = dtpDate.Value.ToZeroTime();
        }

        private SiloEmptying GetSiloEmptyingCreate()
        {
            var siloEmptying = new SiloEmptying()
            {
                Id = Guid.NewGuid(),
                CreatedDate = DateTime.Now,
                Date = dtpDate.Value.ToZeroTime(),
                IsDeleted = false,
                BatchId = _stateController.CurrentSelectedBatch.Id
            };

            return siloEmptying;
        }

        protected override void ValidateControls()
        {
            if (_batch.PostureDate == null)
            {
                this.FormErrorProvider.SetError(dtpDate, "El lote todavía no se encuentra en la etapa de postura.");
            } 
            else if (_batch.PostureDate > dtpDate.Value)
            {
                this.FormErrorProvider.SetError(dtpDate, "Solo pueden registrarse vaciamientos para dias correspondientes a la etapa de postura");
            }
        }

        protected override object GetEntity()
        {
            return GetSiloEmptyingCreate();
        }

        public event EventHandler<SiloEmptying> SiloEmptyingCreated;
        private void OnSiloEmptyingCreated(SiloEmptying siloEmptying)
        {
            if (SiloEmptyingCreated != null)
            {
                SiloEmptyingCreated(this, siloEmptying);
            }
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
