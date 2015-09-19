using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity.Migrations.History;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using Avicola.Office.Entities;
using Framework.Common.Mapping;

namespace Avicola.Production.Win.Models.Batchs
{
    public class AssignBarnModel
    {
        [Required]
        public Guid? BarnId { get; set; }

        [Required]
        public DateTime? ArrivedToBarn { get; set; }
    }
}
