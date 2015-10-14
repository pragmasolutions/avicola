using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Avicola.Office.Entities;
using Framework.Common.Mapping;

namespace Avicola.Office.Services.Dtos
{
    public class BatchBarnDto : IMapFrom<BatchBarn>
    {
        public System.Guid Id { get; set; }
        public System.Guid BatchId { get; set; }
        public System.Guid BarnId { get; set; }
        public System.DateTime CreatedDate { get; set; }
        public int InitialBirds { get; set; }
        public decimal StartingFood { get; set; }
        public System.Guid FoodClassId { get; set; }
        public bool IsDeleted { get; set; }

        public Barn Barn { get; set; }
        public FoodClass FoodClass { get; set; }
    }
}
