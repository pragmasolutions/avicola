using System;
using System.ComponentModel.DataAnnotations;
using AutoMapper;
using Avicola.Sales.Entities;

namespace Avicola.Deposit.Win.Model
{
    public class EditOrderModel
    {
        public Guid Id { get; set; }
        
        [Required]
        public Guid? ClientId { get; set; }
       
        [Required]
        public string Address { get; set; }
        
        [Required]
        public string City { get; set; }

        [Required]
        public string PhoneNumber { get; set; }
        
        public Order ToOrder()
        {
            var order = new Order
            {
                CreatedDate = DateTime.Now,
                ClientId = ClientId.GetValueOrDefault(),
                City = this.City,
                Address = this.Address,
                PhoneNumber = this.PhoneNumber,
                IsDeleted = false,
                OrderStatusId = OrderStatus.PENDING
            };
            return order;
        }

        public static EditOrderModel FromOrder(Order order)
        {
            var form = Mapper.Map<Order, EditOrderModel>(order);
            return form;
        }
    }
}
