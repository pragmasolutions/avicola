using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Avicola.Common.Win.Forms;
using Avicola.Deposit.Win.Infrastructure;
using Telerik.WinControls;

namespace Avicola.Deposit.Win.Forms
{
    public partial class FrmDepositBase : FrmBase
    {
        public ITransitionManager TransitionManager { get; set; }
    }
}
