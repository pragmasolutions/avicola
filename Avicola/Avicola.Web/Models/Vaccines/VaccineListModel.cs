using System.ComponentModel.DataAnnotations;
using Avicola.Office.Entities.DTO;
using Avicola.Office.Services.Dtos;
using PagedList;

namespace Avicola.Web.Models.Vaccinees
{
    public class VaccineListModel
    {
        public VaccineListModel(IPagedList<VaccineDto> list, VaccineListFiltersModel filters)
        {
            List = list;
            Filters = filters;
        }
        public IPagedList<VaccineDto> List { get; set; }

        public VaccineListFiltersModel Filters { get; set; }
    }
}