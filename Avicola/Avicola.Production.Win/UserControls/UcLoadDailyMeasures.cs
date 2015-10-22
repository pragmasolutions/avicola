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
using Avicola.Office.Services.Interfaces;
using Avicola.Production.Win.Infrastructure;
using Avicola.Production.Win.Models.Measures;
using Avicola.Production.Win.Properties;
using Telerik.WinControls.UI;

namespace Avicola.Production.Win.UserControls
{
    public partial class UcLoadDailyMeasures : UserControl
    {
        private readonly IStateController _stateController;
        private IList<LoadDailyStandardMeasures> _loadDailyStandardMeasures;
        private LoadDailyStandardMeasures _currentDailyStandardMeasure;

        

        public UcLoadDailyMeasures(IServiceFactory serviceFactory, IStateController stateController)
        {
            _stateController = stateController;
            _serviceFactory = serviceFactory;
            InitializeComponent();
            gvDailyMeasures.TableElement.RowHeight = GlobalConstants.DefaultRowHeight;
        }

        public event EventHandler SaveClick;

        public bool IsDirty { get; set; }

        public Standard Standard { get; set; }

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

                ucWeekSelection.MinWeekNumber = _loadDailyStandardMeasures.Min(x => x.Week);
                ucWeekSelection.MaxWeekNumber = _loadDailyStandardMeasures.Max(x => x.Week);

                ucWeekSelection.Current = firstWeek.Week;

                UpdateCurrentDailyStandardMeasure(firstWeek);
                
                UpdateTotal();
            }
        }

        public int CurrentWeek
        {
            set { ucWeekSelection.Current = value; }
        }

        private void UpdateCurrentDailyStandardMeasure(LoadDailyStandardMeasures firstWeek)
        {
            _currentDailyStandardMeasure = firstWeek;

            gvDailyMeasures.DataSource = firstWeek.DailyStandardMeasures;

            ShowHideFoodClassColumn();
        }

        private void ShowHideFoodClassColumn()
        {
            if (this.Standard.Id != Standard.FoodEntry)
            {
                gvDailyMeasures.Columns["FoodClassId"].IsVisible = false;
            }
        }

        private void ucWeekSelection_CurrentWeekChanged(object sender, int e)
        {
            if (_currentDailyStandardMeasure != null && ucWeekSelection.Current != _currentDailyStandardMeasure.Week)
            {
                var newWeek = _loadDailyStandardMeasures.First(x => x.Week == ucWeekSelection.Current);

                UpdateCurrentDailyStandardMeasure(newWeek);

                UpdateTotal();
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
            decimal total = 0;

            if (Standard.AggregateOperation == GlobalConstants.SumAggregateOperation || string.IsNullOrEmpty(Standard.AggregateOperation))
            {
                lbAggregate.Text = Resources.Total;
                total = _currentDailyStandardMeasure.DailyStandardMeasures.Sum(x => x.Value ?? 0);
            }
            else if (Standard.AggregateOperation == GlobalConstants.AvgAggregateOperation)
            {
                lbAggregate.Text = Resources.Average;
                total = _currentDailyStandardMeasure.DailyStandardMeasures.Average(x => x.Value ?? 0);
            }

            txtTotal.Text = total.ToString("n2");
        }

        private void gvDailyMeasures_CellValueChanged(object sender, Telerik.WinControls.UI.GridViewCellEventArgs e)
        {
            IsDirty = true;

            UpdateTotal();
        }

        private void gvDailyMeasures_CellBeginEdit(object sender, Telerik.WinControls.UI.GridViewCellCancelEventArgs e)
        {
            var measure = e.Row.DataBoundItem as DailyStandardMeasure;

            if (measure != null)
            {
                var editMeasure = measure.Date.Date <= DateTime.Today && (e.Column.Name == "Value" || e.Column.Name == "FoodClassId") && measure.Date >= _stateController.CurrentSelectedBatch.CurrentBatchStartDate;

                if (!editMeasure)
                {
                    e.Cancel = true;
                }
                else if (e.Column.Name == "FoodClassId")
                {
                    var value = e.Row.Cells["Value"].Value;
                    if (value == null)
                    {
                        e.Cancel = true;
                    }
                }
            }
        }

        private void UcLoadDailyMeasures_Load(object sender, EventArgs e)
        {
            var dropdown = gvDailyMeasures.Columns["FoodClassId"] as GridViewComboBoxColumn;
            dropdown.DataSource = FoodClasses;
            dropdown.ValueMember = "Id";
            dropdown.DisplayMember = "Name";
        }
    }
}
