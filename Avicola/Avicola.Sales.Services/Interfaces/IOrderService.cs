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
        IQueryable<Order> GetAll();

        Order GetById(Guid id);

        List<OrderDto> GetAll(string sortBy, string sortDirection, Guid[] statusId, int pageIndex, int pageSize, out int pageTotal);

        void Create(Order order);

        void Edit(Order order);

        void Delete(Guid orderId);
    }
}
