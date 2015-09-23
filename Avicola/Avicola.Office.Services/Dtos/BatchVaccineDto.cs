using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Avicola.Office.Services.Dtos
{
    public class BatchVaccineDto
    {
        public Guid Id { get; set; }
        public Guid BatchId { get; set; }
        public Guid VaccineId { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime? RecommendedDate { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public bool IsDeleted { get; set; }
        public string VaccineName { get; set; }
    }
}
