using System;
using System.Web.Mvc;
using Avicola.Sales.Services.Dtos;
using Avicola.Sales.Services.Interfaces;
using Avicola.Web.Models;
using Framework.Common.Web.Alerts;
using PagedList;

namespace Avicola.Web.Controllers
{
    public class ProviderController : BaseController
    {
        private readonly IProviderService _providerService;

        public ProviderController(IProviderService providerService)
        {
            _providerService = providerService;
        }

        public ActionResult Index(ProviderListFiltersModel filters)
        {
            int pageTotal;

            var providers = _providerService.GetAll("CreatedDate", "DESC", filters.Criteria, filters.Page, DefaultPageSize, out pageTotal);

            var pagedList = new StaticPagedList<ProviderDto>(providers, filters.Page, DefaultPageSize, pageTotal);

            var listModel = new ProviderListModel(pagedList, filters);

            return View(listModel);
        }

        public ActionResult Detail(Guid id)
        {
            var provider = _providerService.GetById(id);
            var providerForm = ProviderForm.FromProvider(provider);
            return View(providerForm);
        }

        public ActionResult Create()
        {
            var providerForm = new ProviderForm();
            return View(providerForm);
        }

        [HttpPost, ValidateAntiForgeryToken]
        public ActionResult Create(ProviderForm providerForm)
        {
            if (!ModelState.IsValid)
            {
                return View(providerForm);
            }

            var provider = providerForm.ToProvider();

            _providerService.Create(provider);

            return RedirectToAction("Index", new ProviderListFiltersModel().GetRouteValues()).WithSuccess("Camion Creado");
        }

        public ActionResult Edit(Guid id)
        {
            var provider = _providerService.GetById(id);
            var providerForm = ProviderForm.FromProvider(provider);
            return View(providerForm);
        }

        [HttpPost, ValidateAntiForgeryToken]
        public ActionResult Edit(Guid id, ProviderForm providerForm)
        {
            if (!ModelState.IsValid)
            {
                return View(providerForm);
            }

            _providerService.Edit(providerForm.ToProvider());

            return RedirectToAction("Index", new ProviderListFiltersModel().GetRouteValues()).WithSuccess("Camion Editado");
        }

        [HttpPost, ValidateAntiForgeryToken]
        public ActionResult Delete(Guid id, FormCollection collection)
        {
            _providerService.Delete(id);

            return RedirectToAction("Index", new ProviderListFiltersModel().GetRouteValues()).WithSuccess("Camion Eliminado");
        }

        public ActionResult IsNameAvailable(string name, Guid id)
        {
            return Json(_providerService.IsNameAvailable(name, id), JsonRequestBehavior.AllowGet);
        }
    }
}