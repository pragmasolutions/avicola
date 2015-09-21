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

                if (batch.ArrivedToBarn != null && batch.ArrivedToBarn >= DateTime.Now)
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

                //var ventasPorProductoDataSource = Uow.Reportes.VentasPorCierreCaja(model.CierreCajaId).ToList();

                //var ventasPorProductoRankingDataSource = Uow.Reportes.VentasPorProductoRanking(null, null, null, null, null, model.CierreCajaId).ToList();
                //var reporteFactory = new ReportFactory();

                //var cierreCaja = Uow.CierresDeCaja.Obtener(c => c.CierreCajaId == model.CierreCajaId,
                //                                            c => c.Usuario, c => c.MaxiKiosco);
                //var parameters = new Dictionary<string, string>
                //              {
                //                  {"CierreCajaId", model.CierreCajaId.ToString()},
                //                  {"Desde", cierreCaja.FechaInicioFormateada},
                //                  {"Hasta", string.IsNullOrEmpty(cierreCaja.FechaFinFormateada) ? "TODAVIA ABIERTA" : cierreCaja.FechaFinFormateada},
                //                  {"Usuario", cierreCaja.Usuario.NombreUsuario},
                //                  {"Maxikiosco", cierreCaja.MaxiKiosco.Nombre}
                //              };

                //reporteFactory.SetPathCompleto(Server.MapPath("~/Reportes/VentasPorCierreCaja.rdl"))
                //    .SetDataSource("VentasPorProductoDataSet", ventasPorProductoDataSource)
                //    .SetDataSource("VentasPorProductoRankingDataSet", ventasPorProductoRankingDataSource)
                //    .SetParametro(parameters); ;

                //byte[] archivo = reporteFactory.Renderizar(model.ReportType);

                //return File(archivo, reporteFactory.MimeType);
                
            }
            return null;
        }
    }
}