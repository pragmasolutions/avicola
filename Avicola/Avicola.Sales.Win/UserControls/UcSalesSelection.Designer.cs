namespace Avicola.Sales.Win.UserControls
{
    partial class UcSalesSelection
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
            this.ddlSaless = new Telerik.WinControls.UI.RadDropDownList();
            ((System.ComponentModel.ISupportInitialize)(this.ddlSaless)).BeginInit();
            this.SuspendLayout();
            // 
            // ddlSaless
            // 
            this.ddlSaless.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ddlSaless.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ddlSaless.Location = new System.Drawing.Point(0, 0);
            this.ddlSaless.Name = "ddlSaless";
            this.ddlSaless.Size = new System.Drawing.Size(284, 28);
            this.ddlSaless.TabIndex = 0;
            this.ddlSaless.SelectedIndexChanged += new Telerik.WinControls.UI.Data.PositionChangedEventHandler(this.ddlSaless_SelectedIndexChanged);
            // 
            // UcSalesSelection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ddlSaless);
            this.Name = "UcSalesSelection";
            this.Size = new System.Drawing.Size(284, 28);
            ((System.ComponentModel.ISupportInitialize)(this.ddlSaless)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Telerik.WinControls.UI.RadDropDownList ddlSaless;
    }
}
