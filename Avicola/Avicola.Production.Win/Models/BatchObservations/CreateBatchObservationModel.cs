using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity.Migrations.History;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using Avicola.Office.Entities;
using Framework.Common.Mapping;

namespace Avicola.Production.Win.Models.BatchObservations
{
    public class CreateBatchObservationModel
    {
        [Required]
        public Guid? GeneticLineId { get; set; }

        [Required]
        public Guid? FoodClassId { get; set; }

        [Required]
        [Range(0, int.MaxValue)]
        public decimal? StartingFood { get; set; }

        [Required]
        [Range(0, int.MaxValue)]
        public int? InitialBirds { get; set; }

        [Required]
        public DateTime? DateOfBirth { get; set; }


        public BatchObservation ToBatchObservation()
        {
            var batch = new BatchObservation
            {
                InitialBirds = this.InitialBirds.GetValueOrDefault(),
                StartingFood = this.StartingFood.GetValueOrDefault(),
                DateOfBirth = this.DateOfBirth.GetValueOrDefault(),
                GeneticLineId = this.GeneticLineId.GetValueOrDefault(),
                FoodClassId = this.FoodClassId.GetValueOrDefault(),
                StageId = Stage.BREEDING
            };
            return batch;
        }

        public static CreateBatchObservationModel FromClient(CreateBatchObservationModel batchObservation)
        {
            var form = Mapper.Map<BatchObservation, CreateBatchObservationModel>(batchObservation);
            return form;
        }
    }
}
