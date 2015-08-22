using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Framework.Data.Interfaces;

namespace Avicola.Office.Entities
{
    public partial class DataLoadType : IEntity
    {
        public static readonly Guid DAYLY = new Guid("C4D05E89-69FB-42F7-8F6A-15C8BC130377");
        public static readonly Guid WEEKLY = new Guid("939E6F2D-8001-448A-88E2-FEC280FBB055");
    }
}
