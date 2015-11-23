using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using AutoMapper;
using AutoMapper.QueryableExtensions;
using Avicola.Sales.Data.Interfaces;
using Avicola.Sales.Entities;
using Avicola.Sales.Services.Dtos;
using Avicola.Sales.Services.Interfaces;
using Avicola.Services.Common.Exceptions;
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

        public List<OrderDto> GetOrdersByStatus(Guid statusId)
        {
            int total;
            return GetAll(string.Empty, String.Empty, new[] { statusId }, 1, int.MaxValue, out total);
        }

        public void BuildOrder(Guid orderId)
        {
            var order = InternalGet(orderId);

            order.OrderStatusId = OrderStatus.IN_PROGESS;
        }

        public void SendOrder(Guid orderId)
        {
            var order = InternalGet(orderId);

            order.OrderStatusId = OrderStatus.SENT;
        }

        public void FinishOrder(Guid orderId)
        {
            var order = InternalGet(orderId);

            order.OrderStatusId = OrderStatus.FINISHED;
        }

        private Order InternalGet(Guid orderId)
        {
            var order = Uow.Orders.Get(orderId);

            if (order == null)
            {
                throw new NotFoundException("No se ha encontrado el pedido");
            }
            return order;
        }

        public OrderDto Get(Guid orderId)
        {
            var order = Uow.Orders.Get(x => x.Id == orderId, x => x.Client, x => x.OrderStatus, x => x.Driver);

            if (order == null)
            {
                throw new NotFoundException("No se ha encontrado el pedido");
            }

            return Mapper.Map<Order, OrderDto>(order);
        }
    }
}
