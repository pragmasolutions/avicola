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
    public class MeasureService : ServiceBase, IMeasureService
    {
        public MeasureService(IOfficeUow uow)
        {
            Uow = uow;
        }

        public void CreateMeasures(IEnumerable<Measure> measures)
        {
            foreach (var measure in measures)
            {
                Uow.Measures.Add(measure);
            }

            Uow.Commit();
        }
    }
}
