using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using Avicola.Sales.Entities;

namespace Avicola.Deposit.Win.Model
{
    public class CreateStockEntryModel
    {
        public Guid Id { get; set; }

        [Required]
        public Guid BarnId { get; set; }

        [Required]
        public DateTime CreatedDate { get; set; }
        [Required]
        public Guid? ShiftId { get; set; }
       
        public Guid? ProviderId { get; set; }
        [Required]
        public int? Boxes { get; set; }
        [Required]
        public int? Maples { get; set; }
        [Required]
        public int? Eggs { get; set; }

        [Required]
        public bool IsDelete { get; set; }

        public StockEntry ToStockEntry()
        {
            var stockEntry = new StockEntry
            {
                Id = Guid.NewGuid(),
                CreatedDate = DateTime.Now,
                ShiftId = this.ShiftId.GetValueOrDefault(),
                ProviderId = this.ProviderId.GetValueOrDefault(),
                Boxes = this.Boxes.GetValueOrDefault(),
                Maples = this.Maples.GetValueOrDefault(),
                Eggs = this.Eggs.GetValueOrDefault(),
                IsDeleted = false,
                BarnId = this.BarnId,
                CurrentEggs = Convert.ToInt32(Maples.GetValueOrDefault() * 30 + Boxes.GetValueOrDefault() * 360 + Eggs.GetValueOrDefault())
            };

            if (stockEntry.ProviderId == Guid.Empty)
            {
                stockEntry.ProviderId = null;
            }
            else
            {
                stockEntry.ProviderId = this.ProviderId.GetValueOrDefault();
            }

            return stockEntry;
        }

        public static CreateStockEntryModel FromClient(StockEntry stockEntry)
        {
            var form = Mapper.Map<StockEntry, CreateStockEntryModel>(stockEntry);
            return form;
        }
    }
}
