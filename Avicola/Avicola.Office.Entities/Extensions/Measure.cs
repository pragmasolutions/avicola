using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Framework.Data.Interfaces;

namespace Avicola.Office.Entities
{
    public partial class Measure : IEntity
    {
        //esto se setea manualmente a traves de calculos... no usar a menos que se hayan hecho.
        public DateTime MeasureDate { get; set; }
    }
}
