using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
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
        public DateTime? ArrivedToBarn { get; set; }
        public DateTime? EndDate { get; set; }
        public System.Guid? StageId { get; set; }
        public string StageName { get; set; }
        public int Week { get; set; }
        public string Barns { get; set; }
        public DateTime CurrentStageStartDate { get; set; }
        public int CurrentStageStartWeek { get; set; }
    }
}
