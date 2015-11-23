using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Avicola.Services.Common.Interfaces;

namespace Avicola.Deposit.Win.Forms
{
    public partial class FrmBuildOrder : EditFormBase
    {
        private readonly IServiceFactory _serviceFactory;

        public FrmBuildOrder(IServiceFactory serviceFactory)
        {
            _serviceFactory = serviceFactory;
            InitializeComponent();
        }

        private void btnBuildOrder_Click(object sender, EventArgs e)
        {

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {

        }
    }
}
