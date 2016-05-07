using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace De.Provision.Databases
{
    public class SyncProgressEventArgs : EventArgs
    {
        public SyncProgressEventArgs(int completedWork, int totalWork)
        {
            CompletedWork = completedWork;
            TotalWork = totalWork;
        }

        public int CompletedWork { get; private set; }
        public int TotalWork { get; private set; }
    }
}
