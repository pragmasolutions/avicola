using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Avicola.Office.Entities.DTO;
using Avicola.Office.Services.Dtos;
using Avicola.Office.Services.Interfaces;
using Framework.Common.Web.Alerts;
using PagedList;
using Avicola.Web.Models.Medicines;

namespace Avicola.Web.Controllers
{
    public class MedicineController : BaseController
    {
        private readonly IMedicineService _medicineService;

        public MedicineController(IMedicineService medicineService)
        {
            _medicineService = medicineService;
        }

        public ActionResult Index(MedicineListFiltersModel filters)
        {
            int pageTotal;

            var medicines = _medicineService.GetAll("CreatedDate", "DESC", filters.Criteria, filters.Page, DefaultPageSize, out pageTotal);

            var pagedList = new StaticPagedList<MedicineDto>(medicines, filters.Page, DefaultPageSize, pageTotal);

            var listModel = new MedicineListModel(pagedList, filters);

            return View(listModel);
        }

        public ActionResult Detail(Guid id)
        {
            var medicine = _medicineService.GetById(id);
            var medicineForm = MedicineForm.FromMedicine(medicine);
            return View(medicineForm);
        }

        public ActionResult Create()
        {
            var medicineForm = new MedicineForm();
            return View(medicineForm);
        }

        [HttpPost, ValidateAntiForgeryToken]
        public ActionResult Create(MedicineForm medicineForm)
        {
            if (!ModelState.IsValid)
            {
                return View(medicineForm);
            }
            var available = _medicineService.IsNameAvailable(medicineForm.Name, Guid.Empty);
            if (!available)
            {
                return View(medicineForm).WithError("Ya existe un medicamento con el nombre ingresado.");
            }

            var medicine = medicineForm.ToMedicine();

            _medicineService.Create(medicine);

            return RedirectToAction("Index", new MedicineListFiltersModel().GetRouteValues()).WithSuccess("Medicamento creado");
        }

        public ActionResult Edit(Guid id)
        {
            var medicine = _medicineService.GetById(id);
            var medicineForm = MedicineForm.FromMedicine(medicine);
            return View(medicineForm);
        }

        [HttpPost, ValidateAntiForgeryToken]
        public ActionResult Edit(Guid id, MedicineForm medicineForm)
        {
            if (!ModelState.IsValid)
            {
                return View(medicineForm);
            }
            var available = _medicineService.IsNameAvailable(medicineForm.Name, id);
            if (!available)
            {
                return View(medicineForm).WithError("Ya existe un medicamento con el nombre ingresado.");
            }

            _medicineService.Edit(medicineForm.ToMedicine());

            return RedirectToAction("Index", new MedicineListFiltersModel().GetRouteValues()).WithSuccess("Medicamento editado");
        }

        [HttpPost, ValidateAntiForgeryToken]
        public ActionResult Delete(Guid id, FormCollection collection)
        {
            _medicineService.Delete(id);

            return RedirectToAction("Index", new MedicineListFiltersModel().GetRouteValues()).WithSuccess("Medicamento eliminado");
        }

        public ActionResult IsNameAvailable(string name, Guid id)
        {
            return Json(_medicineService.IsNameAvailable(name, id), JsonRequestBehavior.AllowGet);
        }
    }
}