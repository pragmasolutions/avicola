using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Avicola.Office.Entities;

namespace Avicola.Production.Win.UserControls
{
    public partial class UcStageSelection : UcSelectionBaseControl
    {
        public UcStageSelection()
        {
            InitializeComponent();
        }

        public IList<Stage> Stages
        {
            set
            {
                ddlStages.ValueMember = "Id";
                ddlStages.DisplayMember = "Name";
                ddlStages.DataSource = value;
            }
        }

        public EventHandler<Stage> StageSelected;

        public Stage SelectedStage
        {
            get { return ddlStages.SelectedItem.DataBoundItem as Stage; } 
        }

        protected void OnStageSelected(Stage item)
        {
            if (StageSelected != null)
            {
                StageSelected(this, item);
            }
        }

        private void ddlStages_SelectedValueChanged(object sender, EventArgs e)
        {
            OnStageSelected(SelectedStage);
        }
    }
}
