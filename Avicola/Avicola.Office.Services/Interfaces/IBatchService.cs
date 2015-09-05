using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Avicola.Office.Entities;
using Avicola.Office.Entities.DTO;
using Avicola.Office.Services.Dtos;
using Avicola.Services.Common;

namespace Avicola.Office.Services.Interfaces
{
    public interface IBatchService : IService
    {
        IList<BatchDto> GetAllActive();
        IList<Batch> GetAllActiveComplete();
    }
}
