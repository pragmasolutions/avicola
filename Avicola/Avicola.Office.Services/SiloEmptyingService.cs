using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using AutoMapper;
using AutoMapper.QueryableExtensions;
using Avicola.Office.Data.Interfaces;
using Avicola.Office.Entities;
using Avicola.Office.Services.Dtos;
using Avicola.Office.Services.Interfaces;
using Framework.Common.Extentensions;
using Framework.Common.Utility;
using Framework.Data.Helpers;

namespace Avicola.Office.Services
{
    public class SiloEmptyingService : ServiceBase, ISiloEmptyingService
    {
        public SiloEmptyingService(IOfficeUow uow)
        {
            Uow = uow;
        }


        public List<SiloEmptying> GetByBatch(Guid batchId)
        {
            return Uow.SiloEmptyings.GetAll().Where(x => x.BatchId == batchId).OrderBy(x => x.Date).ToList();
        }


        public SiloEmptying GetById(Guid id)
        {
            return Uow.SiloEmptyings.Get(id);
        }

        public void Create(SiloEmptying siloEmptying)
        {
            Uow.SiloEmptyings.Add(siloEmptying);
            Uow.Commit();
        }

        public void Edit(SiloEmptying siloEmptying)
        {
            var currentSiloEmptying = this.GetById(siloEmptying.Id);

            currentSiloEmptying.Date = siloEmptying.Date;

            Uow.SiloEmptyings.Edit(currentSiloEmptying);
            Uow.Commit();
        }


        public void Delete(Guid emptyingId)
        {
            Uow.SiloEmptyings.Delete(emptyingId);
            Uow.Commit();
        }
    }
}
