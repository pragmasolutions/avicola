using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Framework.Data.Interfaces;

namespace Avicola.Office.Entities
{
    public partial class StandardItem : IEntity
    {
        //public int Week
        //{
        //    get
        //    {
        //        var loadType = this.StandardGeneticLine.Standard.DataLoadTypeId;
        //        if (loadType == DataLoadType.WEEKLY)
        //        {
        //            return Sequence;
        //        }
        //        return Convert.ToInt32(Math.Ceiling(Convert.ToDecimal(Sequence/7M)));
        //    }
        //}

        //public int? Day
        //{
        //    get
        //    {
        //        var loadType = this.StandardGeneticLine.Standard.DataLoadTypeId;
        //        if (loadType == DataLoadType.WEEKLY)
        //        {
        //            return null;
        //        }
        //        return 7-((Week*7)-Sequence);
        //    }
        //}

        //StartDate y EndDate van a ser iguales para standards de tipo diario
        //pero para semanales, uno marca el comienzo y el otro el fin de la semana
        //y ser cargan manualmente cuando se calcula a partir de la fecha de nacimiento del lote
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
    }
}
