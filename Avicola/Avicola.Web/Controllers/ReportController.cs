using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Avicola.Office.Entities;
using Avicola.Office.Services.Interfaces;
using Avicola.Reports;
using Avicola.Web.Extensions;
using Avicola.Web.Models.Reports;

namespace Avicola.Web.Controllers
{
    public class ReportController : BaseController
    {
        private readonly IReportService _reportService;
        private readonly IBatchService _batchService;

        public ReportController(IReportService reportService, IBatchService batchService)
        {
            _reportService = reportService;
            _batchService = batchService;
        }

        public ActionResult GetBatches(int id)
        {
            var query = _batchService.GetAll();
            if (id == 0)
            {
                query = query.Where(b => b.EndDate == null);
            }
            else if (id == 1)
            {
                query = query.Where(b => b.EndDate != null);
            }
            var result = query.ToList().Select(x => new
            {
                x.Id,
                x.Name
            }).ToList();
            return Json(result, JsonRequestBehavior.AllowGet);
        }

        public ActionResult GetStages(Guid? id)
        {
            var list = new List<Stage>();
            if (id != null)
            {
                var batch = _batchService.GetById(id.GetValueOrDefault());
                list.Add(new Stage(){ Name = "Cría y Pre-Cría", Id = Stage.BREEDING});

                //if (DateTime.Now >= batch.CalculatedPostureStartDate)
                //{
                //    list.Add(new Stage() { Name = "Postura", Id = Stage.POSTURE });
                //}
            }
            var result = list.Select(x => new {x.Id, x.Name});
            return Json(result, JsonRequestBehavior.AllowGet);
        }

        
        public ActionResult MeasuresFollowUp(MeasuresFollowUpFilterModel model)
        {
            var activeBatches = _batchService.GetAllActiveComplete().OrderBy(b => b.Number).ToList();
            ViewBag.BatchesSelectList = new SelectList(activeBatches, "Id", "Name");
            return View(model);
        }

        public ActionResult GenerateMeasuresFollowUp(MeasuresFollowUpFilterModel model)
        {
            if (ModelState.IsValid)
            {

                var dataset = model.StageId == Stage.BREEDING
                    ? _reportService.BreedingMeasuresFollowUp(model.BatchId, DateTime.Now.AddMonths(-5),
                        DateTime.Now.AddMonths(1)).ToList()
                    : null;
                var dsBatchObservation = _reportService.BatchObservation(model.BatchId, model.StageId);
                var dsBatchVaccine = _reportService.BatchVaccine(model.BatchId, model.StageId);
                var dsBatchMedicine = _reportService.BatchMedicine(model.BatchId, model.StageId);
                var reportFactory = new ReportFactory();

                var parameters = new Dictionary<string, string>
                              {
                                  {"BatchId", model.BatchId.ToString()},
                                  {"DateFrom", null},
                                  {"DateTo", null},
                                  {"StageId", null}
                              };

                reportFactory.SetPathCompleto(Server.MapPath("~/Reports/MeasuresFollowUp.rdl"))
                    .SetDataSource("DataSet1", dataset)
                    .SetDataSource("BatchObservation", dsBatchObservation)
                    .SetDataSource("BatchVaccine", dsBatchVaccine)
                    .SetDataSource("BatchMedicine", dsBatchMedicine)
                    .SetParametro(parameters); 

                byte[] archivo = reportFactory.Renderizar(model.ReportType);

                return File(archivo, reportFactory.MimeType);
                
            }
            return null;
        }

        public ActionResult BatchStandardFollowUp(BatchStandardFollowUpModel model)
        {
            var activeBatches = _batchService.GetAllActiveComplete().OrderBy(b => b.Number).ToList();
            ViewBag.BatchesSelectList = new SelectList(activeBatches, "Id", "Name");
            ViewBag.Standards = new SelectList(new List<SelectListItem>(), "Value", "Text");
            return View(model);
        }

        public ActionResult GetStandards(Guid? id)
        {
            var batch = _batchService.GetById(id.GetValueOrDefault());
            var result = batch.GeneticLine.StandardGeneticLines.Where(sgl => !sgl.IsDeleted)
                            .Select(sgl => sgl.Standard).Select(x => new { x.Id, x.Name });
            return Json(result, JsonRequestBehavior.AllowGet);
        }


        public ActionResult GenerateBatchStandardFollowUp(Guid batchId, Guid standardId)
        {
            var batch = _batchService.GetByIdComplete(batchId);

            var weeksAge = Math.Ceiling(DateTime.Now.Subtract(batch.DateOfBirth).Days / (double)7);
            var obj = new
            {
                batch.Id,
                Name = String.Format("Lote {0}", batch.Number),
                GeneticLine = new
                {
                    batch.GeneticLine.Name,
                    Standards = batch.GeneticLine.StandardGeneticLines.Where(sql => !sql.IsDeleted & sql.StandardId == standardId).Select(sgl => new
                    {
                        sgl.Standard.Name,
                        ShowSecondValue = sgl.Standard.StandardTypeId == StandardType.VALUES_RANGE,
                        sgl.Standard.AggregateOperation,
                        sgl.Standard.AllowDecimal,
                        sgl.Standard.MeasureUnity,
                        StandardItems = sgl.StandardItems.Where(sql => !sgl.IsDeleted && sql.Sequence <= weeksAge).OrderBy(s => s.Sequence).Select(si => new
                        {
                            si.Value1,
                            si.Value2,
                            si.Sequence,
                            Measures =
                                si.Measures.Where(m => !m.IsDeleted && m.BatchId == batch.Id).Select(m => new
                                {
                                    m.Value,
                                    m.StandardItemId
                                })
                        })
                    })
                }
            };
            return Json(obj, JsonRequestBehavior.AllowGet);
        }

    }
}