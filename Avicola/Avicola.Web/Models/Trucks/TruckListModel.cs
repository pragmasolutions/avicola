using Avicola.Sales.Services.Dtos;
using PagedList;

namespace Avicola.Web.Models
{
    public class TruckListModel
    {
        public TruckListModel(IPagedList<TruckDto> list, TruckListFiltersModel filters)
        {
            List = list;
            Filters = filters;
        }

        public IPagedList<TruckDto> List { get; set; }

        public TruckListFiltersModel Filters { get; set; }
    }
}