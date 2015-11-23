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
    public class OrderStatusService : ServiceBase, IOrderStatusService
    {
        public OrderStatusService(ISalesUow uow)
        {
            Uow = uow;
        }
        
        public List<OrderStatus> GetActiveStatus()
        {
            return
                Uow.OrderStatuses.GetAll(x => x.Id != OrderStatus.FINISHED).ToArray().OrderBy(x => x.Postion).ToList();
        }
    }
}
