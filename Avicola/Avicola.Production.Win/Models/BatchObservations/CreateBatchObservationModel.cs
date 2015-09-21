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
        
        public BatchObservation ToBatchObservation()
        {
            var batchObservation = new BatchObservation
            {
                Id = Guid.NewGuid(),
                CreatedDate = DateTime.Now,
                Content = this.Content,
                ObservationDate = this.ObservationDate.GetValueOrDefault(),
                BatchId = this.BatchId.GetValueOrDefault(),
                IsDeleted = false
            };
            return batchObservation;
        }

        public static CreateBatchObservationModel FromClient(BatchObservation batchObservation)
        {
            var form = Mapper.Map<BatchObservation, CreateBatchObservationModel>(batchObservation);
            return form;
        }
    }
}
