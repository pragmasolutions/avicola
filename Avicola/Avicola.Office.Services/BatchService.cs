using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using AutoMapper.QueryableExtensions;
using Avicola.Office.Data.Interfaces;
using Avicola.Office.Entities;
using Avicola.Office.Services.Dtos;
using Avicola.Office.Services.Interfaces;
using Framework.Common.Utility;
using Framework.Data.Helpers;

namespace Avicola.Office.Services
{
    public class BatchService : ServiceBase, IBatchService
    {
        public BatchService(IOfficeUow uow)
        {
            Uow = uow;
        }

        public IQueryable<Batch> GetAllActive()
        {
            return Uow.Batches.GetAll(whereClause: x => !x.EndDate.HasValue && !x.IsDeleted);
        }
    }
}
