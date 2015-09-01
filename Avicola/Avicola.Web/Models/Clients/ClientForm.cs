using System;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;
using AutoMapper;
using Avicola.Sales.Entities;
using Framework.Common.Mapping;
using Resources;

namespace Avicola.Web.Models
{
    public class ClientForm : IMapFrom<Client>
    {
        [HiddenInput]
        public Guid Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Tel1 { get; set; }
        public string Tel2 { get; set; }
        public string CellPhone { get; set; }
        [EmailAddress(ErrorMessageResourceType = typeof(AvicolaGlobalResources), ErrorMessageResourceName = "EmailAddress", ErrorMessage = null)]
        public string Email { get; set; }
        public string Referent { get; set; }
        public string WebSite { get; set; }
        [Required]
        public string Address { get; set; }
        [Required]
        public string City { get; set; }

        public Client ToClient()
        {
            var client = Mapper.Map<ClientForm, Client>(this);
            return client;
        }

        public static ClientForm FromClient(Client driver)
        {
            var form = Mapper.Map<Client, ClientForm>(driver);
            return form;
        }
    }
}
