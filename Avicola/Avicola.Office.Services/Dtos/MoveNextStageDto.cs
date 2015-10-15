using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Avicola.Office.Services.Dtos
{
    public class MoveNextStageDto
    {
        public MoveNextStageDto()
        {
            BarnsAssigned = new List<BarnsAssignedDto>();
        }

        public Guid BatchId { get; set; }

        public DateTime NextStageStartDate { get; set; }

        public IList<BarnsAssignedDto> BarnsAssigned { get; set; }
    }

    public class BarnsAssignedDto
    {
        public Guid BarnId { get; set; }

        public decimal InitialBirds { get; set; }

        public decimal StartingFood { get; set; }
    }
}
