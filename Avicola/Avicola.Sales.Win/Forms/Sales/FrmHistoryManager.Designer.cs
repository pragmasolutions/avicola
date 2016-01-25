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
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn8 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn9 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn10 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn11 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn12 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewDateTimeColumn gridViewDateTimeColumn2 = new Telerik.WinControls.UI.GridViewDateTimeColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn13 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn14 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewCommandColumn gridViewCommandColumn2 = new Telerik.WinControls.UI.GridViewCommandColumn();
            Telerik.WinControls.UI.TableViewDefinition tableViewDefinition2 = new Telerik.WinControls.UI.TableViewDefinition();
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
            gridViewTextBoxColumn8.FieldName = "OrderId";
            gridViewTextBoxColumn8.HeaderText = "OrderId";
            gridViewTextBoxColumn8.IsVisible = false;
            gridViewTextBoxColumn8.Name = "OrderId";
            gridViewTextBoxColumn9.FieldName = "ClientName";
            gridViewTextBoxColumn9.HeaderText = "Cliente";
            gridViewTextBoxColumn9.MaxWidth = 5000;
            gridViewTextBoxColumn9.MinWidth = 200;
            gridViewTextBoxColumn9.Name = "ClientName";
            gridViewTextBoxColumn9.Width = 279;
            gridViewTextBoxColumn10.DataType = typeof(System.DateTime);
            gridViewTextBoxColumn10.FieldName = "CreatedDate";
            gridViewTextBoxColumn10.FormatString = "{0: dd/M/yyyy H:mm}";
            gridViewTextBoxColumn10.HeaderText = "Fecha Pedido";
            gridViewTextBoxColumn10.MinWidth = 80;
            gridViewTextBoxColumn10.Name = "CreatedDate";
            gridViewTextBoxColumn10.Width = 111;
            gridViewTextBoxColumn11.AllowSort = false;
            gridViewTextBoxColumn11.FieldName = "Dozens";
            gridViewTextBoxColumn11.HeaderText = "Docenas";
            gridViewTextBoxColumn11.MinWidth = 60;
            gridViewTextBoxColumn11.Name = "Dozens";
            gridViewTextBoxColumn11.Width = 84;
            gridViewTextBoxColumn12.FieldName = "OrderStatusName";
            gridViewTextBoxColumn12.HeaderText = "Estado";
            gridViewTextBoxColumn12.MinWidth = 60;
            gridViewTextBoxColumn12.Name = "OrderStatusName";
            gridViewTextBoxColumn12.Width = 84;
            gridViewDateTimeColumn2.FieldName = "DispatchedDate";
            gridViewDateTimeColumn2.FormatString = "{0: dd/M/yyyy H:mm}";
            gridViewDateTimeColumn2.HeaderText = "Fecha Envio";
            gridViewDateTimeColumn2.MinWidth = 80;
            gridViewDateTimeColumn2.Name = "DispatchedDate";
            gridViewDateTimeColumn2.Width = 111;
            gridViewTextBoxColumn13.FieldName = "DriverName";
            gridViewTextBoxColumn13.HeaderText = "Conductor";
            gridViewTextBoxColumn13.MinWidth = 120;
            gridViewTextBoxColumn13.Name = "DriverName";
            gridViewTextBoxColumn13.Width = 167;
            gridViewTextBoxColumn14.FieldName = "Truck";
            gridViewTextBoxColumn14.HeaderText = "Camión";
            gridViewTextBoxColumn14.MinWidth = 120;
            gridViewTextBoxColumn14.Name = "Truck";
            gridViewTextBoxColumn14.Width = 206;
            gridViewCommandColumn2.FieldName = "Delete";
            gridViewCommandColumn2.HeaderText = "";
            gridViewCommandColumn2.Image = global::Avicola.Sales.Win.Properties.Resources.Garbage_Closed;
            gridViewCommandColumn2.MaxWidth = 50;
            gridViewCommandColumn2.MinWidth = 50;
            gridViewCommandColumn2.Name = "Delete";
            this.gvOrders.MasterTemplate.Columns.AddRange(new Telerik.WinControls.UI.GridViewDataColumn[] {
            gridViewTextBoxColumn8,
            gridViewTextBoxColumn9,
            gridViewTextBoxColumn10,
            gridViewTextBoxColumn11,
            gridViewTextBoxColumn12,
            gridViewDateTimeColumn2,
            gridViewTextBoxColumn13,
            gridViewTextBoxColumn14,
            gridViewCommandColumn2});
            this.gvOrders.MasterTemplate.ViewDefinition = tableViewDefinition2;
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
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
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
            this.lbTitle.Size = new System.Drawing.Size(589, 38);
            this.lbTitle.TabIndex = 13;
            this.lbTitle.Text = "Historial de pedidos enviados";
            // 
            // btnBackToSalesManager
            // 
            this.btnBackToSalesManager.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBackToSalesManager.Location = new System.Drawing.Point(8, 12);
            this.btnBackToSalesManager.Margin = new System.Windows.Forms.Padding(8, 12, 8, 8);
            this.btnBackToSalesManager.Name = "btnBackToSalesManager";
            this.btnBackToSalesManager.Size = new System.Drawing.Size(100, 24);
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
            this.UcGridPager.PageSize = 20;
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
