using System.ComponentModel.DataAnnotations;
using Avicola.Office.Entities.DTO;
using Avicola.Office.Services.Dtos;
using PagedList;

namespace Avicola.Web.Models.FoodClasses
{
    public class FoodClassListModel
    {
        public FoodClassListModel(IPagedList<FoodClassDto> list, FoodClassListFiltersModel filters)
        {
            List = list;
            Filters = filters;
        }
        public IPagedList<FoodClassDto> List { get; set; }

        public FoodClassListFiltersModel Filters { get; set; }
    }
}