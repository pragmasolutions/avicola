using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Avicola.Sales.Services.Interfaces
{
    public interface IServiceFactory
    {
        T Create<T>();
    }
}
