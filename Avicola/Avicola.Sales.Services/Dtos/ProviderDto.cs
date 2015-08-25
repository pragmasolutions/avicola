using System;
using Avicola.Sales.Entities;
using Framework.Common.Mapping;

namespace Avicola.Sales.Services.Dtos
{
    public class ProviderDto : IMapFrom<Provider>
    {
        public System.Guid Id { get; set; }
        public string Name { get; set; }
        public string Tel1 { get; set; }
        public string Tel2 { get; set; }
        public string CellPhone { get; set; }
        public string Email { get; set; }
        public string Referent { get; set; }
        public string WebSite { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
    }
}
