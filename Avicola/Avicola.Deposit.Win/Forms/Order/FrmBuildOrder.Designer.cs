namespace Avicola.Deposit.Win.Forms
{
    partial class FrmBuildOrder
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
            this.btnCancel = new Telerik.WinControls.UI.RadButton();
            this.btnBuildOrder = new Telerik.WinControls.UI.RadButton();
            this.ucOrderDetails = new Avicola.Deposit.Win.UserControls.UcOrderDetails();
            this.lbTitle = new Telerik.WinControls.UI.RadLabel();
            this.btnBackToDepositManager = new Telerik.WinControls.UI.RadButton();
            ((System.ComponentModel.ISupportInitialize)(this.btnCancel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnBuildOrder)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lbTitle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnBackToDepositManager)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(616, 367);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(110, 24);
            this.btnCancel.TabIndex = 0;
            this.btnCancel.Text = "Cancelar";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnBuildOrder
            // 
            this.btnBuildOrder.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBuildOrder.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuildOrder.Location = new System.Drawing.Point(500, 367);
            this.btnBuildOrder.Name = "btnBuildOrder";
            this.btnBuildOrder.Size = new System.Drawing.Size(110, 24);
            this.btnBuildOrder.TabIndex = 1;
            this.btnBuildOrder.Text = "Armar";
            this.btnBuildOrder.Click += new System.EventHandler(this.btnBuildOrder_Click);
            // 
            // ucOrderDetails
            // 
            this.ucOrderDetails.Location = new System.Drawing.Point(1, 59);
            this.ucOrderDetails.Name = "ucOrderDetails";
            this.ucOrderDetails.Size = new System.Drawing.Size(260, 222);
            this.ucOrderDetails.TabIndex = 2;
            // 
            // lbTitle
            // 
            this.lbTitle.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitle.Location = new System.Drawing.Point(118, 12);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(193, 41);
            this.lbTitle.TabIndex = 14;
            this.lbTitle.Text = "Armar Pedido";
            // 
            // btnBackToDepositManager
            // 
            this.btnBackToDepositManager.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBackToDepositManager.Location = new System.Drawing.Point(17, 21);
            this.btnBackToDepositManager.Margin = new System.Windows.Forms.Padding(8, 12, 8, 8);
            this.btnBackToDepositManager.Name = "btnBackToDepositManager";
            this.btnBackToDepositManager.Size = new System.Drawing.Size(100, 24);
            this.btnBackToDepositManager.TabIndex = 15;
            this.btnBackToDepositManager.Text = "Volver";
            this.btnBackToDepositManager.Click += new System.EventHandler(this.btnBackToDepositManager_Click);
            // 
            // FrmBuildOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(738, 403);
            this.Controls.Add(this.btnBackToDepositManager);
            this.Controls.Add(this.lbTitle);
            this.Controls.Add(this.ucOrderDetails);
            this.Controls.Add(this.btnBuildOrder);
            this.Controls.Add(this.btnCancel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmBuildOrder";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.Text = "Armar Pedido";
            this.Load += new System.EventHandler(this.FrmBuildOrder_Load);
            ((System.ComponentModel.ISupportInitialize)(this.btnCancel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnBuildOrder)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lbTitle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnBackToDepositManager)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Telerik.WinControls.UI.RadButton btnCancel;
        private Telerik.WinControls.UI.RadButton btnBuildOrder;
        private UserControls.UcOrderDetails ucOrderDetails;
        private Telerik.WinControls.UI.RadLabel lbTitle;
        private Telerik.WinControls.UI.RadButton btnBackToDepositManager;
    }
}
