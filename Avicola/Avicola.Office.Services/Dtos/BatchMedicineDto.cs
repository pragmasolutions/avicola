using Avicola.Office.Entities;
using Framework.Common.Mapping;
using System;

namespace Avicola.Office.Services.Dtos
{
    public class BatchMedicineDto : IMapFrom<BatchMedicine>
    {
        public Guid Id { get; set; }
        public Guid BatchId { get; set; }
        public Guid MedicineId { get; set; }
        public DateTime CreatedDate { get; set; }        
        public DateTime StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public bool IsDeleted { get; set; }
        public string MedicineName { get; set; }
        public string Observation { get; set; }
    }
}
