namespace Avicola.Production.Win.Forms.Medicines
{
    partial class FrmBatchMedicinesList
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
            this.components = new System.ComponentModel.Container();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn1 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn2 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn3 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn4 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn5 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewCommandColumn gridViewCommandColumn1 = new Telerik.WinControls.UI.GridViewCommandColumn();
            Telerik.WinControls.UI.GridViewCommandColumn gridViewCommandColumn2 = new Telerik.WinControls.UI.GridViewCommandColumn();
            Telerik.WinControls.UI.TableViewDefinition tableViewDefinition1 = new Telerik.WinControls.UI.TableViewDefinition();
            this.BtnAgregar = new Telerik.WinControls.UI.RadButton();
            this.BtnCancelar = new Telerik.WinControls.UI.RadButton();
            this.pbvBatch = new System.Windows.Forms.ErrorProvider(this.components);
            this.gvBatchMedicines = new Telerik.WinControls.UI.RadGridView();
            ((System.ComponentModel.ISupportInitialize)(this.BtnAgregar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnCancelar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbvBatch)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvBatchMedicines)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvBatchMedicines.MasterTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnAgregar
            // 
            this.BtnAgregar.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAgregar.Location = new System.Drawing.Point(461, 271);
            this.BtnAgregar.Margin = new System.Windows.Forms.Padding(2);
            this.BtnAgregar.Name = "BtnAgregar";
            this.BtnAgregar.Size = new System.Drawing.Size(75, 24);
            this.BtnAgregar.TabIndex = 82;
            this.BtnAgregar.Text = "Agregar";
            this.BtnAgregar.ThemeName = "TelerikMetroBlue";
            this.BtnAgregar.Click += new System.EventHandler(this.BtnAgregar_Click);
            // 
            // BtnCancelar
            // 
            this.BtnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BtnCancelar.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCancelar.Location = new System.Drawing.Point(546, 271);
            this.BtnCancelar.Margin = new System.Windows.Forms.Padding(2);
            this.BtnCancelar.Name = "BtnCancelar";
            this.BtnCancelar.Size = new System.Drawing.Size(75, 24);
            this.BtnCancelar.TabIndex = 83;
            this.BtnCancelar.Text = "Cancelar";
            this.BtnCancelar.ThemeName = "TelerikMetroBlue";
            this.BtnCancelar.Click += new System.EventHandler(this.BtnCancelar_Click);
            // 
            // pbvBatch
            // 
            this.pbvBatch.ContainerControl = this;
            // 
            // gvBatchMedicines
            // 
            this.gvBatchMedicines.Location = new System.Drawing.Point(2, 12);
            // 
            // 
            // 
            this.gvBatchMedicines.MasterTemplate.AllowAddNewRow = false;
            this.gvBatchMedicines.MasterTemplate.AutoSizeColumnsMode = Telerik.WinControls.UI.GridViewAutoSizeColumnsMode.Fill;
            gridViewTextBoxColumn1.FieldName = "Id";
            gridViewTextBoxColumn1.HeaderText = "Id";
            gridViewTextBoxColumn1.IsVisible = false;
            gridViewTextBoxColumn1.Name = "Id";
            gridViewTextBoxColumn2.FieldName = "MedicineName";
            gridViewTextBoxColumn2.HeaderText = "Medicamento";
            gridViewTextBoxColumn2.Name = "MedicineName";
            gridViewTextBoxColumn2.Width = 213;
            gridViewTextBoxColumn3.FieldName = "StartDate";
            gridViewTextBoxColumn3.FormatString = "{0: dd/M/yyyy}";
            gridViewTextBoxColumn3.HeaderText = "Comienzo";
            gridViewTextBoxColumn3.Name = "StartDate";
            gridViewTextBoxColumn3.Width = 81;
            gridViewTextBoxColumn4.FieldName = "EndDate";
            gridViewTextBoxColumn4.FormatString = "{0: dd/M/yyyy}";
            gridViewTextBoxColumn4.HeaderText = "Fin";
            gridViewTextBoxColumn4.Name = "EndDate";
            gridViewTextBoxColumn4.Width = 81;
            gridViewTextBoxColumn5.FieldName = "Observation";
            gridViewTextBoxColumn5.HeaderText = "Observación";
            gridViewTextBoxColumn5.Name = "Observation";
            gridViewTextBoxColumn5.Width = 149;
            gridViewCommandColumn1.HeaderText = "";
            gridViewCommandColumn1.Image = global::Avicola.Production.Win.Properties.Resources.Data_Edit;
            gridViewCommandColumn1.ImageLayout = System.Windows.Forms.ImageLayout.Center;
            gridViewCommandColumn1.MaxWidth = 40;
            gridViewCommandColumn1.MinWidth = 40;
            gridViewCommandColumn1.Name = "btnEdit";
            gridViewCommandColumn1.Width = 40;
            gridViewCommandColumn2.HeaderText = "";
            gridViewCommandColumn2.Image = global::Avicola.Production.Win.Properties.Resources.Garbage_Closed;
            gridViewCommandColumn2.ImageLayout = System.Windows.Forms.ImageLayout.Center;
            gridViewCommandColumn2.MaxWidth = 40;
            gridViewCommandColumn2.MinWidth = 40;
            gridViewCommandColumn2.Name = "btnDelete";
            gridViewCommandColumn2.Width = 40;
            this.gvBatchMedicines.MasterTemplate.Columns.AddRange(new Telerik.WinControls.UI.GridViewDataColumn[] {
            gridViewTextBoxColumn1,
            gridViewTextBoxColumn2,
            gridViewTextBoxColumn3,
            gridViewTextBoxColumn4,
            gridViewTextBoxColumn5,
            gridViewCommandColumn1,
            gridViewCommandColumn2});
            this.gvBatchMedicines.MasterTemplate.ViewDefinition = tableViewDefinition1;
            this.gvBatchMedicines.Name = "gvBatchMedicines";
            this.gvBatchMedicines.ReadOnly = true;
            this.gvBatchMedicines.ShowGroupPanel = false;
            this.gvBatchMedicines.Size = new System.Drawing.Size(619, 244);
            this.gvBatchMedicines.TabIndex = 84;
            this.gvBatchMedicines.Text = "radGridView1";
            this.gvBatchMedicines.CommandCellClick += new Telerik.WinControls.UI.CommandCellClickEventHandler(this.gvBatchMedicines_CommandCellClick);
            // 
            // FrmBatchMedicinesList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(623, 306);
            this.Controls.Add(this.gvBatchMedicines);
            this.Controls.Add(this.BtnAgregar);
            this.Controls.Add(this.BtnCancelar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FrmBatchMedicinesList";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Medicamentos";
            this.Load += new System.EventHandler(this.FrmBatchMedicineList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.BtnAgregar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnCancelar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbvBatch)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvBatchMedicines.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvBatchMedicines)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Telerik.WinControls.UI.RadButton BtnAgregar;
        private Telerik.WinControls.UI.RadButton BtnCancelar;
        private System.Windows.Forms.ErrorProvider pbvBatch;
        private Telerik.WinControls.UI.RadGridView gvBatchMedicines;
    }
}
