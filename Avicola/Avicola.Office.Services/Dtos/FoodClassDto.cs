﻿using System;
using Avicola.Office.Entities;
using Framework.Common.Mapping;

namespace Avicola.Office.Services.Dtos
{
    public class FoodClassDto : IMapFrom<FoodClass>
    {
        public Guid Id { get; set; }
        public string Name { get; set; }               
        public DateTime CreatedDate { get; set; }        
        public bool IsDeleted { get; set; }
    }
}
