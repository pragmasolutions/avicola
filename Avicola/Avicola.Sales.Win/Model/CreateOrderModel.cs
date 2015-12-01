using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using Avicola.Sales.Entities;
using Telerik.WinControls.Design;

namespace Avicola.Sales.Win.Model
{
    public class CreateOrderModel
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
        
        [Required]
        [Range(1, int.MaxValue)]
        public int? Dozens { get; set; }

        public Order ToOrder()
        {
            var order = new Order
            {
                Id = Guid.NewGuid(),
                CreatedDate = DateTime.Now,
                ClientId = ClientId.GetValueOrDefault(),
                City = this.City,
                Address = this.Address,
                PhoneNumber = this.PhoneNumber,
                Dozens = this.Dozens.GetValueOrDefault(),
                IsDeleted = false,
                OrderStatusId = OrderStatus.PENDING
            };
            return order;
        }

        public static CreateOrderModel FromOrder(Order order)
        {
            var form = Mapper.Map<Order, CreateOrderModel>(order);
            return form;
        }
    }
}
