namespace Avicola.Deposit.Win.Forms
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
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn1 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn2 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn3 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn4 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn5 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewDateTimeColumn gridViewDateTimeColumn1 = new Telerik.WinControls.UI.GridViewDateTimeColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn6 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn7 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewCommandColumn gridViewCommandColumn1 = new Telerik.WinControls.UI.GridViewCommandColumn();
            Telerik.WinControls.UI.GridViewCommandColumn gridViewCommandColumn2 = new Telerik.WinControls.UI.GridViewCommandColumn();
            Telerik.WinControls.UI.GridViewCommandColumn gridViewCommandColumn3 = new Telerik.WinControls.UI.GridViewCommandColumn();
            Telerik.WinControls.UI.TableViewDefinition tableViewDefinition1 = new Telerik.WinControls.UI.TableViewDefinition();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.lbTitle = new Telerik.WinControls.UI.RadLabel();
            this.btnBackToDepositManager = new Telerik.WinControls.UI.RadButton();
            this.gvOrders = new Telerik.WinControls.UI.RadGridView();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lbTitle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnBackToDepositManager)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvOrders)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvOrders.MasterTemplate)).BeginInit();
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
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 74F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1384, 678);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 90F));
            this.tableLayoutPanel2.Controls.Add(this.lbTitle, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.btnBackToDepositManager, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(4, 4);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1376, 66);
            this.tableLayoutPanel2.TabIndex = 9;
            // 
            // lbTitle
            // 
            this.lbTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbTitle.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitle.Location = new System.Drawing.Point(141, 4);
            this.lbTitle.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(497, 51);
            this.lbTitle.TabIndex = 13;
            this.lbTitle.Text = "Historial de pedidos enviados";
            // 
            // btnBackToDepositManager
            // 
            this.btnBackToDepositManager.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBackToDepositManager.Location = new System.Drawing.Point(11, 15);
            this.btnBackToDepositManager.Margin = new System.Windows.Forms.Padding(11, 15, 11, 10);
            this.btnBackToDepositManager.Name = "btnBackToDepositManager";
            this.btnBackToDepositManager.Size = new System.Drawing.Size(115, 30);
            this.btnBackToDepositManager.TabIndex = 10;
            this.btnBackToDepositManager.Text = "Volver";
            this.btnBackToDepositManager.Click += new System.EventHandler(this.btnBackToDepositManager_Click);
            // 
            // gvOrders
            // 
            this.gvOrders.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gvOrders.Location = new System.Drawing.Point(4, 78);
            this.gvOrders.Margin = new System.Windows.Forms.Padding(4);
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
            gridViewTextBoxColumn1.FieldName = "OrderId";
            gridViewTextBoxColumn1.HeaderText = "OrderId";
            gridViewTextBoxColumn1.IsVisible = false;
            gridViewTextBoxColumn1.Name = "OrderId";
            gridViewTextBoxColumn2.FieldName = "ClientName";
            gridViewTextBoxColumn2.HeaderText = "Cliente";
            gridViewTextBoxColumn2.MaxWidth = 5000;
            gridViewTextBoxColumn2.MinWidth = 200;
            gridViewTextBoxColumn2.Name = "ClientName";
            gridViewTextBoxColumn2.Width = 294;
            gridViewTextBoxColumn3.DataType = typeof(System.DateTime);
            gridViewTextBoxColumn3.FieldName = "CreatedDate";
            gridViewTextBoxColumn3.FormatString = "{0: dd/M/yyyy H:mm}";
            gridViewTextBoxColumn3.HeaderText = "Fecha Pedido";
            gridViewTextBoxColumn3.MinWidth = 80;
            gridViewTextBoxColumn3.Name = "CreatedDate";
            gridViewTextBoxColumn3.Width = 117;
            gridViewTextBoxColumn4.FieldName = "Dozens";
            gridViewTextBoxColumn4.HeaderText = "Docenas";
            gridViewTextBoxColumn4.MinWidth = 60;
            gridViewTextBoxColumn4.Name = "Dozens";
            gridViewTextBoxColumn4.Width = 88;
            gridViewTextBoxColumn5.FieldName = "OrderStatusName";
            gridViewTextBoxColumn5.HeaderText = "Estado";
            gridViewTextBoxColumn5.MinWidth = 60;
            gridViewTextBoxColumn5.Name = "OrderStatusName";
            gridViewTextBoxColumn5.Width = 88;
            gridViewDateTimeColumn1.FieldName = "DispatchedDate";
            gridViewDateTimeColumn1.FormatString = "{0: dd/M/yyyy H:mm}";
            gridViewDateTimeColumn1.HeaderText = "Fecha Envio";
            gridViewDateTimeColumn1.MinWidth = 80;
            gridViewDateTimeColumn1.Name = "DispatchedDate";
            gridViewDateTimeColumn1.Width = 117;
            gridViewTextBoxColumn6.FieldName = "DriverName";
            gridViewTextBoxColumn6.HeaderText = "Conductor";
            gridViewTextBoxColumn6.MinWidth = 120;
            gridViewTextBoxColumn6.Name = "DriverName";
            gridViewTextBoxColumn6.Width = 177;
            gridViewTextBoxColumn7.FieldName = "Truck";
            gridViewTextBoxColumn7.HeaderText = "Camión";
            gridViewTextBoxColumn7.MinWidth = 120;
            gridViewTextBoxColumn7.Name = "Truck";
            gridViewTextBoxColumn7.Width = 274;
            gridViewCommandColumn1.DefaultText = "Armar";
            gridViewCommandColumn1.HeaderText = "";
            gridViewCommandColumn1.MaxWidth = 70;
            gridViewCommandColumn1.MinWidth = 70;
            gridViewCommandColumn1.Name = "BuildOrder";
            gridViewCommandColumn1.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            gridViewCommandColumn1.UseDefaultText = true;
            gridViewCommandColumn1.Width = 70;
            gridViewCommandColumn2.DefaultText = "Finalizar";
            gridViewCommandColumn2.HeaderText = "";
            gridViewCommandColumn2.MaxWidth = 70;
            gridViewCommandColumn2.MinWidth = 70;
            gridViewCommandColumn2.Name = "FinishOrder";
            gridViewCommandColumn2.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            gridViewCommandColumn2.UseDefaultText = true;
            gridViewCommandColumn2.Width = 70;
            gridViewCommandColumn3.DefaultText = "Enviar";
            gridViewCommandColumn3.HeaderText = "";
            gridViewCommandColumn3.MaxWidth = 70;
            gridViewCommandColumn3.MinWidth = 70;
            gridViewCommandColumn3.Name = "SendOrder";
            gridViewCommandColumn3.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            gridViewCommandColumn3.UseDefaultText = true;
            gridViewCommandColumn3.Width = 70;
            this.gvOrders.MasterTemplate.Columns.AddRange(new Telerik.WinControls.UI.GridViewDataColumn[] {
            gridViewTextBoxColumn1,
            gridViewTextBoxColumn2,
            gridViewTextBoxColumn3,
            gridViewTextBoxColumn4,
            gridViewTextBoxColumn5,
            gridViewDateTimeColumn1,
            gridViewTextBoxColumn6,
            gridViewTextBoxColumn7,
            gridViewCommandColumn1,
            gridViewCommandColumn2,
            gridViewCommandColumn3});
            this.gvOrders.MasterTemplate.EnablePaging = true;
            this.gvOrders.MasterTemplate.ViewDefinition = tableViewDefinition1;
            this.gvOrders.Name = "gvOrders";
            this.gvOrders.ReadOnly = true;
            this.gvOrders.ShowGroupPanelScrollbars = false;
            this.gvOrders.Size = new System.Drawing.Size(1376, 596);
            this.gvOrders.TabIndex = 10;
            this.gvOrders.ThemeName = "TelerikMetroBlue";
            this.gvOrders.CellFormatting += new Telerik.WinControls.UI.CellFormattingEventHandler(this.gvOrders_CellFormatting);
            this.gvOrders.CommandCellClick += new Telerik.WinControls.UI.CommandCellClickEventHandler(this.gvOrders_CommandCellClick);
            // 
            // FrmHistoryManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1384, 678);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Name = "FrmHistoryManager";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.Text = "FrmPendingOrders";
            this.Load += new System.EventHandler(this.FrmPendingOrders_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lbTitle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnBackToDepositManager)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvOrders.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvOrders)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private Telerik.WinControls.UI.RadLabel lbTitle;
        private Telerik.WinControls.UI.RadButton btnBackToDepositManager;
        private Telerik.WinControls.UI.RadGridView gvOrders;
    }
}
