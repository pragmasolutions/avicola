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
        public int InitialBirds { get; set; }
        public string BarnName { get; set; }
        public string BarnStageName { get; set; }
        public Guid BarnStageId { get; set; }
    }
}
