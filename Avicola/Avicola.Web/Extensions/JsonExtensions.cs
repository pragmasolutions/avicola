using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Avicola.Office.Entities;

namespace Avicola.Web.Extensions
{
    public static class JsonExtensions
    {
        public static Object ToJSON(this Batch instance)
        {
            var weeksAge = Math.Ceiling(DateTime.Now.Subtract(instance.DateOfBirth).Days / (double)7);
            return new
            {
                instance.Id,
                Name = String.Format("Lote {0} [ Galpón: {1}]", instance.Number, instance.CurrentStageBarnNames),
                GeneticLine = new
                {
                    instance.GeneticLine.Name,
                    Standards = instance.GeneticLine.StandardGeneticLines.Where(sql => !sql.IsDeleted).Select(sgl => new
                    {
                        sgl.Standard.Name,
                        ShowSecondValue = sgl.Standard.StandardTypeId == StandardType.VALUES_RANGE,
                        sgl.Standard.AggregateOperation,
                        sgl.Standard.AllowDecimal,
                        sgl.Standard.MeasureUnity,
                        sgl.Standard.YAxis,
                        StandardItems = sgl.StandardItems.Where(sql => !sgl.IsDeleted && sql.Sequence <= weeksAge).OrderBy(s => s.Sequence).Select(si => new
                        {
                            si.Value1,
                            si.Value2,
                            si.Sequence,
                            Measures =
                                si.Measures.Where(m => !m.IsDeleted && m.BatchId == instance.Id).Select(m => new
                                {
                                    m.Value,
                                    m.StandardItemId
                                })
                        })
                    })
                }
            };
        }
    }
}