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

        public IList<BatchDto> GetAllActive()
        {
            return
                Uow.Batches.GetAll(whereClause: x => !x.EndDate.HasValue && !x.IsDeleted)
                    .Project()
                    .To<BatchDto>()
                    .ToList();
        }

        public IList<Batch> GetAllActiveComplete()
        {
            return Uow.Batches.GetAll(x => !x.EndDate.HasValue && !x.IsDeleted,
                                    x => x.Barn,
                                    x => x.Measures,
                                    x => x.GeneticLine,
                                    x => x.GeneticLine.StandardGeneticLines,
                                    x => x.GeneticLine.StandardGeneticLines.Select(sgl => sgl.Standard),
                                    x => x.GeneticLine.StandardGeneticLines.Select(sgl => sgl.StandardItems)).ToList();
        }

        public int GetNextNumber()
        {
            var max = Uow.Batches.GetAll().Max(x => x.Number);
            return max + 1;
        }


        public void Create(Batch batch)
        {
            Uow.Batches.Add(batch);
            Uow.Commit();
        }
    }
}
