using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Avicola.Common.Win;
using Avicola.Production.Win.Forms.Measure;
using Avicola.Production.Win.Forms.Measure.History;
using Framework.Data.Repository;
using Telerik.WinControls;

namespace Avicola.Production.Win.Forms
{
    public partial class FrmPrincipal : FrmBase
    {
        public FrmPrincipal(IFormFactory formFactory)
        {
            FormFactory = formFactory;
            //Uow = uow;
            //UowFactory = uowFactory;
            InitializeComponent();
        }

        private void BtnMedidas_Click(object sender, EventArgs e)
        {
            
            var meassureWizard = FormFactory.Create<FrmCreateMeasureWizard>();
            meassureWizard.Show();
            
        
        }

        private void BtnMeassureHistory_Click(object sender, EventArgs e)
        {
            var meassureHistory = FormFactory.Create<FrmMeasureHistory>();
            meassureHistory.Show();
        }
    }
}
