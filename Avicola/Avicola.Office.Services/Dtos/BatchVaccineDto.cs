using Avicola.Office.Entities;
using Framework.Common.Mapping;
using System;

namespace Avicola.Office.Services.Dtos
{
    public class BatchVaccineDto : IMapFrom<BatchVaccine>
    {
        public Guid Id { get; set; }
        public Guid BatchId { get; set; }
        public Guid VaccineId { get; set; }
        public DateTime CreatedDate { get; set; }        
        public DateTime StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public bool IsDeleted { get; set; }
        public string VaccineName { get; set; }
        public int Week { get; set; }
        public int Day { get; set; }     
    }
}
