using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using Framework.Data.Interfaces;

namespace Avicola.Office.Entities
{
    public partial class Batch : IEntity
    {
        public string Name
        {
            get { return String.Format("Lote {0}", this.Number); }
        }

        public int Week
        {
            get
            {
                var daysDifference = (DateTime.Today.Date - DateOfBirth.Date).TotalDays + 1;
                return Convert.ToInt32(Math.Ceiling(daysDifference / 7d));
            }
        }

        public IList<BatchBarn> CurrentStageBarns
        {
            get
            {
                return this.BatchBarns.Where(bb => bb.Barn.StageId == this.StageId).ToList();
            }
        }

        public string CurrentStageBarnNames
        {
            get
            {
                return String.Join(", ", CurrentStageBarns.Select(bb => bb.Barn.Name));
            }
        }
    }
}
