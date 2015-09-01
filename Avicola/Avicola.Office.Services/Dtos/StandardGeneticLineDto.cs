using System;
using Avicola.Office.Entities;
using Framework.Common.Mapping;

namespace Avicola.Office.Services.Dtos
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
