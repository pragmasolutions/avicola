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
    public partial class UcLoadWeeklyMeasures : UserControl
    {
        private IList<LoadWeeklyStandardMeasures> _loadWeeklyStandardMeasures;
        private LoadWeeklyStandardMeasures _currentWeeklyStandardMeasures;

        public UcLoadWeeklyMeasures()
        {
            InitializeComponent();
        }

        public event EventHandler SaveClick;

        public bool IsDirty { get; set; }

        public decimal? MeasureValue
        {
            get
            {
                decimal value;
                if (decimal.TryParse(txtValue.Text, out value))
                {
                    return value;
                }
                return null;
            }
            set { txtValue.Text = value.HasValue ? value.Value.ToString("n2") : string.Empty; }
        }

        public IList<LoadWeeklyStandardMeasures> LoadWeeklyStandardMeasures
        {
            get { return _loadWeeklyStandardMeasures; }
            set
            {
                if (value == null || !value.Any())
                {
                    return;
                }

                _loadWeeklyStandardMeasures = value;

                var firstWeek = _loadWeeklyStandardMeasures.First();

                ucWeekSelection.MinWeekNumber = _loadWeeklyStandardMeasures.Min(x => x.Week);
                ucWeekSelection.MaxWeekNumber = _loadWeeklyStandardMeasures.Max(x => x.Week);
                ucWeekSelection.Current = firstWeek.Week;

                UpdateCurrentDailyStandardMeasure(firstWeek);
            }
        }

        public int CurrentWeek
        {
            set { ucWeekSelection.Current = value; }
        }

        private void UpdateCurrentDailyStandardMeasure(LoadWeeklyStandardMeasures weeklyStandardMeasure)
        {
            _currentWeeklyStandardMeasures = weeklyStandardMeasure;

            txtDateFrom.Text = weeklyStandardMeasure.DateFrom.ToShortDateString();
            txtDateTo.Text = weeklyStandardMeasure.DateTo.ToShortDateString();
            MeasureValue = weeklyStandardMeasure.Value;

            if (DateTime.Today.Date < weeklyStandardMeasure.DateFrom.Date)
            {
                txtValue.Enabled = false;
            }
            else
            {
                txtValue.Enabled = true;
            }
        }

        private void ucWeekSelection_CurrentWeekChanged(object sender, int e)
        {
            if (_currentWeeklyStandardMeasures != null && ucWeekSelection.Current != _currentWeeklyStandardMeasures.Week)
            {
                var newWeek = _loadWeeklyStandardMeasures.First(x => x.Week == ucWeekSelection.Current);

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

        private void txtValue_TextChanged(object sender, EventArgs e)
        {
            _currentWeeklyStandardMeasures.Value = MeasureValue;
        }
    }
}
