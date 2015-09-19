namespace Avicola.Production.Win.Forms.Batchs
{
    partial class FrmAssignBarn
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
            this.dtpArrivedToBarn = new Telerik.WinControls.UI.RadDateTimePicker();
            this.BtnGuardar = new Telerik.WinControls.UI.RadButton();
            this.BtnCancelar = new Telerik.WinControls.UI.RadButton();
            this.pbvBatch = new System.Windows.Forms.ErrorProvider(this.components);
            this.radLabel1 = new Telerik.WinControls.UI.RadLabel();
            this.ddlBarns = new Telerik.WinControls.UI.RadDropDownList();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpArrivedToBarn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnGuardar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnCancelar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbvBatch)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ddlBarns)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // radLabel2
            // 
            this.radLabel2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radLabel2.Location = new System.Drawing.Point(31, 132);
            this.radLabel2.Name = "radLabel2";
            this.radLabel2.Size = new System.Drawing.Size(239, 29);
            this.radLabel2.TabIndex = 88;
            this.radLabel2.Text = "Fecha  de Ingreso a galpón";
            this.radLabel2.ThemeName = "TelerikMetroBlue";
            // 
            // dtpArrivedToBarn
            // 
            this.dtpArrivedToBarn.CustomFormat = "";
            this.dtpArrivedToBarn.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpArrivedToBarn.Location = new System.Drawing.Point(31, 167);
            this.dtpArrivedToBarn.MinDate = new System.DateTime(2004, 1, 15, 0, 0, 0, 0);
            this.dtpArrivedToBarn.Name = "dtpArrivedToBarn";
            this.dtpArrivedToBarn.Size = new System.Drawing.Size(193, 24);
            this.dtpArrivedToBarn.TabIndex = 1;
            this.dtpArrivedToBarn.TabStop = false;
            this.dtpArrivedToBarn.Text = "14/09/2015";
            this.dtpArrivedToBarn.Value = new System.DateTime(2015, 9, 14, 10, 20, 19, 820);
            // 
            // BtnGuardar
            // 
            this.BtnGuardar.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.BtnGuardar.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnGuardar.Location = new System.Drawing.Point(31, 239);
            this.BtnGuardar.Name = "BtnGuardar";
            this.BtnGuardar.Size = new System.Drawing.Size(100, 30);
            this.BtnGuardar.TabIndex = 2;
            this.BtnGuardar.Text = "Continuar";
            this.BtnGuardar.ThemeName = "TelerikMetroBlue";
            this.BtnGuardar.Click += new System.EventHandler(this.BtnGuardar_Click);
            // 
            // BtnCancelar
            // 
            this.BtnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BtnCancelar.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCancelar.Location = new System.Drawing.Point(144, 239);
            this.BtnCancelar.Name = "BtnCancelar";
            this.BtnCancelar.Size = new System.Drawing.Size(100, 30);
            this.BtnCancelar.TabIndex = 3;
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
            this.radLabel1.Location = new System.Drawing.Point(31, 33);
            this.radLabel1.Name = "radLabel1";
            this.radLabel1.Size = new System.Drawing.Size(164, 29);
            this.radLabel1.TabIndex = 89;
            this.radLabel1.Text = "Galpón disponible";
            this.radLabel1.ThemeName = "TelerikMetroBlue";
            // 
            // ddlBarns
            // 
            this.ddlBarns.Location = new System.Drawing.Point(31, 68);
            this.ddlBarns.Name = "ddlBarns";
            this.ddlBarns.Size = new System.Drawing.Size(186, 24);
            this.ddlBarns.TabIndex = 90;
            this.ddlBarns.Text = "Seleccione galpón";
            // 
            // FrmAssignBarn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(300, 325);
            this.Controls.Add(this.ddlBarns);
            this.Controls.Add(this.radLabel1);
            this.Controls.Add(this.radLabel2);
            this.Controls.Add(this.dtpArrivedToBarn);
            this.Controls.Add(this.BtnGuardar);
            this.Controls.Add(this.BtnCancelar);
            this.Name = "FrmAssignBarn";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.Text = "Asignar galpón";
            this.Load += new System.EventHandler(this.FrmAssignBarn_Load);
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpArrivedToBarn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnGuardar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnCancelar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbvBatch)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ddlBarns)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Telerik.WinControls.UI.RadButton BtnGuardar;
        private Telerik.WinControls.UI.RadButton BtnCancelar;
        private Telerik.WinControls.UI.RadDateTimePicker dtpArrivedToBarn;
        private Telerik.WinControls.UI.RadLabel radLabel2;
        private System.Windows.Forms.ErrorProvider pbvBatch;
        private Telerik.WinControls.UI.RadDropDownList ddlBarns;
        private Telerik.WinControls.UI.RadLabel radLabel1;
    }
}
