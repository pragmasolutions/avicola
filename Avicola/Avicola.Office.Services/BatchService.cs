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
    public class BatchService : ServiceBase, IBatchService
    {
        public const string MortalityStandardName = "Mortandad";
        public const string FoodEntryStandardName = "Ingreso de Alimento";
        public const string DiscardStandardName = "Descarte";

        private readonly IBarnService _barnService;

        public BatchService(IOfficeUow uow, IBarnService barnService)
        {
            Uow = uow;
            _barnService = barnService;
        }

        public IList<BatchDto> GetAllActive()
        {
            return Uow.Batches.GetAll(x => !x.EndDate.HasValue && !x.IsDeleted,
                                    x => x.GeneticLine,
                                    x => x.Stage,
                                    x => x.BatchBarns,
                                    x => x.BatchBarns.Select(bb => bb.Barn))
                                    .Select(Mapper.Map<Batch, BatchDto>)
                    .ToList();
        }

        public BatchDto GetActiveById(Guid batchId)
        {
            return Uow.Batches.GetAll(x => !x.EndDate.HasValue && !x.IsDeleted && x.Id == batchId,
                x => x.GeneticLine,
                x => x.Stage,
                x => x.BatchBarns,
                x => x.BatchBarns.Select(bb => bb.Barn))
                .Select(Mapper.Map<Batch, BatchDto>)
                .FirstOrDefault();
        }

        public IList<Batch> GetAllActiveComplete()
        {
            return Uow.Batches.GetAll(x => !x.EndDate.HasValue && !x.IsDeleted,
                                    x => x.BatchBarns,
                                    x => x.BatchBarns.Select(bb => bb.Barn),
                                    x => x.Measures,
                                    x => x.GeneticLine,
                                    x => x.GeneticLine.StandardGeneticLines,
                                    x => x.GeneticLine.StandardGeneticLines.Select(sgl => sgl.Standard),
                                    x => x.GeneticLine.StandardGeneticLines.Select(sgl => sgl.StandardItems)).ToList();
        }

        public Batch GetByIdComplete(Guid batchId)
        {
            return Uow.Batches.GetAll(x => !x.EndDate.HasValue && !x.IsDeleted,
                                    x => x.BatchBarns,
                                    x => x.BatchBarns.Select(bb => bb.Barn),
                                    x => x.Measures,
                                    x => x.GeneticLine,
                                    x => x.GeneticLine.StandardGeneticLines,
                                    x => x.GeneticLine.StandardGeneticLines.Select(sgl => sgl.Standard),
                                    x => x.GeneticLine.StandardGeneticLines.Select(sgl => sgl.StandardItems))
                                   .First(x => x.Id == batchId);
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

        public int GetBirdsAmount(Guid batchId, DateTime date)
        {
            var batch = this.GetById(batchId);

            var startStageDate = batch.CurrentStageStartDate;
            var endStageDate = date;

            var measures =
                Uow.Measures.GetAll(
                    x =>
                        x.BatchId == batchId &&
                        (x.StandardItem.StandardGeneticLine.Standard.Name.Contains(MortalityStandardName) ||
                        x.StandardItem.StandardGeneticLine.Standard.Name.Contains(DiscardStandardName)) &&
                        x.Date >= startStageDate &&
                        x.Date <= endStageDate,
                    x => x.StandardItem.StandardGeneticLine.Standard);

            var initialBirds = GetInitialBirds(batchId, batch.StageId);

            var deathBirds = measures.Select(x => x.Value).DefaultIfEmpty(0).Sum();

            return (int)Math.Floor(initialBirds - deathBirds);
        }

        public int GetInitialBirds(Guid batchId, Guid stageId)
        {
            var batchBarn = Uow.BatchBarns.GetAll(x => x.BatchId == batchId && x.Barn.StageId == stageId, x => x.Barn);

            if (!batchBarn.Any())
            {
                throw new ApplicationException("El lote no tiene asignado ningun galpon para la etapa solicitada");
            }

            var initialBirds = batchBarn.Select(x => x.InitialBirds).DefaultIfEmpty(0).Sum();
            return (int)Math.Floor((decimal)initialBirds);
        }

        public decimal GetCurrentStageFoodEntry(Guid batchId, DateTime date)
        {
            var batch = this.GetById(batchId);

            var startStageDate = batch.CurrentStageStartDate;
            var endStageDate = date;

            var measures =
                Uow.Measures.GetAll(
                    x =>
                        x.BatchId == batchId &&
                        x.StandardItem.StandardGeneticLine.Standard.Name.Contains(FoodEntryStandardName) &&
                        x.Date >= startStageDate &&
                        x.Date <= endStageDate,
                    x => x.StandardItem.StandardGeneticLine.Standard);

            var foodEntry = measures.Select(x => x.Value).DefaultIfEmpty(0).Sum();

            return foodEntry;
        }

        public void Create(Batch batch)
        {
            foreach (var batchBarn in batch.BatchBarns)
            {
                Uow.BatchBarns.Add(batchBarn);
            }

            Uow.Batches.Add(batch);

            Uow.Commit();
        }

        public void Delete(Guid batchId)
        {
            Uow.Batches.Delete(batchId);
            Uow.Commit();
        }

        public DateTime GetEndDateById(Guid batchId)
        {
            var batch = Uow.Batches.Get(x => x.Id == batchId, x => x.GeneticLine);

            return batch.DateOfBirth.AddDays(batch.GeneticLine.ProductionWeeks * 7);
        }

        public Batch GetById(Guid batchId)
        {
            return Uow.Batches.Get(x => x.Id == batchId,
                                b => b.Measures,
                                b => b.Measures.Select(m => m.StandardItem),
                                b => b.Measures.Select(m => m.StandardItem.StandardGeneticLine),
                                b => b.Measures.Select(m => m.StandardItem.StandardGeneticLine.GeneticLine),
                                b => b.Measures.Select(m => m.StandardItem.StandardGeneticLine.Standard),
                                b => b.GeneticLine);
        }


        public void EndBatch(Batch batch, DateTime endDate)
        {
            batch.EndDate = endDate;
            Uow.Batches.Edit(batch);
            Uow.Commit();
        }


        public string AssignBarn(Guid batchId, Guid barnId)
        {
            var batch = GetById(batchId);

            //ahora chequeo que el galpon este disponible
            var availableBarns = _barnService.GetAllAvailable();
            if (availableBarns.All(b => b.Id != barnId))
            {
                return "El galpón seleccionado ya no se encuentra disponible";
            }

            Uow.Batches.Edit(batch);
            Uow.Commit();
            return null;
        }

        public IQueryable<Batch> GetAll()
        {
            return Uow.Batches.GetAll();
        }

        public void MoveNextStage(MoveNextStageDto nextStageDto)
        {
            var batch = GetById(nextStageDto.BatchId);

            if (batch.StageId == Stage.POSTURE)
            {
                throw new ApplicationException("El lote ya se encuentra en la ultima etapa de postura");
            }

            var currentStage = batch.StageId;
            var nextStage = Stage.NextStageId(batch.StageId);

            var stageChange = new StageChange();

            stageChange.BatchId = batch.Id;
            stageChange.StageFromId = currentStage;
            stageChange.StageToId = nextStage;
            stageChange.CurrentFoodStock = nextStageDto.CurrentFoodStock;

            stageChange.FoodEntryDuringPeriod = GetCurrentStageFoodEntry(batch.Id, nextStageDto.NextStageStartDate);
            stageChange.StageFromInitialBirds = GetInitialBirds(batch.Id, currentStage);
            stageChange.StageFromIFinalBirds = GetBirdsAmount(batch.Id, nextStageDto.NextStageStartDate);

            Uow.StageChanges.Add(stageChange);

            batch.StageId = nextStage;

            if (nextStage == Stage.REBREEDING)
            {
                batch.ReBreedingDate = nextStageDto.NextStageStartDate;
            }
            else if (nextStage == Stage.POSTURE)
            {
                batch.PostureDate = nextStageDto.NextStageStartDate;
            }

            Uow.Batches.Edit(batch);

            foreach (var barn in nextStageDto.BarnsAssigned)
            {
                Uow.BatchBarns.Add(new BatchBarn()
                                   {
                                       BatchId = batch.Id,
                                       BarnId = barn.BarnId,
                                       InitialBirds = (int)barn.InitialBirds
                                   });
            }

            Uow.Commit();
        }

        public IList<BatchBarnDetailDto> GetBarnsDetails(Guid batchId)
        {

            var detailList = new List<BatchBarnDetailDto>();

            var batch = Uow.Batches.Get(batchId);

            var barnsBatches = Uow.BatchBarns.GetAll(x => x.BatchId == batchId, x => x.Batch.Stage)
                .OrderBy(x => x.CreatedDate)
                .Project()
                .To<BatchBarnDto>()
                .ToList();

            var barnsGrouped = barnsBatches.GroupBy(x => x.BarnStageName);

            foreach (IGrouping<string, BatchBarnDto> barnsBatch in barnsGrouped)
            {
                if (!barnsBatch.Any())
                {
                    continue;
                }

                detailList.Add(new BatchBarnDetailDto()
                               {
                                   BatchBarns = barnsBatch.ToList(),
                                   StageDetails =
                                       string.Format("{0} ({1})", barnsBatch.Key,
                                           batch.GetDateByState(barnsBatch.First().BarnStageId).ToShortDateString())
                               });
            }

            return detailList;
        }
    }
}
