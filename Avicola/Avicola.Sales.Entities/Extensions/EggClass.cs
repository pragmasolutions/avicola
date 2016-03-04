using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Framework.Data.Interfaces;

namespace Avicola.Sales.Entities
{
    public partial class EggClass : IEntity
    {
        public static readonly Guid BROKEN = new Guid("17A79438-C6D9-4D58-8959-2AED463F6F67");
    }
}
