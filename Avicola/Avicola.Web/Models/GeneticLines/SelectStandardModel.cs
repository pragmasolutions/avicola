using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.Spatial;
using System.Linq;
using System.Web.Mvc;
using AutoMapper;
using Avicola.Office.Entities;
using Framework.Common.Mapping;

namespace Avicola.Web.Models.GeneticLines
{
    public class SelectStandardModel
    {
        [HiddenInput]
        public Guid GeneticLineId { get; set; }

        [Required]
        [Display(Name = "Estandar")]
        [UIHint("StandardId")]
        public Guid? StandardId { get; set; }
    }
}
