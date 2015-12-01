using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Avicola.Common.Win.Forms;
using Avicola.Sales.Win.Infrastructure;
using Telerik.WinControls;

namespace Avicola.Sales.Win.Forms
{
    public partial class FrmSalesBase : FrmBase
    {
        public ITransitionManager TransitionManager { get; set; }
    }
}
