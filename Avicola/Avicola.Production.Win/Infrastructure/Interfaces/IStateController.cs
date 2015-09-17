using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Avicola.Office.Entities;
using Avicola.Office.Services.Dtos;

namespace Avicola.Production.Win.Infrastructure
{
    public interface IStateController
    {
        BatchDto CurrentSelectedBatch { get; set; }

        Standard CurrentSelectedStandard { get; set; }  
    }
}
