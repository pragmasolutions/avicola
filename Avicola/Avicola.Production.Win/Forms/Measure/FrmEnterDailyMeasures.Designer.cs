namespace Avicola.Production.Win.Forms.Measure
{
    partial class FrmEnterDailyMeasures
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
            this.ucLoadDailyMeasures = new Avicola.Production.Win.UserControls.UcLoadDailyMeasures();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // ucLoadDailyMeasures
            // 
            this.ucLoadDailyMeasures.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucLoadDailyMeasures.LoadDailyStandardMeasures = null;
            this.ucLoadDailyMeasures.Location = new System.Drawing.Point(0, 0);
            this.ucLoadDailyMeasures.Name = "ucLoadDailyMeasures";
            this.ucLoadDailyMeasures.Size = new System.Drawing.Size(1061, 492);
            this.ucLoadDailyMeasures.TabIndex = 0;
            this.ucLoadDailyMeasures.SaveClick += new System.EventHandler(this.ucLoadDailyMeasures_SaveClick);
            // 
            // FrmEnterDailyMeasures
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1061, 492);
            this.Controls.Add(this.ucLoadDailyMeasures);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmEnterDailyMeasures";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.Text = "FrmBatchSelection";
            this.Load += new System.EventHandler(this.FrmEnterDailyMeasures_Load);
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private UserControls.UcLoadDailyMeasures ucLoadDailyMeasures;


    }
}
