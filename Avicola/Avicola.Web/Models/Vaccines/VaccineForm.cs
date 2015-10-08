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

namespace Avicola.Web.Models.Vaccinees
{
    public class VaccineForm : IMapFrom<Vaccine>
    {
        [HiddenInput]
        public Guid Id { get; set; }

        [Required]
        [Display(Name = "Nombre")]
        public string Name { get; set; }

        [HiddenInput]
        public DateTime CreatedDate { get; set; }

        [Display(Name = "Día Recomendado")]
        public int? RecommendedDay { get; set; }

        public Vaccine ToVaccine()
        {
            var vaccine = Mapper.Map<VaccineForm, Vaccine>(this);
            return vaccine;
        }

        public static VaccineForm FromVaccine(Vaccine vaccine)
        {
            var form = Mapper.Map<Vaccine, VaccineForm>(vaccine);
            return form;
        }
    }
}
