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
        public string Name
        {
            get { return String.Format("Lote {0}", this.Number); }
        }

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
            get
            {
                var date = DateOfBirth.AddDays(GeneticLine.WeeksInBreeding * 7);
                return new DateTime(date.Year, date.Month, date.Day, 0, 0, 0);
            }
        }

    }
}
