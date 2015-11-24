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
            this.ucDepositSelection = new Avicola.Deposit.Win.UserControls.UcDepositSelection();
            this.radLabel1 = new Telerik.WinControls.UI.RadLabel();
            this.lbTitle = new Telerik.WinControls.UI.RadLabel();
            ((System.ComponentModel.ISupportInitialize)(this.btnCancel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnBuildOrder)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lbTitle)).BeginInit();
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
            this.ucOrderDetails.Location = new System.Drawing.Point(12, 60);
            this.ucOrderDetails.Name = "ucOrderDetails";
            this.ucOrderDetails.Size = new System.Drawing.Size(260, 222);
            this.ucOrderDetails.TabIndex = 2;
            // 
            // ucDepositSelection
            // 
            this.ucDepositSelection.Location = new System.Drawing.Point(290, 88);
            this.ucDepositSelection.Name = "ucDepositSelection";
            this.ucDepositSelection.Size = new System.Drawing.Size(284, 28);
            this.ucDepositSelection.TabIndex = 3;
            // 
            // radLabel1
            // 
            this.radLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radLabel1.Location = new System.Drawing.Point(287, 64);
            this.radLabel1.Name = "radLabel1";
            this.radLabel1.Size = new System.Drawing.Size(69, 21);
            this.radLabel1.TabIndex = 4;
            this.radLabel1.Text = "Deposito";
            // 
            // lbTitle
            // 
            this.lbTitle.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitle.Location = new System.Drawing.Point(12, 13);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(193, 41);
            this.lbTitle.TabIndex = 14;
            this.lbTitle.Text = "Armar Pedido";
            // 
            // FrmBuildOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(738, 403);
            this.Controls.Add(this.lbTitle);
            this.Controls.Add(this.radLabel1);
            this.Controls.Add(this.ucDepositSelection);
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
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lbTitle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Telerik.WinControls.UI.RadButton btnCancel;
        private Telerik.WinControls.UI.RadButton btnBuildOrder;
        private UserControls.UcOrderDetails ucOrderDetails;
        private UserControls.UcDepositSelection ucDepositSelection;
        private Telerik.WinControls.UI.RadLabel radLabel1;
        private Telerik.WinControls.UI.RadLabel lbTitle;
    }
}
