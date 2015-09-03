namespace Avicola.Production.Win.Forms.Measure
{
    partial class FrmCreateMeasureWizard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCreateMeasureWizard));
            this.radWizard1 = new Telerik.WinControls.UI.RadWizard();
            this.wizardPage1 = new Telerik.WinControls.UI.WizardPage();
            this.panel2 = new System.Windows.Forms.Panel();
            this.wizardCompletionPage1 = new Telerik.WinControls.UI.WizardCompletionPage();
            this.panel3 = new System.Windows.Forms.Panel();
            this.wizardPage2 = new Telerik.WinControls.UI.WizardPage();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.radWizard1)).BeginInit();
            this.radWizard1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // radWizard1
            // 
            this.radWizard1.CompletionPage = this.wizardCompletionPage1;
            this.radWizard1.Controls.Add(this.panel2);
            this.radWizard1.Controls.Add(this.panel3);
            this.radWizard1.Controls.Add(this.panel1);
            this.radWizard1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.radWizard1.Location = new System.Drawing.Point(0, 0);
            this.radWizard1.Name = "radWizard1";
            this.radWizard1.PageHeaderIcon = ((System.Drawing.Image)(resources.GetObject("radWizard1.PageHeaderIcon")));
            this.radWizard1.Pages.Add(this.wizardPage1);
            this.radWizard1.Pages.Add(this.wizardPage2);
            this.radWizard1.Pages.Add(this.wizardCompletionPage1);
            this.radWizard1.Size = new System.Drawing.Size(1030, 547);
            this.radWizard1.TabIndex = 0;
            this.radWizard1.Text = "radWizard1";
            this.radWizard1.WelcomePage = null;
            // 
            // wizardPage1
            // 
            this.wizardPage1.ContentArea = this.panel2;
            this.wizardPage1.Name = "wizardPage1";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Location = new System.Drawing.Point(0, 81);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1030, 418);
            this.panel2.TabIndex = 1;
            // 
            // wizardCompletionPage1
            // 
            this.wizardCompletionPage1.ContentArea = this.panel3;
            this.wizardCompletionPage1.Name = "wizardCompletionPage1";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Location = new System.Drawing.Point(150, 56);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(880, 443);
            this.panel3.TabIndex = 2;
            // 
            // wizardPage2
            // 
            this.wizardPage2.ContentArea = this.panel1;
            this.wizardPage2.Header = "Page header";
            this.wizardPage2.Name = "wizardPage2";
            this.wizardPage2.Title = "Page title";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(0, 81);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1030, 418);
            this.panel1.TabIndex = 3;
            // 
            // FrmCreateMeasureWizard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1030, 547);
            this.Controls.Add(this.radWizard1);
            this.Name = "FrmCreateMeasureWizard";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.Text = "FrmCreateMeasureWizard";
            ((System.ComponentModel.ISupportInitialize)(this.radWizard1)).EndInit();
            this.radWizard1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Telerik.WinControls.UI.RadWizard radWizard1;
        private Telerik.WinControls.UI.WizardCompletionPage wizardCompletionPage1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private Telerik.WinControls.UI.WizardPage wizardPage1;
        private Telerik.WinControls.UI.WizardPage wizardPage2;
    }
}
