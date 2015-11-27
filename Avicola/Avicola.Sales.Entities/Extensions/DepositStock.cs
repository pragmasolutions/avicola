using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Avicola.Sales.Entities
{
    public partial class DepositStock
    {
        public const int EggsPerBox = 360;
        public const int EggsPerMapple = 30;

        public int TotalEggs
        {
            get
            {
                var mappleEggs = Maples * EggsPerMapple;
                var boxesEggs = Boxes * EggsPerMapple;

                return Convert.ToInt32(mappleEggs + boxesEggs + Eggs);
            }
        }
    }
}
