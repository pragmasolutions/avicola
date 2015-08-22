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
    public class GeneticLineController : BaseController
    {
        private readonly IGeneticLineService _geneticLineService;

        public GeneticLineController(IGeneticLineService geneticLineService)
        {
            _geneticLineService = geneticLineService;
        }

        public ActionResult Index(GeneticLineListFiltersModel filters)
        {
            int pageTotal;

            var geneticLines = _geneticLineService.GetAll("CreatedDate", "DESC", filters.Criteria, filters.Page, DefaultPageSize, out pageTotal);

            var pagedList = new StaticPagedList<GeneticLineDto>(geneticLines, filters.Page, DefaultPageSize, pageTotal);

            var listModel = new GeneticLineListModel(pagedList, filters);

            return View(listModel);
        }

        public ActionResult Detail(Guid id)
        {
            var geneticLine = _geneticLineService.GetById(id);
            var geneticLineForm = GeneticLineForm.FromGeneticLine(geneticLine);
            return View(geneticLineForm);
        }

        public ActionResult Create()
        {
            var geneticLineForm = new GeneticLineForm();
            return View(geneticLineForm);
        }

        [HttpPost, ValidateAntiForgeryToken]
        public ActionResult Create(GeneticLineForm geneticLineForm)
        {
            if (!ModelState.IsValid)
            {
                return View(geneticLineForm);
            }

            var geneticLine = geneticLineForm.ToGeneticLine();

            _geneticLineService.Create(geneticLine);

            return RedirectToAction("Index", new GeneticLineListFiltersModel().GetRouteValues()).WithSuccess("Línea genética creada");
        }

        public ActionResult Edit(Guid id)
        {
            var geneticLine = _geneticLineService.GetById(id);
            var geneticLineForm = GeneticLineForm.FromGeneticLine(geneticLine);
            return View(geneticLineForm);
        }

        [HttpPost, ValidateAntiForgeryToken]
        public ActionResult Edit(Guid id, GeneticLineForm geneticLineForm)
        {
            if (!ModelState.IsValid)
            {
                return View(geneticLineForm);
            }

            _geneticLineService.Edit(geneticLineForm.ToGeneticLine());

            return RedirectToAction("Index", new GeneticLineListFiltersModel().GetRouteValues()).WithSuccess("Línea genética editada");
        }

        [HttpPost, ValidateAntiForgeryToken]
        public ActionResult Delete(Guid id, FormCollection collection)
        {
            _geneticLineService.Delete(id);

            return RedirectToAction("Index", new GeneticLineListFiltersModel().GetRouteValues()).WithSuccess("Línea genética eliminada");
        }

        public ActionResult IsNameAvailable(string name, Guid id)
        {
            return Json(_geneticLineService.IsNameAvailable(name, id), JsonRequestBehavior.AllowGet);
        }
    }
}