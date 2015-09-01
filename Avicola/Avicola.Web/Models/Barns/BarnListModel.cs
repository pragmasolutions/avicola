using Avicola.Office.Services.Dtos;
using PagedList;

namespace Avicola.Web.Models
{
    public class BarnListModel
    {
        public BarnListModel(IPagedList<BarnDto> list, BarnListFiltersModel filters)
        {
            List = list;
            Filters = filters;
        }

        public IPagedList<BarnDto> List { get; set; }

        public BarnListFiltersModel Filters { get; set; }
    }
}