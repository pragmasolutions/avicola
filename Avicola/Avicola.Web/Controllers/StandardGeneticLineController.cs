using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Avicola.Office.Entities;
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
        private readonly IStandardService _standardService;
        private readonly IGeneticLineService _geneticLineService;

        public StandardGeneticLineController(IStandardGeneticLineService service, IStandardService standardService, IGeneticLineService geneticLineService)
        {
            _service = service;
            _standardService = standardService;
            _geneticLineService = geneticLineService;
        }

        public ActionResult Index(Guid id)
        {
            
            var line = _geneticLineService.GetById(id);
            
            var standards = _standardService.GetAll().ToList();
            var lineItems = _service.GetByGeneticLine(id);
            var missing = standards.Where(s => !lineItems.Any(x => x.Standard.Id == s.Id)).ToList();
            ViewBag.HideButtons = missing.Any();
            ViewBag.MissingList = new SelectList(missing, "Id", "Name");

            var model = new StandardGeneticLineForm()
            {
                GeneticLine = line,
                MissingList = missing
            };
            return View(model);
        }

        public ActionResult Create(Guid geneticLineId, Guid standardId)
        {
            var geneticLine = _geneticLineService.GetById(geneticLineId);
            var standard = _standardService.GetById(standardId);

            var model = new CreateStandardGeneticLineForm()
            {
                GeneticLine = geneticLine,
                Standard = standard
            };
            model.GenerateItems();
            return View(model);
        }

        [HttpPost]
        public ActionResult Create(CreateStandardGeneticLineForm form)
        {
            if (!ModelState.IsValid)
            {
                return View(form).WithError("Se ha producido un error. Por favor valide que los datos ingresados sean correctos");
            }

            StandardGeneticLine item = form.ToStandardGeneticLine();
            _service.Create(item);
            return Redirect("/StandardGeneticLine/Index/" + form.GeneticLine.Id).WithSuccess("El estandar se ha creado correctamente");
        }

        public ActionResult Detail(Guid id)
        {
            var item = _service.GetById(id);
            ViewBag.GeneticLineId = id;
            return View(item);
        }

    }
}