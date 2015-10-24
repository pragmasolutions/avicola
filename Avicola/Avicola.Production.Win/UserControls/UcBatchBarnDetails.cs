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
    public partial class UcBatchBarnDetails : UserControl
    {
        public UcBatchBarnDetails()
        {
            InitializeComponent();
        }

        public BatchBarnDetailDto BatchBarnDetail
        {
            set
            {
                lbBatchBarnTitle.Text = value.StageDetails;
                gvBatchBarns.DataSource = value.BatchBarns;
            }
        }
    }
}
