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
    public class ClassificationService : ServiceBase, IClassificationService
    {
        public ClassificationService(ISalesUow uow)
        {
            Uow = uow;
        }

        public IList<ClassificationDto> GetByStockEntryId(Guid stockEntryId)
        {
            return
                Uow.Classifications.GetAll(whereClause: x => x.StockEntryId == stockEntryId,
                    includes: x => x.ClassificationEggClasses.Select(y => y.EggEquivalence))
                    .AsEnumerable().Select(Mapper.Map<Classification, ClassificationDto>).ToList();
        }

        public void Save(Classification classification)
        {

            if (classification.Id == Guid.Empty)
            {
                classification.Id = Guid.NewGuid();

                Uow.Classifications.Add(classification);

                foreach (var classificationClasses in classification.ClassificationEggClasses)
                {
                    classificationClasses.Id = Guid.NewGuid();

                    Uow.ClassificationEggClasses.Add(classificationClasses);
                }
            }
            else
            {
                var currentClassification = Uow.Classifications.Get(classification.Id);

                currentClassification.ClassificationDate = classification.ClassificationDate;

                var currentClassificationClasses = Uow.ClassificationEggClasses.GetAll(whereClause:x => x.ClassificationId == classification.Id);

                foreach (var classificationClasses in classification.ClassificationEggClasses)
                {
                    var currentClassificationClass =
                        currentClassificationClasses.FirstOrDefault(x => x.Id == classificationClasses.Id);

                    if (currentClassificationClass != null)
                    {
                        if (classificationClasses.Amount > 0)
                        {
                            currentClassificationClass.Amount = classificationClasses.Amount;
                            currentClassificationClass.EggEquivalenceId = classificationClasses.EggEquivalenceId;

                            Uow.ClassificationEggClasses.Edit(currentClassificationClass);
                        }
                        else
                        {
                            Uow.ClassificationEggClasses.Delete(currentClassificationClass);
                        }
                    }
                    else
                    {
                        if (classificationClasses.Id == Guid.Empty)
                        {
                            classificationClasses.Id = Guid.NewGuid();
                            classificationClasses.ClassificationId = classification.Id;

                            Uow.ClassificationEggClasses.Add(classificationClasses);
                        }
                        else
                        {
                            Uow.ClassificationEggClasses.Delete(currentClassificationClass);
                        }
                    }
                }
            }

            Uow.Commit();
        }


        public void Delete(Guid classificationId)
        {
            var currentClassification = GetById(classificationId);

            foreach (var classificationClass in currentClassification.ClassificationEggClasses)
            {
                Uow.ClassificationEggClasses.Delete(classificationClass);
            }

            Uow.Classifications.Delete(currentClassification);

            Uow.Commit();
        }

        public Classification GetById(Guid classificationId)
        {
            return Uow.Classifications.Get(x => x.Id == classificationId, includes: x => x.ClassificationEggClasses);
        }
    }
}
