using System;
using Avicola.Office.Entities;
using Framework.Common.Mapping;

namespace Avicola.Office.Services.Dtos
{
    public class BatchObservationDto : IMapFrom<BatchObservation>
    {
        public System.Guid Id { get; set; }
        public System.DateTime CreatedDate { get; set; }
        public System.DateTime ObservationDate { get; set; }
        public int Week { get; set; }
        public int Day { get; set; }        
        public string Content { get; set; }              
    }
}
