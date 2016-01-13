using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Framework.Data.Interfaces;

namespace Avicola.Sales.Entities
{
    public partial class Order : IEntity
    {
        public int Dozens
        {
            get { return this.OrderEggClasses.Select(y => y.Dozens).DefaultIfEmpty(0).Sum(); }
        }
    }
}