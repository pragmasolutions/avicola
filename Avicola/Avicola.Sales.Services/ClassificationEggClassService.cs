using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Security.Cryptography.X509Certificates;
using AutoMapper;
using AutoMapper.QueryableExtensions;
using Avicola.Sales.Data.Interfaces;
using Avicola.Sales.Entities;
using Avicola.Sales.Services.Dtos;
using Avicola.Sales.Services.Interfaces;
using Framework.Common.Utility;
using Framework.Data.Helpers;

namespace Avicola.Sales.Services
{
    public class ClassificationEggClassService : ServiceBase, IClassificationEggClassService
    {
        public ClassificationEggClassService(ISalesUow uow)
        {
            Uow = uow;
        }

        public IList<ClassificationEggClass> GetAll()
        {
            return Uow.ClassificationEggClasses.GetAll().ToList();
        }
    }
}
