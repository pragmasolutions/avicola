using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Avicola.Common.Win;
using Framework.Data.Repository;
using Telerik.WinControls;

namespace Avicola.Production.Win.Forms
{
    public partial class FrmBase : Telerik.WinControls.UI.RadForm
    {
        public FrmBase()
        {
            InitializeComponent();
        }

        protected IUow Uow { get; set; }

        protected IFormFactory FormFactory { get; set; }

        protected IUowFactory UowFactory { get; set; }

        
    }
}
