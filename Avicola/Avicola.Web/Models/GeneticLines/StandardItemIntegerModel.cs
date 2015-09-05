using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Avicola.Web.Models.GeneticLines
{
    public class StandardItemIntegerModel
    {
        public int Sequence { get; set; }
        public Guid Id { get; set; }
        public bool ShowSecondValue { get; set; }

        [Required]
        [Range(0, 10000)]
        public int Value1 { get; set; }

        [Range(0, 10000)]
        public int? Value2 { get; set; }
    }
}