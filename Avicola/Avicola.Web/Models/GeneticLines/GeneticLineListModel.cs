using System.ComponentModel.DataAnnotations;
using Avicola.Office.Entities.DTO;
using PagedList;

namespace Avicola.Web.Models.GeneticLines
{
    public class GeneticLineListModel
    {
        public GeneticLineListModel(IPagedList<GeneticLineDto> list, GeneticLineListFiltersModel filters)
        {
            List = list;
            Filters = filters;
        }
        public IPagedList<GeneticLineDto> List { get; set; }

        public GeneticLineListFiltersModel Filters { get; set; }
    }
}