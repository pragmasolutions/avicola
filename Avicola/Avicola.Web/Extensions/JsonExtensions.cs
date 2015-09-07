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
            return new
            {
                instance.Id,
                Name = instance.Barn == null
                    ? String.Format("Lote {0}", instance.Number.ToString())
                    : String.Format("Lote {0} [ Galpón: {1}]", instance.Number, instance.Barn.Number),
                GeneticLine = new
                {
                    instance.GeneticLine.Name,
                    Standards = instance.GeneticLine.StandardGeneticLines.Where(sql => !sql.IsDeleted).Select(sgl => new
                    {
                        sgl.Standard.Name,
                        ShowSecondValue = sgl.Standard.StandardTypeId == StandardType.VALUES_RANGE,
                        sgl.Standard.AllowDecimal,
                        sgl.Standard.MeasureUnity,
                        StandardItems = sgl.StandardItems.Where(sql => !sgl.IsDeleted).OrderBy(s => s.Sequence).Select(si => new
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