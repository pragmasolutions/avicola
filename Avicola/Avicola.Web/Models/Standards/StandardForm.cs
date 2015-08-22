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

namespace Avicola.Web.Models.Standards
{
    public class StandardForm : IMapFrom<Standard>
    {
        [HiddenInput]
        public Guid Id { get; set; }

        [Required]
        [Display(Name = "Nombre")]
        [Remote("IsNameAvailable", "Standard", "Admin", ErrorMessage = "Ya existe un estandar con este nombre", AdditionalFields = "Id")]
        public string Name { get; set; }

        [Required]
        [Display(Name = "Ingreso de datos")]
        [UIHint("DataLoadTypeId")]
        public Guid DataLoadTypeId { get; set; }

        [HiddenInput]
        public DateTime CreatedDate { get; set; }
        
        public Standard ToStandard()
        {
            var shop = Mapper.Map<StandardForm, Standard>(this);
            return shop;
        }

        public static StandardForm FromStandard(Standard standard)
        {
            var form = Mapper.Map<Standard, StandardForm>(standard);
            return form;
        }
    }
}