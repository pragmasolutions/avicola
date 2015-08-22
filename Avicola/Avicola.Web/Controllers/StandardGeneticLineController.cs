using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Avicola.Office.Entities.DTO;
using Avicola.Office.Services.Interfaces;
using Avicola.Web.Models.GeneticLines;
using Framework.Common.Web.Alerts;
using PagedList;

namespace Avicola.Web.Controllers
{
    public class StandardGeneticLineController : BaseController
    {
        private readonly IStandardGeneticLineService _service;

        public StandardGeneticLineController(IStandardGeneticLineService service)
        {
            _service = service;
        }

        public ActionResult Index(Guid id)
        {
            var list = _service.GetByGeneticLine(id);
            return View(list);
        }

        public ActionResult Detail(Guid id)
        {
            var item = _service.GetById(id);
            ViewBag.GeneticLineId = id;
            return View(item);
        }
    }
}