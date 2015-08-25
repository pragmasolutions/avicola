using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Avicola.Office.Entities;

namespace Avicola.Web.Models.GeneticLines
{
    public class CreateStandardGeneticLineForm
    {
        public List<StandardItemModel> StandardItems { get; set; }
        public StandardGeneticLine StandardGeneticLine { get; set; }

        public void GenerateItems()
        {
            if (StandardGeneticLine.Id != Guid.Empty)
            {
                StandardItems = new List<StandardItemModel>();
                var activeList = StandardGeneticLine.StandardItems.Where(x => !x.IsDeleted).OrderBy(x => x.Sequence).ToList();
                for (int i = 0; i < activeList.Count; i++)
                {
                    var item = activeList.ElementAt(i);
                    StandardItems.Add(new StandardItemModel
                    {
                        Sequence = i + 1,
                        Value = item.Value
                    });
                }
            }
            else if (StandardGeneticLine.GeneticLine != null && StandardGeneticLine.Standard != null)
            {
                StandardItems = new List<StandardItemModel>();
                for (int i = 0; i < StandardGeneticLine.GeneticLine.ProductionWeeks; i++)
                {
                    StandardItems.Add(new StandardItemModel { Sequence = i + 1 });
                }
            }
            
        }

        public StandardGeneticLine ToStandardGeneticLine()
        {
            var item = new StandardGeneticLine()
            {
                GeneticLineId = this.StandardGeneticLine.GeneticLine.Id,
                StandardId = this.StandardGeneticLine.Standard.Id,
                StandardItems = this.StandardItems.Select(si => new StandardItem()
                {
                    Sequence = si.Sequence,
                    Value = si.Value
                }).ToList()
            };
            return item;
        }
    }
}