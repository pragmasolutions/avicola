using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Avicola.Production.Win.Infrastructure
{
    public interface ITransitionManager
    {
        void LoadBatchSelectionView();
        void LoadBatchManagerView();
        void LoadStandardSelectionView();
        void LoadEnterDailyStandardView();
        void LoadEnterWeeklyStandardView();
    }
}
