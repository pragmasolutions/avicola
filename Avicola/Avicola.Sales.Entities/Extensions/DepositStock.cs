﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Avicola.Sales.Entities
{
    public partial class DepositStock
    {
        public int TotalEggs
        {
            get
            {
                var mappleEggs = Maples * 12 * 2.5;
                var boxesEggs = Boxes * 30 * 12;

                return Convert.ToInt32(mappleEggs + boxesEggs + Eggs);
            }
        }
    }
}
