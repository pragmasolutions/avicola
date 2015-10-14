namespace Avicola.Production.Win.Forms.Batchs
{
    partial class FrmMoveNextStage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMoveNextStage));
            this.ucAssignBarns = new Avicola.Production.Win.UserControls.UcAssignBarns();
            this.radLabel2 = new Telerik.WinControls.UI.RadLabel();
            this.dtpDate = new Telerik.WinControls.UI.RadDateTimePicker();
            this.txtCurrentStage = new Telerik.WinControls.UI.RadTextBox();
            this.metroLabel1 = new Telerik.WinControls.UI.RadLabel();
            this.txtNextStage = new Telerik.WinControls.UI.RadTextBox();
            this.radLabel1 = new Telerik.WinControls.UI.RadLabel();
            this.txtBatchBirdsAmount = new Telerik.WinControls.UI.RadTextBox();
            this.radLabel3 = new Telerik.WinControls.UI.RadLabel();
            this.BtnGuardar = new Telerik.WinControls.UI.RadButton();
            this.BtnCancelar = new Telerik.WinControls.UI.RadButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpDate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCurrentStage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.metroLabel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNextStage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBatchBirdsAmount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnGuardar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnCancelar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // ucAssignBarns
            // 
            this.ucAssignBarns.FormFactory = null;
            this.ucAssignBarns.Location = new System.Drawing.Point(12, 159);
            this.ucAssignBarns.MessageBoxDisplayService = null;
            this.ucAssignBarns.Name = "ucAssignBarns";
            this.ucAssignBarns.Size = new System.Drawing.Size(905, 258);
            this.ucAssignBarns.StageId = new System.Guid("00000000-0000-0000-0000-000000000000");
            this.ucAssignBarns.TabIndex = 0;
            // 
            // radLabel2
            // 
            this.radLabel2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radLabel2.Location = new System.Drawing.Point(35, 75);
            this.radLabel2.Margin = new System.Windows.Forms.Padding(2);
            this.radLabel2.Name = "radLabel2";
            this.radLabel2.Size = new System.Drawing.Size(47, 24);
            this.radLabel2.TabIndex = 92;
            this.radLabel2.Text = "Fecha";
            this.radLabel2.ThemeName = "TelerikMetroBlue";
            // 
            // dtpDate
            // 
            this.dtpDate.CustomFormat = "";
            this.dtpDate.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDate.Location = new System.Drawing.Point(35, 104);
            this.dtpDate.Margin = new System.Windows.Forms.Padding(2);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(145, 28);
            this.dtpDate.TabIndex = 91;
            this.dtpDate.TabStop = false;
            this.dtpDate.Text = "14/09/2015";
            this.dtpDate.Value = new System.DateTime(2015, 9, 14, 10, 20, 19, 820);
            // 
            // txtCurrentStage
            // 
            this.txtCurrentStage.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtCurrentStage.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCurrentStage.Location = new System.Drawing.Point(35, 36);
            this.txtCurrentStage.Margin = new System.Windows.Forms.Padding(2);
            this.txtCurrentStage.MaxLength = 50;
            this.txtCurrentStage.Name = "txtCurrentStage";
            this.txtCurrentStage.Size = new System.Drawing.Size(145, 28);
            this.txtCurrentStage.TabIndex = 89;
            this.txtCurrentStage.TabStop = false;
            this.txtCurrentStage.ThemeName = "TelerikMetroBlue";
            // 
            // metroLabel1
            // 
            this.metroLabel1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.metroLabel1.Location = new System.Drawing.Point(35, 11);
            this.metroLabel1.Margin = new System.Windows.Forms.Padding(2);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(100, 24);
            this.metroLabel1.TabIndex = 90;
            this.metroLabel1.Text = "Estado Actual";
            this.metroLabel1.ThemeName = "TelerikMetroBlue";
            // 
            // txtNextStage
            // 
            this.txtNextStage.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNextStage.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNextStage.Location = new System.Drawing.Point(231, 36);
            this.txtNextStage.Margin = new System.Windows.Forms.Padding(2);
            this.txtNextStage.MaxLength = 50;
            this.txtNextStage.Name = "txtNextStage";
            this.txtNextStage.Size = new System.Drawing.Size(145, 28);
            this.txtNextStage.TabIndex = 91;
            this.txtNextStage.TabStop = false;
            this.txtNextStage.ThemeName = "TelerikMetroBlue";
            // 
            // radLabel1
            // 
            this.radLabel1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radLabel1.Location = new System.Drawing.Point(231, 11);
            this.radLabel1.Margin = new System.Windows.Forms.Padding(2);
            this.radLabel1.Name = "radLabel1";
            this.radLabel1.Size = new System.Drawing.Size(121, 24);
            this.radLabel1.TabIndex = 92;
            this.radLabel1.Text = "Siguiente Estado";
            this.radLabel1.ThemeName = "TelerikMetroBlue";
            // 
            // txtBatchBirdsAmount
            // 
            this.txtBatchBirdsAmount.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtBatchBirdsAmount.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBatchBirdsAmount.Location = new System.Drawing.Point(231, 104);
            this.txtBatchBirdsAmount.Margin = new System.Windows.Forms.Padding(2);
            this.txtBatchBirdsAmount.MaxLength = 50;
            this.txtBatchBirdsAmount.Name = "txtBatchBirdsAmount";
            this.txtBatchBirdsAmount.Size = new System.Drawing.Size(145, 28);
            this.txtBatchBirdsAmount.TabIndex = 91;
            this.txtBatchBirdsAmount.TabStop = false;
            this.txtBatchBirdsAmount.ThemeName = "TelerikMetroBlue";
            // 
            // radLabel3
            // 
            this.radLabel3.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radLabel3.Location = new System.Drawing.Point(231, 75);
            this.radLabel3.Margin = new System.Windows.Forms.Padding(2);
            this.radLabel3.Name = "radLabel3";
            this.radLabel3.Size = new System.Drawing.Size(126, 24);
            this.radLabel3.TabIndex = 92;
            this.radLabel3.Text = "Cantidad de Aves";
            this.radLabel3.ThemeName = "TelerikMetroBlue";
            // 
            // BtnGuardar
            // 
            this.BtnGuardar.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.BtnGuardar.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnGuardar.Location = new System.Drawing.Point(718, 422);
            this.BtnGuardar.Margin = new System.Windows.Forms.Padding(2);
            this.BtnGuardar.Name = "BtnGuardar";
            this.BtnGuardar.Size = new System.Drawing.Size(96, 24);
            this.BtnGuardar.TabIndex = 93;
            this.BtnGuardar.Text = "Guardar";
            this.BtnGuardar.ThemeName = "TelerikMetroBlue";
            // 
            // BtnCancelar
            // 
            this.BtnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BtnCancelar.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCancelar.Location = new System.Drawing.Point(824, 422);
            this.BtnCancelar.Margin = new System.Windows.Forms.Padding(2);
            this.BtnCancelar.Name = "BtnCancelar";
            this.BtnCancelar.Size = new System.Drawing.Size(96, 24);
            this.BtnCancelar.TabIndex = 94;
            this.BtnCancelar.Text = "Cancelar";
            this.BtnCancelar.ThemeName = "TelerikMetroBlue";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(185, 36);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(41, 28);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 95;
            this.pictureBox1.TabStop = false;
            // 
            // FrmMoveNextStage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(929, 462);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.BtnGuardar);
            this.Controls.Add(this.BtnCancelar);
            this.Controls.Add(this.txtBatchBirdsAmount);
            this.Controls.Add(this.txtNextStage);
            this.Controls.Add(this.radLabel3);
            this.Controls.Add(this.radLabel2);
            this.Controls.Add(this.radLabel1);
            this.Controls.Add(this.dtpDate);
            this.Controls.Add(this.txtCurrentStage);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.ucAssignBarns);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FrmMoveNextStage";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pasar de Estado a Lote";
            this.Load += new System.EventHandler(this.FrmMoveNextStage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpDate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCurrentStage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.metroLabel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNextStage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBatchBirdsAmount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnGuardar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnCancelar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private UserControls.UcAssignBarns ucAssignBarns;
        private Telerik.WinControls.UI.RadLabel radLabel2;
        private Telerik.WinControls.UI.RadDateTimePicker dtpDate;
        private Telerik.WinControls.UI.RadTextBox txtCurrentStage;
        private Telerik.WinControls.UI.RadLabel metroLabel1;
        private Telerik.WinControls.UI.RadTextBox txtNextStage;
        private Telerik.WinControls.UI.RadLabel radLabel1;
        private Telerik.WinControls.UI.RadTextBox txtBatchBirdsAmount;
        private Telerik.WinControls.UI.RadLabel radLabel3;
        private Telerik.WinControls.UI.RadButton BtnGuardar;
        private Telerik.WinControls.UI.RadButton BtnCancelar;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}
