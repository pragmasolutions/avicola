using System;
using System.Web.Mvc;
using Avicola.Sales.Services.Dtos;
using Avicola.Sales.Services.Interfaces;
using Avicola.Web.Models;
using Framework.Common.Web.Alerts;
using PagedList;

namespace Avicola.Web.Controllers
{
    public class DepositController : BaseController
    {
        private readonly IDepositService _depositService;

        public DepositController(IDepositService depositService)
        {
            _depositService = depositService;
        }

        public ActionResult Index(DepositListFiltersModel filters)
        {
            int pageTotal;

            var deposits = _depositService.GetAll("CreatedDate", "DESC", filters.Criteria, filters.Page, DefaultPageSize, out pageTotal);

            var pagedList = new StaticPagedList<DepositDto>(deposits, filters.Page, DefaultPageSize, pageTotal);

            var listModel = new DepositListModel(pagedList, filters);

            return View(listModel);
        }

        public ActionResult Detail(Guid id)
        {
            var deposit = _depositService.GetById(id);
            var depositForm = DepositForm.FromDeposit(deposit);
            return View(depositForm);
        }

        public ActionResult Create()
        {
            var depositForm = new DepositForm();
            return View(depositForm);
        }

        [HttpPost, ValidateAntiForgeryToken]
        public ActionResult Create(DepositForm depositForm)
        {
            if (!ModelState.IsValid)
            {
                return View(depositForm);
            }

            var deposit = depositForm.ToDeposit();

            _depositService.Create(deposit);

            return RedirectToAction("Index", new DepositListFiltersModel().GetRouteValues()).WithSuccess("Depósito Creado");
        }

        public ActionResult Edit(Guid id)
        {
            var deposit = _depositService.GetById(id);
            var depositForm = DepositForm.FromDeposit(deposit);
            return View(depositForm);
        }

        [HttpPost, ValidateAntiForgeryToken]
        public ActionResult Edit(Guid id, DepositForm depositForm)
        {
            if (!ModelState.IsValid)
            {
                return View(depositForm);
            }

            _depositService.Edit(depositForm.ToDeposit());

            return RedirectToAction("Index", new DepositListFiltersModel().GetRouteValues()).WithSuccess("Depósito Editado");
        }

        [HttpPost, ValidateAntiForgeryToken]
        public ActionResult Delete(Guid id, FormCollection collection)
        {
            _depositService.Delete(id);

            return RedirectToAction("Index", new DepositListFiltersModel().GetRouteValues()).WithSuccess("Depósito Eliminado");
        }

        public ActionResult IsNameAvailable(string name, Guid id)
        {
            return Json(_depositService.IsNameAvailable(name, id), JsonRequestBehavior.AllowGet);
        }
    }
}