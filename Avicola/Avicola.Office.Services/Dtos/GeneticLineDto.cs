using System;
using Avicola.Office.Entities;
using Framework.Common.Mapping;

namespace Avicola.Office.Services.Dtos
{
    public class GeneticLineDto : IMapFrom<GeneticLine>
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public int ProductionWeeks { get; set; }
        public DateTime CreatedDate { get; set; }
        public bool IsDeleted { get; set; }
    }
}
