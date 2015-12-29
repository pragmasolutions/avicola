using System;
using System.Collections.Generic;
using System.Linq;
using Avicola.Sales.Entities;
using Avicola.Sales.Services.Dtos;
using Avicola.Services.Common;

namespace Avicola.Sales.Services.Interfaces
{
    public interface IOrderService : IService
    {
        List<OrderDto> GetAll(string sortBy, string sortDirection, Guid[] statusId,DateTime? from, DateTime? to, int pageIndex, int pageSize, out int pageTotal);
        List<OrderDto> GetPendingOrders();
        List<OrderDto> GetOrdersByStatus(Guid statusId);
        List<OrderDto> GetOrdersByStatus(Guid[] statusIds);
        List<OrderDto> GetActiveOrders();
        OrderDto Get(Guid orderId);
        void BuildOrder(Guid orderId, Guid depositId);
        void CancelBuildedOrder(Guid orderId);
        void SendOrder(Guid orderId, Guid driverId, Guid truckId);
        void FinishOrder(Guid orderId, int boxes, int mapples, int eggsUnits);
        void Create(Order order);
        void Delete(Guid id);
        void Edit(Order order);
    }
}
