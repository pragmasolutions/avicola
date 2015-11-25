using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Avicola.Sales.Services.Dtos
{
    public class StockDto
    {
        public Guid Id { get; set; }
        public Guid ProductId { get; set; }
        public Guid DepositId { get; set; }
        public int CurrentBoxes { get; set; }
        public int CurrentMapples { get; set; }
        public int CurrentEggs { get; set; }

        public int TotalEggs
        {
            get
            {
                var mappleEggs = CurrentMapples * 12 * 2.5;
                var boxesEggs = CurrentBoxes * 30 * 12;
                
                return Convert.ToInt32(mappleEggs + boxesEggs + CurrentBoxes);
            }
        }
    }
}
