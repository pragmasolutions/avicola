using System;
using Avicola.Sales.Entities;
using Framework.Common.Mapping;

namespace Avicola.Sales.Services.Dtos
{
    public class DepositDto : IMapFrom<Deposit>
    {
        public System.Guid Id { get; set; }
        public string Name { get; set; }
    }
}
