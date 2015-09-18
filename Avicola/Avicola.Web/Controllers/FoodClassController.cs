using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Avicola.Office.Entities.DTO;
using Avicola.Office.Services.Dtos;
using Avicola.Office.Services.Interfaces;
using Avicola.Web.Models.FoodClasses;
using Framework.Common.Web.Alerts;
using PagedList;

namespace Avicola.Web.Controllers
{
    public class FoodClassController : BaseController
    {
        private readonly IFoodClassService _foodClassService;

        public FoodClassController(IFoodClassService foodClassService)
        {
            _foodClassService = foodClassService;
        }

        public ActionResult Index(FoodClassListFiltersModel filters)
        {
            int pageTotal;

            var foodClasses = _foodClassService.GetAll("CreatedDate", "DESC", filters.Criteria, filters.Page, DefaultPageSize, out pageTotal);

            var pagedList = new StaticPagedList<FoodClassDto>(foodClasses, filters.Page, DefaultPageSize, pageTotal);

            var listModel = new FoodClassListModel(pagedList, filters);

            return View(listModel);
        }

        public ActionResult Detail(Guid id)
        {
            var foodClass = _foodClassService.GetById(id);
            var foodClassForm = FoodClassForm.FromFoodClass(foodClass);
            return View(foodClassForm);
        }

        public ActionResult Create()
        {
            var foodClassForm = new FoodClassForm();
            return View(foodClassForm);
        }

        [HttpPost, ValidateAntiForgeryToken]
        public ActionResult Create(FoodClassForm foodClassForm)
        {
            if (!ModelState.IsValid)
            {
                return View(foodClassForm);
            }
            var available = _foodClassService.IsNameAvailable(foodClassForm.Name, Guid.Empty);
            if (!available)
            {
                return View(foodClassForm).WithError("Ya existe una clase de comida con el nombre ingresado.");
            }

            var foodClass = foodClassForm.ToFoodClass();

            _foodClassService.Create(foodClass);

            return RedirectToAction("Index", new FoodClassListFiltersModel().GetRouteValues()).WithSuccess("Clase de comida creada");
        }

        public ActionResult Edit(Guid id)
        {
            var foodClass = _foodClassService.GetById(id);
            var foodClassForm = FoodClassForm.FromFoodClass(foodClass);
            return View(foodClassForm);
        }

        [HttpPost, ValidateAntiForgeryToken]
        public ActionResult Edit(Guid id, FoodClassForm foodClassForm)
        {
            if (!ModelState.IsValid)
            {
                return View(foodClassForm);
            }
            var available = _foodClassService.IsNameAvailable(foodClassForm.Name, id);
            if (!available)
            {
                return View(foodClassForm).WithError("Ya existe una clase de comida con el nombre ingresado.");
            }

            _foodClassService.Edit(foodClassForm.ToFoodClass());

            return RedirectToAction("Index", new FoodClassListFiltersModel().GetRouteValues()).WithSuccess("Clase de comida editada");
        }

        [HttpPost, ValidateAntiForgeryToken]
        public ActionResult Delete(Guid id, FormCollection collection)
        {
            _foodClassService.Delete(id);

            return RedirectToAction("Index", new FoodClassListFiltersModel().GetRouteValues()).WithSuccess("Clase de comida eliminada");
        }

        public ActionResult IsNameAvailable(string name, Guid id)
        {
            return Json(_foodClassService.IsNameAvailable(name, id), JsonRequestBehavior.AllowGet);
        }
    }
}