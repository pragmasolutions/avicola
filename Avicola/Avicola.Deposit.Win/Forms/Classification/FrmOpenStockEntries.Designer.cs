namespace Avicola.Deposit.Win.Forms
{
    partial class FrmOpenStockEntries
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
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn1 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn2 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn3 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn4 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn5 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewCommandColumn gridViewCommandColumn1 = new Telerik.WinControls.UI.GridViewCommandColumn();
            Telerik.WinControls.UI.TableViewDefinition tableViewDefinition1 = new Telerik.WinControls.UI.TableViewDefinition();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.gvStockEntries = new Telerik.WinControls.UI.RadGridView();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.lbTitle = new Telerik.WinControls.UI.RadLabel();
            this.btnBackToDepositManager = new Telerik.WinControls.UI.RadButton();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvStockEntries)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvStockEntries.MasterTemplate)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lbTitle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnBackToDepositManager)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.gvStockEntries, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1038, 551);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // gvStockEntries
            // 
            this.gvStockEntries.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gvStockEntries.Location = new System.Drawing.Point(3, 63);
            // 
            // 
            // 
            this.gvStockEntries.MasterTemplate.AllowAddNewRow = false;
            this.gvStockEntries.MasterTemplate.AllowColumnReorder = false;
            this.gvStockEntries.MasterTemplate.AllowDeleteRow = false;
            this.gvStockEntries.MasterTemplate.AllowDragToGroup = false;
            this.gvStockEntries.MasterTemplate.AllowEditRow = false;
            this.gvStockEntries.MasterTemplate.AllowRowReorder = true;
            this.gvStockEntries.MasterTemplate.AutoGenerateColumns = false;
            this.gvStockEntries.MasterTemplate.AutoSizeColumnsMode = Telerik.WinControls.UI.GridViewAutoSizeColumnsMode.Fill;
            gridViewTextBoxColumn1.FieldName = "OrderId";
            gridViewTextBoxColumn1.HeaderText = "OrderId";
            gridViewTextBoxColumn1.IsVisible = false;
            gridViewTextBoxColumn1.Name = "OrderId";
            gridViewTextBoxColumn2.DataType = typeof(System.DateTime);
            gridViewTextBoxColumn2.FieldName = "CreatedDate";
            gridViewTextBoxColumn2.FormatString = "{0: dd/M/yyyy H:mm}";
            gridViewTextBoxColumn2.HeaderText = "Fecha";
            gridViewTextBoxColumn2.MinWidth = 80;
            gridViewTextBoxColumn2.Name = "CreatedDate";
            gridViewTextBoxColumn2.Width = 294;
            gridViewTextBoxColumn3.FieldName = "ShiftName";
            gridViewTextBoxColumn3.HeaderText = "Turno";
            gridViewTextBoxColumn3.MinWidth = 120;
            gridViewTextBoxColumn3.Name = "ShiftName";
            gridViewTextBoxColumn3.Width = 120;
            gridViewTextBoxColumn4.FieldName = "TotalEggs";
            gridViewTextBoxColumn4.HeaderText = "Huevos Totales";
            gridViewTextBoxColumn4.MinWidth = 60;
            gridViewTextBoxColumn4.Name = "TotalEggs";
            gridViewTextBoxColumn4.TextAlignment = System.Drawing.ContentAlignment.MiddleRight;
            gridViewTextBoxColumn4.Width = 220;
            gridViewTextBoxColumn5.FieldName = "CurrentEggs";
            gridViewTextBoxColumn5.HeaderText = "Huevos Restantes";
            gridViewTextBoxColumn5.MinWidth = 60;
            gridViewTextBoxColumn5.Name = "RemainingEggs";
            gridViewTextBoxColumn5.TextAlignment = System.Drawing.ContentAlignment.MiddleRight;
            gridViewTextBoxColumn5.Width = 312;
            gridViewCommandColumn1.DefaultText = "Detalle";
            gridViewCommandColumn1.HeaderText = "";
            gridViewCommandColumn1.MaxWidth = 70;
            gridViewCommandColumn1.MinWidth = 70;
            gridViewCommandColumn1.Name = "Details";
            gridViewCommandColumn1.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            gridViewCommandColumn1.UseDefaultText = true;
            gridViewCommandColumn1.Width = 70;
            this.gvStockEntries.MasterTemplate.Columns.AddRange(new Telerik.WinControls.UI.GridViewDataColumn[] {
            gridViewTextBoxColumn1,
            gridViewTextBoxColumn2,
            gridViewTextBoxColumn3,
            gridViewTextBoxColumn4,
            gridViewTextBoxColumn5,
            gridViewCommandColumn1});
            this.gvStockEntries.MasterTemplate.EnablePaging = true;
            this.gvStockEntries.MasterTemplate.ViewDefinition = tableViewDefinition1;
            this.gvStockEntries.Name = "gvStockEntries";
            this.gvStockEntries.ReadOnly = true;
            this.gvStockEntries.ShowGroupPanelScrollbars = false;
            this.gvStockEntries.Size = new System.Drawing.Size(1032, 485);
            this.gvStockEntries.TabIndex = 10;
            this.gvStockEntries.ThemeName = "TelerikMetroBlue";
            this.gvStockEntries.CommandCellClick += new Telerik.WinControls.UI.CommandCellClickEventHandler(this.gvStockEntries_CommandCellClick);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.lbTitle, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.btnBackToDepositManager, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1032, 54);
            this.tableLayoutPanel2.TabIndex = 9;
            // 
            // lbTitle
            // 
            this.lbTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbTitle.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitle.Location = new System.Drawing.Point(119, 3);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(910, 41);
            this.lbTitle.TabIndex = 13;
            this.lbTitle.Text = "Partidas";
            // 
            // btnBackToDepositManager
            // 
            this.btnBackToDepositManager.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBackToDepositManager.Location = new System.Drawing.Point(8, 12);
            this.btnBackToDepositManager.Margin = new System.Windows.Forms.Padding(8, 12, 8, 8);
            this.btnBackToDepositManager.Name = "btnBackToDepositManager";
            this.btnBackToDepositManager.Size = new System.Drawing.Size(100, 24);
            this.btnBackToDepositManager.TabIndex = 10;
            this.btnBackToDepositManager.Text = "Volver";
            this.btnBackToDepositManager.Click += new System.EventHandler(this.btnBackToDepositManager_Click);
            // 
            // FrmOpenStockEntries
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1038, 551);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmOpenStockEntries";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.Text = "FrmPendingOrders";
            this.Load += new System.EventHandler(this.FrmOpenStockEntries_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gvStockEntries.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvStockEntries)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lbTitle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnBackToDepositManager)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private Telerik.WinControls.UI.RadLabel lbTitle;
        private Telerik.WinControls.UI.RadButton btnBackToDepositManager;
        private Telerik.WinControls.UI.RadGridView gvStockEntries;
    }
}
