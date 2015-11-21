namespace Avicola.Services.Common.Interfaces
{
    public interface IServiceFactory
    {
        T Create<T>();
    }
}
