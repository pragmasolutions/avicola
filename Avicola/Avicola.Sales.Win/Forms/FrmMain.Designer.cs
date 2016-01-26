namespace Avicola.Sales.Win.Forms
{
    partial class FrmMain
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
            this.MainContenPanel = new Telerik.WinControls.UI.RadPanel();
            this.WaitingBar = new Telerik.WinControls.UI.RadWaitingBar();
            this.btnSync = new Telerik.WinControls.UI.RadButton();
            ((System.ComponentModel.ISupportInitialize)(this.MainContenPanel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.WaitingBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSync)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // MainContenPanel
            // 
            this.MainContenPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MainContenPanel.Location = new System.Drawing.Point(12, 44);
            this.MainContenPanel.Name = "MainContenPanel";
            this.MainContenPanel.Size = new System.Drawing.Size(1077, 568);
            this.MainContenPanel.TabIndex = 0;
            // 
            // WaitingBar
            // 
            this.WaitingBar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.WaitingBar.Location = new System.Drawing.Point(843, 12);
            this.WaitingBar.Name = "WaitingBar";
            this.WaitingBar.Size = new System.Drawing.Size(130, 24);
            this.WaitingBar.TabIndex = 4;
            this.WaitingBar.Text = "Sincronozando";
            this.WaitingBar.Visible = false;
            this.WaitingBar.WaitingSpeed = 100;
            // 
            // btnSync
            // 
            this.btnSync.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSync.Location = new System.Drawing.Point(979, 12);
            this.btnSync.Name = "btnSync";
            this.btnSync.Size = new System.Drawing.Size(110, 24);
            this.btnSync.TabIndex = 3;
            this.btnSync.Text = "Sincronizar";
            this.btnSync.Click += new System.EventHandler(this.btnSync_Click);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1101, 624);
            this.Controls.Add(this.WaitingBar);
            this.Controls.Add(this.btnSync);
            this.Controls.Add(this.MainContenPanel);
            this.Name = "FrmMain";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.Text = "Ventas";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.MainContenPanel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.WaitingBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSync)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Telerik.WinControls.UI.RadPanel MainContenPanel;
        private Telerik.WinControls.UI.RadWaitingBar WaitingBar;
        private Telerik.WinControls.UI.RadButton btnSync;
    }
}
