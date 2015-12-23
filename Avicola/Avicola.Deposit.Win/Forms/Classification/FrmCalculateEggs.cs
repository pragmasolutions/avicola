using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Avicola.Sales.Services.Dtos;
using Avicola.Sales.Services.Interfaces;
using Framework.WinForm.Comun.Notification;
using IServiceFactory = Avicola.Services.Common.Interfaces.IServiceFactory;

namespace Avicola.Deposit.Win.Forms
{
    public partial class FrmCalculateEggs : EditFormBase
    {
        private readonly IMessageBoxDisplayService _messageBoxDisplayService;

        public FrmCalculateEggs(IMessageBoxDisplayService messageBoxDisplayService)
        {
            _messageBoxDisplayService = messageBoxDisplayService;
            InitializeComponent();
        }

        public event EventHandler<int> EggsCalculated;

        private void btnFinishOrder_Click(object sender, EventArgs e)
        {
            OnEggsCalculated(ucEggsAmount.TotalEggs);
        }

        private void OnEggsCalculated(int calculatedEggs)
        {
            if (EggsCalculated != null)
            {
                EggsCalculated(this, calculatedEggs);
            }
        }
    }
}
