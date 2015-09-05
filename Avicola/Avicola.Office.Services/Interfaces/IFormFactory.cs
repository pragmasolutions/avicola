namespace Avicola.Office.Services.Interfaces
{
    public interface IServiceFactory
    {
        T Create<T>();
    }
}
