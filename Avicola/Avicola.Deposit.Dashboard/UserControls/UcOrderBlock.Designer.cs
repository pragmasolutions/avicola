namespace Avicola.Deposit.Dashboard.UserControls
{
    partial class UcOrderBlock
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.lblClientName = new System.Windows.Forms.Label();
            this.lblCreatedDate = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.lblAddress = new System.Windows.Forms.Label();
            this.lblClientNameValue = new System.Windows.Forms.Label();
            this.lblCreatedDateValue = new System.Windows.Forms.Label();
            this.lblAddressValue = new System.Windows.Forms.Label();
            this.lblStatusValue = new System.Windows.Forms.Label();
            this.flpOrderEggClasses = new System.Windows.Forms.FlowLayoutPanel();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.flpOrderEggClasses, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 150F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(494, 408);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel2.Controls.Add(this.lblClientName, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.lblCreatedDate, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.lblStatus, 1, 2);
            this.tableLayoutPanel2.Controls.Add(this.lblAddress, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.lblClientNameValue, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.lblCreatedDateValue, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.lblAddressValue, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.lblStatusValue, 1, 3);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 4;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(488, 144);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // lblClientName
            // 
            this.lblClientName.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblClientName.AutoSize = true;
            this.lblClientName.Location = new System.Drawing.Point(3, 9);
            this.lblClientName.Name = "lblClientName";
            this.lblClientName.Size = new System.Drawing.Size(51, 17);
            this.lblClientName.TabIndex = 0;
            this.lblClientName.Text = "Cliente";
            // 
            // lblCreatedDate
            // 
            this.lblCreatedDate.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblCreatedDate.AutoSize = true;
            this.lblCreatedDate.Location = new System.Drawing.Point(344, 9);
            this.lblCreatedDate.Name = "lblCreatedDate";
            this.lblCreatedDate.Size = new System.Drawing.Size(47, 17);
            this.lblCreatedDate.TabIndex = 1;
            this.lblCreatedDate.Text = "Fecha";
            // 
            // lblStatus
            // 
            this.lblStatus.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(344, 81);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(52, 17);
            this.lblStatus.TabIndex = 2;
            this.lblStatus.Text = "Estado";
            // 
            // lblAddress
            // 
            this.lblAddress.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblAddress.AutoSize = true;
            this.lblAddress.Location = new System.Drawing.Point(3, 81);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(67, 17);
            this.lblAddress.TabIndex = 3;
            this.lblAddress.Text = "Dirección";
            // 
            // lblClientNameValue
            // 
            this.lblClientNameValue.AutoSize = true;
            this.lblClientNameValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClientNameValue.Location = new System.Drawing.Point(3, 36);
            this.lblClientNameValue.Name = "lblClientNameValue";
            this.lblClientNameValue.Size = new System.Drawing.Size(129, 17);
            this.lblClientNameValue.TabIndex = 4;
            this.lblClientNameValue.Text = "{{CLIENTNAME}}";
            // 
            // lblCreatedDateValue
            // 
            this.lblCreatedDateValue.AutoSize = true;
            this.lblCreatedDateValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCreatedDateValue.Location = new System.Drawing.Point(344, 36);
            this.lblCreatedDateValue.Name = "lblCreatedDateValue";
            this.lblCreatedDateValue.Size = new System.Drawing.Size(139, 34);
            this.lblCreatedDateValue.TabIndex = 5;
            this.lblCreatedDateValue.Text = "{{CREATEDDATE}}";
            // 
            // lblAddressValue
            // 
            this.lblAddressValue.AutoSize = true;
            this.lblAddressValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddressValue.Location = new System.Drawing.Point(3, 108);
            this.lblAddressValue.Name = "lblAddressValue";
            this.lblAddressValue.Size = new System.Drawing.Size(105, 17);
            this.lblAddressValue.TabIndex = 6;
            this.lblAddressValue.Text = "{{ADDRESS}}";
            // 
            // lblStatusValue
            // 
            this.lblStatusValue.AutoSize = true;
            this.lblStatusValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatusValue.Location = new System.Drawing.Point(344, 108);
            this.lblStatusValue.Name = "lblStatusValue";
            this.lblStatusValue.Size = new System.Drawing.Size(93, 17);
            this.lblStatusValue.TabIndex = 7;
            this.lblStatusValue.Text = "{{STATUS}}";
            // 
            // flpOrderEggClasses
            // 
            this.flpOrderEggClasses.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flpOrderEggClasses.Location = new System.Drawing.Point(3, 153);
            this.flpOrderEggClasses.Name = "flpOrderEggClasses";
            this.flpOrderEggClasses.Size = new System.Drawing.Size(488, 252);
            this.flpOrderEggClasses.TabIndex = 1;
            // 
            // UcOrderBlock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "UcOrderBlock";
            this.Padding = new System.Windows.Forms.Padding(3);
            this.Size = new System.Drawing.Size(500, 414);
            this.Load += new System.EventHandler(this.UcOrderBlock_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label lblClientName;
        private System.Windows.Forms.Label lblCreatedDate;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.Label lblClientNameValue;
        private System.Windows.Forms.Label lblCreatedDateValue;
        private System.Windows.Forms.Label lblAddressValue;
        private System.Windows.Forms.Label lblStatusValue;
        private System.Windows.Forms.FlowLayoutPanel flpOrderEggClasses;
    }
}
