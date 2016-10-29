using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Avicola.Office.Services.Interfaces;
using Avicola.Web.Extensions;

namespace Avicola.Web.Controllers
{
    public class ControlPanelController : Controller
    {
        private readonly IBatchService _batchService;

        public ControlPanelController(IBatchService batchService)
        {
            _batchService = batchService;
        }

        public ActionResult ProductionStandards()
        {
            return View();
        }

        public ActionResult GetAllActive()
        {
            var list = _batchService.GetAllActiveComplete().Select(x => x.ToJSON());
            return Json(list, JsonRequestBehavior.AllowGet);
        }
    }
}