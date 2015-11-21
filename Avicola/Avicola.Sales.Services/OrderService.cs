using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using AutoMapper.QueryableExtensions;
using Avicola.Sales.Data.Interfaces;
using Avicola.Sales.Entities;
using Avicola.Sales.Services.Dtos;
using Avicola.Sales.Services.Interfaces;
using Framework.Common.Utility;
using Framework.Data.Helpers;

namespace Avicola.Sales.Services
{
    public class OrderService : ServiceBase, IOrderService
    {
        private readonly IClock _clock;

        public OrderService(ISalesUow uow, IClock clock)
        {
            _clock = clock;
            Uow = uow;
        }
        public List<OrderDto> GetAll(string sortBy, string sortDirection, Guid[] statusId, int pageIndex, int pageSize, out int pageTotal)
        {
            var pagingCriteria = new PagingCriteria();

            pagingCriteria.PageNumber = pageIndex;
            pagingCriteria.PageSize = pageSize;
            pagingCriteria.SortBy = !string.IsNullOrEmpty(sortBy) ? sortBy : "CreatedDate";
            pagingCriteria.SortDirection = !string.IsNullOrEmpty(sortDirection) ? sortDirection : "DESC";

            Expression<Func<Order, bool>> where = x => statusId.Any(y => y == x.OrderStatusId);

            var results = Uow.Orders.GetAll(pagingCriteria, where);

            pageTotal = results.PagedMetadata.TotalItemCount;

            return results.Entities.Project().To<OrderDto>().ToList();
        }

        public List<OrderDto> GetPendingOrders()
        {
            int total;
            return GetAll(string.Empty, String.Empty, new[] { OrderStatus.PENDING }, 1, int.MaxValue, out total);
        }
    }
}
