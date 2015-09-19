using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Avicola.Production.Win.Models.Measures
{
    public class LoadWeeklyStandardMeasures
    {
        public int Week { get; set; }
        public Guid StandardItemId { get; set; }
        public Guid MeasureId { get; set; }
        public DateTime DateFrom { get; set; }
        public DateTime DateTo { get; set; }
        public decimal? Value { get; set; }
    }
}
