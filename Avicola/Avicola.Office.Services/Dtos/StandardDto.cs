using System;
using Avicola.Office.Entities;
using Framework.Common.Mapping;

namespace Avicola.Office.Services.Dtos
{
    public class StandardDto : IMapFrom<Standard>
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string MeasureUnity { get; set; }
        public Guid DataLoadTypeId { get; set; }
        public Guid StandardTypeId { get; set; }
        public DateTime CreatedDate { get; set; }
        public bool AllowDecimal { get; set; }
        public bool IsDeleted { get; set; }
    }
}
