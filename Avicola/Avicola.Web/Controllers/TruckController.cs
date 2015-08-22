using System;
using System.Web.Mvc;
using Avicola.Sales.Services.Dtos;
using Avicola.Sales.Services.Interfaces;
using Avicola.Web.Models;
using Framework.Common.Web.Alerts;
using PagedList;

namespace Avicola.Web.Controllers
{
    public class TruckController : BaseController
    {
        private readonly ITruckService _truckService;

        public TruckController(ITruckService truckService)
        {
            _truckService = truckService;
        }

        public ActionResult Index(TruckListFiltersModel filters)
        {
            int pageTotal;

            var trucks = _truckService.GetAll("CreatedDate", "DESC", filters.Criteria, filters.Page, DefaultPageSize, out pageTotal);

            var pagedList = new StaticPagedList<TruckDto>(trucks, filters.Page, DefaultPageSize, pageTotal);

            var listModel = new TruckListModel(pagedList, filters);

            return View(listModel);
        }

        public ActionResult Detail(Guid id)
        {
            var truck = _truckService.GetById(id);
            var truckForm = TruckForm.FromTruck(truck);
            return View(truckForm);
        }

        public ActionResult Create()
        {
            var truckForm = new TruckForm();
            return View(truckForm);
        }

        [HttpPost, ValidateAntiForgeryToken]
        public ActionResult Create(TruckForm truckForm)
        {
            if (!ModelState.IsValid)
            {
                return View(truckForm);
            }

            var truck = truckForm.ToTruck();

            _truckService.Create(truck);

            return RedirectToAction("Index", new TruckListFiltersModel().GetRouteValues()).WithSuccess("Camion Creado");
        }

        public ActionResult Edit(Guid id)
        {
            var truck = _truckService.GetById(id);
            var truckForm = TruckForm.FromTruck(truck);
            return View(truckForm);
        }

        [HttpPost, ValidateAntiForgeryToken]
        public ActionResult Edit(Guid id, TruckForm truckForm)
        {
            if (!ModelState.IsValid)
            {
                return View(truckForm);
            }

            _truckService.Edit(truckForm.ToTruck());

            return RedirectToAction("Index", new TruckListFiltersModel().GetRouteValues()).WithSuccess("Camion Editado");
        }

        [HttpPost, ValidateAntiForgeryToken]
        public ActionResult Delete(Guid id, FormCollection collection)
        {
            _truckService.Delete(id);

            return RedirectToAction("Index", new TruckListFiltersModel().GetRouteValues()).WithSuccess("Camion Eliminado");
        }
    }
}