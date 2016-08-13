using Avicola.Entities;
using Avicola.Sales.Entities;

namespace Avicola.Security
{
    public interface IAvicolaContext
    {
        User User { get; }
        bool IsInRole(string roles);
        string Role { get; }
    }
}
