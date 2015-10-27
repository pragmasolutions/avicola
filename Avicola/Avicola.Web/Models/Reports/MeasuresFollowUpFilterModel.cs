using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using Avicola.Reports.Enums;
using Framework.Common.Validation;

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

    public class MeasuresFollowUpFilterModel : ReporteModelBase , IValidatableObject
    {
        [DataType(DataType.Date)]
        [Display(Name = "Estado")]
        [UIHint("BatchStatusId")]
        public BatchStatusEnum BatchStatus { get; set; }

        [Display(Name = "Lote")]
        [Required]
        public Guid BatchId { get; set; }

        [Display(Name = "Desde")]
        [DataType(DataType.Date)]
        public DateTime? From { get; set; }

        [Display(Name = "Hasta")]
        [DataType(DataType.Date)]
        [IsDateAfter("From", true, ErrorMessage = "La fecha hasta no puede ser menor a la fecha desde")]
        public DateTime? To { get; set; }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            if (From.HasValue && From.Value.Date > DateTime.Today.Date)
            {
                yield return new ValidationResult("La fecha desde no puede ser mayor a la fecha actual", new string[] { "From" });
            }

            if (To.HasValue && To.Value.Date > DateTime.Today.Date)
            {
                yield return new ValidationResult("La fecha hasta no puede ser mayor a la fecha actual", new string[] { "To" });
            }

            yield return ValidationResult.Success;
        }
    }
}