﻿namespace Avicola.Production.Win.Forms.Medicines
{
    partial class FrmCreateEditBatchMedicine
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
            this.lblRecommendedDate = new Telerik.WinControls.UI.RadLabel();
            this.radLabel3 = new Telerik.WinControls.UI.RadLabel();
            this.dtpEndDate = new Telerik.WinControls.UI.RadDateTimePicker();
            this.txtObservation = new Telerik.WinControls.UI.RadTextBox();
            this.ddlMedicines = new Telerik.WinControls.UI.RadDropDownList();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpStartDate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.metroLabel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnGuardar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnCancelar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbvBatch)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblRecommendedDate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpEndDate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtObservation)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ddlMedicines)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // radLabel2
            // 
            this.radLabel2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radLabel2.Location = new System.Drawing.Point(11, 12);
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
            this.dtpStartDate.Location = new System.Drawing.Point(11, 38);
            this.dtpStartDate.Margin = new System.Windows.Forms.Padding(2);
            this.dtpStartDate.Name = "dtpStartDate";
            this.dtpStartDate.Size = new System.Drawing.Size(157, 24);
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
            this.BtnGuardar.Location = new System.Drawing.Point(110, 311);
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
            this.BtnCancelar.Location = new System.Drawing.Point(195, 311);
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
            // lblRecommendedDate
            // 
            this.lblRecommendedDate.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRecommendedDate.Location = new System.Drawing.Point(11, 168);
            this.lblRecommendedDate.Margin = new System.Windows.Forms.Padding(2);
            this.lblRecommendedDate.Name = "lblRecommendedDate";
            this.lblRecommendedDate.Size = new System.Drawing.Size(92, 24);
            this.lblRecommendedDate.TabIndex = 86;
            this.lblRecommendedDate.Text = "Observación";
            this.lblRecommendedDate.ThemeName = "TelerikMetroBlue";
            // 
            // radLabel3
            // 
            this.radLabel3.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radLabel3.Location = new System.Drawing.Point(11, 116);
            this.radLabel3.Margin = new System.Windows.Forms.Padding(2);
            this.radLabel3.Name = "radLabel3";
            this.radLabel3.Size = new System.Drawing.Size(102, 24);
            this.radLabel3.TabIndex = 87;
            this.radLabel3.Text = "Medicamento";
            this.radLabel3.ThemeName = "TelerikMetroBlue";
            // 
            // dtpEndDate
            // 
            this.dtpEndDate.CustomFormat = "";
            this.dtpEndDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpEndDate.Location = new System.Drawing.Point(11, 90);
            this.dtpEndDate.Margin = new System.Windows.Forms.Padding(2);
            this.dtpEndDate.Name = "dtpEndDate";
            this.dtpEndDate.Size = new System.Drawing.Size(157, 24);
            this.dtpEndDate.TabIndex = 88;
            this.dtpEndDate.TabStop = false;
            this.dtpEndDate.Text = "14/09/2015";
            this.dtpEndDate.Value = new System.DateTime(2015, 9, 14, 10, 20, 19, 820);
            // 
            // txtObservation
            // 
            this.txtObservation.AutoSize = false;
            this.txtObservation.Location = new System.Drawing.Point(11, 194);
            this.txtObservation.MaxLength = 500;
            this.txtObservation.Multiline = true;
            this.txtObservation.Name = "txtObservation";
            this.txtObservation.Size = new System.Drawing.Size(258, 97);
            this.txtObservation.TabIndex = 92;
            // 
            // ddlMedicines
            // 
            this.ddlMedicines.Location = new System.Drawing.Point(11, 142);
            this.ddlMedicines.Margin = new System.Windows.Forms.Padding(2);
            this.ddlMedicines.Name = "ddlMedicines";
            this.ddlMedicines.Size = new System.Drawing.Size(260, 24);
            this.ddlMedicines.TabIndex = 91;
            this.ddlMedicines.Text = "Seleccione medicamento";
            // 
            // FrmCreateEditBatchMedicine
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(276, 346);
            this.ControlBox = false;
            this.Controls.Add(this.ddlMedicines);
            this.Controls.Add(this.txtObservation);
            this.Controls.Add(this.dtpEndDate);
            this.Controls.Add(this.radLabel3);
            this.Controls.Add(this.radLabel2);
            this.Controls.Add(this.lblRecommendedDate);
            this.Controls.Add(this.dtpStartDate);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.BtnGuardar);
            this.Controls.Add(this.BtnCancelar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "FrmCreateEditBatchMedicine";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Crear Medicamento";
            this.Load += new System.EventHandler(this.FrmCreateEditBatchMedicine_Load);
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpStartDate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.metroLabel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnGuardar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnCancelar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbvBatch)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblRecommendedDate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpEndDate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtObservation)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ddlMedicines)).EndInit();
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
        private Telerik.WinControls.UI.RadLabel lblRecommendedDate;
        private Telerik.WinControls.UI.RadLabel radLabel3;
        private Telerik.WinControls.UI.RadDateTimePicker dtpEndDate;
        private Telerik.WinControls.UI.RadTextBox txtObservation;
        private Telerik.WinControls.UI.RadDropDownList ddlMedicines;
    }
}
