using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Avicola.Common.Win;
using Avicola.Common.Win.Forms;
using Avicola.Production.Win.Infrastructure;
using Avicola.Production.Win.Properties;
using Framework.Data.Repository;
using Framework.WinForm.Comun.Notification;
using Telerik.WinControls;
using Telerik.WinControls.UI;

namespace Avicola.Production.Win.Forms
{
    public partial class FrmProductionBase : FrmBase
    {
        public ITransitionManager TransitionManager { get; set; }
    }
}
