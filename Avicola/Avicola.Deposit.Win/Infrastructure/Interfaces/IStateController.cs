using Avicola.Sales.Entities;

namespace Avicola.Deposit.Win.Infrastructure.Interfaces
{
    public interface IStateController
    {
        OrderStatus CurrentOrderStatus { get; set; }
    }
}
