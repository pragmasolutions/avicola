namespace Avicola.Production.Win.UserControls
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
            this.lbBirdsAmount = new Telerik.WinControls.UI.RadLabel();
            this.btnRemoveBarn = new Telerik.WinControls.UI.RadButton();
            this.txtInitialFood = new Telerik.WinControls.UI.RadSpinEditor();
            this.lbInitialFood = new Telerik.WinControls.UI.RadLabel();
            this.txtBirdsAmount = new Telerik.WinControls.UI.RadSpinEditor();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lbBarnName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radSeparator1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBarnCapacity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lbBirdsAmount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnRemoveBarn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtInitialFood)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lbInitialFood)).BeginInit();
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
            this.radSeparator1.Size = new System.Drawing.Size(563, 10);
            this.radSeparator1.TabIndex = 1;
            this.radSeparator1.Text = "radSeparator1";
            // 
            // radLabel2
            // 
            this.radLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radLabel2.Location = new System.Drawing.Point(27, 80);
            this.radLabel2.Name = "radLabel2";
            this.radLabel2.Size = new System.Drawing.Size(60, 16);
            this.radLabel2.TabIndex = 2;
            this.radLabel2.Text = "Capacidad";
            // 
            // txtBarnCapacity
            // 
            this.txtBarnCapacity.Location = new System.Drawing.Point(106, 76);
            this.txtBarnCapacity.Name = "txtBarnCapacity";
            this.txtBarnCapacity.Size = new System.Drawing.Size(100, 24);
            this.txtBarnCapacity.TabIndex = 3;
            // 
            // lbBirdsAmount
            // 
            this.lbBirdsAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbBirdsAmount.Location = new System.Drawing.Point(225, 80);
            this.lbBirdsAmount.Name = "lbBirdsAmount";
            this.lbBirdsAmount.Size = new System.Drawing.Size(121, 16);
            this.lbBirdsAmount.TabIndex = 4;
            this.lbBirdsAmount.Text = "Cantidad Aves Ingreso";
            // 
            // btnRemoveBarn
            // 
            this.btnRemoveBarn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRemoveBarn.BackColor = System.Drawing.Color.Transparent;
            this.btnRemoveBarn.Image = global::Avicola.Production.Win.Properties.Resources.Remove;
            this.btnRemoveBarn.ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnRemoveBarn.Location = new System.Drawing.Point(738, 26);
            this.btnRemoveBarn.Name = "btnRemoveBarn";
            this.btnRemoveBarn.Size = new System.Drawing.Size(43, 24);
            this.btnRemoveBarn.TabIndex = 6;
            this.btnRemoveBarn.Text = "X";
            this.btnRemoveBarn.TextAlignment = System.Drawing.ContentAlignment.TopCenter;
            this.btnRemoveBarn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnRemoveBarn.Click += new System.EventHandler(this.btnRemoveBarn_Click);
            ((Telerik.WinControls.UI.RadButtonElement)(this.btnRemoveBarn.GetChildAt(0))).Image = global::Avicola.Production.Win.Properties.Resources.Remove;
            ((Telerik.WinControls.UI.RadButtonElement)(this.btnRemoveBarn.GetChildAt(0))).TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            ((Telerik.WinControls.UI.RadButtonElement)(this.btnRemoveBarn.GetChildAt(0))).ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            ((Telerik.WinControls.UI.RadButtonElement)(this.btnRemoveBarn.GetChildAt(0))).TextAlignment = System.Drawing.ContentAlignment.TopCenter;
            ((Telerik.WinControls.UI.RadButtonElement)(this.btnRemoveBarn.GetChildAt(0))).Text = "X";
            ((Telerik.WinControls.Primitives.BorderPrimitive)(this.btnRemoveBarn.GetChildAt(0).GetChildAt(2))).Width = 0F;
            ((Telerik.WinControls.Primitives.BorderPrimitive)(this.btnRemoveBarn.GetChildAt(0).GetChildAt(2))).LeftWidth = 0F;
            ((Telerik.WinControls.Primitives.BorderPrimitive)(this.btnRemoveBarn.GetChildAt(0).GetChildAt(2))).TopWidth = 0F;
            ((Telerik.WinControls.Primitives.BorderPrimitive)(this.btnRemoveBarn.GetChildAt(0).GetChildAt(2))).RightWidth = 0F;
            ((Telerik.WinControls.Primitives.BorderPrimitive)(this.btnRemoveBarn.GetChildAt(0).GetChildAt(2))).BottomWidth = 0F;
            ((Telerik.WinControls.Primitives.BorderPrimitive)(this.btnRemoveBarn.GetChildAt(0).GetChildAt(2))).SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighSpeed;
            // 
            // txtInitialFood
            // 
            this.txtInitialFood.DecimalPlaces = 2;
            this.txtInitialFood.Location = new System.Drawing.Point(628, 76);
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
            // lbInitialFood
            // 
            this.lbInitialFood.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbInitialFood.Location = new System.Drawing.Point(503, 81);
            this.lbInitialFood.Margin = new System.Windows.Forms.Padding(2);
            this.lbInitialFood.Name = "lbInitialFood";
            this.lbInitialFood.Size = new System.Drawing.Size(105, 16);
            this.lbInitialFood.TabIndex = 94;
            this.lbInitialFood.Text = "Alimento Inicial (kg)";
            this.lbInitialFood.ThemeName = "TelerikMetroBlue";
            // 
            // txtBirdsAmount
            // 
            this.txtBirdsAmount.Location = new System.Drawing.Point(365, 76);
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
            this.Controls.Add(this.lbInitialFood);
            this.Controls.Add(this.txtBarnCapacity);
            this.Controls.Add(this.lbBirdsAmount);
            this.Controls.Add(this.radLabel2);
            this.Controls.Add(this.radSeparator1);
            this.Controls.Add(this.lbBarnName);
            this.Name = "UcBarnAssigned";
            this.Size = new System.Drawing.Size(795, 121);
            ((System.ComponentModel.ISupportInitialize)(this.ErrorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lbBarnName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radSeparator1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBarnCapacity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lbBirdsAmount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnRemoveBarn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtInitialFood)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lbInitialFood)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBirdsAmount)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Telerik.WinControls.UI.RadLabel lbBarnName;
        private Telerik.WinControls.UI.RadSeparator radSeparator1;
        private Telerik.WinControls.UI.RadLabel radLabel2;
        private Telerik.WinControls.UI.RadTextBox txtBarnCapacity;
        private Telerik.WinControls.UI.RadLabel lbBirdsAmount;
        private Telerik.WinControls.UI.RadButton btnRemoveBarn;
        private Telerik.WinControls.UI.RadSpinEditor txtInitialFood;
        private Telerik.WinControls.UI.RadLabel lbInitialFood;
        private Telerik.WinControls.UI.RadSpinEditor txtBirdsAmount;
    }
}
