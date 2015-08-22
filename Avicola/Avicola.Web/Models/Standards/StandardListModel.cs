using System.ComponentModel.DataAnnotations;
using Avicola.Office.Entities.DTO;
using Avicola.Office.Services.DTO;
using PagedList;

namespace Avicola.Web.Models.Standards
{
    public class StandardListModel
    {
        public StandardListModel(IPagedList<StandardDto> list, StandardListFiltersModel filters)
        {
            List = list;
            Filters = filters;
        }
        public IPagedList<StandardDto> List { get; set; }

        public StandardListFiltersModel Filters { get; set; }
    }
}