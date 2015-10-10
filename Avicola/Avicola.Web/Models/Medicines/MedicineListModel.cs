using System.ComponentModel.DataAnnotations;
using Avicola.Office.Entities.DTO;
using Avicola.Office.Services.Dtos;
using PagedList;

namespace Avicola.Web.Models.Medicines
{
    public class MedicineListModel
    {
        public MedicineListModel(IPagedList<MedicineDto> list, MedicineListFiltersModel filters)
        {
            List = list;
            Filters = filters;
        }
        public IPagedList<MedicineDto> List { get; set; }

        public MedicineListFiltersModel Filters { get; set; }
    }
}