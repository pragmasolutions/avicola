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

        public string Barns
        {
            get
            {
                if (!this.BatchBarns.Any())
                    return string.Empty;

                var currentStageBarns = this.BatchBarns.Where(bb => bb.Barn.StageId == this.StageId).Select(bb => bb.Barn.Name).ToArray();
                return String.Join(", ", currentStageBarns);
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

        public DateTime CurrentStageStartDate
        {
            get
            {
                if (this.StageId == Stage.BREEDING)
                {
                    return this.BreedingDate.GetValueOrDefault();
                }
                else if (this.StageId == Stage.REBREEDING)
                {
                    return this.ReBreedingDate.GetValueOrDefault();
                }
                else
                {
                    return this.PostureDate.GetValueOrDefault();
                }
            }
        }

        public int CurrentStageStartWeek
        {
            get
            {
                if (this.StageId == Stage.BREEDING)
                {
                    return GetWeeks(this.DateOfBirth, this.BreedingDate.GetValueOrDefault());
                }
                else if (this.StageId == Stage.REBREEDING)
                {
                    return GetWeeks(this.DateOfBirth, this.ReBreedingDate.GetValueOrDefault());
                }
                else
                {
                    return GetWeeks(this.DateOfBirth, this.PostureDate.GetValueOrDefault());
                }
            }
        }

        private int GetWeeks(DateTime dateFrom, DateTime dateTo)
        {
            var daysDifference = (dateTo.Date - dateFrom.Date).TotalDays + 1;
            return Convert.ToInt32(Math.Ceiling(daysDifference / 7d));
        }
    }
}
