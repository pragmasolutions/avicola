using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Avicola.Office.Entities.DTO;
using Avicola.Office.Services.Dtos;
using Avicola.Office.Services.Interfaces;
using Avicola.Web.Models.Standards;
using Framework.Common.Web.Alerts;
using PagedList;

namespace Avicola.Web.Controllers
{
    public class StandardController : BaseController
    {
        private readonly IStandardService _standardService;

        public StandardController(IStandardService standardService)
        {
            _standardService = standardService;
        }

        public ActionResult Index(StandardListFiltersModel filters)
        {
            int pageTotal;

            var standards = _standardService.GetAll("CreatedDate", "DESC", filters.Criteria, filters.Page, DefaultPageSize, out pageTotal);

            var pagedList = new StaticPagedList<StandardDto>(standards, filters.Page, DefaultPageSize, pageTotal);

            var listModel = new StandardListModel(pagedList, filters);

            return View(listModel);
        }

        public ActionResult Detail(Guid id)
        {
            var standard = _standardService.GetById(id);
            var standardForm = StandardForm.FromStandard(standard);
            return View(standardForm);
        }

        public ActionResult Create()
        {
            var standardForm = new StandardForm();
            return View(standardForm);
        }

        [HttpPost, ValidateAntiForgeryToken]
        public ActionResult Create(StandardForm standardForm)
        {
            if (!ModelState.IsValid)
            {
                return View(standardForm);
            }
            var available = _standardService.IsNameAvailable(standardForm.Name, Guid.Empty);
            if (!available)
            {
                return View(standardForm).WithError("Ya existe una standard con el nombre ingresado.");
            }

            var standard = standardForm.ToStandard();

            _standardService.Create(standard);

            return RedirectToAction("Index", new StandardListFiltersModel().GetRouteValues()).WithSuccess("Línea genética creada");
        }

        public ActionResult Edit(Guid id)
        {
            var standard = _standardService.GetById(id);
            var standardForm = StandardForm.FromStandard(standard);
            return View(standardForm);
        }

        [HttpPost, ValidateAntiForgeryToken]
        public ActionResult Edit(Guid id, StandardForm standardForm)
        {
            if (!ModelState.IsValid)
            {
                return View(standardForm);
            }
            var available = _standardService.IsNameAvailable(standardForm.Name, id);
            if (!available)
            {
                return View(standardForm).WithError("Ya existe un estandar con el nombre ingresado.");
            }

            _standardService.Edit(standardForm.ToStandard());

            return RedirectToAction("Index", new StandardListFiltersModel().GetRouteValues()).WithSuccess("Línea genética editada");
        }

        [HttpPost, ValidateAntiForgeryToken]
        public ActionResult Delete(Guid id, FormCollection collection)
        {
            _standardService.Delete(id);

            return RedirectToAction("Index", new StandardListFiltersModel().GetRouteValues()).WithSuccess("Línea genética eliminada");
        }

        public ActionResult IsNameAvailable(string name, Guid id)
        {
            return Json(_standardService.IsNameAvailable(name, id), JsonRequestBehavior.AllowGet);
        }
    }
}