using System;
using Avicola.Sales.Entities;
using Framework.Common.Mapping;

namespace Avicola.Sales.Services.Dtos
{
    public class OrderDto : IMapFrom<Order>
    {
        public System.Guid Id { get; set; }
        public string ClientName { get; set; }
        public string OrderStatusName { get; set; }
        public string PreparedDate { get; set; }
        public string CreatedDate { get; set; }
    }
}
