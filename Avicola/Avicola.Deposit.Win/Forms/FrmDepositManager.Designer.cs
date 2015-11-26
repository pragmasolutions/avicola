namespace Avicola.Deposit.Win.Forms
{
    partial class FrmDepositManager
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmDepositManager));
            this.groupBox1 = new Telerik.WinControls.UI.RadGroupBox();
            this.btnHistory = new Telerik.WinControls.UI.RadButton();
            this.btnOrders = new Telerik.WinControls.UI.RadButton();
            this.btnStock = new Telerik.WinControls.UI.RadButton();
            ((System.ComponentModel.ISupportInitialize)(this.groupBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnHistory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnOrders)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnStock)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping;
            this.groupBox1.Controls.Add(this.btnHistory);
            this.groupBox1.Controls.Add(this.btnOrders);
            this.groupBox1.Controls.Add(this.btnStock);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.HeaderText = "Operaciones";
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 22, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(1084, 482);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Operaciones";
            ((Telerik.WinControls.UI.RadGroupBoxElement)(this.groupBox1.GetChildAt(0))).Padding = new System.Windows.Forms.Padding(3, 22, 3, 2);
            ((Telerik.WinControls.Primitives.TextPrimitive)(this.groupBox1.GetChildAt(0).GetChildAt(1).GetChildAt(2).GetChildAt(1))).Text = "Operaciones";
            ((Telerik.WinControls.Primitives.TextPrimitive)(this.groupBox1.GetChildAt(0).GetChildAt(1).GetChildAt(2).GetChildAt(1))).Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            ((Telerik.WinControls.Primitives.TextPrimitive)(this.groupBox1.GetChildAt(0).GetChildAt(1).GetChildAt(2).GetChildAt(1))).Alignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnHistory
            // 
            this.btnHistory.Image = global::Avicola.Deposit.Win.Properties.Resources.cabinet;
            this.btnHistory.ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnHistory.Location = new System.Drawing.Point(647, 43);
            this.btnHistory.Margin = new System.Windows.Forms.Padding(4);
            this.btnHistory.Name = "btnHistory";
            this.btnHistory.Size = new System.Drawing.Size(307, 196);
            this.btnHistory.TabIndex = 10;
            this.btnHistory.Text = "Historial de Pedidos Enviados";
            this.btnHistory.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnHistory.Click += new System.EventHandler(this.btnHistory_Click);
            // 
            // btnOrders
            // 
            this.btnOrders.Image = global::Avicola.Deposit.Win.Properties.Resources.orders;
            this.btnOrders.ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnOrders.Location = new System.Drawing.Point(332, 43);
            this.btnOrders.Margin = new System.Windows.Forms.Padding(4);
            this.btnOrders.Name = "btnOrders";
            this.btnOrders.Size = new System.Drawing.Size(307, 196);
            this.btnOrders.TabIndex = 9;
            this.btnOrders.Text = "Pedidos";
            this.btnOrders.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnOrders.Click += new System.EventHandler(this.btnOrders_Click);
            // 
            // btnStock
            // 
            this.btnStock.Image = ((System.Drawing.Image)(resources.GetObject("btnStock.Image")));
            this.btnStock.ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnStock.Location = new System.Drawing.Point(17, 43);
            this.btnStock.Margin = new System.Windows.Forms.Padding(4);
            this.btnStock.Name = "btnStock";
            this.btnStock.Size = new System.Drawing.Size(307, 196);
            this.btnStock.TabIndex = 8;
            this.btnStock.Text = "Ingresar stock";
            this.btnStock.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnStock.Click += new System.EventHandler(this.btnStock_Click);
            // 
            // FrmDepositManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1084, 482);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "FrmDepositManager";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.Text = "Producción";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmDepositManager_Load);
            ((System.ComponentModel.ISupportInitialize)(this.groupBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnHistory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnOrders)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnStock)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Telerik.WinControls.UI.RadGroupBox groupBox1;
        private Telerik.WinControls.UI.RadButton btnStock;
        private Telerik.WinControls.UI.RadButton btnOrders;
        private Telerik.WinControls.UI.RadButton btnHistory;

    }
}
