using System;
using Avicola.Sales.Entities;
using Framework.Common.Mapping;

namespace Avicola.Sales.Services.Dtos
{
    public class DriverDto : IMapFrom<Driver>
    {
        public System.Guid Id { get; set; }
        public string Name { get; set; }
        public string Tel1 { get; set; }
        public string Tel2 { get; set; }
        public string CellPhone { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public Guid? TruckId { get; set; }
        public string TruckNumberPlate { get; set; }
    }
}
