namespace Avicola.Sales.Win.UserControls
{
    partial class UcTruckSelection
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
            this.ddlTrucks = new Telerik.WinControls.UI.RadDropDownList();
            ((System.ComponentModel.ISupportInitialize)(this.ddlTrucks)).BeginInit();
            this.SuspendLayout();
            // 
            // ddlTrucks
            // 
            this.ddlTrucks.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ddlTrucks.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ddlTrucks.Location = new System.Drawing.Point(0, 0);
            this.ddlTrucks.Name = "ddlTrucks";
            this.ddlTrucks.Size = new System.Drawing.Size(284, 28);
            this.ddlTrucks.TabIndex = 0;
            this.ddlTrucks.SelectedIndexChanged += new Telerik.WinControls.UI.Data.PositionChangedEventHandler(this.ddlTrucks_SelectedIndexChanged);
            // 
            // UcTruckSelection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ddlTrucks);
            this.Name = "UcTruckSelection";
            this.Size = new System.Drawing.Size(284, 28);
            ((System.ComponentModel.ISupportInitialize)(this.ddlTrucks)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Telerik.WinControls.UI.RadDropDownList ddlTrucks;
    }
}
