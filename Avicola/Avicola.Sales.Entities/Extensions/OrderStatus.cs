using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Framework.Data.Interfaces;

namespace Avicola.Sales.Entities
{
    public partial class OrderStatus : IEntity
    {
        public static readonly Guid SENT = new Guid("65021B0D-6BFD-438A-8692-2AB8E5BE17BD");
        public static readonly Guid FINISHED = new Guid("CAA647AB-0049-47AE-A4F4-6CFE50C4EE48");
        public static readonly Guid IN_PROGESS = new Guid("279ABF04-CAF4-4EF5-8113-CFADADF34D31");
        public static readonly Guid PENDING = new Guid("B3C0D4A0-B223-47B1-891C-FE4D23EEE9E3");
    }
}
