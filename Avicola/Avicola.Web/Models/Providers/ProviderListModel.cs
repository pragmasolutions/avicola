using Avicola.Sales.Services.Dtos;
using PagedList;

namespace Avicola.Web.Models
{
    public class ProviderListModel
    {
        public ProviderListModel(IPagedList<ProviderDto> list, ProviderListFiltersModel filters)
        {
            List = list;
            Filters = filters;
        }

        public IPagedList<ProviderDto> List { get; set; }

        public ProviderListFiltersModel Filters { get; set; }
    }
}