using Avicola.Sales.Services.Dtos;
using PagedList;

namespace Avicola.Web.Models
{
    public class ClientListModel
    {
        public ClientListModel(IPagedList<ClientDto> list, ClientListFiltersModel filters)
        {
            List = list;
            Filters = filters;
        }

        public IPagedList<ClientDto> List { get; set; }

        public ClientListFiltersModel Filters { get; set; }
    }
}