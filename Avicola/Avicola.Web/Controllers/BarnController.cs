using System;
using System.Web.Mvc;
using Avicola.Office.Services.Dtos;
using Avicola.Office.Services.Interfaces;
using Avicola.Web.Models;
using Framework.Common.Web.Alerts;
using PagedList;

namespace Avicola.Web.Controllers
{
    public class BarnController : BaseController
    {
        private readonly IBarnService _barnService;

        public BarnController(IBarnService barnService)
        {
            _barnService = barnService;
        }

        public ActionResult Index(BarnListFiltersModel filters)
        {
            int pageTotal;

            var barns = _barnService.GetAll("CreatedDate", "DESC", filters.Criteria, filters.Page, DefaultPageSize, out pageTotal);

            var pagedList = new StaticPagedList<BarnDto>(barns, filters.Page, DefaultPageSize, pageTotal);

            var listModel = new BarnListModel(pagedList, filters);

            return View(listModel);
        }

        public ActionResult Detail(Guid id)
        {
            var barn = _barnService.GetById(id);
            var barnForm = BarnForm.FromBarn(barn);
            return View(barnForm);
        }

        public ActionResult Create()
        {
            var barnForm = new BarnForm();
            return View(barnForm);
        }

        [HttpPost, ValidateAntiForgeryToken]
        public ActionResult Create(BarnForm barnForm)
        {
            if (!ModelState.IsValid)
            {
                return View(barnForm);
            }

            var barn = barnForm.ToBarn();

            _barnService.Create(barn);

            return RedirectToAction("Index", new BarnListFiltersModel().GetRouteValues()).WithSuccess("Galpón Creado");
        }

        public ActionResult Edit(Guid id)
        {
            var barn = _barnService.GetById(id);
            var barnForm = BarnForm.FromBarn(barn);
            return View(barnForm);
        }

        [HttpPost, ValidateAntiForgeryToken]
        public ActionResult Edit(Guid id, BarnForm barnForm)
        {
            if (!ModelState.IsValid)
            {
                return View(barnForm);
            }

            _barnService.Edit(barnForm.ToBarn());

            return RedirectToAction("Index", new BarnListFiltersModel().GetRouteValues()).WithSuccess("Galpón Editado");
        }

        [HttpPost, ValidateAntiForgeryToken]
        public ActionResult Delete(Guid id, FormCollection collection)
        {
            _barnService.Delete(id);

            return RedirectToAction("Index", new BarnListFiltersModel().GetRouteValues()).WithSuccess("Galpón Eliminado");
        }

        public ActionResult IsNameAvailable(string name, Guid id)
        {
            return Json(_barnService.IsNameAvailable(name, id), JsonRequestBehavior.AllowGet);
        }
    }
}