namespace Avicola.Deposit.Win.Forms
{
    partial class FrmSendOrder
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
            this.btnSendOrder = new Telerik.WinControls.UI.RadButton();
            this.ucOrderDetails = new Avicola.Deposit.Win.UserControls.UcOrderDetails();
            this.ucDriverSelection = new Avicola.Deposit.Win.UserControls.UcDriverSelection();
            this.ucTruckSelection = new Avicola.Deposit.Win.UserControls.UcTruckSelection();
            this.radLabel1 = new Telerik.WinControls.UI.RadLabel();
            this.radLabel2 = new Telerik.WinControls.UI.RadLabel();
            this.lbTitle = new Telerik.WinControls.UI.RadLabel();
            this.btnBackToDepositManager = new Telerik.WinControls.UI.RadButton();
            ((System.ComponentModel.ISupportInitialize)(this.btnCancel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSendOrder)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lbTitle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnBackToDepositManager)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(616, 598);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(110, 24);
            this.btnCancel.TabIndex = 0;
            this.btnCancel.Text = "Cancelar";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSendOrder
            // 
            this.btnSendOrder.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSendOrder.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSendOrder.Location = new System.Drawing.Point(500, 598);
            this.btnSendOrder.Name = "btnSendOrder";
            this.btnSendOrder.Size = new System.Drawing.Size(110, 24);
            this.btnSendOrder.TabIndex = 1;
            this.btnSendOrder.Text = "Enviar";
            this.btnSendOrder.Click += new System.EventHandler(this.btnSendOrder_Click);
            // 
            // ucOrderDetails
            // 
            this.ucOrderDetails.Location = new System.Drawing.Point(0, 59);
            this.ucOrderDetails.Name = "ucOrderDetails";
            this.ucOrderDetails.Size = new System.Drawing.Size(260, 460);
            this.ucOrderDetails.TabIndex = 2;
            // 
            // ucDriverSelection
            // 
            this.ucDriverSelection.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ucDriverSelection.Location = new System.Drawing.Point(278, 87);
            this.ucDriverSelection.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ucDriverSelection.Name = "ucDriverSelection";
            this.ucDriverSelection.Size = new System.Drawing.Size(284, 28);
            this.ucDriverSelection.TabIndex = 3;
            // 
            // ucTruckSelection
            // 
            this.ucTruckSelection.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ucTruckSelection.Location = new System.Drawing.Point(278, 144);
            this.ucTruckSelection.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ucTruckSelection.Name = "ucTruckSelection";
            this.ucTruckSelection.Size = new System.Drawing.Size(284, 28);
            this.ucTruckSelection.TabIndex = 4;
            // 
            // radLabel1
            // 
            this.radLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radLabel1.Location = new System.Drawing.Point(278, 63);
            this.radLabel1.Name = "radLabel1";
            this.radLabel1.Size = new System.Drawing.Size(79, 21);
            this.radLabel1.TabIndex = 5;
            this.radLabel1.Text = "Conductor";
            // 
            // radLabel2
            // 
            this.radLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radLabel2.Location = new System.Drawing.Point(279, 121);
            this.radLabel2.Name = "radLabel2";
            this.radLabel2.Size = new System.Drawing.Size(61, 21);
            this.radLabel2.TabIndex = 6;
            this.radLabel2.Text = "Camión";
            // 
            // lbTitle
            // 
            this.lbTitle.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitle.Location = new System.Drawing.Point(119, 12);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(191, 41);
            this.lbTitle.TabIndex = 16;
            this.lbTitle.Text = "Enviar Pedido";
            // 
            // btnBackToDepositManager
            // 
            this.btnBackToDepositManager.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBackToDepositManager.Location = new System.Drawing.Point(17, 21);
            this.btnBackToDepositManager.Margin = new System.Windows.Forms.Padding(8, 12, 8, 8);
            this.btnBackToDepositManager.Name = "btnBackToDepositManager";
            this.btnBackToDepositManager.Size = new System.Drawing.Size(100, 24);
            this.btnBackToDepositManager.TabIndex = 11;
            this.btnBackToDepositManager.Text = "Volver";
            this.btnBackToDepositManager.Click += new System.EventHandler(this.btnBackToDepositManager_Click);
            // 
            // FrmSendOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(738, 634);
            this.Controls.Add(this.btnBackToDepositManager);
            this.Controls.Add(this.lbTitle);
            this.Controls.Add(this.radLabel2);
            this.Controls.Add(this.radLabel1);
            this.Controls.Add(this.ucTruckSelection);
            this.Controls.Add(this.ucDriverSelection);
            this.Controls.Add(this.ucOrderDetails);
            this.Controls.Add(this.btnSendOrder);
            this.Controls.Add(this.btnCancel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmSendOrder";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.Text = "Armar Pedido";
            this.Load += new System.EventHandler(this.FrmSendOrder_Load);
            ((System.ComponentModel.ISupportInitialize)(this.btnCancel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSendOrder)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lbTitle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnBackToDepositManager)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Telerik.WinControls.UI.RadButton btnCancel;
        private Telerik.WinControls.UI.RadButton btnSendOrder;
        private UserControls.UcOrderDetails ucOrderDetails;
        private UserControls.UcDriverSelection ucDriverSelection;
        private UserControls.UcTruckSelection ucTruckSelection;
        private Telerik.WinControls.UI.RadLabel radLabel1;
        private Telerik.WinControls.UI.RadLabel radLabel2;
        private Telerik.WinControls.UI.RadLabel lbTitle;
        private Telerik.WinControls.UI.RadButton btnBackToDepositManager;
    }
}
