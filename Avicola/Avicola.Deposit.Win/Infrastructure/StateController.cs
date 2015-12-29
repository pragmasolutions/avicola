using Avicola.Deposit.Win.Infrastructure.Interfaces;

namespace Avicola.Deposit.Win.Infrastructure
{
    public class StateController : IStateController
    {
        public Sales.Entities.OrderStatus CurrentOrderStatus { get; set; }
    }
}
