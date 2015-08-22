﻿using System;
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
    public class GeneticLineForm : IMapFrom<GeneticLine>
    {
        [HiddenInput]
        public Guid Id { get; set; }

        [Required]
        [Display(Name = "Nombre")]
        [Remote("IsNameAvailable", "GeneticLine", "Admin", ErrorMessage = "Ya existe un estandar con este nombre", AdditionalFields = "Id")]
        public string Name { get; set; }

        [Required]
        [Display(Name = "Ciclo de vida (en semanas)")]
        public int ProductionWeeks { get; set; }

        [HiddenInput]
        public int CreatedDate { get; set; }
        
        public GeneticLine ToGeneticLine()
        {
            var shop = Mapper.Map<GeneticLineForm, GeneticLine>(this);
            return shop;
        }

        public static GeneticLineForm FromGeneticLine(GeneticLine educationalInstitution)
        {
            var form = Mapper.Map<GeneticLine, GeneticLineForm>(educationalInstitution);
            return form;
        }
    }
}
