namespace Avicola.Deposit.Dashboard
{
    partial class DepositDashboard
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
            Telerik.WinControls.UI.TableViewDefinition tableViewDefinition1 = new Telerik.WinControls.UI.TableViewDefinition();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.label6 = new System.Windows.Forms.Label();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.flpStock = new System.Windows.Forms.FlowLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.label5 = new System.Windows.Forms.Label();
            this.dgvPreparedOrders = new Telerik.WinControls.UI.RadGridView();
            this.flpCurrentOrders = new System.Windows.Forms.FlowLayoutPanel();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel6.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel5.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPreparedOrders)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPreparedOrders.MasterTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 700F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.panel6, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1348, 726);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // panel6
            // 
            this.panel6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel6.Controls.Add(this.tableLayoutPanel4);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel6.Location = new System.Drawing.Point(710, 10);
            this.panel6.Margin = new System.Windows.Forms.Padding(10);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(628, 706);
            this.panel6.TabIndex = 3;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 1;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Controls.Add(this.label6, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.flpCurrentOrders, 0, 1);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 2;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.01549F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 88.98451F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(626, 704);
            this.tableLayoutPanel4.TabIndex = 0;
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(140, 22);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(345, 32);
            this.label6.TabIndex = 6;
            this.label6.Text = "PEDIDOS PENDIENTES";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.panel5, 0, 1);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 300F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(694, 720);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.flpStock);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(10, 10);
            this.panel1.Margin = new System.Windows.Forms.Padding(10);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(674, 280);
            this.panel1.TabIndex = 0;
            // 
            // flpStock
            // 
            this.flpStock.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flpStock.Location = new System.Drawing.Point(10, 58);
            this.flpStock.Name = "flpStock";
            this.flpStock.Size = new System.Drawing.Size(652, 206);
            this.flpStock.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(150, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(242, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "STOCK ACTUAL";
            // 
            // panel5
            // 
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel5.Controls.Add(this.tableLayoutPanel3);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(10, 310);
            this.panel5.Margin = new System.Windows.Forms.Padding(10);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(674, 400);
            this.panel5.TabIndex = 1;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Controls.Add(this.label5, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.dgvPreparedOrders, 0, 1);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 2;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel3.Size = new System.Drawing.Size(672, 398);
            this.tableLayoutPanel3.TabIndex = 0;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(183, 14);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(305, 32);
            this.label5.TabIndex = 1;
            this.label5.Text = "PEDIDOS ARMADOS";
            // 
            // dgvPreparedOrders
            // 
            this.dgvPreparedOrders.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvPreparedOrders.Location = new System.Drawing.Point(10, 70);
            this.dgvPreparedOrders.Margin = new System.Windows.Forms.Padding(10);
            // 
            // 
            // 
            gridViewTextBoxColumn1.FieldName = "OrderId";
            gridViewTextBoxColumn1.HeaderText = "OrderId";
            gridViewTextBoxColumn1.IsVisible = false;
            gridViewTextBoxColumn1.Name = "OrderId";
            gridViewTextBoxColumn2.FieldName = "ClientName";
            gridViewTextBoxColumn2.HeaderText = "Cliente";
            gridViewTextBoxColumn2.MaxWidth = 5000;
            gridViewTextBoxColumn2.MinWidth = 1;
            gridViewTextBoxColumn2.Name = "ClientName";
            gridViewTextBoxColumn2.Width = 200;
            gridViewTextBoxColumn3.DataType = typeof(System.DateTime);
            gridViewTextBoxColumn3.FieldName = "CreatedDate";
            gridViewTextBoxColumn3.FormatString = "{0: dd/M/yyyy}";
            gridViewTextBoxColumn3.HeaderText = "Fecha Pedido";
            gridViewTextBoxColumn3.MinWidth = 1;
            gridViewTextBoxColumn3.Name = "CreatedDate";
            gridViewTextBoxColumn3.Width = 100;
            gridViewTextBoxColumn4.FieldName = "Dozens";
            gridViewTextBoxColumn4.HeaderText = "Docenas";
            gridViewTextBoxColumn4.MinWidth = 1;
            gridViewTextBoxColumn4.Name = "Dozens";
            gridViewTextBoxColumn4.Width = 70;
            gridViewTextBoxColumn5.FieldName = "PreparedDate";
            gridViewTextBoxColumn5.FormatString = "{0: dd/M/yyyy}";
            gridViewTextBoxColumn5.HeaderText = "Fecha Armado";
            gridViewTextBoxColumn5.MinWidth = 1;
            gridViewTextBoxColumn5.Name = "PreparedDate";
            gridViewTextBoxColumn5.Width = 100;
            this.dgvPreparedOrders.MasterTemplate.Columns.AddRange(new Telerik.WinControls.UI.GridViewDataColumn[] {
            gridViewTextBoxColumn1,
            gridViewTextBoxColumn2,
            gridViewTextBoxColumn3,
            gridViewTextBoxColumn4,
            gridViewTextBoxColumn5});
            this.dgvPreparedOrders.MasterTemplate.ViewDefinition = tableViewDefinition1;
            this.dgvPreparedOrders.Name = "dgvPreparedOrders";
            this.dgvPreparedOrders.ReadOnly = true;
            this.dgvPreparedOrders.Size = new System.Drawing.Size(652, 318);
            this.dgvPreparedOrders.TabIndex = 2;
            this.dgvPreparedOrders.Text = "radGridView1";
            this.dgvPreparedOrders.ThemeName = "TelerikMetroBlue";
            // 
            // flpCurrentOrders
            // 
            this.flpCurrentOrders.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flpCurrentOrders.Location = new System.Drawing.Point(3, 80);
            this.flpCurrentOrders.Name = "flpCurrentOrders";
            this.flpCurrentOrders.Size = new System.Drawing.Size(620, 621);
            this.flpCurrentOrders.TabIndex = 7;
            // 
            // DepositDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1348, 726);
            this.ControlBox = false;
            this.Controls.Add(this.tableLayoutPanel1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "DepositDashboard";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.Text = "Tablero de Depósito";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.DepositDashboard_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPreparedOrders.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPreparedOrders)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox txtEggs;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Label label5;
        private Telerik.WinControls.UI.RadGridView dgvPreparedOrders;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.FlowLayoutPanel flpStock;
        private System.Windows.Forms.FlowLayoutPanel flpCurrentOrders;
    }
}