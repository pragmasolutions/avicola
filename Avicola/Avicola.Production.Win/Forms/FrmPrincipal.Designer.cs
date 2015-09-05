namespace Avicola.Production.Win.Forms
{
    partial class FrmPrincipal
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.radMenu1 = new Telerik.WinControls.UI.RadMenu();
            this.radMenuItem1 = new Telerik.WinControls.UI.RadMenuItem();
            this.BtnMedidas = new Telerik.WinControls.UI.RadButton();
            this.PnlBotones = new Telerik.WinControls.UI.RadPanel();
            this.BtnMeassureHistory = new Telerik.WinControls.UI.RadButton();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radMenu1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnMedidas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PnlBotones)).BeginInit();
            this.PnlBotones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BtnMeassureHistory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.White;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.Controls.Add(this.radMenu1, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1082, 30);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // radMenu1
            // 
            this.radMenu1.Items.AddRange(new Telerik.WinControls.RadItem[] {
            this.radMenuItem1});
            this.radMenu1.Location = new System.Drawing.Point(3, 3);
            this.radMenu1.Name = "radMenu1";
            this.radMenu1.Size = new System.Drawing.Size(1076, 24);
            this.radMenu1.TabIndex = 0;
            this.radMenu1.Text = "radMenu1";
            // 
            // radMenuItem1
            // 
            this.radMenuItem1.AccessibleDescription = "Medidas";
            this.radMenuItem1.AccessibleName = "Medidas";
            this.radMenuItem1.Name = "radMenuItem1";
            this.radMenuItem1.Text = "Medidas";
            // 
            // BtnMedidas
            // 
            this.BtnMedidas.Location = new System.Drawing.Point(3, 3);
            this.BtnMedidas.Name = "BtnMedidas";
            this.BtnMedidas.Size = new System.Drawing.Size(109, 105);
            this.BtnMedidas.TabIndex = 1;
            this.BtnMedidas.Text = "Medidas";
            this.BtnMedidas.Click += new System.EventHandler(this.BtnMedidas_Click);
            // 
            // PnlBotones
            // 
            this.PnlBotones.Controls.Add(this.BtnMeassureHistory);
            this.PnlBotones.Controls.Add(this.BtnMedidas);
            this.PnlBotones.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PnlBotones.Location = new System.Drawing.Point(0, 30);
            this.PnlBotones.Name = "PnlBotones";
            this.PnlBotones.Size = new System.Drawing.Size(1082, 576);
            this.PnlBotones.TabIndex = 2;
            // 
            // BtnMeassureHistory
            // 
            this.BtnMeassureHistory.Location = new System.Drawing.Point(118, 3);
            this.BtnMeassureHistory.Name = "BtnMeassureHistory";
            this.BtnMeassureHistory.Size = new System.Drawing.Size(109, 105);
            this.BtnMeassureHistory.TabIndex = 2;
            this.BtnMeassureHistory.Text = "Historial de Medidas";
            this.BtnMeassureHistory.Click += new System.EventHandler(this.BtnMeassureHistory_Click);
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1082, 606);
            this.Controls.Add(this.PnlBotones);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "FrmPrincipal";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.Text = "Sistema de gestión Avicola Santa Ana";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radMenu1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnMedidas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PnlBotones)).EndInit();
            this.PnlBotones.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.BtnMeassureHistory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private Telerik.WinControls.UI.RadMenu radMenu1;
        private Telerik.WinControls.UI.RadMenuItem radMenuItem1;
        private Telerik.WinControls.UI.RadButton BtnMedidas;
        private Telerik.WinControls.UI.RadPanel PnlBotones;
        private Telerik.WinControls.UI.RadButton BtnMeassureHistory;
    }
}
