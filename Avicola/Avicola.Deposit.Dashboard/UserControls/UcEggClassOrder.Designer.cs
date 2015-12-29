namespace Avicola.Deposit.Dashboard.UserControls
{
    partial class UcEggClassOrder
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
            this.lblAmount = new Telerik.WinControls.UI.RadLabel();
            this.lblMissingStock = new Telerik.WinControls.UI.RadLabel();
            ((System.ComponentModel.ISupportInitialize)(this.lblName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblAmount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblMissingStock)).BeginInit();
            this.SuspendLayout();
            // 
            // lblName
            // 
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(4, 4);
            this.lblName.Margin = new System.Windows.Forms.Padding(4);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(86, 26);
            this.lblName.TabIndex = 3;
            this.lblName.Text = "{{Name}}";
            // 
            // lblAmount
            // 
            this.lblAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAmount.ForeColor = System.Drawing.Color.Gray;
            this.lblAmount.Location = new System.Drawing.Point(88, 4);
            this.lblAmount.Margin = new System.Windows.Forms.Padding(4);
            this.lblAmount.Name = "lblAmount";
            this.lblAmount.Size = new System.Drawing.Size(101, 25);
            this.lblAmount.TabIndex = 4;
            this.lblAmount.Text = "{{Amount}}";
            // 
            // lblMissingStock
            // 
            this.lblMissingStock.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMissingStock.ForeColor = System.Drawing.Color.Firebrick;
            this.lblMissingStock.Location = new System.Drawing.Point(179, 4);
            this.lblMissingStock.Margin = new System.Windows.Forms.Padding(4);
            this.lblMissingStock.Name = "lblMissingStock";
            this.lblMissingStock.Size = new System.Drawing.Size(83, 25);
            this.lblMissingStock.TabIndex = 5;
            this.lblMissingStock.Text = "{{Stock}}";
            // 
            // UcEggClassOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblMissingStock);
            this.Controls.Add(this.lblAmount);
            this.Controls.Add(this.lblName);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "UcEggClassOrder";
            this.Size = new System.Drawing.Size(205, 39);
            this.Load += new System.EventHandler(this.UcEggClassStock_Load);
            ((System.ComponentModel.ISupportInitialize)(this.lblName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblAmount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblMissingStock)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Telerik.WinControls.UI.RadLabel lblName;
        private Telerik.WinControls.UI.RadLabel lblAmount;
        private Telerik.WinControls.UI.RadLabel lblMissingStock;
    }
}
