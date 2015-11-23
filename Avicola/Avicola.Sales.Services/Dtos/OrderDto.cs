using System;
using Avicola.Sales.Entities;
using Framework.Common.Mapping;

namespace Avicola.Sales.Services.Dtos
{
    public class OrderDto : IMapFrom<Order>
    {
        public System.Guid Id { get; set; }
        public string ClientName { get; set; }
        public Guid OrderStatusId { get; set; }
        public string OrderStatusName { get; set; }
        public DateTime? PreparedDate { get; set; }
        public DateTime CreatedDate { get; set; }
        public int Dozens { get; set; }
    }
}
