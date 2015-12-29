using System;
using System.Collections.Generic;
using AutoMapper;
using Avicola.Sales.Entities;
using Framework.Common.Mapping;

namespace Avicola.Sales.Services.Dtos
{
    public class OrderDto : IMapFrom<Order>
    {
        public System.Guid Id { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string PhoneNumber { get; set; }
        public Guid ClientId { get; set; }
        public string ClientName { get; set; }
        public Guid OrderStatusId { get; set; }
        public string OrderStatusName { get; set; }
        public DateTime? PreparedDate { get; set; }
        public DateTime CreatedDate { get; set; }
        public int Dozens { get; set; }
        public DateTime? DispatchedDate { get; set; }
        public string DriverName { get; set; }
        public string Truck { get; set; }
        public Guid? DepositId { get; set; }
        public string DepositName { get; set; }
        public string CanStartPreparing { get; set; }
        public int? Boxes { get; set; }
        public int? Maples { get; set; }
        public int? Eggs { get; set; }
        public string ClientAddress { get; set; }
        public List<OrderEggClassDto> OrderEggClasses { get; set; }
    }
}
