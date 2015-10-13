using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Avicola.Office.Services.Dtos;

namespace Avicola.Production.Win.UserControls
{
    public partial class UcLoadMeasuresSummary : UserControl
    {
        public UcLoadMeasuresSummary()
        {
            InitializeComponent();
        }

        public BatchDto Batch
        {
            set
            {
                lbNumber.Text = value.Number.ToString();
                lbGeneticLineName.Text = value.GeneticLineName;
                lbStageName.Text = value.StageName;
            }
        }
    }
}
