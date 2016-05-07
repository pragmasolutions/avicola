namespace Avicola.Production.Win.Forms.SiloEmptyings
{
    partial class FrmEnterSilosEmptying
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
            Telerik.WinControls.UI.GridViewCommandColumn gridViewCommandColumn1 = new Telerik.WinControls.UI.GridViewCommandColumn();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmEnterSilosEmptying));
            Telerik.WinControls.UI.GridViewCommandColumn gridViewCommandColumn2 = new Telerik.WinControls.UI.GridViewCommandColumn();
            Telerik.WinControls.UI.TableViewDefinition tableViewDefinition1 = new Telerik.WinControls.UI.TableViewDefinition();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.lbCurrentStandard = new Telerik.WinControls.UI.RadLabel();
            this.btnShowStandardSelection = new Telerik.WinControls.UI.RadButton();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.gvSilos = new Telerik.WinControls.UI.RadGridView();
            this.btnCrearVaciamiento = new Telerik.WinControls.UI.RadButton();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lbCurrentStandard)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnShowStandardSelection)).BeginInit();
            this.tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvSilos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvSilos.MasterTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCrearVaciamiento)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(832, 492);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 200F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 855F));
            this.tableLayoutPanel2.Controls.Add(this.lbCurrentStandard, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.btnShowStandardSelection, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(826, 44);
            this.tableLayoutPanel2.TabIndex = 4;
            // 
            // lbCurrentStandard
            // 
            this.lbCurrentStandard.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbCurrentStandard.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCurrentStandard.Location = new System.Drawing.Point(203, 3);
            this.lbCurrentStandard.Name = "lbCurrentStandard";
            this.lbCurrentStandard.Size = new System.Drawing.Size(278, 41);
            this.lbCurrentStandard.TabIndex = 2;
            this.lbCurrentStandard.Text = "{{Current Standard}}";
            // 
            // btnShowStandardSelection
            // 
            this.btnShowStandardSelection.Image = global::Avicola.Production.Win.Properties.Resources.back;
            this.btnShowStandardSelection.Location = new System.Drawing.Point(3, 3);
            this.btnShowStandardSelection.Name = "btnShowStandardSelection";
            this.btnShowStandardSelection.Size = new System.Drawing.Size(177, 37);
            this.btnShowStandardSelection.TabIndex = 1;
            this.btnShowStandardSelection.Text = "Ir Seleccionar Indicador";
            this.btnShowStandardSelection.Click += new System.EventHandler(this.btnShowStandardSelection_Click);
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Controls.Add(this.gvSilos, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.btnCrearVaciamiento, 0, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(2, 52);
            this.tableLayoutPanel3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 2;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.992203F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 92.0078F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(828, 418);
            this.tableLayoutPanel3.TabIndex = 5;
            // 
            // gvSilos
            // 
            this.gvSilos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gvSilos.Location = new System.Drawing.Point(3, 36);
            // 
            // 
            // 
            this.gvSilos.MasterTemplate.AllowAddNewRow = false;
            this.gvSilos.MasterTemplate.AutoSizeColumnsMode = Telerik.WinControls.UI.GridViewAutoSizeColumnsMode.Fill;
            gridViewTextBoxColumn1.FieldName = "Id";
            gridViewTextBoxColumn1.HeaderText = "Id";
            gridViewTextBoxColumn1.IsVisible = false;
            gridViewTextBoxColumn1.Name = "Id";
            gridViewTextBoxColumn2.FieldName = "Date";
            gridViewTextBoxColumn2.FormatString = "{0: dd/M/yyyy}";
            gridViewTextBoxColumn2.HeaderText = "Fecha";
            gridViewTextBoxColumn2.Name = "Date";
            gridViewTextBoxColumn2.Width = 732;
            gridViewCommandColumn1.HeaderText = "";
            gridViewCommandColumn1.Image = ((System.Drawing.Image)(resources.GetObject("gridViewCommandColumn1.Image")));
            gridViewCommandColumn1.MaxWidth = 36;
            gridViewCommandColumn1.MinWidth = 36;
            gridViewCommandColumn1.Name = "btnEdit";
            gridViewCommandColumn1.Width = 36;
            gridViewCommandColumn2.HeaderText = "";
            gridViewCommandColumn2.Image = ((System.Drawing.Image)(resources.GetObject("gridViewCommandColumn2.Image")));
            gridViewCommandColumn2.MaxWidth = 36;
            gridViewCommandColumn2.MinWidth = 36;
            gridViewCommandColumn2.Name = "btnDelete";
            gridViewCommandColumn2.Width = 36;
            this.gvSilos.MasterTemplate.Columns.AddRange(new Telerik.WinControls.UI.GridViewDataColumn[] {
            gridViewTextBoxColumn1,
            gridViewTextBoxColumn2,
            gridViewCommandColumn1,
            gridViewCommandColumn2});
            this.gvSilos.MasterTemplate.ViewDefinition = tableViewDefinition1;
            this.gvSilos.Name = "gvSilos";
            this.gvSilos.ReadOnly = true;
            this.gvSilos.ShowGroupPanel = false;
            this.gvSilos.Size = new System.Drawing.Size(822, 379);
            this.gvSilos.TabIndex = 85;
            this.gvSilos.Text = "radGridView1";
            this.gvSilos.CommandCellClick += new Telerik.WinControls.UI.CommandCellClickEventHandler(this.gvSilos_CommandCellClick);
            // 
            // btnCrearVaciamiento
            // 
            this.btnCrearVaciamiento.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCrearVaciamiento.Location = new System.Drawing.Point(648, 3);
            this.btnCrearVaciamiento.Name = "btnCrearVaciamiento";
            this.btnCrearVaciamiento.Size = new System.Drawing.Size(177, 27);
            this.btnCrearVaciamiento.TabIndex = 2;
            this.btnCrearVaciamiento.Text = "Registrar Vaciamiento";
            this.btnCrearVaciamiento.Click += new System.EventHandler(this.btnCrearVaciamiento_Click);
            // 
            // FrmEnterSilosEmptying
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(832, 492);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FrmEnterSilosEmptying";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.Text = "FrmBatchSelection";
            this.Load += new System.EventHandler(this.FrmEnterSilosEmptying_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lbCurrentStandard)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnShowStandardSelection)).EndInit();
            this.tableLayoutPanel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gvSilos.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvSilos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCrearVaciamiento)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private UserControls.UcLoadDailyMeasures ucLoadDailyMeasures;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private Telerik.WinControls.UI.RadButton btnShowStandardSelection;
        private Telerik.WinControls.UI.RadLabel lbCurrentStandard;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private Telerik.WinControls.UI.RadButton btnCrearVaciamiento;
        private Telerik.WinControls.UI.RadGridView gvSilos;


    }
}
