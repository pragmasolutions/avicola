﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Avicola.Office.Services.Dtos
{
    public class VaccineDto
    {
        public Guid Id { get; set; }
        public DateTime CreatedDate { get; set; }
        public string Name { get; set; }
        public bool IsDeleted { get; set; }
    }
}
