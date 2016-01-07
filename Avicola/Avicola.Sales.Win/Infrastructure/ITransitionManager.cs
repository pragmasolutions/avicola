using Avicola.Sales.Services.Dtos;

namespace Avicola.Sales.Win.Infrastructure
{
    public interface ITransitionManager
    {
        void LoadSalesManagerView();
        void LoadNewSaleView();
        void LoadHistoryManagerView();

        void LoadClientsView();
    }
}
