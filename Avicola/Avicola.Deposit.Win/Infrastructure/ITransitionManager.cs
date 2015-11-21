namespace Avicola.Deposit.Win.Infrastructure
{
    public interface ITransitionManager
    {
        void LoadPendingOrdersView();

        void LoadDepositManagerView();
    }
}
