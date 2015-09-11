namespace Avicola.Production.Win.UserControls
{
    partial class UcStandardSelecction
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.StandardButtonsPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // StandardButtonsPanel
            // 
            this.StandardButtonsPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.StandardButtonsPanel.Location = new System.Drawing.Point(0, 0);
            this.StandardButtonsPanel.Name = "StandardButtonsPanel";
            this.StandardButtonsPanel.Size = new System.Drawing.Size(998, 255);
            this.StandardButtonsPanel.TabIndex = 0;
            // 
            // UcStandardSelecction
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.StandardButtonsPanel);
            this.Name = "UcStandardSelecction";
            this.Size = new System.Drawing.Size(998, 255);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel StandardButtonsPanel;
    }
}
