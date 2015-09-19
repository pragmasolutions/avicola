using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Avicola.Production.Win.Models.Measures
{
    public class LoadDailyStandardMeasures
    {
        public int Week { get; set; }
        public IList<DailyStandardMeasure> DailyStandardMeasures { get; set; }
    }

    public class DailyStandardMeasure
    {
        public Guid StandardItemId { get; set; }
        public Guid MeasureId { get; set; }
        public int Day { get; set; }
        public DateTime Date { get; set; }
        public decimal? Value { get; set; }
    }
}
