using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Avicola.Office.Services.Dtos
{
    public partial class UpdateMeasureDto
    {
        public System.Guid Id { get; set; }
        public System.Guid BatchId { get; set; }
        public System.Guid StandardItemId { get; set; }
        public decimal? Value { get; set; }
        public Guid? FoodClassId { get; set; }
        public DateTime? Date { get; set; }
    }
}
