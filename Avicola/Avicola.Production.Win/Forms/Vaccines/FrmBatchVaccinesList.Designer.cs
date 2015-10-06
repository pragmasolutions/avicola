namespace Avicola.Production.Win.Forms.Vaccines
{
    partial class FrmBatchVaccinesList
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
            Telerik.WinControls.UI.GridViewCommandColumn gridViewCommandColumn1 = new Telerik.WinControls.UI.GridViewCommandColumn();
            Telerik.WinControls.UI.GridViewCommandColumn gridViewCommandColumn2 = new Telerik.WinControls.UI.GridViewCommandColumn();
            Telerik.WinControls.UI.TableViewDefinition tableViewDefinition1 = new Telerik.WinControls.UI.TableViewDefinition();
            this.BtnAgregar = new Telerik.WinControls.UI.RadButton();
            this.BtnCancelar = new Telerik.WinControls.UI.RadButton();
            this.pbvBatch = new System.Windows.Forms.ErrorProvider(this.components);
            this.gvBatchVaccines = new Telerik.WinControls.UI.RadGridView();
            ((System.ComponentModel.ISupportInitialize)(this.BtnAgregar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnCancelar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbvBatch)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvBatchVaccines)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvBatchVaccines.MasterTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnAgregar
            // 
            this.BtnAgregar.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAgregar.Location = new System.Drawing.Point(321, 271);
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
            this.BtnCancelar.Location = new System.Drawing.Point(406, 271);
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
            // gvBatchVaccines
            // 
            this.gvBatchVaccines.Location = new System.Drawing.Point(2, 12);
            // 
            // 
            // 
            this.gvBatchVaccines.MasterTemplate.AllowAddNewRow = false;
            gridViewTextBoxColumn1.FieldName = "Id";
            gridViewTextBoxColumn1.HeaderText = "Id";
            gridViewTextBoxColumn1.IsVisible = false;
            gridViewTextBoxColumn1.Name = "Id";
            gridViewTextBoxColumn2.FieldName = "VaccineName";
            gridViewTextBoxColumn2.HeaderText = "Vacuna";
            gridViewTextBoxColumn2.Name = "VaccineName";
            gridViewTextBoxColumn2.Width = 180;
            gridViewTextBoxColumn3.FieldName = "StartDate";
            gridViewTextBoxColumn3.FormatString = "{0: dd/M/yyyy}";
            gridViewTextBoxColumn3.HeaderText = "Comienzo";
            gridViewTextBoxColumn3.Name = "StartDate";
            gridViewTextBoxColumn3.Width = 100;
            gridViewTextBoxColumn4.FieldName = "EndDate";
            gridViewTextBoxColumn4.FormatString = "{0: dd/M/yyyy}";
            gridViewTextBoxColumn4.HeaderText = "Fin";
            gridViewTextBoxColumn4.Name = "EndDate";
            gridViewTextBoxColumn4.Width = 100;
            gridViewCommandColumn1.HeaderText = "";
            gridViewCommandColumn1.Image = global::Avicola.Production.Win.Properties.Resources.Data_Edit;
            gridViewCommandColumn1.ImageLayout = System.Windows.Forms.ImageLayout.Center;
            gridViewCommandColumn1.Name = "btnEdit";
            gridViewCommandColumn1.Width = 40;
            gridViewCommandColumn2.HeaderText = "";
            gridViewCommandColumn2.Image = global::Avicola.Production.Win.Properties.Resources.Garbage_Closed;
            gridViewCommandColumn2.ImageLayout = System.Windows.Forms.ImageLayout.Center;
            gridViewCommandColumn2.Name = "btnDelete";
            gridViewCommandColumn2.Width = 40;
            this.gvBatchVaccines.MasterTemplate.Columns.AddRange(new Telerik.WinControls.UI.GridViewDataColumn[] {
            gridViewTextBoxColumn1,
            gridViewTextBoxColumn2,
            gridViewTextBoxColumn3,
            gridViewTextBoxColumn4,
            gridViewCommandColumn1,
            gridViewCommandColumn2});
            this.gvBatchVaccines.MasterTemplate.ViewDefinition = tableViewDefinition1;
            this.gvBatchVaccines.Name = "gvBatchVaccines";
            this.gvBatchVaccines.ReadOnly = true;
            this.gvBatchVaccines.ShowGroupPanel = false;
            this.gvBatchVaccines.Size = new System.Drawing.Size(479, 244);
            this.gvBatchVaccines.TabIndex = 84;
            this.gvBatchVaccines.Text = "radGridView1";
            this.gvBatchVaccines.CommandCellClick += new Telerik.WinControls.UI.CommandCellClickEventHandler(this.gvBatchVaccines_CommandCellClick);
            // 
            // FrmBatchVaccinesList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 306);
            this.Controls.Add(this.gvBatchVaccines);
            this.Controls.Add(this.BtnAgregar);
            this.Controls.Add(this.BtnCancelar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FrmBatchVaccinesList";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Vacunaciones";
            this.Load += new System.EventHandler(this.FrmBatchVaccinesList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.BtnAgregar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnCancelar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbvBatch)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvBatchVaccines.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvBatchVaccines)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Telerik.WinControls.UI.RadButton BtnAgregar;
        private Telerik.WinControls.UI.RadButton BtnCancelar;
        private System.Windows.Forms.ErrorProvider pbvBatch;
        private Telerik.WinControls.UI.RadGridView gvBatchVaccines;
    }
}
