using System;
using Avicola.Sales.Entities;
using Framework.Common.Mapping;

namespace Avicola.Sales.Services.Dtos
{
    public class TruckDto : IMapFrom<Truck>
    {
        public System.Guid Id { get; set; }
        public string NumberPlate { get; set; }
        public string Description { get; set; }
    }
}
