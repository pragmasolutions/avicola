using Framework.Common.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Avicola.Office.Entities;

namespace Avicola.Office.Services.DTO
{
    public class StandardGeneticLineDto : IMapFrom<StandardGeneticLine>
    {
        public Guid Id { get; set; }
        public Guid StandardId { get; set; }
        public Guid GeneticLineId { get; set; }
        public DateTime CreatedDate { get; set; }
        public bool IsDeleted { get; set; }
    }
}
