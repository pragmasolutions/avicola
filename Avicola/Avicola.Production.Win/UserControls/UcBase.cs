using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Avicola.Common.Win;
using Framework.WinForm.Comun.Notification;

namespace Avicola.Production.Win.UserControls
{
    public class UcBase : UserControl
    {
        public IFormFactory FormFactory { get; set; }

        public IMessageBoxDisplayService MessageBoxDisplayService { get; set; }
    }
}
