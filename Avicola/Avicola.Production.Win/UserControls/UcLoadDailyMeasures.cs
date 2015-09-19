using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using Avicola.Office.Entities;
using Avicola.Production.Win.Models.Measures;

namespace Avicola.Production.Win.UserControls
{
    public partial class UcLoadDailyMeasures : UserControl
    {
        private IList<LoadDailyStandardMeasures> _loadDailyStandardMeasures;
        private LoadDailyStandardMeasures _currentDailyStandardMeasure;

        public UcLoadDailyMeasures()
        {
            InitializeComponent();
        }

        public event EventHandler SaveClick;

        public IList<LoadDailyStandardMeasures> LoadDailyStandardMeasures
        {
            get { return _loadDailyStandardMeasures; }
            set
            {
                if (value == null || !value.Any())
                {
                    return;
                }

                _loadDailyStandardMeasures = value;

                var firstWeek = _loadDailyStandardMeasures.First();

                ucWeekSelection.NumberOfWeek = _loadDailyStandardMeasures.Count;
                ucWeekSelection.Current = firstWeek.Week;

                UpdateCurrentDailyStandardMeasure(firstWeek);

                UpdateTotal();
            }
        }

        private void UpdateCurrentDailyStandardMeasure(LoadDailyStandardMeasures firstWeek)
        {
            _currentDailyStandardMeasure = firstWeek;

            gvDailyMeasures.DataSource = firstWeek.DailyStandardMeasures;
        }

        private void ucWeekSelection_CurrentWeekChanged(object sender, int e)
        {
            if (_currentDailyStandardMeasure != null && ucWeekSelection.Current != _currentDailyStandardMeasure.Week)
            {
                var newWeek = _loadDailyStandardMeasures.First(x => x.Week == ucWeekSelection.Current);

                UpdateCurrentDailyStandardMeasure(newWeek);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            OnSaveClick();
        }

        private void OnSaveClick()
        {
            if (SaveClick != null)
            {
                SaveClick(this, new EventArgs());
            }
        }

        private void UpdateTotal()
        {
            var total = LoadDailyStandardMeasures.SelectMany(x => x.DailyStandardMeasures).Sum(x => x.Value ?? 0);
            txtTotal.Text = total.ToString("n2");
        }

        private void gvDailyMeasures_CellValueChanged(object sender, Telerik.WinControls.UI.GridViewCellEventArgs e)
        {
            UpdateTotal();
        }
    }
}
