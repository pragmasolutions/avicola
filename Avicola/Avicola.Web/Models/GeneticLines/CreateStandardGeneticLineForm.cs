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
        public List<StandardItemIntegerModel> IntegerStandardItems { get; set; }
        public StandardGeneticLine StandardGeneticLine { get; set; }
        public Guid StageId { get; set; }

        public void GenerateItems()
        {
            if (StandardGeneticLine.Id != Guid.Empty)
            {
                if (StandardGeneticLine.Standard.AllowDecimal)
                {
                    StandardItems = new List<StandardItemModel>();
                    var activeList = StandardGeneticLine.StandardItems.Where(x => !x.IsDeleted).OrderBy(x => x.Sequence).ToList();
                    for (int i = 0; i < activeList.Count; i++)
                    {
                        var item = activeList.ElementAt(i);
                        StandardItems.Add(new StandardItemModel
                        {
                            Id = item.Id,
                            Sequence = item.Sequence,
                            Value1 = item.Value1,
                            Value2 = item.Value2,
                            ShowSecondValue = this.StandardGeneticLine.Standard.StandardTypeId == StandardType.VALUES_RANGE
                        });
                    }
                }
                else
                {
                    IntegerStandardItems = new List<StandardItemIntegerModel>();
                    var activeList = StandardGeneticLine.StandardItems.Where(x => !x.IsDeleted).OrderBy(x => x.Sequence).ToList();
                    for (int i = 0; i < activeList.Count; i++)
                    {
                        var item = activeList.ElementAt(i);
                        IntegerStandardItems.Add(new StandardItemIntegerModel
                        {
                            Id = item.Id,
                            Sequence = item.Sequence,
                            Value1 = Convert.ToInt32(item.Value1),
                            Value2 = item.Value2 == null ? (int?)null : Convert.ToInt32(item.Value2),
                            ShowSecondValue = this.StandardGeneticLine.Standard.StandardTypeId == StandardType.VALUES_RANGE
                        });
                    }
                }
            }
            else if (StandardGeneticLine.GeneticLine != null && StandardGeneticLine.Standard != null)
            {
                if (StandardGeneticLine.Standard.AllowDecimal)
                {
                    StandardItems = new List<StandardItemModel>();

                    int initialSequence = GetInitialSequence();
                    int finalSequence = GetFinalSequence();

                    for (int i = initialSequence; i < finalSequence; i++)
                    {
                        StandardItems.Add(new StandardItemModel
                        {
                            Sequence = i + 1,
                            ShowSecondValue = this.StandardGeneticLine.Standard.StandardTypeId == StandardType.VALUES_RANGE,
                            Value2 = 0
                        });
                    }
                }
                else
                {
                    IntegerStandardItems = new List<StandardItemIntegerModel>();

                    int initialSequence = GetInitialSequence();
                    int finalSequence = GetFinalSequence();

                    for (int i = initialSequence; i < finalSequence; i++)
                    {
                        IntegerStandardItems.Add(new StandardItemIntegerModel
                        {
                            Sequence = i + 1,
                            ShowSecondValue = this.StandardGeneticLine.Standard.StandardTypeId == StandardType.VALUES_RANGE,
                            Value2 = 0
                        });
                    }
                }
            }
        }

        public StandardGeneticLine ToStandardGeneticLine()
        {
            var item = new StandardGeneticLine()
            {
                GeneticLineId = this.StandardGeneticLine.GeneticLine.Id,
                StandardId = this.StandardGeneticLine.Standard.Id,
                Id = this.StandardGeneticLine.Id
            };

            if (this.StandardGeneticLine.Standard.AllowDecimal)
            {
                item.StandardItems = this.StandardItems.Select(si => new StandardItem()
                {
                    Sequence = si.Sequence,
                    Value1 = si.Value1,
                    Value2 = si.Value2,
                    Id = si.Id
                }).ToList();
            }
            else
            {
                item.StandardItems = this.IntegerStandardItems.Select(si => new StandardItem()
                {
                    Sequence = si.Sequence,
                    Value1 = Convert.ToDecimal(si.Value1),
                    Value2 = si.Value2 != null ? Convert.ToDecimal(si.Value2) : (decimal?)null,
                    Id = si.Id
                }).ToList();
            }

            return item;
        }

        private int GetInitialSequence()
        {
            return this.StageId == Stage.POSTURE ? StandardGeneticLine.GeneticLine.WeeksInBreeding : 0;
        }

        private int GetFinalSequence()
        {
            return this.StageId == Stage.BREEDING
                ? StandardGeneticLine.GeneticLine.WeeksInBreeding
                : StandardGeneticLine.GeneticLine.ProductionWeeks;
        }
    }
}