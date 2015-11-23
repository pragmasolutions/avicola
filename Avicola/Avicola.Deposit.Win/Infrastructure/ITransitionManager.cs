using Avicola.Sales.Services.Dtos;

namespace Avicola.Deposit.Win.Infrastructure
{
    public interface ITransitionManager
    {
        void LoadOrdersManagerView();
        void LoadDepositManagerView();
        void LoadBuildOrderView(OrderDto order);
    }
}
