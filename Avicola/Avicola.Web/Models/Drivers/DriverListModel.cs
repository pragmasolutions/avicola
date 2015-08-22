using Avicola.Sales.Services.Dtos;
using PagedList;

namespace Avicola.Web.Models
{
    public class DriverListModel
    {
        public DriverListModel(IPagedList<DriverDto> list, DriverListFiltersModel filters)
        {
            List = list;
            Filters = filters;
        }

        public IPagedList<DriverDto> List { get; set; }

        public DriverListFiltersModel Filters { get; set; }
    }
}