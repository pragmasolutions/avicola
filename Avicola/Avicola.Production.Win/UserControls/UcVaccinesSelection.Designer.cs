using Avicola.Office.Services.Interfaces;
namespace Avicola.Production.Win.UserControls
{
    partial class UcVaccinesSelection
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private readonly IServiceFactory _serviceFactory;
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
            this.ddlVaccines = new Telerik.WinControls.UI.RadDropDownList();
            ((System.ComponentModel.ISupportInitialize)(this.ddlVaccines)).BeginInit();
            this.SuspendLayout();
            // 
            // ddlVaccines
            // 
            this.ddlVaccines.Location = new System.Drawing.Point(0, 0);
            this.ddlVaccines.Name = "ddlVaccines";
            this.ddlVaccines.Size = new System.Drawing.Size(150, 20);
            this.ddlVaccines.TabIndex = 0;
            this.ddlVaccines.Text = "radDropDownList1";
            this.ddlVaccines.SelectedValueChanged += new System.EventHandler(this.ddlVaccines_SelectedValueChanged);
            // 
            // UcVaccinesSelection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ddlVaccines);
            this.Name = "UcVaccinesSelection";
            this.Size = new System.Drawing.Size(153, 20);
            ((System.ComponentModel.ISupportInitialize)(this.ddlVaccines)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Telerik.WinControls.UI.RadDropDownList ddlVaccines;
    }
}
