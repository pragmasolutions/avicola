﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
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
        
        private readonly IBarnService _barnService;

        public BatchService(IOfficeUow uow, IBarnService barnService)
        {
            Uow = uow;
            _barnService = barnService;
        }

        public IList<BatchDto> GetAllActive()
        {
            return Uow.Batches.GetAll(x => !x.EndDate.HasValue && !x.IsDeleted, 
                                    x => x.BatchBarns, 
                                    x => x.BatchBarns.Select(bb => bb.Barn))
                    .Project()
                    .To<BatchDto>()
                    .ToList();
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

        public decimal GetBirdsAmount(Guid batchId)
        {
            var startStageDate = DateTime.Today;
            var endStageDate = DateTime.Today;

            var measures =
                Uow.Measures.GetAll(
                    x =>
                        x.BatchId == batchId &&
                        x.StandardItem.StandardGeneticLine.Standard.Name.Contains(MortalityStandardName) &&
                        x.Date >= startStageDate &&
                        x.Date <= endStageDate,
                    x => x.StandardItem.StandardGeneticLine.Standard);

            var batch = Uow.BatchBarns.GetAll(x => x.BarnId == batchId && x.Barn.StageId == x.Batch.StageId, x => x.Batch,x => x.Barn);

            var initialBirds = batch.Sum(x => x.InitialBirds);

            var deathBirds = measures.Sum(x => x.Value);

            return initialBirds - deathBirds;
        }

        public void Create(Batch batch)
        {
            var geneticLine = Uow.GeneticLines.Get(batch.GeneticLineId);
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


            //chequeamos que no tenga medidas de precria para fechas posteriores
            //foreach (var measure in batch.Measures)
            //{
            //    if (measure.Date > arrivedToBarn && measure.StandardItem.StandardGeneticLine.StageId == Stage.BREEDING)
            //    {
            //        return "Existen medidas cargadas para estandares de cría y pre-cría posteriores a la fecha seleccionada";
            //    }
            //}

            //ahora chequeo que el galpon este disponible
            var availableBarns = _barnService.GetAllAvailable();
            if (availableBarns.All(b => b.Id != barnId))
            {
                return "El galpón seleccionado ya no se encuentra disponible";
            }

            //var today = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, 0, 0, 0);
            //if (arrivedToBarn <= today)
            //{
            //    batch.StageId = Stage.POSTURE;
            //}
            //batch.ArrivedToBarn = arrivedToBarn;
            //batch.BarnId = barnId;
            Uow.Batches.Edit(batch);
            Uow.Commit();
            return null;
        }


        public IQueryable<Batch> GetAll()
        {
            return Uow.Batches.GetAll();
        }
    }
}
