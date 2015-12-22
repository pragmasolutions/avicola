using System;
using System.Collections.Generic;
using System.Linq;
using Avicola.Sales.Entities;
using Avicola.Sales.Services.Dtos;
using Avicola.Services.Common;

namespace Avicola.Sales.Services.Interfaces
{
    public interface IClassificationService : IService
    {
        IList<ClassificationDto> GetByStockEntryId(Guid stockEntryId);

        int Save(Classification classification);

        int Delete(Guid guid);
        Classification GetById(Guid classificationId);
    }
}
