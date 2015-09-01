using System;
using System.Web.Mvc;
using Avicola.Sales.Services.Dtos;
using Avicola.Sales.Services.Interfaces;
using Avicola.Web.Models;
using Framework.Common.Web.Alerts;
using PagedList;

namespace Avicola.Web.Controllers
{
    public class ClientController : BaseController
    {
        private readonly IClientService _clientService;

        public ClientController(IClientService clientService)
        {
            _clientService = clientService;
        }

        public ActionResult Index(ClientListFiltersModel filters)
        {
            int pageTotal;

            var clients = _clientService.GetAll("CreatedDate", "DESC", filters.Criteria, filters.Page, DefaultPageSize, out pageTotal);

            var pagedList = new StaticPagedList<ClientDto>(clients, filters.Page, DefaultPageSize, pageTotal);

            var listModel = new ClientListModel(pagedList, filters);

            return View(listModel);
        }

        public ActionResult Detail(Guid id)
        {
            var client = _clientService.GetById(id);
            var clientForm = ClientForm.FromClient(client);
            return View(clientForm);
        }

        public ActionResult Create()
        {
            var clientForm = new ClientForm();
            return View(clientForm);
        }

        [HttpPost, ValidateAntiForgeryToken]
        public ActionResult Create(ClientForm clientForm)
        {
            if (!ModelState.IsValid)
            {
                return View(clientForm);
            }

            var client = clientForm.ToClient();

            _clientService.Create(client);

            return RedirectToAction("Index", new ClientListFiltersModel().GetRouteValues()).WithSuccess("Camion Creado");
        }

        public ActionResult Edit(Guid id)
        {
            var client = _clientService.GetById(id);
            var clientForm = ClientForm.FromClient(client);
            return View(clientForm);
        }

        [HttpPost, ValidateAntiForgeryToken]
        public ActionResult Edit(Guid id, ClientForm clientForm)
        {
            if (!ModelState.IsValid)
            {
                return View(clientForm);
            }

            _clientService.Edit(clientForm.ToClient());

            return RedirectToAction("Index", new ClientListFiltersModel().GetRouteValues()).WithSuccess("Camion Editado");
        }

        [HttpPost, ValidateAntiForgeryToken]
        public ActionResult Delete(Guid id, FormCollection collection)
        {
            _clientService.Delete(id);

            return RedirectToAction("Index", new ClientListFiltersModel().GetRouteValues()).WithSuccess("Camion Eliminado");
        }
    }
}