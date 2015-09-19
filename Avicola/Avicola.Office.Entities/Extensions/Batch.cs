using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using Framework.Data.Interfaces;

namespace Avicola.Office.Entities
{
    public partial class Batch : IEntity
    {
        public int CurrentWeek
        {
            get
            {
                var daysDifference = (DateTime.Now - DateOfBirth).TotalDays;
                return Convert.ToInt32(Math.Floor(daysDifference % 7));
            }
        }

        public DateTime CalculatedPostureStartDate
        {
            get { return DateOfBirth.AddDays(GeneticLine.WeeksInBreeding * 7); }
        }

        public void AssignDatesToStandardMeasures()
        {
            foreach (var measure in this.Measures)
            {
                measure.MeasureDate = this.DateOfBirth.AddDays((measure.StandardItem.Week - 1) * 7);
                if (measure.StandardItem.Day != null)
                {
                    measure.MeasureDate = this.DateOfBirth.AddDays(measure.StandardItem.Day.GetValueOrDefault() - 1);
                }
            }
        }
    }
}
