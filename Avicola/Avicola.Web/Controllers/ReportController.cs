using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Avicola.Office.Entities;
using Avicola.Office.Services.Interfaces;
using Avicola.Reports;
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

                if (DateTime.Now >= batch.CalculatedPostureStartDate)
                {
                    list.Add(new Stage() { Name = "Postura", Id = Stage.POSTURE });
                }
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
                var reportFactory = new ReportFactory();

                var parameters = new Dictionary<string, string>
                              {
                                  {"BatchId", model.BatchId.ToString()},
                                  {"DateFrom", null},
                                  {"DateTo", null},
                                  {"StageId", model.StageId.ToString()}
                              };

                reportFactory.SetPathCompleto(Server.MapPath("~/Reports/MeasuresFollowUp.rdl"))
                    .SetDataSource("DataSet1", dataset)
                    .SetDataSource("BatchObservation", dsBatchObservation)
                    .SetDataSource("BatchVaccine", dsBatchVaccine)
                    .SetParametro(parameters); 

                byte[] archivo = reportFactory.Renderizar(model.ReportType);

                return File(archivo, reportFactory.MimeType);
                
            }
            return null;
        }
    }
}