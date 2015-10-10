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

namespace Avicola.Web.Models.Medicines
{
    public class MedicineForm : IMapFrom<Medicine>
    {
        [HiddenInput]
        public Guid Id { get; set; }

        [Required]
        [Display(Name = "Nombre")]
        public string Name { get; set; }

        [HiddenInput]
        public DateTime CreatedDate { get; set; }

        [DataType(DataType.MultilineText)]
        [Display(Name = "Observación")]
        public string Observation { get; set; }

        public Medicine ToMedicine()
        {
            var medicine = Mapper.Map<MedicineForm, Medicine>(this);
            return medicine;
        }

        public static MedicineForm FromMedicine(Medicine medicine)
        {
            var form = Mapper.Map<Medicine, MedicineForm>(medicine);
            return form;
        }
    }
}
