namespace Avicola.Deposit.Win.Forms
{
    partial class FrmFinishOrder
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
            this.btnFinishOrder = new Telerik.WinControls.UI.RadButton();
            this.ucOrderDetails = new Avicola.Deposit.Win.UserControls.UcOrderDetails();
            this.lbTitle = new Telerik.WinControls.UI.RadLabel();
            this.ucEggsAmount = new Avicola.Deposit.Win.UserControls.UcEggsAmount();
            this.btnBackToDepositManager = new Telerik.WinControls.UI.RadButton();
            ((System.ComponentModel.ISupportInitialize)(this.btnCancel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnFinishOrder)).BeginInit();
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
            // btnFinishOrder
            // 
            this.btnFinishOrder.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFinishOrder.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFinishOrder.Location = new System.Drawing.Point(500, 367);
            this.btnFinishOrder.Name = "btnFinishOrder";
            this.btnFinishOrder.Size = new System.Drawing.Size(110, 24);
            this.btnFinishOrder.TabIndex = 1;
            this.btnFinishOrder.Text = "Finalizar";
            this.btnFinishOrder.Click += new System.EventHandler(this.btnFinishOrder_Click);
            // 
            // ucOrderDetails
            // 
            this.ucOrderDetails.Location = new System.Drawing.Point(-1, 107);
            this.ucOrderDetails.Name = "ucOrderDetails";
            this.ucOrderDetails.Size = new System.Drawing.Size(260, 222);
            this.ucOrderDetails.TabIndex = 2;
            // 
            // lbTitle
            // 
            this.lbTitle.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitle.Location = new System.Drawing.Point(12, 56);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(220, 41);
            this.lbTitle.TabIndex = 15;
            this.lbTitle.Text = "Finalizar Pedido";
            // 
            // ucEggsAmount
            // 
            this.ucEggsAmount.Location = new System.Drawing.Point(266, 85);
            this.ucEggsAmount.Name = "ucEggsAmount";
            this.ucEggsAmount.Size = new System.Drawing.Size(384, 255);
            this.ucEggsAmount.TabIndex = 16;
            // 
            // btnBackToDepositManager
            // 
            this.btnBackToDepositManager.Location = new System.Drawing.Point(17, 21);
            this.btnBackToDepositManager.Margin = new System.Windows.Forms.Padding(8, 12, 8, 8);
            this.btnBackToDepositManager.Name = "btnBackToDepositManager";
            this.btnBackToDepositManager.Size = new System.Drawing.Size(87, 24);
            this.btnBackToDepositManager.TabIndex = 17;
            this.btnBackToDepositManager.Text = "Volver";
            this.btnBackToDepositManager.Click += new System.EventHandler(this.btnBackToDepositManager_Click);
            // 
            // FrmFinishOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(738, 403);
            this.Controls.Add(this.btnBackToDepositManager);
            this.Controls.Add(this.ucEggsAmount);
            this.Controls.Add(this.lbTitle);
            this.Controls.Add(this.ucOrderDetails);
            this.Controls.Add(this.btnFinishOrder);
            this.Controls.Add(this.btnCancel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmFinishOrder";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.Text = "Armar Pedido";
            this.Load += new System.EventHandler(this.FrmBuildOrder_Load);
            ((System.ComponentModel.ISupportInitialize)(this.btnCancel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnFinishOrder)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lbTitle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnBackToDepositManager)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Telerik.WinControls.UI.RadButton btnCancel;
        private Telerik.WinControls.UI.RadButton btnFinishOrder;
        private UserControls.UcOrderDetails ucOrderDetails;
        private Telerik.WinControls.UI.RadLabel lbTitle;
        private UserControls.UcEggsAmount ucEggsAmount;
        private Telerik.WinControls.UI.RadButton btnBackToDepositManager;
    }
}
