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

namespace Avicola.Web.Models.FoodClasses
{
    public class FoodClassForm : IMapFrom<FoodClass>
    {
        [HiddenInput]
        public Guid Id { get; set; }

        [Required]
        [Display(Name = "Nombre")]
        public string Name { get; set; }
      
        [HiddenInput]
        public DateTime CreatedDate { get; set; }        
        
        public FoodClass ToFoodClass()
        {
            var foodClass = Mapper.Map<FoodClassForm, FoodClass>(this);
            return foodClass;
        }

        public static FoodClassForm FromFoodClass(FoodClass foodClass)
        {
            var form = Mapper.Map<FoodClass, FoodClassForm>(foodClass);
            return form;
        }
    }
}
