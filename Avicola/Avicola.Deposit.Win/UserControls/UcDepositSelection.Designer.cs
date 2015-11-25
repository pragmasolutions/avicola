namespace Avicola.Deposit.Win.UserControls
{
    partial class UcDepositSelection
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
            this.ddlDeposits = new Telerik.WinControls.UI.RadDropDownList();
            ((System.ComponentModel.ISupportInitialize)(this.ddlDeposits)).BeginInit();
            this.SuspendLayout();
            // 
            // ddlDeposits
            // 
            this.ddlDeposits.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ddlDeposits.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ddlDeposits.Location = new System.Drawing.Point(0, 0);
            this.ddlDeposits.Name = "ddlDeposits";
            this.ddlDeposits.Size = new System.Drawing.Size(284, 28);
            this.ddlDeposits.TabIndex = 0;
            this.ddlDeposits.SelectedIndexChanged += new Telerik.WinControls.UI.Data.PositionChangedEventHandler(this.ddlDeposits_SelectedIndexChanged);
            // 
            // UcDepositSelection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ddlDeposits);
            this.Name = "UcDepositSelection";
            this.Size = new System.Drawing.Size(284, 28);
            ((System.ComponentModel.ISupportInitialize)(this.ddlDeposits)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Telerik.WinControls.UI.RadDropDownList ddlDeposits;
    }
}
