namespace Avicola.Deposit.Dashboard.UserControls
{
    partial class UcEggClassStock
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
            this.lblName = new Telerik.WinControls.UI.RadLabel();
            this.lblStock = new Telerik.WinControls.UI.RadLabel();
            ((System.ComponentModel.ISupportInitialize)(this.lblName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblStock)).BeginInit();
            this.SuspendLayout();
            // 
            // lblName
            // 
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(13, 9);
            this.lblName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(169, 26);
            this.lblName.TabIndex = 3;
            this.lblName.Text = "{{EggClassName}}";
            // 
            // lblStock
            // 
            this.lblStock.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStock.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.lblStock.Location = new System.Drawing.Point(172, 9);
            this.lblStock.Margin = new System.Windows.Forms.Padding(4);
            this.lblStock.Name = "lblStock";
            this.lblStock.Size = new System.Drawing.Size(83, 25);
            this.lblStock.TabIndex = 4;
            this.lblStock.Text = "{{Stock}}";
            // 
            // UcEggClassStock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblStock);
            this.Controls.Add(this.lblName);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "UcEggClassStock";
            this.Size = new System.Drawing.Size(308, 45);
            this.Load += new System.EventHandler(this.UcEggClassStock_Load);
            ((System.ComponentModel.ISupportInitialize)(this.lblName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblStock)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Telerik.WinControls.UI.RadLabel lblName;
        private Telerik.WinControls.UI.RadLabel lblStock;
    }
}
