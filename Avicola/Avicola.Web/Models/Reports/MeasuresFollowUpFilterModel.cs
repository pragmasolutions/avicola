using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using Avicola.Reports.Enums;

namespace Avicola.Web.Models.Reports
{
    public class ReporteModelBase
    {
        public ReportTypeEnum ReportType { get; set; }
    }

    public enum BatchStatusEnum
    {
        ShowAll = 2,
        Active = 0,
        Inactive = 1
    }

    public class MeasuresFollowUpFilterModel : ReporteModelBase
    {
        [DataType(DataType.Date)]
        [Display(Name = "Estado")]
        [UIHint("BatchStatusId")]
        public BatchStatusEnum BatchStatus { get; set; }

        [Display(Name = "Lote")]
        [Required]
        public Guid BatchId { get; set; }

        [Display(Name = "Etapa")]
        [Required]
        [UIHint("StageId")]
        public Guid StageId { get; set; }
    }
}