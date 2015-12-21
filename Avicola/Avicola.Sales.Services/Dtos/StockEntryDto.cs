using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Avicola.Sales.Entities;
using Framework.Common.Mapping;

namespace Avicola.Sales.Services.Dtos
{
    public class StockEntryDto : IMapFrom<StockEntry>
    {
        public System.Guid Id { get; set; }
        public System.DateTime CreatedDate { get; set; }
        public System.Guid ShiftId { get; set; }
        public string ShiftName { get; set; }
        public System.Guid StockId { get; set; }
        public int Boxes { get; set; }
        public int Maples { get; set; }
        public int Eggs { get; set; }
        public Guid? ProviderId { get; set; }
        public int TotalEggs { get; set; }
        public int CurrentEggs { get; set; }
        public System.Guid BarnId { get; set; }
        public string BarnName { get; set; }
    }
}
