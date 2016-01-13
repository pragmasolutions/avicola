namespace Avicola.Sales.Win.Forms
{
    partial class FrmHistoryManager
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn22 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn23 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn24 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn25 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn26 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewDateTimeColumn gridViewDateTimeColumn4 = new Telerik.WinControls.UI.GridViewDateTimeColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn27 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn28 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewCommandColumn gridViewCommandColumn4 = new Telerik.WinControls.UI.GridViewCommandColumn();
            Telerik.WinControls.UI.TableViewDefinition tableViewDefinition4 = new Telerik.WinControls.UI.TableViewDefinition();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.gvOrders = new Telerik.WinControls.UI.RadGridView();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.lbTitle = new Telerik.WinControls.UI.RadLabel();
            this.btnBackToSalesManager = new Telerik.WinControls.UI.RadButton();
            this.ucOrdersFilters = new Avicola.Sales.Win.UserControls.UcOrdersFilters();
            this.UcGridPager = new Framework.Common.Win.UserControls.UcGridPager();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvOrders)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvOrders.MasterTemplate)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lbTitle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnBackToSalesManager)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.gvOrders, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 230F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1111, 648);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // gvOrders
            // 
            this.gvOrders.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gvOrders.Location = new System.Drawing.Point(3, 233);
            // 
            // 
            // 
            this.gvOrders.MasterTemplate.AllowAddNewRow = false;
            this.gvOrders.MasterTemplate.AllowColumnReorder = false;
            this.gvOrders.MasterTemplate.AllowDeleteRow = false;
            this.gvOrders.MasterTemplate.AllowDragToGroup = false;
            this.gvOrders.MasterTemplate.AllowEditRow = false;
            this.gvOrders.MasterTemplate.AllowRowReorder = true;
            this.gvOrders.MasterTemplate.AutoGenerateColumns = false;
            this.gvOrders.MasterTemplate.AutoSizeColumnsMode = Telerik.WinControls.UI.GridViewAutoSizeColumnsMode.Fill;
            gridViewTextBoxColumn22.FieldName = "OrderId";
            gridViewTextBoxColumn22.HeaderText = "OrderId";
            gridViewTextBoxColumn22.IsVisible = false;
            gridViewTextBoxColumn22.Name = "OrderId";
            gridViewTextBoxColumn23.FieldName = "ClientName";
            gridViewTextBoxColumn23.HeaderText = "Cliente";
            gridViewTextBoxColumn23.MaxWidth = 5000;
            gridViewTextBoxColumn23.MinWidth = 200;
            gridViewTextBoxColumn23.Name = "ClientName";
            gridViewTextBoxColumn23.Width = 279;
            gridViewTextBoxColumn24.DataType = typeof(System.DateTime);
            gridViewTextBoxColumn24.FieldName = "CreatedDate";
            gridViewTextBoxColumn24.FormatString = "{0: dd/M/yyyy H:mm}";
            gridViewTextBoxColumn24.HeaderText = "Fecha Pedido";
            gridViewTextBoxColumn24.MinWidth = 80;
            gridViewTextBoxColumn24.Name = "CreatedDate";
            gridViewTextBoxColumn24.Width = 111;
            gridViewTextBoxColumn25.FieldName = "Dozens";
            gridViewTextBoxColumn25.HeaderText = "Docenas";
            gridViewTextBoxColumn25.MinWidth = 60;
            gridViewTextBoxColumn25.Name = "Dozens";
            gridViewTextBoxColumn25.Width = 84;
            gridViewTextBoxColumn26.FieldName = "OrderStatusName";
            gridViewTextBoxColumn26.HeaderText = "Estado";
            gridViewTextBoxColumn26.MinWidth = 60;
            gridViewTextBoxColumn26.Name = "OrderStatusName";
            gridViewTextBoxColumn26.Width = 84;
            gridViewDateTimeColumn4.FieldName = "DispatchedDate";
            gridViewDateTimeColumn4.FormatString = "{0: dd/M/yyyy H:mm}";
            gridViewDateTimeColumn4.HeaderText = "Fecha Envio";
            gridViewDateTimeColumn4.MinWidth = 80;
            gridViewDateTimeColumn4.Name = "DispatchedDate";
            gridViewDateTimeColumn4.Width = 111;
            gridViewTextBoxColumn27.FieldName = "DriverName";
            gridViewTextBoxColumn27.HeaderText = "Conductor";
            gridViewTextBoxColumn27.MinWidth = 120;
            gridViewTextBoxColumn27.Name = "DriverName";
            gridViewTextBoxColumn27.Width = 167;
            gridViewTextBoxColumn28.FieldName = "Truck";
            gridViewTextBoxColumn28.HeaderText = "Camión";
            gridViewTextBoxColumn28.MinWidth = 120;
            gridViewTextBoxColumn28.Name = "Truck";
            gridViewTextBoxColumn28.Width = 206;
            gridViewCommandColumn4.FieldName = "Delete";
            gridViewCommandColumn4.HeaderText = "";
            gridViewCommandColumn4.Image = global::Avicola.Sales.Win.Properties.Resources.Garbage_Closed;
            gridViewCommandColumn4.MaxWidth = 50;
            gridViewCommandColumn4.MinWidth = 50;
            gridViewCommandColumn4.Name = "Delete";
            this.gvOrders.MasterTemplate.Columns.AddRange(new Telerik.WinControls.UI.GridViewDataColumn[] {
            gridViewTextBoxColumn22,
            gridViewTextBoxColumn23,
            gridViewTextBoxColumn24,
            gridViewTextBoxColumn25,
            gridViewTextBoxColumn26,
            gridViewDateTimeColumn4,
            gridViewTextBoxColumn27,
            gridViewTextBoxColumn28,
            gridViewCommandColumn4});
            this.gvOrders.MasterTemplate.ViewDefinition = tableViewDefinition4;
            this.gvOrders.Name = "gvOrders";
            this.gvOrders.ReadOnly = true;
            this.gvOrders.ShowGroupPanelScrollbars = false;
            this.gvOrders.Size = new System.Drawing.Size(1105, 412);
            this.gvOrders.TabIndex = 10;
            this.gvOrders.ThemeName = "TelerikMetroBlue";
            this.gvOrders.CellFormatting += new Telerik.WinControls.UI.CellFormattingEventHandler(this.gvOrders_CellFormatting);
            this.gvOrders.PageChanged += new System.EventHandler<System.EventArgs>(this.gvOrders_PageChanged);
            this.gvOrders.CommandCellClick += new Telerik.WinControls.UI.CommandCellClickEventHandler(this.gvOrders_CommandCellClick);
            this.gvOrders.FilterChanged += new Telerik.WinControls.UI.GridViewCollectionChangedEventHandler(this.gvOrders_FilterChanged);
            this.gvOrders.SortChanged += new Telerik.WinControls.UI.GridViewCollectionChangedEventHandler(this.gvOrders_SortChanged);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 410F));
            this.tableLayoutPanel2.Controls.Add(this.lbTitle, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.btnBackToSalesManager, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.ucOrdersFilters, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.UcGridPager, 2, 1);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1105, 224);
            this.tableLayoutPanel2.TabIndex = 9;
            // 
            // lbTitle
            // 
            this.lbTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbTitle.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitle.Location = new System.Drawing.Point(103, 3);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(398, 41);
            this.lbTitle.TabIndex = 13;
            this.lbTitle.Text = "Historial de pedidos enviados";
            // 
            // btnBackToSalesManager
            // 
            this.btnBackToSalesManager.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBackToSalesManager.Location = new System.Drawing.Point(8, 12);
            this.btnBackToSalesManager.Margin = new System.Windows.Forms.Padding(8, 12, 8, 8);
            this.btnBackToSalesManager.Name = "btnBackToSalesManager";
            this.btnBackToSalesManager.Size = new System.Drawing.Size(84, 24);
            this.btnBackToSalesManager.TabIndex = 10;
            this.btnBackToSalesManager.Text = "Volver";
            this.btnBackToSalesManager.Click += new System.EventHandler(this.btnBackToSalesManager_Click);
            // 
            // ucOrdersFilters
            // 
            this.tableLayoutPanel2.SetColumnSpan(this.ucOrdersFilters, 2);
            this.ucOrdersFilters.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucOrdersFilters.Location = new System.Drawing.Point(3, 47);
            this.ucOrdersFilters.Name = "ucOrdersFilters";
            this.ucOrdersFilters.Size = new System.Drawing.Size(689, 174);
            this.ucOrdersFilters.TabIndex = 15;
            this.ucOrdersFilters.FiltersChanged += new System.EventHandler(this.ucOrdersFilters_FiltersChanged);
            // 
            // UcGridPager
            // 
            this.UcGridPager.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.UcGridPager.CurrentPage = 1;
            this.UcGridPager.Location = new System.Drawing.Point(731, 195);
            this.UcGridPager.Margin = new System.Windows.Forms.Padding(0);
            this.UcGridPager.Name = "UcGridPager";
            this.UcGridPager.PageSize = 50;
            this.UcGridPager.PageTotal = 1;
            this.UcGridPager.RefreshAction = null;
            this.UcGridPager.RefreshActionAsync = null;
            this.UcGridPager.Size = new System.Drawing.Size(374, 29);
            this.UcGridPager.TabIndex = 14;
            // 
            // FrmHistoryManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1111, 648);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmHistoryManager";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.Text = "FrmPendingOrders";
            this.Load += new System.EventHandler(this.FrmPendingOrders_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gvOrders.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvOrders)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lbTitle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnBackToSalesManager)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private Telerik.WinControls.UI.RadLabel lbTitle;
        private Telerik.WinControls.UI.RadButton btnBackToSalesManager;
        private Telerik.WinControls.UI.RadGridView gvOrders;
        private Framework.Common.Win.UserControls.UcGridPager UcGridPager;
        private UserControls.UcOrdersFilters ucOrdersFilters;
    }
}
