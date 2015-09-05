using System;
using Avicola.Office.Entities;
using Framework.Common.Mapping;

namespace Avicola.Office.Services.Dtos
{
    public class MeasureDto : IMapFrom<Measure>
    {
        public System.Guid Id { get; set; }
        public System.DateTime CreatedDate { get; set; }
        public System.Guid BatchId { get; set; }
        public System.Guid StandardItemId { get; set; }
        public decimal Value { get; set; }
        public bool IsDeleted { get; set; }

        public virtual Batch Batch { get; set; }
        public virtual StandardItem StandardItem { get; set; }
    }
}
