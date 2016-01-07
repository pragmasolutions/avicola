namespace Avicola.Sales.Win.Forms
{
    partial class FrmSalesManager
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
            this.groupBox1 = new Telerik.WinControls.UI.RadGroupBox();
            this.btnClients = new Telerik.WinControls.UI.RadButton();
            this.btnSalesHistory = new Telerik.WinControls.UI.RadButton();
            this.btnNewSale = new Telerik.WinControls.UI.RadButton();
            ((System.ComponentModel.ISupportInitialize)(this.groupBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnClients)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSalesHistory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnNewSale)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping;
            this.groupBox1.Controls.Add(this.btnClients);
            this.groupBox1.Controls.Add(this.btnSalesHistory);
            this.groupBox1.Controls.Add(this.btnNewSale);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.HeaderText = "Operaciones";
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(813, 392);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Operaciones";
            ((Telerik.WinControls.UI.RadGroupBoxElement)(this.groupBox1.GetChildAt(0))).Padding = new System.Windows.Forms.Padding(2, 18, 2, 2);
            ((Telerik.WinControls.Primitives.TextPrimitive)(this.groupBox1.GetChildAt(0).GetChildAt(1).GetChildAt(2).GetChildAt(1))).Text = "Operaciones";
            ((Telerik.WinControls.Primitives.TextPrimitive)(this.groupBox1.GetChildAt(0).GetChildAt(1).GetChildAt(2).GetChildAt(1))).Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            ((Telerik.WinControls.Primitives.TextPrimitive)(this.groupBox1.GetChildAt(0).GetChildAt(1).GetChildAt(2).GetChildAt(1))).Alignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnClients
            // 
            this.btnClients.Image = global::Avicola.Sales.Win.Properties.Resources.customers;
            this.btnClients.ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnClients.Location = new System.Drawing.Point(485, 35);
            this.btnClients.Name = "btnClients";
            this.btnClients.Size = new System.Drawing.Size(230, 159);
            this.btnClients.TabIndex = 11;
            this.btnClients.Text = "Clientes";
            this.btnClients.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnClients.Click += new System.EventHandler(this.btnClients_Click);
            // 
            // btnSalesHistory
            // 
            this.btnSalesHistory.Image = global::Avicola.Sales.Win.Properties.Resources.sales_history;
            this.btnSalesHistory.ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnSalesHistory.Location = new System.Drawing.Point(249, 35);
            this.btnSalesHistory.Name = "btnSalesHistory";
            this.btnSalesHistory.Size = new System.Drawing.Size(230, 159);
            this.btnSalesHistory.TabIndex = 10;
            this.btnSalesHistory.Text = "Historial de Ventas";
            this.btnSalesHistory.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnSalesHistory.Click += new System.EventHandler(this.btnHistory_Click);
            // 
            // btnNewSale
            // 
            this.btnNewSale.Image = global::Avicola.Sales.Win.Properties.Resources.new_sale;
            this.btnNewSale.ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnNewSale.Location = new System.Drawing.Point(13, 35);
            this.btnNewSale.Name = "btnNewSale";
            this.btnNewSale.Size = new System.Drawing.Size(230, 159);
            this.btnNewSale.TabIndex = 8;
            this.btnNewSale.Text = "Ingresar Venta";
            this.btnNewSale.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnNewSale.Click += new System.EventHandler(this.btnNewSale_Click);
            // 
            // FrmSalesManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(813, 392);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FrmSalesManager";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.Text = "Producción";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmSalesManager_Load);
            ((System.ComponentModel.ISupportInitialize)(this.groupBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnClients)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSalesHistory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnNewSale)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Telerik.WinControls.UI.RadGroupBox groupBox1;
        private Telerik.WinControls.UI.RadButton btnNewSale;
        private Telerik.WinControls.UI.RadButton btnSalesHistory;
        private Telerik.WinControls.UI.RadButton btnClients;

    }
}
