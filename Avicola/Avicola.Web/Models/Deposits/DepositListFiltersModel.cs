using System;
using System.ComponentModel.DataAnnotations;
using System.Linq.Expressions;
using System.Web.Routing;
using Avicola.Web.Models.List;

namespace Avicola.Web.Models
{
    public class DepositListFiltersModel : FilterBaseModel
    {
        public Guid CurrentRowId { get; set; }

        [Display(Name = "Palabra a Buscar", Prompt = "Palabra a Buscar")]
        public string Criteria { get; set; }

        public override RouteValueDictionary GetRouteValues(int page = 1)
        {
            var routeValues = base.GetRouteValues(page);
            routeValues.Add("Criteria", this.Criteria);
            return routeValues;
        }
    }
}