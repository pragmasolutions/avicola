﻿using System;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;
using AutoMapper;
using Avicola.Sales.Entities;
using Framework.Common.Mapping;

namespace Avicola.Web.Models
{
    public class TruckForm : IMapFrom<Truck>
    {
        [HiddenInput]
        public Guid Id { get; set; }

        [Required]
        [Display(Name = "Patente")]
        public string NumberPlate { get; set; }

        [Required]
        [Display(Name = "Descripción")]
        public string Description { get; set; }
        
        public Truck ToTruck()
        {
            var truck = Mapper.Map<TruckForm, Truck>(this);
            return truck;
        }

        public static TruckForm FromTruck(Truck driver)
        {
            var form = Mapper.Map<Truck, TruckForm>(driver);
            return form;
        }
    }
}
