namespace Avicola.Production.Win.UserControls
{
    partial class UcBatchBarnDetails
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn1 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn2 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.TableViewDefinition tableViewDefinition1 = new Telerik.WinControls.UI.TableViewDefinition();
            this.gvBatchBarns = new Telerik.WinControls.UI.RadGridView();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lbBatchBarnTitle = new Telerik.WinControls.UI.RadLabel();
            ((System.ComponentModel.ISupportInitialize)(this.gvBatchBarns)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvBatchBarns.MasterTemplate)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lbBatchBarnTitle)).BeginInit();
            this.SuspendLayout();
            // 
            // gvBatchBarns
            // 
            this.gvBatchBarns.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gvBatchBarns.Location = new System.Drawing.Point(3, 53);
            // 
            // 
            // 
            this.gvBatchBarns.MasterTemplate.AllowAddNewRow = false;
            this.gvBatchBarns.MasterTemplate.AllowColumnReorder = false;
            this.gvBatchBarns.MasterTemplate.AutoSizeColumnsMode = Telerik.WinControls.UI.GridViewAutoSizeColumnsMode.Fill;
            gridViewTextBoxColumn1.FieldName = "BarnName";
            gridViewTextBoxColumn1.HeaderText = "Galpón";
            gridViewTextBoxColumn1.Name = "BarnName";
            gridViewTextBoxColumn1.Width = 418;
            gridViewTextBoxColumn2.FieldName = "InitialBirds";
            gridViewTextBoxColumn2.HeaderText = "Aves Iniciales";
            gridViewTextBoxColumn2.Name = "InitialBirds";
            gridViewTextBoxColumn2.Width = 321;
            this.gvBatchBarns.MasterTemplate.Columns.AddRange(new Telerik.WinControls.UI.GridViewDataColumn[] {
            gridViewTextBoxColumn1,
            gridViewTextBoxColumn2});
            this.gvBatchBarns.MasterTemplate.ViewDefinition = tableViewDefinition1;
            this.gvBatchBarns.Name = "gvBatchBarns";
            this.gvBatchBarns.ReadOnly = true;
            this.gvBatchBarns.ShowGroupPanel = false;
            this.gvBatchBarns.Size = new System.Drawing.Size(758, 136);
            this.gvBatchBarns.TabIndex = 85;
            this.gvBatchBarns.Text = "radGridView1";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoSize = true;
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.lbBatchBarnTitle, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.gvBatchBarns, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(764, 192);
            this.tableLayoutPanel1.TabIndex = 86;
            // 
            // lbBatchBarnTitle
            // 
            this.lbBatchBarnTitle.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbBatchBarnTitle.Location = new System.Drawing.Point(3, 3);
            this.lbBatchBarnTitle.Name = "lbBatchBarnTitle";
            this.lbBatchBarnTitle.Size = new System.Drawing.Size(192, 41);
            this.lbBatchBarnTitle.TabIndex = 86;
            this.lbBatchBarnTitle.Text = "{{Batch Title}}";
            // 
            // UcBatchBarnDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "UcBatchBarnDetails";
            this.Size = new System.Drawing.Size(764, 192);
            ((System.ComponentModel.ISupportInitialize)(this.gvBatchBarns.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvBatchBarns)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lbBatchBarnTitle)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Telerik.WinControls.UI.RadGridView gvBatchBarns;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private Telerik.WinControls.UI.RadLabel lbBatchBarnTitle;

    }
}
