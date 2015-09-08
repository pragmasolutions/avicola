using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Avicola.Common.Win;
using Avicola.Production.Win.Forms.Measure;
using Avicola.Production.Win.Forms.Measure.History;
using Framework.Data.Repository;
using Ninject.Extensions.Conventions.Syntax;
using Telerik.WinControls;

namespace Avicola.Production.Win.Forms
{
    public partial class FrmPrincipal : FrmBase
    {
        public FrmPrincipal(IFormFactory formFactory)
        {
            FormFactory = formFactory;
            InitializeComponent();
        }

        private void BtnMedidas_Click(object sender, EventArgs e)
        {
            OpenCreateMeasureWizard();
        }

        private void BtnMeassureHistory_Click(object sender, EventArgs e)
        {
            OpenMeasuresHistory();
        }

        private void miCreateMeasures_Click(object sender, EventArgs e)
        {
            OpenCreateMeasureWizard();
        }

        private void miMeasuresHistory_Click(object sender, EventArgs e)
        {
            OpenMeasuresHistory();
        }

        private void OpenCreateMeasureWizard()
        {
            var form = Application.OpenForms.OfType<FrmCreateMeasureWizard>().FirstOrDefault();
            if (form != null)
            {
                form.Activate();
            }
            else
            {
                var meassureWizard = FormFactory.Create<FrmCreateMeasureWizard>();
                meassureWizard.Show();
            }
        }
        private void OpenMeasuresHistory()
        {
            var form = Application.OpenForms.OfType<FrmMeasureHistory>().FirstOrDefault();
            if (form != null)
            {
                form.Activate();
            }
            else
            {
                var meassureHistory = FormFactory.Create<FrmMeasureHistory>();
                meassureHistory.Show();
            }
        }
    }
}
