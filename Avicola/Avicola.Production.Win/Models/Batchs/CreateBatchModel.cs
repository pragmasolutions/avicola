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

namespace Avicola.Production.Win.Models.Batchs
{
    public class CreateBatchModel
    {
        [Required(ErrorMessage = "El campo linea genética es requerido")]
        public Guid? GeneticLineId { get; set; }

        [Required(ErrorMessage = "El campo tipo de alimento es requerido")]
        public Guid? FoodClassId { get; set; }

        [Required(ErrorMessage = "El campo cantidad de aves inicial es requerido")]
        [Range(1, int.MaxValue, ErrorMessage = "El campo cantidad de aves inicial debe ser mayor a 0")]
        public int? InitialBirds { get; set; }

        [Required(ErrorMessage = "El campo fecha  de nac. es requerido")]
        public DateTime? DateOfBirth { get; set; }

        [Required(ErrorMessage = "El campo fecha  de ingreso es requerido")]
        public DateTime? EntranceDate { get; set; }

        [Required(ErrorMessage = "El campo alimento inicial es requerido")]
        [Range(0, int.MaxValue, ErrorMessage = "El campo campo alimento inicial debe ser mayor o igual 0")]
        public decimal? StartingFood { get; set; }

        public Batch ToBatch()
        {
            var batch = new Batch
            {
                InitialBirds = this.InitialBirds.GetValueOrDefault(),
                DateOfBirth = this.DateOfBirth.GetValueOrDefault(),
                GeneticLineId = this.GeneticLineId.GetValueOrDefault(),
                FoodClassId = this.FoodClassId.GetValueOrDefault(),
                StartingFood = this.StartingFood.GetValueOrDefault(),
            };
            return batch;
        }

        public static CreateBatchModel FromClient(Batch batch)
        {
            var form = Mapper.Map<Batch, CreateBatchModel>(batch);
            return form;
        }
    }
}
