namespace Avicola.Production.Win.Forms.Batchs
{
    partial class FrmBatchSelection
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
            Telerik.WinControls.UI.GridViewCommandColumn gridViewCommandColumn1 = new Telerik.WinControls.UI.GridViewCommandColumn();
            Telerik.WinControls.UI.TableViewDefinition tableViewDefinition1 = new Telerik.WinControls.UI.TableViewDefinition();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.gvBatches = new Telerik.WinControls.UI.RadGridView();
            this.btnCreateBatch = new Telerik.WinControls.UI.RadButton();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvBatches)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvBatches.MasterTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.gvBatches, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.btnCreateBatch, 0, 1);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 90F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1061, 492);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // gvBatches
            // 
            this.gvBatches.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gvBatches.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gvBatches.Location = new System.Drawing.Point(4, 4);
            this.gvBatches.Margin = new System.Windows.Forms.Padding(4);
            // 
            // 
            // 
            this.gvBatches.MasterTemplate.AllowAddNewRow = false;
            this.gvBatches.MasterTemplate.AllowDeleteRow = false;
            this.gvBatches.MasterTemplate.AllowDragToGroup = false;
            this.gvBatches.MasterTemplate.AllowEditRow = false;
            this.gvBatches.MasterTemplate.AutoGenerateColumns = false;
            this.gvBatches.MasterTemplate.AutoSizeColumnsMode = Telerik.WinControls.UI.GridViewAutoSizeColumnsMode.Fill;
            gridViewTextBoxColumn1.FieldName = "Number";
            gridViewTextBoxColumn1.HeaderText = "Número";
            gridViewTextBoxColumn1.MinWidth = 120;
            gridViewTextBoxColumn1.Name = "Number";
            gridViewTextBoxColumn1.Width = 123;
            gridViewTextBoxColumn2.FieldName = "GeneticLineName";
            gridViewTextBoxColumn2.HeaderText = "Linea Genética";
            gridViewTextBoxColumn2.Name = "GeneticLineName";
            gridViewTextBoxColumn2.Width = 218;
            gridViewTextBoxColumn3.FieldName = "DateOfBirth";
            gridViewTextBoxColumn3.FormatString = "{0: dd/M/yyyy}";
            gridViewTextBoxColumn3.HeaderText = "Fecha de Nac.";
            gridViewTextBoxColumn3.MinWidth = 160;
            gridViewTextBoxColumn3.Name = "DateOfBirth";
            gridViewTextBoxColumn3.Width = 168;
            gridViewTextBoxColumn4.FieldName = "Week";
            gridViewTextBoxColumn4.HeaderText = "Semana Actual";
            gridViewTextBoxColumn4.MinWidth = 160;
            gridViewTextBoxColumn4.Name = "Week";
            gridViewTextBoxColumn4.Width = 160;
            gridViewTextBoxColumn5.FieldName = "StageName";
            gridViewTextBoxColumn5.HeaderText = "Estado";
            gridViewTextBoxColumn5.MinWidth = 120;
            gridViewTextBoxColumn5.Name = "StageName";
            gridViewTextBoxColumn5.Width = 120;
            gridViewTextBoxColumn6.FieldName = "BarnNumber";
            gridViewTextBoxColumn6.HeaderText = "Galpón";
            gridViewTextBoxColumn6.MinWidth = 100;
            gridViewTextBoxColumn6.Name = "BarnNumber";
            gridViewTextBoxColumn6.Width = 100;
            gridViewCommandColumn1.AllowResize = false;
            gridViewCommandColumn1.AllowSort = false;
            gridViewCommandColumn1.DefaultText = "Seleccionar";
            gridViewCommandColumn1.HeaderText = "";
            gridViewCommandColumn1.Name = "SelectColumn";
            gridViewCommandColumn1.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            gridViewCommandColumn1.UseDefaultText = true;
            gridViewCommandColumn1.Width = 150;
            this.gvBatches.MasterTemplate.Columns.AddRange(new Telerik.WinControls.UI.GridViewDataColumn[] {
            gridViewTextBoxColumn1,
            gridViewTextBoxColumn2,
            gridViewTextBoxColumn3,
            gridViewTextBoxColumn4,
            gridViewTextBoxColumn5,
            gridViewTextBoxColumn6,
            gridViewCommandColumn1});
            this.gvBatches.MasterTemplate.ViewDefinition = tableViewDefinition1;
            this.gvBatches.Name = "gvBatches";
            this.gvBatches.Size = new System.Drawing.Size(1053, 434);
            this.gvBatches.TabIndex = 1;
            this.gvBatches.CommandCellClick += new Telerik.WinControls.UI.CommandCellClickEventHandler(this.gvBatches_CommandCellClick);
            // 
            // btnCreateBatch
            // 
            this.btnCreateBatch.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnCreateBatch.Location = new System.Drawing.Point(896, 452);
            this.btnCreateBatch.Name = "btnCreateBatch";
            this.btnCreateBatch.Size = new System.Drawing.Size(162, 30);
            this.btnCreateBatch.TabIndex = 2;
            this.btnCreateBatch.Text = "Crear Lote";
            this.btnCreateBatch.Click += new System.EventHandler(this.btnCreateBatch_Click);
            // 
            // FrmBatchSelection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1061, 492);
            this.Controls.Add(this.tableLayoutPanel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmBatchSelection";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.Text = "FrmBatchSelection";
            this.Load += new System.EventHandler(this.FrmBatchSelection_Load);
            this.tableLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gvBatches.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvBatches)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private Telerik.WinControls.UI.RadGridView gvBatches;
        private Telerik.WinControls.UI.RadButton btnCreateBatch;

    }
}
