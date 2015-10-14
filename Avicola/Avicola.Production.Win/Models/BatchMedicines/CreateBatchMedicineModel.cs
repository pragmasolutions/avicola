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

namespace Avicola.Production.Win.Models.BatchMedicines
{
    public class CreateBatchMedicineModel
    {

        public Guid Id { get; set; }
        [Required]
        public DateTime CreatedDate { get; set; }
        [Required]
        public Guid? BatchId { get; set; }
        [Required]
        public Guid? MedicineId { get; set; }        
        [Required]
        public DateTime StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public string Observation { get; set; }
        [Required]
        public bool IsDelete { get; set; }

        public BatchMedicine ToBatchMedicine()
        {
            var batchVaccine = new BatchMedicine
            {
                Id = Guid.NewGuid(),
                CreatedDate = DateTime.Now,
                BatchId = this.BatchId.GetValueOrDefault(),
                MedicineId = this.MedicineId.GetValueOrDefault(),                
                StartDate = this.StartDate,
                EndDate = this.EndDate.Value,
                Observation = this.Observation,
                IsDeleted = false
            };
            return batchVaccine;
        }

        public static CreateBatchMedicineModel FromClient(BatchMedicine batchMedicine)
        {
            var form = Mapper.Map<BatchMedicine, CreateBatchMedicineModel>(batchMedicine);
            return form;
        }
    }
}
