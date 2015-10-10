using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Avicola.Office.Entities.DTO;
using Avicola.Office.Services.Dtos;
using Avicola.Office.Services.Interfaces;
using Avicola.Web.Models.Vaccinees;
using Framework.Common.Web.Alerts;
using PagedList;

namespace Avicola.Web.Controllers
{
    public class VaccineController : BaseController
    {
        private readonly IVaccineService _vaccineService;

        public VaccineController(IVaccineService vaccineService)
        {
            _vaccineService = vaccineService;
        }

        public ActionResult Index(VaccineListFiltersModel filters)
        {
            int pageTotal;

            var vaccinees = _vaccineService.GetAll("CreatedDate", "DESC", filters.Criteria, filters.Page, DefaultPageSize, out pageTotal);

            var pagedList = new StaticPagedList<VaccineDto>(vaccinees, filters.Page, DefaultPageSize, pageTotal);

            var listModel = new VaccineListModel(pagedList, filters);

            return View(listModel);
        }

        public ActionResult Detail(Guid id)
        {
            var vaccine = _vaccineService.GetById(id);
            var vaccineForm = VaccineForm.FromVaccine(vaccine);
            return View(vaccineForm);
        }

        public ActionResult Create()
        {
            var vaccineForm = new VaccineForm();
            return View(vaccineForm);
        }

        [HttpPost, ValidateAntiForgeryToken]
        public ActionResult Create(VaccineForm vaccineForm)
        {
            if (!ModelState.IsValid)
            {
                return View(vaccineForm);
            }
            var available = _vaccineService.IsNameAvailable(vaccineForm.Name, Guid.Empty);
            if (!available)
            {
                return View(vaccineForm).WithError("Ya existe una vacuna con el nombre ingresado.");
            }

            var vaccine = vaccineForm.ToVaccine();

            _vaccineService.Create(vaccine);

            return RedirectToAction("Index", new VaccineListFiltersModel().GetRouteValues()).WithSuccess("Vacuna creada");
        }

        public ActionResult Edit(Guid id)
        {
            var vaccine = _vaccineService.GetById(id);
            var vaccineForm = VaccineForm.FromVaccine(vaccine);
            return View(vaccineForm);
        }

        [HttpPost, ValidateAntiForgeryToken]
        public ActionResult Edit(Guid id, VaccineForm vaccineForm)
        {
            if (!ModelState.IsValid)
            {
                return View(vaccineForm);
            }
            var available = _vaccineService.IsNameAvailable(vaccineForm.Name, id);
            if (!available)
            {
                return View(vaccineForm).WithError("Ya existe una vacuna con el nombre ingresado.");
            }

            _vaccineService.Edit(vaccineForm.ToVaccine());

            return RedirectToAction("Index", new VaccineListFiltersModel().GetRouteValues()).WithSuccess("Vacuna editada");
        }

        [HttpPost, ValidateAntiForgeryToken]
        public ActionResult Delete(Guid id, FormCollection collection)
        {
            _vaccineService.Delete(id);

            return RedirectToAction("Index", new VaccineListFiltersModel().GetRouteValues()).WithSuccess("Vacuna eliminada");
        }

        public ActionResult IsNameAvailable(string name, Guid id)
        {
            return Json(_vaccineService.IsNameAvailable(name, id), JsonRequestBehavior.AllowGet);
        }
    }
}