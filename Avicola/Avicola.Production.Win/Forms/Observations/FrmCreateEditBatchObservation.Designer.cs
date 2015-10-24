namespace Avicola.Production.Win.Forms.Observations
{
    partial class FrmCreateEditBatchObservation
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
            this.dtpObservationDate = new Telerik.WinControls.UI.RadDateTimePicker();
            this.txtWeek = new Telerik.WinControls.UI.RadTextBox();
            this.metroLabel1 = new Telerik.WinControls.UI.RadLabel();
            this.BtnGuardar = new Telerik.WinControls.UI.RadButton();
            this.BtnCancelar = new Telerik.WinControls.UI.RadButton();
            this.pbvBatch = new System.Windows.Forms.ErrorProvider(this.components);
            this.txtDay = new Telerik.WinControls.UI.RadTextBox();
            this.radLabel1 = new Telerik.WinControls.UI.RadLabel();
            this.radLabel3 = new Telerik.WinControls.UI.RadLabel();
            this.txtObservation = new Telerik.WinControls.UI.RadTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpObservationDate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtWeek)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.metroLabel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnGuardar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnCancelar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbvBatch)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtObservation)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // radLabel2
            // 
            this.radLabel2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radLabel2.Location = new System.Drawing.Point(13, 11);
            this.radLabel2.Margin = new System.Windows.Forms.Padding(2);
            this.radLabel2.Name = "radLabel2";
            this.radLabel2.Size = new System.Drawing.Size(47, 24);
            this.radLabel2.TabIndex = 88;
            this.radLabel2.Text = "Fecha";
            this.radLabel2.ThemeName = "TelerikMetroBlue";
            // 
            // dtpObservationDate
            // 
            this.dtpObservationDate.CustomFormat = "";
            this.dtpObservationDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpObservationDate.Location = new System.Drawing.Point(13, 36);
            this.dtpObservationDate.Margin = new System.Windows.Forms.Padding(2);
            this.dtpObservationDate.Name = "dtpObservationDate";
            this.dtpObservationDate.Size = new System.Drawing.Size(145, 24);
            this.dtpObservationDate.TabIndex = 87;
            this.dtpObservationDate.TabStop = false;
            this.dtpObservationDate.Text = "14/09/2015";
            this.dtpObservationDate.Value = new System.DateTime(2015, 9, 14, 10, 20, 19, 820);
            this.dtpObservationDate.ValueChanged += new System.EventHandler(this.dtpObservationDate_ValueChanged);
            // 
            // txtWeek
            // 
            this.txtWeek.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtWeek.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtWeek.Location = new System.Drawing.Point(13, 86);
            this.txtWeek.Margin = new System.Windows.Forms.Padding(2);
            this.txtWeek.MaxLength = 50;
            this.txtWeek.Name = "txtWeek";
            this.txtWeek.Size = new System.Drawing.Size(145, 28);
            this.txtWeek.TabIndex = 81;
            this.txtWeek.TabStop = false;
            this.txtWeek.ThemeName = "TelerikMetroBlue";
            // 
            // metroLabel1
            // 
            this.metroLabel1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.metroLabel1.Location = new System.Drawing.Point(13, 61);
            this.metroLabel1.Margin = new System.Windows.Forms.Padding(2);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(62, 24);
            this.metroLabel1.TabIndex = 84;
            this.metroLabel1.Text = "Semana";
            this.metroLabel1.ThemeName = "TelerikMetroBlue";
            // 
            // BtnGuardar
            // 
            this.BtnGuardar.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.BtnGuardar.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnGuardar.Location = new System.Drawing.Point(243, 297);
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
            this.BtnCancelar.Location = new System.Drawing.Point(328, 297);
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
            // txtDay
            // 
            this.txtDay.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtDay.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDay.Location = new System.Drawing.Point(13, 140);
            this.txtDay.Margin = new System.Windows.Forms.Padding(2);
            this.txtDay.MaxLength = 50;
            this.txtDay.Name = "txtDay";
            this.txtDay.Size = new System.Drawing.Size(145, 28);
            this.txtDay.TabIndex = 85;
            this.txtDay.TabStop = false;
            this.txtDay.ThemeName = "TelerikMetroBlue";
            // 
            // radLabel1
            // 
            this.radLabel1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radLabel1.Location = new System.Drawing.Point(13, 115);
            this.radLabel1.Margin = new System.Windows.Forms.Padding(2);
            this.radLabel1.Name = "radLabel1";
            this.radLabel1.Size = new System.Drawing.Size(30, 24);
            this.radLabel1.TabIndex = 86;
            this.radLabel1.Text = "Día";
            this.radLabel1.ThemeName = "TelerikMetroBlue";
            // 
            // radLabel3
            // 
            this.radLabel3.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radLabel3.Location = new System.Drawing.Point(13, 169);
            this.radLabel3.Margin = new System.Windows.Forms.Padding(2);
            this.radLabel3.Name = "radLabel3";
            this.radLabel3.Size = new System.Drawing.Size(92, 24);
            this.radLabel3.TabIndex = 87;
            this.radLabel3.Text = "Observación";
            this.radLabel3.ThemeName = "TelerikMetroBlue";
            // 
            // txtObservation
            // 
            this.txtObservation.AutoSize = false;
            this.txtObservation.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtObservation.Location = new System.Drawing.Point(13, 194);
            this.txtObservation.Margin = new System.Windows.Forms.Padding(2);
            this.txtObservation.MaxLength = 50;
            this.txtObservation.Multiline = true;
            this.txtObservation.Name = "txtObservation";
            this.txtObservation.Size = new System.Drawing.Size(390, 78);
            this.txtObservation.TabIndex = 86;
            this.txtObservation.TabStop = false;
            this.txtObservation.ThemeName = "TelerikMetroBlue";
            // 
            // FrmCreateEditBatchObservation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(418, 332);
            this.ControlBox = false;
            this.Controls.Add(this.txtObservation);
            this.Controls.Add(this.radLabel3);
            this.Controls.Add(this.txtDay);
            this.Controls.Add(this.radLabel2);
            this.Controls.Add(this.radLabel1);
            this.Controls.Add(this.dtpObservationDate);
            this.Controls.Add(this.txtWeek);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.BtnGuardar);
            this.Controls.Add(this.BtnCancelar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "FrmCreateEditBatchObservation";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Crear Observación";
            this.Load += new System.EventHandler(this.FrmCreateBatchObservation_Load);
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpObservationDate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtWeek)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.metroLabel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnGuardar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnCancelar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbvBatch)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtObservation)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Telerik.WinControls.UI.RadTextBox txtWeek;
        private Telerik.WinControls.UI.RadLabel metroLabel1;
        private Telerik.WinControls.UI.RadButton BtnGuardar;
        private Telerik.WinControls.UI.RadButton BtnCancelar;
        private Telerik.WinControls.UI.RadDateTimePicker dtpObservationDate;
        private Telerik.WinControls.UI.RadLabel radLabel2;
        private System.Windows.Forms.ErrorProvider pbvBatch;
        private Telerik.WinControls.UI.RadTextBox txtDay;
        private Telerik.WinControls.UI.RadLabel radLabel1;
        private Telerik.WinControls.UI.RadTextBox txtObservation;
        private Telerik.WinControls.UI.RadLabel radLabel3;
    }
}
