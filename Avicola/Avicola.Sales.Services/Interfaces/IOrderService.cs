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
        List<OrderDto> GetAll(string sortBy, string sortDirection, Guid[] statusId, int pageIndex, int pageSize, out int pageTotal);
        List<OrderDto> GetPendingOrders();
    }
}
