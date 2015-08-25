using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Avicola.Web.Models.GeneticLines
{
    public class StandardItemModel
    {
        public int Sequence { get; set; }

        [Required]
        [Range(0, 10000)]
        public decimal Value { get; set; }
    }
}