namespace Avicola.Sales.Win.UserControls
{
    partial class UcEggClassSale
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
            this.txtDozens = new Framework.Common.Win.Controls.CustomSpinEditor();
            this.lblName = new Telerik.WinControls.UI.RadLabel();
            ((System.ComponentModel.ISupportInitialize)(this.txtDozens)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblName)).BeginInit();
            this.SuspendLayout();
            // 
            // txtDozens
            // 
            this.txtDozens.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDozens.Location = new System.Drawing.Point(125, 16);
            this.txtDozens.Margin = new System.Windows.Forms.Padding(4);
            this.txtDozens.Name = "txtDozens";
            this.txtDozens.NullableValue = null;
            this.txtDozens.Size = new System.Drawing.Size(131, 30);
            this.txtDozens.TabIndex = 0;
            this.txtDozens.TabStop = false;
            // 
            // lblName
            // 
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(31, 20);
            this.lblName.Margin = new System.Windows.Forms.Padding(4);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(86, 26);
            this.lblName.TabIndex = 3;
            this.lblName.Text = "{{Name}}";
            // 
            // UcEggClassSale
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.txtDozens);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "UcEggClassSale";
            this.Size = new System.Drawing.Size(306, 69);
            ((System.ComponentModel.ISupportInitialize)(this.txtDozens)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblName)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Framework.Common.Win.Controls.CustomSpinEditor txtDozens;
        private Telerik.WinControls.UI.RadLabel lblName;
    }
}
