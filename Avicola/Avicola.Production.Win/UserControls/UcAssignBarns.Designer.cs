namespace Avicola.Production.Win.UserControls
{
    partial class UcAssignBarns
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
            this.btnAddBarn = new Telerik.WinControls.UI.RadButton();
            this.BarnsContainer = new System.Windows.Forms.FlowLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.btnAddBarn)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAddBarn
            // 
            this.btnAddBarn.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddBarn.Location = new System.Drawing.Point(3, 3);
            this.btnAddBarn.Name = "btnAddBarn";
            this.btnAddBarn.Size = new System.Drawing.Size(110, 24);
            this.btnAddBarn.TabIndex = 0;
            this.btnAddBarn.Text = "Agregar";
            this.btnAddBarn.Click += new System.EventHandler(this.btnAddBarn_Click);
            // 
            // BarnsContainer
            // 
            this.BarnsContainer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BarnsContainer.AutoScroll = true;
            this.BarnsContainer.Location = new System.Drawing.Point(3, 33);
            this.BarnsContainer.Name = "BarnsContainer";
            this.BarnsContainer.Size = new System.Drawing.Size(874, 114);
            this.BarnsContainer.TabIndex = 1;
            // 
            // UcAssignBarns
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.BarnsContainer);
            this.Controls.Add(this.btnAddBarn);
            this.Name = "UcAssignBarns";
            this.Size = new System.Drawing.Size(880, 150);
            this.Load += new System.EventHandler(this.UcAssignBarns_Load);
            ((System.ComponentModel.ISupportInitialize)(this.btnAddBarn)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Telerik.WinControls.UI.RadButton btnAddBarn;
        private System.Windows.Forms.FlowLayoutPanel BarnsContainer;
    }
}
