using Framework.Common.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Avicola.Office.Entities.DTO
{
    public class GeneticLineDto : IMapFrom<GeneticLineDto>
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public int ProductionWeeks { get; set; }
        public DateTime CreatedDate { get; set; }
    }
}
