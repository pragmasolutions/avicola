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
            if (Uow.Batches.GetAll().Any())
            {
                return Uow.Batches.GetAll().Max(x => x.Number) + 1;
            }
            else
            {
                return 1;
            }
        }

        public void Create(Batch batch)
        {
            Uow.Batches.Add(batch);
            Uow.Commit();
        }

        public void Delete(Guid batchId)
        {
            Uow.Batches.Delete(batchId);
            Uow.Commit();
        }


        public Batch GetById(Guid batchId)
        {
            return Uow.Batches.Get(x => x.Id == batchId,
                                b => b.Measures,
                                b => b.Measures.Select(m => m.StandardItem),
                                b => b.Measures.Select(m => m.StandardItem.StandardGeneticLine),
                                b => b.Measures.Select(m => m.StandardItem.StandardGeneticLine.GeneticLine),
                                b => b.Measures.Select(m => m.StandardItem.StandardGeneticLine.Standard));
        }


        public void EndBatch(Batch batch, DateTime endDate)
        {
            batch.EndDate = endDate;
            Uow.Batches.Edit(batch);
            Uow.Commit();
        }
    }
}
