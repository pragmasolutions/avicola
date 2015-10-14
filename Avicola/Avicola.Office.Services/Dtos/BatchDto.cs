using System;
using Avicola.Office.Entities;
using Framework.Common.Mapping;

namespace Avicola.Office.Services.Dtos
{
    public class BatchDto : IMapFrom<Batch>
    {
        public System.Guid Id { get; set; }
        public System.DateTime CreatedDate { get; set; }
        public int Number { get; set; }
        public int InitialBirds { get; set; }
        public System.DateTime DateOfBirth { get; set; }
        public System.Guid GeneticLineId { get; set; }
        public string GeneticLineName { get; set; }
        public int GeneticLineWeeksInBreeding { get; set; }
        public decimal StartingFood { get; set; }
        public System.Guid FoodClassId { get; set; }
        public string FoodClassName { get; set; }
        public Guid? BarnId { get; set; }
        public int? BarnNumber { get; set; }
        public DateTime? ArrivedToBarn { get; set; }
        public DateTime? EndDate { get; set; }
        public System.Guid? StageId { get; set; }

        public int Week
        {
            get
            {
                var daysDifference = (DateTime.Today.Date - DateOfBirth.Date).TotalDays + 1;
                return Convert.ToInt32(Math.Ceiling(daysDifference / 7d));
            }
        }

        public string StageName { get; set; }
    }
}
