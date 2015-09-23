namespace Avicola.Production.Win.Forms.Vaccines
{
    partial class FrmCreateEditBatchVaccine
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
            this.radLabel2 = new Telerik.WinControls.UI.RadLabel();
            this.dtpStartDate = new Telerik.WinControls.UI.RadDateTimePicker();
            this.metroLabel1 = new Telerik.WinControls.UI.RadLabel();
            this.BtnGuardar = new Telerik.WinControls.UI.RadButton();
            this.BtnCancelar = new Telerik.WinControls.UI.RadButton();
            this.pbvBatch = new System.Windows.Forms.ErrorProvider(this.components);
            this.radLabel1 = new Telerik.WinControls.UI.RadLabel();
            this.radLabel3 = new Telerik.WinControls.UI.RadLabel();
            this.dtpEndDate = new Telerik.WinControls.UI.RadDateTimePicker();
            this.dtpRecommendedDate = new Telerik.WinControls.UI.RadDateTimePicker();
            this.ddlVaccines = new Telerik.WinControls.UI.RadDropDownList();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpStartDate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.metroLabel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnGuardar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnCancelar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbvBatch)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpEndDate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpRecommendedDate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ddlVaccines)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // radLabel2
            // 
            this.radLabel2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radLabel2.Location = new System.Drawing.Point(11, 11);
            this.radLabel2.Margin = new System.Windows.Forms.Padding(2);
            this.radLabel2.Name = "radLabel2";
            this.radLabel2.Size = new System.Drawing.Size(76, 24);
            this.radLabel2.TabIndex = 88;
            this.radLabel2.Text = "Comienzo";
            this.radLabel2.ThemeName = "TelerikMetroBlue";
            // 
            // dtpStartDate
            // 
            this.dtpStartDate.CustomFormat = "";
            this.dtpStartDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpStartDate.Location = new System.Drawing.Point(11, 40);
            this.dtpStartDate.Margin = new System.Windows.Forms.Padding(2);
            this.dtpStartDate.Name = "dtpStartDate";
            this.dtpStartDate.Size = new System.Drawing.Size(145, 20);
            this.dtpStartDate.TabIndex = 87;
            this.dtpStartDate.TabStop = false;
            this.dtpStartDate.Text = "14/09/2015";
            this.dtpStartDate.Value = new System.DateTime(2015, 9, 14, 10, 20, 19, 820);
            // 
            // metroLabel1
            // 
            this.metroLabel1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.metroLabel1.Location = new System.Drawing.Point(11, 64);
            this.metroLabel1.Margin = new System.Windows.Forms.Padding(2);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(28, 24);
            this.metroLabel1.TabIndex = 84;
            this.metroLabel1.Text = "Fin";
            this.metroLabel1.ThemeName = "TelerikMetroBlue";
            // 
            // BtnGuardar
            // 
            this.BtnGuardar.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.BtnGuardar.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnGuardar.Location = new System.Drawing.Point(110, 268);
            this.BtnGuardar.Margin = new System.Windows.Forms.Padding(2);
            this.BtnGuardar.Name = "BtnGuardar";
            this.BtnGuardar.Size = new System.Drawing.Size(75, 24);
            this.BtnGuardar.TabIndex = 82;
            this.BtnGuardar.Text = "Guardar";
            this.BtnGuardar.ThemeName = "TelerikMetroBlue";
            this.BtnGuardar.Click += new System.EventHandler(this.BtnGuardar_Click);
            // 
            // BtnCancelar
            // 
            this.BtnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BtnCancelar.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCancelar.Location = new System.Drawing.Point(195, 268);
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
            // radLabel1
            // 
            this.radLabel1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radLabel1.Location = new System.Drawing.Point(13, 118);
            this.radLabel1.Margin = new System.Windows.Forms.Padding(2);
            this.radLabel1.Name = "radLabel1";
            this.radLabel1.Size = new System.Drawing.Size(117, 24);
            this.radLabel1.TabIndex = 86;
            this.radLabel1.Text = "Recomendación";
            this.radLabel1.ThemeName = "TelerikMetroBlue";
            // 
            // radLabel3
            // 
            this.radLabel3.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radLabel3.Location = new System.Drawing.Point(13, 172);
            this.radLabel3.Margin = new System.Windows.Forms.Padding(2);
            this.radLabel3.Name = "radLabel3";
            this.radLabel3.Size = new System.Drawing.Size(92, 24);
            this.radLabel3.TabIndex = 87;
            this.radLabel3.Text = "Observación";
            this.radLabel3.ThemeName = "TelerikMetroBlue";
            // 
            // dtpEndDate
            // 
            this.dtpEndDate.CustomFormat = "";
            this.dtpEndDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpEndDate.Location = new System.Drawing.Point(11, 92);
            this.dtpEndDate.Margin = new System.Windows.Forms.Padding(2);
            this.dtpEndDate.Name = "dtpEndDate";
            this.dtpEndDate.Size = new System.Drawing.Size(145, 20);
            this.dtpEndDate.TabIndex = 88;
            this.dtpEndDate.TabStop = false;
            this.dtpEndDate.Text = "14/09/2015";
            this.dtpEndDate.Value = new System.DateTime(2015, 9, 14, 10, 20, 19, 820);
            // 
            // dtpRecommendedDate
            // 
            this.dtpRecommendedDate.CustomFormat = "";
            this.dtpRecommendedDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpRecommendedDate.Location = new System.Drawing.Point(11, 148);
            this.dtpRecommendedDate.Margin = new System.Windows.Forms.Padding(2);
            this.dtpRecommendedDate.Name = "dtpRecommendedDate";
            this.dtpRecommendedDate.Size = new System.Drawing.Size(145, 20);
            this.dtpRecommendedDate.TabIndex = 89;
            this.dtpRecommendedDate.TabStop = false;
            this.dtpRecommendedDate.Text = "14/09/2015";
            this.dtpRecommendedDate.Value = new System.DateTime(2015, 9, 14, 10, 20, 19, 820);
            // 
            // ddlVaccines
            // 
            this.ddlVaccines.Location = new System.Drawing.Point(11, 200);
            this.ddlVaccines.Margin = new System.Windows.Forms.Padding(2);
            this.ddlVaccines.Name = "ddlVaccines";
            this.ddlVaccines.Size = new System.Drawing.Size(145, 20);
            this.ddlVaccines.TabIndex = 91;
            this.ddlVaccines.Text = "Seleccione vacuna";
            // 
            // FrmCreateEditBatchVaccine
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(281, 303);
            this.ControlBox = false;
            this.Controls.Add(this.ddlVaccines);
            this.Controls.Add(this.dtpRecommendedDate);
            this.Controls.Add(this.dtpEndDate);
            this.Controls.Add(this.radLabel3);
            this.Controls.Add(this.radLabel2);
            this.Controls.Add(this.radLabel1);
            this.Controls.Add(this.dtpStartDate);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.BtnGuardar);
            this.Controls.Add(this.BtnCancelar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "FrmCreateEditBatchVaccine";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Crear Vacunación";
            this.Load += new System.EventHandler(this.FrmCreateEditVaccine_Load);
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpStartDate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.metroLabel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnGuardar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnCancelar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbvBatch)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpEndDate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpRecommendedDate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ddlVaccines)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Telerik.WinControls.UI.RadLabel metroLabel1;
        private Telerik.WinControls.UI.RadButton BtnGuardar;
        private Telerik.WinControls.UI.RadButton BtnCancelar;
        private Telerik.WinControls.UI.RadDateTimePicker dtpStartDate;
        private Telerik.WinControls.UI.RadLabel radLabel2;
        private System.Windows.Forms.ErrorProvider pbvBatch;
        private Telerik.WinControls.UI.RadLabel radLabel1;
        private Telerik.WinControls.UI.RadLabel radLabel3;
        private Telerik.WinControls.UI.RadDateTimePicker dtpRecommendedDate;
        private Telerik.WinControls.UI.RadDateTimePicker dtpEndDate;
        private Telerik.WinControls.UI.RadDropDownList ddlVaccines;
    }
}
