﻿using System;
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
        private readonly IStandardItemService _standardItemService;

        public StandardGeneticLineController(IStandardGeneticLineService service, IStandardService standardService, 
                        IGeneticLineService geneticLineService, IStandardItemService standardItemService)
        {
            _service = service;
            _standardService = standardService;
            _geneticLineService = geneticLineService;
            _standardItemService = standardItemService;
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
            ViewBag.Operation = "Create";

            var model = new CreateStandardGeneticLineForm()
            {
                StandardGeneticLine = new StandardGeneticLine()
                {
                    GeneticLine = geneticLine,
                    Standard = standard
                }
            };
            model.GenerateItems();
            return View(model);
        }

        [HttpPost]
        public ActionResult Create(CreateStandardGeneticLineForm form, FormCollection collection)
        {
            if (!ModelState.IsValid)
            {
                ViewBag.Operation = "Create";
                return View(form).WithError("Se ha producido un error. Por favor valide que los datos ingresados sean correctos");
            }
            form.StandardGeneticLine.Standard.AllowDecimal = collection["StandardGeneticLine.Standard.AllowDecimal"] == "True";
            StandardGeneticLine item = form.ToStandardGeneticLine();
            _service.Create(item);
            return Redirect("/StandardGeneticLine/Index/" + form.StandardGeneticLine.GeneticLine.Id).WithSuccess("El estandar se ha creado correctamente");
        }

        public ActionResult Detail(Guid id)
        {
            var item = _service.GetById(id);
            var model = new CreateStandardGeneticLineForm()
            {
                StandardGeneticLine = item
            };
            model.GenerateItems();
            return View(model);
        }

        public ActionResult Select(Guid id)
        {
            var model = new SelectStandardModel() {GeneticLineId = id};
            return PartialView(model);
        }

        [HttpPost]
        public ActionResult Select(SelectStandardModel model)
        {
            var exists = _service.CheckExistance(model.GeneticLineId, model.StandardId);
            if (exists)
                return Redirect("/StandardGeneticLine/Index/" + model.GeneticLineId).WithError("Ya existe un estandar para la línea genética y etapa seleccionada");

            var url = String.Format("/StandardGeneticLine/Create?geneticLineId={0}&standardId={1}",
                                model.GeneticLineId,
                                model.StandardId);

            return Redirect(url);
        }

        [HttpPost]
        public ActionResult Delete(Guid id)
        {
            var standard = _service.GetById(id);
            var geneticLineId = standard.GeneticLineId;

            _service.Delete(id);
            return Redirect("/StandardGeneticLine/Index/" + geneticLineId).WithSuccess("Estandar eliminado correctamente.");
        }

        public ActionResult Edit(Guid id)
        {
            var item = _service.GetById(id);
            ViewBag.Operation = "Edit";

            var model = new CreateStandardGeneticLineForm()
            {
                StandardGeneticLine = item,
            };
            model.GenerateItems();
            return View("Create", model);
        }

        [HttpPost]
        public ActionResult Edit(CreateStandardGeneticLineForm form, FormCollection collection)
        {
            if (!ModelState.IsValid)
            {
                ViewBag.Operation = "Edit";
                return View(form).WithError("Se ha producido un error. Por favor valide que los datos ingresados sean correctos");
            }
            form.StandardGeneticLine.Standard.AllowDecimal = collection["StandardGeneticLine.Standard.AllowDecimal"] == "True";
            StandardGeneticLine item = form.ToStandardGeneticLine();
            _service.Edit(item);
            return Redirect("/StandardGeneticLine/Index/" + form.StandardGeneticLine.GeneticLine.Id).WithSuccess("El estandar se ha editado correctamente");
        }
    }
}