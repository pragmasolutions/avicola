using System;
using System.Collections.Generic;
using System.ComponentModel;
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
    public class GeneticLineForm : IMapFrom<GeneticLine>
    {
        [HiddenInput]
        public Guid Id { get; set; }

        [Required]
        [Display(Name = "Nombre")]
        public string Name { get; set; }

        [Required]
        [Display(Name = "Ciclo de vida (en semanas)")]
        public int ProductionWeeks { get; set; }
        
        [HiddenInput]
        public DateTime CreatedDate { get; set; }
        
        public GeneticLine ToGeneticLine()
        {
            var geneticLine = Mapper.Map<GeneticLineForm, GeneticLine>(this);
            //geneticLine.ProductionWeeks = 120;
            return geneticLine;
        }

        public static GeneticLineForm FromGeneticLine(GeneticLine geneticLine)
        {
            var form = Mapper.Map<GeneticLine, GeneticLineForm>(geneticLine);
            return form;
        }
    }
}
