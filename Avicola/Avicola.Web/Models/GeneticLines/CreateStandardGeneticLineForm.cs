using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Avicola.Office.Entities;

namespace Avicola.Web.Models.GeneticLines
{
    public class CreateStandardGeneticLineForm
    {
        public Guid NAME { get; set; }
        public List<StandardItemModel> StandardItems { get; set; }
        public StandardGeneticLine StandardGeneticLine { get; set; }
        public Guid StageId { get; set; }

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
                        Id = item.Id,
                        Sequence = i + 1,
                        Value1 = item.Value1,
                        Value2 = item.Value2,
                        ShowSecondValue = this.StandardGeneticLine.Standard.StandardTypeId == StandardType.VALUES_RANGE
                    });
                }
            }
            else if (StandardGeneticLine.GeneticLine != null && StandardGeneticLine.Standard != null)
            {
                StandardItems = new List<StandardItemModel>();
                for (int i = 0; i < StandardGeneticLine.GeneticLine.ProductionWeeks; i++)
                {
                    StandardItems.Add(new StandardItemModel
                    {
                        Sequence = i + 1,
                        ShowSecondValue = this.StandardGeneticLine.Standard.StandardTypeId == StandardType.VALUES_RANGE,
                        Value2 = 0
                    });
                }
            }
            
        }

        public StandardGeneticLine ToStandardGeneticLine()
        {
            var item = new StandardGeneticLine()
            {
                GeneticLineId = this.StandardGeneticLine.GeneticLine.Id,
                StandardId = this.StandardGeneticLine.Standard.Id,
                StageId = this.StageId,
                Id = this.StandardGeneticLine.Id,
                StandardItems = this.StandardItems.Select(si => new StandardItem()
                {
                    Sequence = si.Sequence,
                    Value1 = si.Value1,
                    Value2 = si.Value2,
                    Id = si.Id
                }).ToList()
            };
            return item;
        }
    }
}