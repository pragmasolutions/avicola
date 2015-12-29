using System;
using System.ComponentModel.DataAnnotations;
using AutoMapper;
using Avicola.Sales.Entities;
using Framework.Common.Mapping;

namespace Avicola.Common.Win.Model
{
    public class ClientModel : IMapFrom<Client>
    {
        public Guid Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public string Tel1 { get; set; }

        public string Tel2 { get; set; }

        public string CellPhone { get; set; }

        [EmailAddress]
        public string Email { get; set; }

        public string Referent { get; set; }

        public string WebSite { get; set; }

        [Required]
        public string Address { get; set; }

        [Required]
        public string City { get; set; }

        public Client ToClient()
        {
            var client = Mapper.Map<ClientModel, Client>(this);
            return client;
        }

        public static ClientModel FromClient(Client client)
        {
            var form = Mapper.Map<Client, ClientModel>(client);
            return form;
        }
    }
}
