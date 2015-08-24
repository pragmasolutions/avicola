using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Framework.Data.Interfaces;

namespace Avicola.Sales.Entities
{
    public partial class Truck : IEntity
    {
        public override string ToString()
        {
            return string.Format("{0} - {1}", this.NumberPlate, this.Description);
        }
    }
}
