namespace Avicola.Production.Win.Forms.Standards
{
    partial class FrmStandardSelection
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
            this.lbBatchTitle = new System.Windows.Forms.Label();
            this.ucStandardSelecction = new Avicola.Production.Win.UserControls.UcStandardSelecction();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // lbBatchTitle
            // 
            this.lbBatchTitle.AutoSize = true;
            this.lbBatchTitle.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbBatchTitle.Location = new System.Drawing.Point(12, 24);
            this.lbBatchTitle.Name = "lbBatchTitle";
            this.lbBatchTitle.Size = new System.Drawing.Size(155, 32);
            this.lbBatchTitle.TabIndex = 12;
            this.lbBatchTitle.Text = "{{Batch Title}}";
            // 
            // ucStandardSelecction
            // 
            this.ucStandardSelecction.Location = new System.Drawing.Point(18, 75);
            this.ucStandardSelecction.Name = "ucStandardSelecction";
            this.ucStandardSelecction.Size = new System.Drawing.Size(984, 403);
            this.ucStandardSelecction.TabIndex = 13;
            this.ucStandardSelecction.StandardSelected += new System.EventHandler<Avicola.Office.Entities.Standard>(this.ucStandardSelecction_StandardSelected);
            // 
            // FrmStandardSelection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1024, 501);
            this.Controls.Add(this.ucStandardSelecction);
            this.Controls.Add(this.lbBatchTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmStandardSelection";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.Text = "FrmBatchSelection";
            this.Load += new System.EventHandler(this.FrmBatchManager_Load);
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbBatchTitle;
        private UserControls.UcStandardSelecction ucStandardSelecction;


    }
}
