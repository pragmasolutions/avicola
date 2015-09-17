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
                if (!value.Any())
                {
                    return;
                }

                _loadDailyStandardMeasures = value;

                ucWeekSelection.Current = 1;
                ucWeekSelection.NumberOfWeek = _loadDailyStandardMeasures.Count;

                var firstWeek = _loadDailyStandardMeasures.First();

                UpdateCurrentDailyStandardMeasure(firstWeek);
            }
        }

        private void UpdateCurrentDailyStandardMeasure(LoadDailyStandardMeasures firstWeek)
        {
            _currentDailyStandardMeasure = firstWeek;

            gvDailyMeasures.DataSource = firstWeek.DailyStandardMeasures;
        }

        private void ucWeekSelection_CurrentWeekChanged(object sender, int e)
        {
            if (ucWeekSelection.Current != _currentDailyStandardMeasure.Week)
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
    }
}
