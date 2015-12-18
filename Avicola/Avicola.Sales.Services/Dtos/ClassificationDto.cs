using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using Avicola.Sales.Entities;
using Framework.Common.Mapping;
using System.Linq;

namespace Avicola.Sales.Services.Dtos
{
    public class ClassificationDto : IHaveCustomMappings
    {
        public System.Guid Id { get; set; }
        public System.DateTime CreatedDate { get; set; }
        public System.DateTime ClassificationDate { get; set; }
        public int TotalClassifiedEggs { get; set; }
        
        public void CreateMappings(AutoMapper.IConfiguration configuration)
        {
            Mapper.CreateMap<Classification, ClassificationDto>()
                .ForMember(x => x.TotalClassifiedEggs, opt => opt.ResolveUsing(x => x.ClassificationEggClasses));
        }
    }
}
