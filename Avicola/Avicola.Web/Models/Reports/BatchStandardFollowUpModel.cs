using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using Avicola.Reports.Enums;

namespace Avicola.Web.Models.Reports
{
    public class BatchStandardFollowUpModel
    {
        [DataType(DataType.Date)]
        [Display(Name = "Estado")]
        [UIHint("BatchStatusId")]
        public BatchStatusEnum BatchStatus { get; set; }

        [Display(Name = "Lote")]
        [Required]
        public Guid BatchId { get; set; }

        [Display(Name = "Estándar")]
        [Required]
        public Guid StandardId { get; set; }
    }
}