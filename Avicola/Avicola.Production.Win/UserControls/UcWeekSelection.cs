using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Avicola.Production.Win.UserControls
{
    public partial class UcWeekSelection : UserControl
    {
        private int _current;
        private int _numberOfWeeks;

        public event EventHandler<int> CurrentWeekChanged;

        public UcWeekSelection()
        {
            InitializeComponent();
        }

        public int Current
        {
            get { return _current; }
            set
            {
                if (value <= 0 && value > _numberOfWeeks)
                {
                    return;
                }

                _current = value;

                lbCurrent.Text = _current.ToString();

                btnPrevious.Enabled = _current > 1;
                btnNext.Enabled = _current < _numberOfWeeks;

                OnCurrentWeekChanged(_current);
            }
        }

        public int NumberOfWeek 
        {
            get { return _numberOfWeeks; }
            set
            {
                if (Current >= _numberOfWeeks)
                {
                    Current = _numberOfWeeks;
                }

                _numberOfWeeks = value;
            }
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            var newCurrent = _current - 1;

            if (newCurrent > 0)
            {
                Current = newCurrent;
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            var newCurrent = _current + 1;

            if (newCurrent < _numberOfWeeks)
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
