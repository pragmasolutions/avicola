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

        public int Save(Classification classification)
        {
            var newCurrentEggs = ValidateClassifedEggsAmounts(classification);

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

                var currentClassificationClasses = Uow.ClassificationEggClasses.GetAll(whereClause: x => x.ClassificationId == classification.Id).ToList();

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

            var stockEntry = Uow.StockEntries.Get(classification.StockEntryId);

            var currentEggs = stockEntry.TotalEggs - newCurrentEggs;

            stockEntry.CurrentEggs = currentEggs;

            Uow.Commit();

            return currentEggs;
        }

        private int ValidateClassifedEggsAmounts(Classification classification)
        {
            var classifications = GetByStockEntryId(classification.StockEntryId);

            var untouchClassifications = classifications.Where(x => x.Id != classification.Id);

            var untouchClassifiedEggs = (int)untouchClassifications.Select(x => x.TotalClassifiedEggs).DefaultIfEmpty(0).Sum();

            var eggEquivalence = Uow.EggEquivalences.GetAll().ToList();

            var newClassifiedEggs =
                classification.ClassificationEggClasses.Select(x => x.Amount * eggEquivalence.Single(y => y.Id == x.EggEquivalenceId).EggsAmount)
                    .DefaultIfEmpty(0)
                    .Sum();

            var newTotalClssifiedEggs = untouchClassifiedEggs + newClassifiedEggs;

            var stockEntry = Uow.StockEntries.Get(classification.StockEntryId);

            var isClassificationValid = stockEntry.TotalEggs >= newTotalClssifiedEggs;

            if (!isClassificationValid)
            {
                throw new ApplicationException(
                    "La cantidad de huevos clasificados no puede superar a la cantidad de huevos totales de la partida");
            }

            return (int) newTotalClssifiedEggs;
        }

        private int UpdateRemainingEggs(Classification classification)
        {
            var stockEntry = Uow.StockEntries.Get(classification.StockEntryId);

            var classifications = GetByStockEntryId(classification.StockEntryId);

            var totalClassifiedEggs = (int)classifications.Sum(x => x.TotalClassifiedEggs);

            var currentEggs = stockEntry.TotalEggs - totalClassifiedEggs;

            stockEntry.CurrentEggs = currentEggs;

            Uow.Commit();

            return stockEntry.CurrentEggs;
        }

        public int Delete(Guid classificationId)
        {
            var currentClassification = GetById(classificationId);

            foreach (var classificationClass in currentClassification.ClassificationEggClasses)
            {
                Uow.ClassificationEggClasses.Delete(classificationClass);
            }

            Uow.Classifications.Delete(currentClassification);

            Uow.Commit();

            return UpdateRemainingEggs(currentClassification);
        }

        public Classification GetById(Guid classificationId)
        {
            return Uow.Classifications.Get(x => x.Id == classificationId, includes: x => x.ClassificationEggClasses);
        }
    }
}
