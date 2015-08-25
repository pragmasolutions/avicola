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
        public GeneticLine GeneticLine { get; set; }
        public Standard Standard { get; set; }

        public void GenerateItems()
        {
            if (GeneticLine != null && Standard != null)
            {
                StandardItems = new List<StandardItemModel>();
                for (int i = 0; i < GeneticLine.ProductionWeeks; i++)
                {
                    StandardItems.Add(new StandardItemModel { Sequence = i + 1 });
                }
            }
        }

        public StandardGeneticLine ToStandardGeneticLine()
        {
            var item = new StandardGeneticLine()
            {
                GeneticLineId = this.GeneticLine.Id,
                StandardId = this.Standard.Id,
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