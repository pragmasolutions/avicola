using System;
using System.Collections.Generic;
using AutoMapper;
using Avicola.Sales.Entities;
using Framework.Common.Mapping;

namespace Avicola.Sales.Services.Dtos
{
    public class OrderEggClassDto : IMapFrom<OrderEggClass>
    {
        public System.Guid Id { get; set; }
        public int Dozens { get; set; }
        public string EggClassName { get; set; }
        public Guid EggClassId { get; set; }
    }
}
