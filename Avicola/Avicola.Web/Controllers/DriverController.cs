using System;
using System.Web.Mvc;
using Avicola.Sales.Services.Dtos;
using Avicola.Sales.Services.Interfaces;
using Avicola.Web.Models;
using Framework.Common.Web.Alerts;
using PagedList;

namespace Avicola.Web.Controllers
{
    public class DriverController : BaseController
    {
        private readonly IDriverService _driverService;

        public DriverController(IDriverService driverService)
        {
            _driverService = driverService;
        }

        public ActionResult Index(DriverListFiltersModel filters)
        {
            int pageTotal;

            var drivers = _driverService.GetAll("CreatedDate", "DESC", filters.Criteria, filters.Page, DefaultPageSize, out pageTotal);

            var pagedList = new StaticPagedList<DriverDto>(drivers, filters.Page, DefaultPageSize, pageTotal);

            var listModel = new DriverListModel(pagedList, filters);

            return View(listModel);
        }

        public ActionResult Detail(Guid id)
        {
            var driver = _driverService.GetById(id);
            var driverForm = DriverForm.FromDriver(driver);
            return View(driverForm);
        }

        public ActionResult Create()
        {
            var driverForm = new DriverForm();
            return View(driverForm);
        }

        [HttpPost, ValidateAntiForgeryToken]
        public ActionResult Create(DriverForm driverForm)
        {
            if (!ModelState.IsValid)
            {
                return View(driverForm);
            }

            var driver = driverForm.ToDriver();

            _driverService.Create(driver);

            return RedirectToAction("Index", new DriverListFiltersModel().GetRouteValues()).WithSuccess("Conductor Creado");
        }

        public ActionResult Edit(Guid id)
        {
            var driver = _driverService.GetById(id);
            var driverForm = DriverForm.FromDriver(driver);
            return View(driverForm);
        }

        [HttpPost, ValidateAntiForgeryToken]
        public ActionResult Edit(Guid id, DriverForm driverForm)
        {
            if (!ModelState.IsValid)
            {
                return View(driverForm);
            }

            _driverService.Edit(driverForm.ToDriver());

            return RedirectToAction("Index", new DriverListFiltersModel().GetRouteValues()).WithSuccess("Conductor Editado");
        }

        [HttpPost, ValidateAntiForgeryToken]
        public ActionResult Delete(Guid id, FormCollection collection)
        {
            _driverService.Delete(id);

            return RedirectToAction("Index", new DriverListFiltersModel().GetRouteValues()).WithSuccess("Conductor Eliminado");
        }
    }
}