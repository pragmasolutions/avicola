using System;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;
using AutoMapper;
using Avicola.Office.Entities;
using Avicola.Sales.Entities;
using Framework.Common.Mapping;
using Resources;

namespace Avicola.Web.Models
{
    public class BarnForm : IMapFrom<Barn>
    {
        [HiddenInput]
        public Guid Id { get; set; }

        [Required]
        [Remote("IsNumberAvailable", "Barn", ErrorMessage = "Ya existe un galpón con ese nombre", AdditionalFields = "Id")]
        public int? Number { get; set; }

        [Required]
        public int? Capacity { get; set; }

        public Barn ToBarn()
        {
            var barn = Mapper.Map<BarnForm, Barn>(this);
            return barn;
        }

        public static BarnForm FromBarn(Barn driver)
        {
            var form = Mapper.Map<Barn, BarnForm>(driver);
            return form;
        }
    }
}
