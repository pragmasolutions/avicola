using System;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;
using AutoMapper;
using Avicola.Sales.Entities;
using Framework.Common.Mapping;

namespace Avicola.Web.Models.Drivers
{
    public class DriverForm : IMapFrom<Driver>
    {
        [HiddenInput]
        public Guid Id { get; set; }
        [Required]
        [Display(Name = "Nombre")]
        public string Name { get; set; }
        [Required]
        public string Tel1 { get; set; }
        public string Tel2 { get; set; }
        public string CellPhone { get; set; }
        [Required]
        public string Address { get; set; }
        [Required]
        public string City { get; set; }
        
        public Driver ToDriver()
        {
            var shop = Mapper.Map<DriverForm, Driver>(this);
            return shop;
        }

        public static DriverForm FromDriver(Driver driver)
        {
            var form = Mapper.Map<Driver, DriverForm>(driver);
            return form;
        }
    }
}
