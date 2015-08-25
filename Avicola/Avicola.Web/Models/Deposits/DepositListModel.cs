using Avicola.Sales.Services.Dtos;
using PagedList;

namespace Avicola.Web.Models
{
    public class DepositListModel
    {
        public DepositListModel(IPagedList<DepositDto> list, DepositListFiltersModel filters)
        {
            List = list;
            Filters = filters;
        }

        public IPagedList<DepositDto> List { get; set; }

        public DepositListFiltersModel Filters { get; set; }
    }
}