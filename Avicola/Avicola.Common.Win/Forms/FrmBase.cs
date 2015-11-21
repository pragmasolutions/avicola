using System.Drawing;
using System.Windows.Forms;
using Framework.WinForm.Comun.Notification;
using Telerik.WinControls;
using Telerik.WinControls.UI;

namespace Avicola.Common.Win.Forms
{
    public partial class FrmBase : Telerik.WinControls.UI.RadForm
    {
        protected ErrorProvider FormErrorProvider { get; set; }

        public FrmBase()
        {
            InitializeComponent();
            InitializeControls();

            ThemeResolutionService.ApplicationThemeName = "TelerikMetroBlue";
        }

        private void InitializeControls()
        {
            this.FormErrorProvider = new ErrorProvider(this);
            this.FormErrorProvider.BlinkStyle = ErrorBlinkStyle.NeverBlink;
            this.FormErrorProvider.Icon = Icon.FromHandle(Resources.Wrong.GetHicon());
            this.Icon = Icon.FromHandle(Resources.Logo.GetHicon());
        }


        protected IFormFactory FormFactory { get; set; }
        
        protected IMessageBoxDisplayService MessageBoxDisplayService { get; set; }

        protected virtual void Grilla_CellFormatting(object sender, CellFormattingEventArgs e)
        {
            GridCommandCellElement cmdCell = e.CellElement as GridCommandCellElement;

            if (cmdCell != null)
            {
                cmdCell.CommandButton.ImageAlignment = ContentAlignment.MiddleCenter;
            }
        }
    }
}
