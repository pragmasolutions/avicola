using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Avicola.Common.Win;
using Avicola.Production.Win.Properties;
using Framework.WinForm.Comun.Notification;

namespace Avicola.Production.Win.UserControls
{
    public class UcBase : UserControl
    {
        public ErrorProvider ErrorProvider;
    
        public UcBase()
        {
            InitializeControls();
        }

        private void InitializeControls()
        {
            this.ErrorProvider = new ErrorProvider(this);
            this.ErrorProvider.BlinkStyle = ErrorBlinkStyle.NeverBlink;
            this.ErrorProvider.Icon = Icon.FromHandle(Resources.ErrorIcon.GetHicon());
        }

        public IFormFactory FormFactory { get; set; }

        public IMessageBoxDisplayService MessageBoxDisplayService { get; set; }
    }
}
