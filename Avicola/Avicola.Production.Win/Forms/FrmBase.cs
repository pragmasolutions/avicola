using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Avicola.Common.Win;
using Avicola.Production.Win.Infrastructure;
using Avicola.Production.Win.Properties;
using Framework.Data.Repository;
using Telerik.WinControls;

namespace Avicola.Production.Win.Forms
{
    public partial class FrmBase : Telerik.WinControls.UI.RadForm
    {
        protected ErrorProvider FormErrorProvider { get; set; }

        public FrmBase()
        {
            InitializeComponent();
            InitializeControls();
        }

        private void InitializeControls()
        {
            this.FormErrorProvider = new ErrorProvider(this);
            this.FormErrorProvider.BlinkStyle = ErrorBlinkStyle.NeverBlink;
            this.FormErrorProvider.Icon = Icon.FromHandle(Resources.ErrorIcon.GetHicon());
        }

        protected IUow Uow { get; set; }

        protected IFormFactory FormFactory { get; set; }

        protected IUowFactory UowFactory { get; set; }

        public ITransitionManager TransitionManager { get; set; }
    }
}
