namespace Avicola.Sales.Win.Forms
{
    partial class FrmClientsList
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
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn6 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn7 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn8 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn9 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewCommandColumn gridViewCommandColumn1 = new Telerik.WinControls.UI.GridViewCommandColumn();
            Telerik.WinControls.UI.GridViewCommandColumn gridViewCommandColumn2 = new Telerik.WinControls.UI.GridViewCommandColumn();
            Telerik.WinControls.UI.TableViewDefinition tableViewDefinition1 = new Telerik.WinControls.UI.TableViewDefinition();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.btnBack = new Telerik.WinControls.UI.RadButton();
            this.BtnAgregar = new Telerik.WinControls.UI.RadButton();
            this.lbTitle = new Telerik.WinControls.UI.RadLabel();
            this.wbClients = new Telerik.WinControls.UI.RadWaitingBar();
            this.gvClients = new Telerik.WinControls.UI.RadGridView();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnBack)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnAgregar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lbTitle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.wbClients)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvClients)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvClients.MasterTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.gvClients, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1189, 534);
            this.tableLayoutPanel1.TabIndex = 85;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 4;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.Controls.Add(this.btnBack, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.BtnAgregar, 3, 0);
            this.tableLayoutPanel2.Controls.Add(this.lbTitle, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.wbClients, 2, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1183, 74);
            this.tableLayoutPanel2.TabIndex = 86;
            // 
            // btnBack
            // 
            this.btnBack.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnBack.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(2, 25);
            this.btnBack.Margin = new System.Windows.Forms.Padding(2);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(100, 24);
            this.btnBack.TabIndex = 83;
            this.btnBack.Text = "Volver";
            this.btnBack.ThemeName = "TelerikMetroBlue";
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // BtnAgregar
            // 
            this.BtnAgregar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BtnAgregar.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAgregar.Location = new System.Drawing.Point(1081, 25);
            this.BtnAgregar.Margin = new System.Windows.Forms.Padding(2);
            this.BtnAgregar.Name = "BtnAgregar";
            this.BtnAgregar.Size = new System.Drawing.Size(100, 24);
            this.BtnAgregar.TabIndex = 82;
            this.BtnAgregar.Text = "Agregar";
            this.BtnAgregar.ThemeName = "TelerikMetroBlue";
            this.BtnAgregar.Click += new System.EventHandler(this.BtnAgregar_Click);
            // 
            // lbTitle
            // 
            this.lbTitle.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lbTitle.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitle.Location = new System.Drawing.Point(107, 16);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(115, 41);
            this.lbTitle.TabIndex = 83;
            this.lbTitle.Text = "Clientes";
            // 
            // wbClients
            // 
            this.wbClients.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.wbClients.Location = new System.Drawing.Point(948, 25);
            this.wbClients.Name = "wbClients";
            this.wbClients.Size = new System.Drawing.Size(128, 24);
            this.wbClients.TabIndex = 84;
            this.wbClients.Text = "radWaitingBar1";
            this.wbClients.Visible = false;
            this.wbClients.WaitingSpeed = 100;
            this.wbClients.WaitingStep = 10;
            // 
            // gvClients
            // 
            this.gvClients.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gvClients.Location = new System.Drawing.Point(3, 83);
            // 
            // 
            // 
            this.gvClients.MasterTemplate.AllowAddNewRow = false;
            this.gvClients.MasterTemplate.AllowColumnReorder = false;
            this.gvClients.MasterTemplate.AutoSizeColumnsMode = Telerik.WinControls.UI.GridViewAutoSizeColumnsMode.Fill;
            gridViewTextBoxColumn1.FieldName = "Name";
            gridViewTextBoxColumn1.HeaderText = "Nombre";
            gridViewTextBoxColumn1.MaxWidth = 240;
            gridViewTextBoxColumn1.MinWidth = 150;
            gridViewTextBoxColumn1.Name = "Name";
            gridViewTextBoxColumn1.Width = 178;
            gridViewTextBoxColumn2.FieldName = "Tel1";
            gridViewTextBoxColumn2.HeaderText = "Tel. 1";
            gridViewTextBoxColumn2.MaxWidth = 100;
            gridViewTextBoxColumn2.MinWidth = 80;
            gridViewTextBoxColumn2.Name = "Tel1";
            gridViewTextBoxColumn2.Width = 80;
            gridViewTextBoxColumn3.FieldName = "Tel2";
            gridViewTextBoxColumn3.HeaderText = "Tel. 2";
            gridViewTextBoxColumn3.MaxWidth = 100;
            gridViewTextBoxColumn3.MinWidth = 80;
            gridViewTextBoxColumn3.Name = "Tel2";
            gridViewTextBoxColumn3.Width = 80;
            gridViewTextBoxColumn4.FieldName = "CellPhone";
            gridViewTextBoxColumn4.HeaderText = "Cel.";
            gridViewTextBoxColumn4.MaxWidth = 100;
            gridViewTextBoxColumn4.MinWidth = 80;
            gridViewTextBoxColumn4.Name = "CellPhone";
            gridViewTextBoxColumn4.Width = 82;
            gridViewTextBoxColumn5.FieldName = "Email";
            gridViewTextBoxColumn5.HeaderText = "Email";
            gridViewTextBoxColumn5.MaxWidth = 160;
            gridViewTextBoxColumn5.MinWidth = 140;
            gridViewTextBoxColumn5.Name = "Email";
            gridViewTextBoxColumn5.Width = 140;
            gridViewTextBoxColumn6.FieldName = "Referent";
            gridViewTextBoxColumn6.HeaderText = "Referente";
            gridViewTextBoxColumn6.MaxWidth = 150;
            gridViewTextBoxColumn6.MinWidth = 120;
            gridViewTextBoxColumn6.Name = "Referent";
            gridViewTextBoxColumn6.RowSpan = 12;
            gridViewTextBoxColumn6.Width = 123;
            gridViewTextBoxColumn7.FieldName = "Address";
            gridViewTextBoxColumn7.HeaderText = "Dirección";
            gridViewTextBoxColumn7.MinWidth = 150;
            gridViewTextBoxColumn7.Name = "Address";
            gridViewTextBoxColumn7.RowSpan = 100;
            gridViewTextBoxColumn7.Width = 150;
            gridViewTextBoxColumn8.FieldName = "City";
            gridViewTextBoxColumn8.HeaderText = "Ciudad";
            gridViewTextBoxColumn8.MaxWidth = 120;
            gridViewTextBoxColumn8.MinWidth = 110;
            gridViewTextBoxColumn8.Name = "City";
            gridViewTextBoxColumn8.RowSpan = 80;
            gridViewTextBoxColumn8.Width = 110;
            gridViewTextBoxColumn9.FieldName = "WebSite";
            gridViewTextBoxColumn9.HeaderText = "Web";
            gridViewTextBoxColumn9.MaxWidth = 150;
            gridViewTextBoxColumn9.MinWidth = 120;
            gridViewTextBoxColumn9.Name = "WebSite";
            gridViewTextBoxColumn9.Width = 150;
            gridViewCommandColumn1.HeaderText = "";
            gridViewCommandColumn1.Image = global::Avicola.Sales.Win.Properties.Resources.Data_Edit;
            gridViewCommandColumn1.ImageLayout = System.Windows.Forms.ImageLayout.Center;
            gridViewCommandColumn1.MaxWidth = 40;
            gridViewCommandColumn1.MinWidth = 40;
            gridViewCommandColumn1.Name = "btnEdit";
            gridViewCommandColumn1.Width = 40;
            gridViewCommandColumn2.HeaderText = "";
            gridViewCommandColumn2.Image = global::Avicola.Sales.Win.Properties.Resources.Garbage_Closed;
            gridViewCommandColumn2.ImageLayout = System.Windows.Forms.ImageLayout.Center;
            gridViewCommandColumn2.MaxWidth = 40;
            gridViewCommandColumn2.MinWidth = 40;
            gridViewCommandColumn2.Name = "btnDelete";
            gridViewCommandColumn2.Width = 40;
            this.gvClients.MasterTemplate.Columns.AddRange(new Telerik.WinControls.UI.GridViewDataColumn[] {
            gridViewTextBoxColumn1,
            gridViewTextBoxColumn2,
            gridViewTextBoxColumn3,
            gridViewTextBoxColumn4,
            gridViewTextBoxColumn5,
            gridViewTextBoxColumn6,
            gridViewTextBoxColumn7,
            gridViewTextBoxColumn8,
            gridViewTextBoxColumn9,
            gridViewCommandColumn1,
            gridViewCommandColumn2});
            this.gvClients.MasterTemplate.EnableFiltering = true;
            this.gvClients.MasterTemplate.EnablePaging = true;
            this.gvClients.MasterTemplate.ViewDefinition = tableViewDefinition1;
            this.gvClients.Name = "gvClients";
            this.gvClients.ReadOnly = true;
            this.gvClients.ShowGroupPanel = false;
            this.gvClients.Size = new System.Drawing.Size(1183, 448);
            this.gvClients.TabIndex = 84;
            this.gvClients.PageChanged += new System.EventHandler<System.EventArgs>(this.gvClients_PageChanged);
            this.gvClients.CommandCellClick += new Telerik.WinControls.UI.CommandCellClickEventHandler(this.gvClients_CommandCellClick);
            // 
            // FrmClientsList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1189, 534);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FrmClientsList";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Medicamentos";
            this.Load += new System.EventHandler(this.FrmBatchMedicineList_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnBack)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnAgregar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lbTitle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.wbClients)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvClients.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvClients)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Telerik.WinControls.UI.RadButton BtnAgregar;
        private Telerik.WinControls.UI.RadGridView gvClients;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private Telerik.WinControls.UI.RadButton btnBack;
        private Telerik.WinControls.UI.RadLabel lbTitle;
        private Telerik.WinControls.UI.RadWaitingBar wbClients;
    }
}
