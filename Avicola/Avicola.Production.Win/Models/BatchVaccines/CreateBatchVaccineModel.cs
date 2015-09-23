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

namespace Avicola.Production.Win.Models.BatchVaccines
{
    public class CreateBatchVaccineModel
    {
        public Guid Id { get; set; }
        [Required]
        public DateTime? CreatedDate { get; set; }
        [Required]
        public string Content { get; set; }
        [Required]
        public DateTime? ObservationDate { get; set; }
        [Required]
        public Guid? BatchId { get; set; }
        [Required]
        public int Week { get; set; }
        [Required]
        public int Day { get; set; }
        [Required]
        public bool IsDelete { get; set; }
        
        public BatchVaccine ToBatchVaccine()
        {
            var batchVaccine = new BatchVaccine
            {
                Id = Guid.NewGuid(),
                CreatedDate = DateTime.Now,
                Content = this.Content,
                ObservationDate = this.ObservationDate.GetValueOrDefault(),
                BatchId = this.BatchId.GetValueOrDefault(),
                IsDeleted = false
            };
            return batchVaccine;
        }

        public static CreateBatchVaccineModel FromClient(BatchVaccine batchVaccine)
        {
            var form = Mapper.Map<BatchVaccine, CreateBatchVaccineModel>(batchVaccine);
            return form;
        }
    }
}
