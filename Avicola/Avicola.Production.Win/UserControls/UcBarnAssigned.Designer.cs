﻿namespace Avicola.Production.Win.UserControls
{
    partial class UcBarnAssigned
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
            this.lbBarnName = new Telerik.WinControls.UI.RadLabel();
            this.radSeparator1 = new Telerik.WinControls.UI.RadSeparator();
            this.radLabel2 = new Telerik.WinControls.UI.RadLabel();
            this.txtBarnCapacity = new Telerik.WinControls.UI.RadTextBox();
            this.radLabel3 = new Telerik.WinControls.UI.RadLabel();
            this.btnRemoveBarn = new Telerik.WinControls.UI.RadButton();
            this.txtInitialFood = new Telerik.WinControls.UI.RadSpinEditor();
            this.radLabel1 = new Telerik.WinControls.UI.RadLabel();
            this.txtBirdsAmount = new Telerik.WinControls.UI.RadSpinEditor();
            ((System.ComponentModel.ISupportInitialize)(this.lbBarnName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radSeparator1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBarnCapacity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnRemoveBarn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtInitialFood)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBirdsAmount)).BeginInit();
            this.SuspendLayout();
            // 
            // lbBarnName
            // 
            this.lbBarnName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbBarnName.Location = new System.Drawing.Point(18, 26);
            this.lbBarnName.Name = "lbBarnName";
            this.lbBarnName.Size = new System.Drawing.Size(134, 26);
            this.lbBarnName.TabIndex = 0;
            this.lbBarnName.Text = "{{Barn Name}}";
            // 
            // radSeparator1
            // 
            this.radSeparator1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.radSeparator1.Location = new System.Drawing.Point(158, 36);
            this.radSeparator1.Name = "radSeparator1";
            this.radSeparator1.ShowShadow = false;
            this.radSeparator1.Size = new System.Drawing.Size(476, 10);
            this.radSeparator1.TabIndex = 1;
            this.radSeparator1.Text = "radSeparator1";
            // 
            // radLabel2
            // 
            this.radLabel2.Location = new System.Drawing.Point(27, 80);
            this.radLabel2.Name = "radLabel2";
            this.radLabel2.Size = new System.Drawing.Size(60, 16);
            this.radLabel2.TabIndex = 2;
            this.radLabel2.Text = "Capacidad";
            // 
            // txtBarnCapacity
            // 
            this.txtBarnCapacity.Location = new System.Drawing.Point(97, 76);
            this.txtBarnCapacity.Name = "txtBarnCapacity";
            this.txtBarnCapacity.Size = new System.Drawing.Size(100, 24);
            this.txtBarnCapacity.TabIndex = 3;
            // 
            // radLabel3
            // 
            this.radLabel3.Location = new System.Drawing.Point(207, 80);
            this.radLabel3.Name = "radLabel3";
            this.radLabel3.Size = new System.Drawing.Size(121, 16);
            this.radLabel3.TabIndex = 4;
            this.radLabel3.Text = "Cantidad Aves Ingreso";
            // 
            // btnRemoveBarn
            // 
            this.btnRemoveBarn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRemoveBarn.Location = new System.Drawing.Point(662, 26);
            this.btnRemoveBarn.Name = "btnRemoveBarn";
            this.btnRemoveBarn.Size = new System.Drawing.Size(43, 24);
            this.btnRemoveBarn.TabIndex = 6;
            this.btnRemoveBarn.Text = "X";
            this.btnRemoveBarn.Click += new System.EventHandler(this.btnRemoveBarn_Click);
            // 
            // txtInitialFood
            // 
            this.txtInitialFood.DecimalPlaces = 2;
            this.txtInitialFood.Location = new System.Drawing.Point(583, 76);
            this.txtInitialFood.Margin = new System.Windows.Forms.Padding(2);
            this.txtInitialFood.Maximum = new decimal(new int[] {
            100000000,
            0,
            0,
            0});
            this.txtInitialFood.Name = "txtInitialFood";
            this.txtInitialFood.Size = new System.Drawing.Size(119, 24);
            this.txtInitialFood.TabIndex = 95;
            this.txtInitialFood.TabStop = false;
            // 
            // radLabel1
            // 
            this.radLabel1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radLabel1.Location = new System.Drawing.Point(467, 79);
            this.radLabel1.Margin = new System.Windows.Forms.Padding(2);
            this.radLabel1.Name = "radLabel1";
            this.radLabel1.Size = new System.Drawing.Size(106, 18);
            this.radLabel1.TabIndex = 94;
            this.radLabel1.Text = "Alimento Inicial (kg)";
            this.radLabel1.ThemeName = "TelerikMetroBlue";
            // 
            // txtBirdsAmount
            // 
            this.txtBirdsAmount.Location = new System.Drawing.Point(338, 76);
            this.txtBirdsAmount.Margin = new System.Windows.Forms.Padding(2);
            this.txtBirdsAmount.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.txtBirdsAmount.Name = "txtBirdsAmount";
            this.txtBirdsAmount.Size = new System.Drawing.Size(119, 24);
            this.txtBirdsAmount.TabIndex = 96;
            this.txtBirdsAmount.TabStop = false;
            // 
            // UcBarnAssigned
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.txtBirdsAmount);
            this.Controls.Add(this.txtInitialFood);
            this.Controls.Add(this.btnRemoveBarn);
            this.Controls.Add(this.radLabel1);
            this.Controls.Add(this.txtBarnCapacity);
            this.Controls.Add(this.radLabel3);
            this.Controls.Add(this.radLabel2);
            this.Controls.Add(this.radSeparator1);
            this.Controls.Add(this.lbBarnName);
            this.Name = "UcBarnAssigned";
            this.Size = new System.Drawing.Size(719, 121);
            ((System.ComponentModel.ISupportInitialize)(this.lbBarnName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radSeparator1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBarnCapacity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnRemoveBarn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtInitialFood)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBirdsAmount)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Telerik.WinControls.UI.RadLabel lbBarnName;
        private Telerik.WinControls.UI.RadSeparator radSeparator1;
        private Telerik.WinControls.UI.RadLabel radLabel2;
        private Telerik.WinControls.UI.RadTextBox txtBarnCapacity;
        private Telerik.WinControls.UI.RadLabel radLabel3;
        private Telerik.WinControls.UI.RadButton btnRemoveBarn;
        private Telerik.WinControls.UI.RadSpinEditor txtInitialFood;
        private Telerik.WinControls.UI.RadLabel radLabel1;
        private Telerik.WinControls.UI.RadSpinEditor txtBirdsAmount;
    }
}