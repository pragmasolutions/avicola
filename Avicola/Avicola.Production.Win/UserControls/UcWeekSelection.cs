using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Avicola.Production.Win.Properties;

namespace Avicola.Production.Win.UserControls
{
    public partial class UcWeekSelection : UserControl
    {
        private int _current;
        //private int _numberOfWeeks;

        public event EventHandler<int> CurrentWeekChanged;

        public UcWeekSelection()
        {
            InitializeComponent();
        }

        public int MinWeekNumber { get; set; }

        public int MaxWeekNumber { get; set; }  

        public int Current
        {
            get { return _current; }
            set
            {
                if (value < MinWeekNumber && value > MaxWeekNumber)
                {
                    return;
                }

                _current = value;

                lbCurrent.Text = Resources.Week + ": " + _current.ToString();

                btnPrevious.Enabled = _current > MinWeekNumber;
                btnNext.Enabled = _current < MaxWeekNumber;

                OnCurrentWeekChanged(_current);
            }
        }

        //public int NumberOfWeek 
        //{
        //    get { return _numberOfWeeks; }
        //    set
        //    {
        //        //if (Current >= MaxWeekNumber)
        //        //{
        //        //    Current = MaxWeekNumber;
        //        //}

        //        _numberOfWeeks = value;
        //    }
        //}

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            var newCurrent = _current - 1;

            if (newCurrent >= MinWeekNumber)
            {
                Current = newCurrent;
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            var newCurrent = _current + 1;

            if (newCurrent <= MaxWeekNumber)
            {
                Current = newCurrent;
            }
        }

        private void OnCurrentWeekChanged(int currentWeek)
        {
            if (CurrentWeekChanged != null)
            {
                CurrentWeekChanged(this, currentWeek);
            }
        }
    }
}
