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
using Framework.Common.Extentensions;
using Framework.Common.Utility;
using Framework.Data.Helpers;

namespace Avicola.Sales.Services
{
    public class OrderService : ServiceBase, IOrderService
    {
        private const int WeeksBeforeToConsiderOrdersActive = 1;
        private readonly IClock _clock;

        public OrderService(ISalesUow uow, IClock clock)
        {
            _clock = clock;
            Uow = uow;
        }
        public List<OrderDto> GetAll(string sortBy, string sortDirection, Guid[] statusId, DateTime? from, DateTime? to, int pageIndex, int pageSize, out int pageTotal)
        {
            var pagingCriteria = new PagingCriteria();

            pagingCriteria.PageNumber = pageIndex;
            pagingCriteria.PageSize = pageSize;
            pagingCriteria.SortBy = !string.IsNullOrEmpty(sortBy) ? sortBy : "CreatedDate";
            pagingCriteria.SortDirection = !string.IsNullOrEmpty(sortDirection) ? sortDirection : "DESC";

            Expression<Func<Order, bool>> where = x => statusId.Any(y => y == x.OrderStatusId)
                                                   && (!from.HasValue || x.CreatedDate >= from)
                                                   && (!to.HasValue || x.CreatedDate <= to);

            var results = Uow.Orders.GetAll(pagingCriteria, where,
                x => x.Client,
                x => x.Truck,
                x => x.Driver,
                x => x.OrderStatus,
                x => x.Deposit);

            pageTotal = results.PagedMetadata.TotalItemCount;

            return results.Entities.AsEnumerable().Select(Mapper.Map<Order, OrderDto>).ToList();
        }

        public List<OrderDto> GetPendingOrders()
        {
            int total;
            return GetAll(string.Empty, String.Empty, new[] { OrderStatus.PENDING }, null, null, 1, int.MaxValue, out total);
        }

        public List<OrderDto> GetOrdersByStatus(Guid statusId)
        {
            int total;
            return GetAll(string.Empty, String.Empty, new[] { statusId }, null, null, 1, int.MaxValue, out total);
        }

        public List<OrderDto> GetActiveOrders()
        {
            int total;
            return GetAll(string.Empty, String.Empty,
                new[] {OrderStatus.PENDING, OrderStatus.IN_PROGESS, OrderStatus.FINISHED, OrderStatus.SENT},
                _clock.Now.AddWeeks(-WeeksBeforeToConsiderOrdersActive)
                    .AbsoluteStart(),
                _clock.Now.AbsoluteEnd(), 1,
                int.MaxValue, out total);
        }

        public List<OrderDto> GetOrdersByStatus(Guid[] statusIds)
        {
            int total;
            return GetAll(string.Empty, String.Empty, statusIds, null, null, 1, int.MaxValue, out total);
        }

        public void BuildOrder(Guid orderId, Guid depositId)
        {
            var order = InternalGet(orderId);

            order.DepositId = depositId;
            order.OrderStatusId = OrderStatus.IN_PROGESS;

            Uow.Commit();
        }

        public void CancelBuildedOrder(Guid orderId)
        {
            var order = InternalGet(orderId);

            if (order.OrderStatusId != OrderStatus.IN_PROGESS)
            {
                throw new ApplicationException("Para cancelar la orden armada debe estar en el estado en proceso");
            }

            order.OrderStatusId = OrderStatus.PENDING;
            order.DepositId = null;

            Uow.Commit();
        }

        public void FinishOrder(Guid orderId, int boxes, int mapples, int eggsUnits)
        {
            var order = InternalGet(orderId);

            var totalEggs = (boxes * DepositStock.EggsPerBox + mapples * DepositStock.EggsPerMapple + eggsUnits);

            var totalDozens = totalEggs / 12M;

            if (totalDozens != order.Dozens)
            {
                throw new ApplicationException("La cantidad de docenas no coincide con la cajas mapples y huevos especificados");
            }

            order.PreparedDate = _clock.Now;
            order.OrderStatusId = OrderStatus.FINISHED;
            order.Boxes = boxes;
            order.Maples = mapples;
            order.Eggs = eggsUnits;

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
