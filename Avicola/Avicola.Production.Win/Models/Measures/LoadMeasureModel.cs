using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Avicola.Production.Win.Models.Measures
{
    public class LoadMeasureModel
    {
        public string Name { get; set; }
        public string MeasureUnity { get; set; }
        public System.DateTime CreatedDate { get; set; }
        public System.Guid BatchId { get; set; }
        public decimal Value { get; set; }
    }
}
