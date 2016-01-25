using System;
using System.Collections.Generic;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;
using Framework.Common.Win.UserControls;
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

        public string SortColumn { get; set; }
        public string SortDirection { get; set; }
        public RadGridView MainGrid { get; set; }
        public UcGridPager MainPager { get; set; }

        public RadWaitingBar LoadingOverlay { get; set; }

        public Dictionary<string, string> SortColumnMappings { get; set; }

        protected virtual void Grilla_CellFormatting(object sender, CellFormattingEventArgs e)
        {
            GridCommandCellElement cmdCell = e.CellElement as GridCommandCellElement;

            if (cmdCell != null)
            {
                cmdCell.CommandButton.ImageAlignment = ContentAlignment.MiddleCenter;
            }
        }

        private void FrmBase_Load(object sender, System.EventArgs e)
        {
            if(MainGrid != null)
            {
                MainGrid.SortChanged += MainGridOnSortChanged;
            }
        }

        private void MainGridOnSortChanged(object sender, GridViewCollectionChangedEventArgs gridViewCollectionChangedEventArgs)
        {
            if (MainPager == null)
            {
                return;
            }

            var sort = gridViewCollectionChangedEventArgs.GridViewTemplate.SortDescriptors.Expression;

            var split = sort.Split(' ');
            
            SortColumn = FinalSortColumn(split[0]);
            
            SortDirection = split[1];
            
            MainPager.CurrentPage = 1;

            RefreshList();
        }

        public virtual async Task<int> RefreshList()
        {
            return 0;
        }

        private string FinalSortColumn(string column)
        {
            if (SortColumnMappings == null || !SortColumnMappings.ContainsKey(column))
                return column;
            return SortColumnMappings[column];
        }

        protected virtual void PositionLoadingOverlay()
        {
            int x = (this.MainGrid.Width / 2) - (this.LoadingOverlay.Width / 2);
            int y = (this.MainGrid.Height / 2) - (this.LoadingOverlay.Height / 2);
            this.LoadingOverlay.Location = new System.Drawing.Point(x, y);
        }

        protected virtual void StartWaiting()
        {
            this.PositionLoadingOverlay();

            this.LoadingOverlay.Visible = true;
            this.LoadingOverlay.StartWaiting();
        }

        protected virtual void StopWaiting()
        {
            this.LoadingOverlay.StopWaiting();
            this.LoadingOverlay.Visible = false;
        }
    }
}
