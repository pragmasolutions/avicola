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
            this.MainMenu = new Telerik.WinControls.UI.RadMenu();
            this.miMeasuresHistory = new Telerik.WinControls.UI.RadMenuItem();
            this.miCreateMeasures = new Telerik.WinControls.UI.RadMenuItem();
            this.radMenuItem3 = new Telerik.WinControls.UI.RadMenuItem();
            this.BtnMedidas = new Telerik.WinControls.UI.RadButton();
            this.PnlBotones = new Telerik.WinControls.UI.RadPanel();
            this.BtnMeassureHistory = new Telerik.WinControls.UI.RadButton();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MainMenu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnMedidas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PnlBotones)).BeginInit();
            this.PnlBotones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BtnMeassureHistory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.Controls.Add(this.MainMenu, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1082, 24);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // MainMenu
            // 
            this.MainMenu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainMenu.Items.AddRange(new Telerik.WinControls.RadItem[] {
            this.miMeasuresHistory});
            this.MainMenu.Location = new System.Drawing.Point(3, 3);
            this.MainMenu.Name = "MainMenu";
            this.MainMenu.Size = new System.Drawing.Size(1076, 20);
            this.MainMenu.TabIndex = 0;
            // 
            // miMeasuresHistory
            // 
            this.miMeasuresHistory.AccessibleDescription = "Medidas";
            this.miMeasuresHistory.AccessibleName = "Medidas";
            this.miMeasuresHistory.Items.AddRange(new Telerik.WinControls.RadItem[] {
            this.miCreateMeasures,
            this.radMenuItem3});
            this.miMeasuresHistory.Name = "miMeasuresHistory";
            this.miMeasuresHistory.Text = "Medidas";
            // 
            // miCreateMeasures
            // 
            this.miCreateMeasures.AccessibleDescription = "Cargar Medidas";
            this.miCreateMeasures.AccessibleName = "Cargar Medidas";
            this.miCreateMeasures.Name = "miCreateMeasures";
            this.miCreateMeasures.Text = "Cargar Medidas";
            this.miCreateMeasures.Click += new System.EventHandler(this.miCreateMeasures_Click);
            // 
            // radMenuItem3
            // 
            this.radMenuItem3.AccessibleDescription = "Historial";
            this.radMenuItem3.AccessibleName = "Historial";
            this.radMenuItem3.Name = "radMenuItem3";
            this.radMenuItem3.Text = "Historial";
            this.radMenuItem3.Click += new System.EventHandler(this.miMeasuresHistory_Click);
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
            this.PnlBotones.Location = new System.Drawing.Point(0, 24);
            this.PnlBotones.Name = "PnlBotones";
            this.PnlBotones.Size = new System.Drawing.Size(1082, 582);
            this.PnlBotones.TabIndex = 2;
            // 
            // BtnMeassureHistory
            // 
            this.BtnMeassureHistory.Location = new System.Drawing.Point(118, 3);
            this.BtnMeassureHistory.Name = "BtnMeassureHistory";
            this.BtnMeassureHistory.Size = new System.Drawing.Size(109, 105);
            this.BtnMeassureHistory.TabIndex = 2;
            this.BtnMeassureHistory.Text = "<html><p>Historial</p><p>de</p><p>Medidas</p></html>";
            this.BtnMeassureHistory.Click += new System.EventHandler(this.BtnMeassureHistory_Click);
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
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
            ((System.ComponentModel.ISupportInitialize)(this.MainMenu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnMedidas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PnlBotones)).EndInit();
            this.PnlBotones.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.BtnMeassureHistory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private Telerik.WinControls.UI.RadMenu MainMenu;
        private Telerik.WinControls.UI.RadMenuItem miMeasuresHistory;
        private Telerik.WinControls.UI.RadButton BtnMedidas;
        private Telerik.WinControls.UI.RadPanel PnlBotones;
        private Telerik.WinControls.UI.RadButton BtnMeassureHistory;
        private Telerik.WinControls.UI.RadMenuItem miCreateMeasures;
        private Telerik.WinControls.UI.RadMenuItem radMenuItem3;
    }
}
