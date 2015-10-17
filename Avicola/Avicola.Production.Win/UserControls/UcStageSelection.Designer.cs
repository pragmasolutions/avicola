namespace Avicola.Production.Win.UserControls
{
    partial class UcStageSelection
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
            this.ddlStages = new Telerik.WinControls.UI.RadDropDownList();
            ((System.ComponentModel.ISupportInitialize)(this.ddlStages)).BeginInit();
            this.SuspendLayout();
            // 
            // ddlStages
            // 
            this.ddlStages.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ddlStages.DropDownStyle = Telerik.WinControls.RadDropDownStyle.DropDownList;
            this.ddlStages.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ddlStages.Location = new System.Drawing.Point(0, 0);
            this.ddlStages.Name = "ddlStages";
            this.ddlStages.Size = new System.Drawing.Size(425, 28);
            this.ddlStages.TabIndex = 0;
            this.ddlStages.SelectedValueChanged += new System.EventHandler(this.ddlStages_SelectedValueChanged);
            // 
            // UcStageSelection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ddlStages);
            this.Name = "UcStageSelection";
            this.Size = new System.Drawing.Size(425, 27);
            ((System.ComponentModel.ISupportInitialize)(this.ddlStages)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Telerik.WinControls.UI.RadDropDownList ddlStages;
    }
}
