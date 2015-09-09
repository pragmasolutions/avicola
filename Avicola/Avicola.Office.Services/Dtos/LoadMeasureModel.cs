using System;

namespace Avicola.Office.Services.Dtos
{
    public class LoadMeasureModel 
    {
        public Guid StandardId { get; set; }
        public string Name { get; set; }                    
        public string MeasureUnity { get; set; }
        public System.DateTime? CreatedDate { get; set; }
        public System.Guid BatchId { get; set; }
        public decimal? Value { get; set; }
    }
}
