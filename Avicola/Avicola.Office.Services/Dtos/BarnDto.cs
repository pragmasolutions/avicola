using System;
using Avicola.Office.Entities;
using Framework.Common.Mapping;

namespace Avicola.Office.Services.Dtos
{
    public class BarnDto : IMapFrom<Barn>
    {
        public System.Guid Id { get; set; }
        public System.DateTime CreatedDate { get; set; }
        public int Number { get; set; }
        public int? Capacity { get; set; }
    }
}
