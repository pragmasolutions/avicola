using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using Avicola.Office.Data;
using Avicola.Office.Data.Interfaces;
using Avicola.Office.Entities;
using Avicola.Office.Services;
using Avicola.Office.Services.Dtos;
using Avicola.Office.Services.Interfaces;
using Framework.Common.Utility;
using Framework.Data.EntityFramework.Helpers;
using Framework.Data.Repository;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;

namespace Avicola.Office.Test.Services
{
    [TestClass]
    public class MeasureServiceTest
    {
        private IMeasureService _measureService;
        private IOfficeUow _uow;
        private IRepository<Standard> _standardRepository;
        private IClock _clock;
        private IRepository<StandardItem> _standardItemRepository;
        private IRepository<Measure> _measureRepository;
        private IRepository<Batch> _batchRepository;

        [TestInitialize()]
        public void Initialize()
        {
            _standardRepository = Mock.Of<IRepository<Standard>>();
            _standardItemRepository = Mock.Of<IRepository<StandardItem>>();
            _measureRepository = Mock.Of<IRepository<Measure>>();
            _batchRepository = Mock.Of<IRepository<Batch>>();
            _clock = new Clock();
            _uow = new Mock<IOfficeUow>().Object;

            SetupUow();
        }

        [TestMethod]
        public void MaxDateAllowed_WhenStandardContains1WeekItem_Returns1WeekFromTheBatchCreatedDate()
        {
            var standardId = Guid.NewGuid();

            var geneticLineId = Guid.NewGuid();

            var batchCreatedDate = new DateTime(2015, 09, 09);

            var batch = new Batch() { CreatedDate = batchCreatedDate, GeneticLineId = geneticLineId };

            var standardItem = new StandardItem()
                               {
                                   Sequence = 1,
                                   StandardGeneticLine =
                                       new StandardGeneticLine()
                                       {
                                           GeneticLineId = geneticLineId,
                                           StandardId = standardId
                                       }
                               };

            var standardItems = new List<StandardItem>() { standardItem }.AsQueryable();

            var standardWithDataTypeWeek = new Standard()
                                           {
                                               Id = standardId,
                                               DataLoadTypeId = new Guid(GlobalConstants.WeeklyDataLoadType)
                                           };

            Mock.Get(_standardRepository)
                .Setup(x => x.Get(standardId))
                .Returns(standardWithDataTypeWeek);

            Mock.Get(_standardItemRepository)
                .Setup(repository => repository.GetAll(It.IsAny<Expression<Func<StandardItem, bool>>>()))
                .Returns(standardItems);

            _measureService = new MeasureService(_uow, _clock);

            var actualValue = _measureService.MaxDateAllowed(standardId, geneticLineId, batch.CreatedDate);

            DateTime expectedValue = new DateTime(2015, 09, 16);

            Assert.AreEqual(actualValue, expectedValue);
        }

        [TestMethod]
        public void MaxDateAllowed_WhenStandardContains1DayItem_Returns1DayFromTheBatchCreatedDate()
        {
            var standardId = Guid.NewGuid();

            var geneticLineId = Guid.NewGuid();

            var batchCreatedDate = new DateTime(2015, 09, 09);

            var standardItem = new StandardItem()
            {
                Sequence = 1,
                StandardGeneticLine =
                    new StandardGeneticLine()
                    {
                        GeneticLineId = geneticLineId,
                        StandardId = standardId
                    }
            };

            var standardItems = new List<StandardItem>() { standardItem }.AsQueryable();

            var standardWithDataTypeDay = new Standard()
            {
                Id = standardId,
                DataLoadTypeId = new Guid(GlobalConstants.DailyDataLoadType)
            };

            Mock.Get(_standardRepository)
                .Setup(x => x.Get(standardId))
                .Returns(standardWithDataTypeDay);

            Mock.Get(_standardItemRepository)
                .Setup(repository => repository.GetAll(It.IsAny<Expression<Func<StandardItem, bool>>>()))
                .Returns(standardItems);

            _measureService = new MeasureService(_uow, _clock);

            var actualValue = _measureService.MaxDateAllowed(standardId, geneticLineId, batchCreatedDate);

            DateTime expectedValue = new DateTime(2015, 09, 10);

            Assert.AreEqual(actualValue, expectedValue);
        }

        [TestMethod]
        [ExpectedException(typeof(ApplicationException))]
        public void CreateMeasures_WhenThereIsNoSequenceForTheMeasureCreatedDate_ApplicationExceptionThrown()
        {
            var standardId = Guid.NewGuid();

            var batchId = Guid.NewGuid();

            var geneticLineId = Guid.NewGuid();

            var batchCreatedDate = new DateTime(2015, 09, 09);

            var batch = new Batch() { CreatedDate = batchCreatedDate, Id = batchId, GeneticLineId = geneticLineId };

            var standardItem = new StandardItem()
            {
                Sequence = 1,
                StandardGeneticLine =
                    new StandardGeneticLine()
                    {
                        GeneticLineId = geneticLineId,
                        StandardId = standardId
                    }
            };

            var standardItems = new List<StandardItem>() { standardItem }.AsQueryable();

            var standardWithDataTypeWeek = new Standard()
            {
                Id = standardId,
                DataLoadTypeId = new Guid(GlobalConstants.WeeklyDataLoadType)
            };

            Mock.Get(_standardRepository)
                .Setup(x => x.Get(standardId))
                .Returns(standardWithDataTypeWeek);

            Mock.Get(_batchRepository)
                .Setup(x => x.Get(batchId))
                .Returns(batch);

            Mock.Get(_standardItemRepository)
                .Setup(repository => repository.GetAll(It.IsAny<Expression<Func<StandardItem, bool>>>()))
                .Returns(standardItems);


            var outOfScopeMeasureDate = new DateTime(2015, 09, 30);

            _measureService = new MeasureService(_uow, _clock);

            var measures = new List<LoadMeasureModel>() { new LoadMeasureModel()
                                                          {
                                                              BatchId = batchId,
                                                              StandardId = standardId,
                                                              CreatedDate = outOfScopeMeasureDate
                                                          }};

            _measureService.CreateMeasures(measures, batchId);
        }

        [TestMethod]
        public void CreateMeasures_WhenThereIsSequenceForTheMeasureCreatedDate_NoException()
        {
            var standardId = Guid.NewGuid();

            var batchId = Guid.NewGuid();

            var geneticLineId = Guid.NewGuid();

            var batchCreatedDate = new DateTime(2015, 09, 09);

            var batch = new Batch() { CreatedDate = batchCreatedDate, Id = batchId, GeneticLineId = geneticLineId };

            var standardItem = new StandardItem()
            {
                Sequence = 1,
                StandardGeneticLine =
                    new StandardGeneticLine()
                    {
                        GeneticLineId = geneticLineId,
                        StandardId = standardId
                    }
            };

            var standardItems = new List<StandardItem>() { standardItem }.AsQueryable();

            var standardWithDataTypeWeek = new Standard()
            {
                Id = standardId,
                DataLoadTypeId = new Guid(GlobalConstants.WeeklyDataLoadType)
            };

            Mock.Get(_standardRepository)
                .Setup(x => x.Get(standardId))
                .Returns(standardWithDataTypeWeek);

            Mock.Get(_batchRepository)
                .Setup(x => x.Get(batchId))
                .Returns(batch);

            Mock.Get(_standardItemRepository)
                .Setup(repository => repository.Get(It.IsAny<Expression<Func<StandardItem, bool>>>()))
                .Returns<Expression<Func<StandardItem, bool>>, 
                         Expression<Func<StandardItem, object>>[]>((expression, includes) =>
                                                                   {
                                                                       return standardItems.FirstOrDefault(expression);
                                                                   });

            Mock.Get(_standardItemRepository)
                .Setup(repository => repository.GetAll(It.IsAny<Expression<Func<StandardItem, bool>>>()))
                .Returns(standardItems);

            var validMeasureDate = new DateTime(2015, 09, 16);

            _measureService = new MeasureService(_uow, _clock);

            var measures = new List<LoadMeasureModel>()
                           {
                               new LoadMeasureModel()
                               {
                                   BatchId = batchId,
                                   StandardId = standardId,
                                   CreatedDate = validMeasureDate
                               }
                           };

            _measureService.CreateMeasures(measures, batchId);

            Assert.IsTrue(true);
        }

        private void SetupUow()
        {
            Mock.Get(_uow)
                .Setup(x => x.Standards)
                .Returns(_standardRepository);

            Mock.Get(_uow)
                .Setup(x => x.StandardItems)
                .Returns(_standardItemRepository);

            Mock.Get(_uow)
                .Setup(x => x.Measures)
                .Returns(_measureRepository);

            Mock.Get(_uow)
                .Setup(x => x.Batches)
                .Returns(_batchRepository);
        }
    }
}
