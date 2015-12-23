namespace Avicola.Deposit.Win.UserControls
{
    partial class UcClassificationEggClassEditor
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
            this.txtAmount = new Framework.Common.Win.Controls.CustomSpinEditor();
            this.lbClassName = new Telerik.WinControls.UI.RadLabel();
            this.ddlEggEquivalences = new Telerik.WinControls.UI.RadDropDownList();
            this.btnCalculateEggsAmount = new Telerik.WinControls.UI.RadButton();
            ((System.ComponentModel.ISupportInitialize)(this.txtAmount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lbClassName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ddlEggEquivalences)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCalculateEggsAmount)).BeginInit();
            this.SuspendLayout();
            // 
            // txtAmount
            // 
            this.txtAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAmount.Location = new System.Drawing.Point(85, 3);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.NullableValue = null;
            this.txtAmount.Size = new System.Drawing.Size(148, 25);
            this.txtAmount.TabIndex = 0;
            this.txtAmount.TabStop = false;
            // 
            // lbClassName
            // 
            this.lbClassName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbClassName.Location = new System.Drawing.Point(3, 5);
            this.lbClassName.Name = "lbClassName";
            this.lbClassName.Size = new System.Drawing.Size(58, 21);
            this.lbClassName.TabIndex = 3;
            this.lbClassName.Text = "{{ B1 }}";
            // 
            // ddlEggEquivalences
            // 
            this.ddlEggEquivalences.DropDownStyle = Telerik.WinControls.RadDropDownStyle.DropDownList;
            this.ddlEggEquivalences.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ddlEggEquivalences.Location = new System.Drawing.Point(240, 3);
            this.ddlEggEquivalences.Name = "ddlEggEquivalences";
            this.ddlEggEquivalences.Size = new System.Drawing.Size(125, 25);
            this.ddlEggEquivalences.TabIndex = 4;
            // 
            // btnCalculateEggsAmount
            // 
            this.btnCalculateEggsAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalculateEggsAmount.Image = global::Avicola.Deposit.Win.Properties.Resources.calculator_20x20;
            this.btnCalculateEggsAmount.ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnCalculateEggsAmount.Location = new System.Drawing.Point(371, 3);
            this.btnCalculateEggsAmount.Name = "btnCalculateEggsAmount";
            this.btnCalculateEggsAmount.Size = new System.Drawing.Size(29, 24);
            this.btnCalculateEggsAmount.TabIndex = 5;
            this.btnCalculateEggsAmount.Click += new System.EventHandler(this.btnCalculateEggsAmount_Click);
            // 
            // UcClassificationEggClassEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnCalculateEggsAmount);
            this.Controls.Add(this.ddlEggEquivalences);
            this.Controls.Add(this.lbClassName);
            this.Controls.Add(this.txtAmount);
            this.Name = "UcClassificationEggClassEditor";
            this.Size = new System.Drawing.Size(408, 30);
            ((System.ComponentModel.ISupportInitialize)(this.txtAmount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lbClassName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ddlEggEquivalences)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCalculateEggsAmount)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Framework.Common.Win.Controls.CustomSpinEditor txtAmount;
        private Telerik.WinControls.UI.RadLabel lbClassName;
        private Telerik.WinControls.UI.RadDropDownList ddlEggEquivalences;
        private Telerik.WinControls.UI.RadButton btnCalculateEggsAmount;
    }
}
