using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Framework.Data.Interfaces;

namespace Avicola.Office.Entities
{
    public partial class StandardType : IEntity
    {
        public static readonly Guid VALUES_RANGE = new Guid("BC083A29-845F-45E9-BF41-5A68F480CA73");
        public static readonly Guid UNIQUE_VALUE = new Guid("7DCE6982-E172-4AFD-9D4D-FADDBA8EBA35");
    }
}
