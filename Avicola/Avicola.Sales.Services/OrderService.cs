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

            var results = Uow.Orders.GetAll(pagingCriteria, where,
                x => x.Client, x =>
                x.Truck,
                x => x.Driver,
                x => x.OrderStatus);

            pageTotal = results.PagedMetadata.TotalItemCount;

            return results.Entities.AsEnumerable().Select(Mapper.Map<Order, OrderDto>).ToList();
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

        public List<OrderDto> GetActiveOrders()
        {
            int total;
            return GetAll(string.Empty, String.Empty,
                new[] { OrderStatus.PENDING, OrderStatus.IN_PROGESS, OrderStatus.FINISHED, OrderStatus.SENT }, 1,
                int.MaxValue, out total);
        }

        public List<OrderDto> GetOrdersByStatus(Guid[] statusIds)
        {
            int total;
            return GetAll(string.Empty, String.Empty, statusIds, 1, int.MaxValue, out total);
        }

        public void BuildOrder(Guid orderId, Guid depositId)
        {
            var order = InternalGet(orderId);

            order.DepositId = depositId;
            order.OrderStatusId = OrderStatus.IN_PROGESS;

            Uow.Commit();
        }

        public void FinishOrder(Guid orderId)
        {
            var order = InternalGet(orderId);

            order.PreparedDate = _clock.Now;
            order.OrderStatusId = OrderStatus.FINISHED;

            Uow.Commit();
        }

        public void SendOrder(Guid orderId, Guid driverId, Guid truckId)
        {
            var order = InternalGet(orderId);

            order.DispatchedDate = _clock.Now;
            order.OrderStatusId = OrderStatus.SENT;
            order.DriverId = driverId;
            order.TruckId = truckId;

            Uow.Commit();
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
