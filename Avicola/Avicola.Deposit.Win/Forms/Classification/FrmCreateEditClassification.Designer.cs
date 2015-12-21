namespace Avicola.Deposit.Win.Forms
{
    partial class FrmCreateEditClassification
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
            this.btnSave = new Telerik.WinControls.UI.RadButton();
            this.btnCancel = new Telerik.WinControls.UI.RadButton();
            this.radGroupBox1 = new Telerik.WinControls.UI.RadGroupBox();
            this.ClassificationEggClassesesContainer = new System.Windows.Forms.FlowLayoutPanel();
            this.radLabel1 = new Telerik.WinControls.UI.RadLabel();
            this.dpClassificationDate = new Telerik.WinControls.UI.RadDateTimePicker();
            this.lbTitle = new Telerik.WinControls.UI.RadLabel();
            ((System.ComponentModel.ISupportInitialize)(this.btnSave)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCancel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox1)).BeginInit();
            this.radGroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dpClassificationDate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lbTitle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(805, 454);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(110, 24);
            this.btnSave.TabIndex = 1;
            this.btnSave.Text = "Guardar";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(921, 454);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(110, 24);
            this.btnCancel.TabIndex = 0;
            this.btnCancel.Text = "Cancelar";
            // 
            // radGroupBox1
            // 
            this.radGroupBox1.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping;
            this.radGroupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.radGroupBox1.Controls.Add(this.ClassificationEggClassesesContainer);
            this.radGroupBox1.HeaderText = "Distribución";
            this.radGroupBox1.Location = new System.Drawing.Point(15, 115);
            this.radGroupBox1.Name = "radGroupBox1";
            this.radGroupBox1.Size = new System.Drawing.Size(1011, 314);
            this.radGroupBox1.TabIndex = 16;
            this.radGroupBox1.Text = "Distribución";
            ((Telerik.WinControls.Primitives.TextPrimitive)(this.radGroupBox1.GetChildAt(0).GetChildAt(1).GetChildAt(2).GetChildAt(1))).Text = "Distribución";
            ((Telerik.WinControls.Primitives.TextPrimitive)(this.radGroupBox1.GetChildAt(0).GetChildAt(1).GetChildAt(2).GetChildAt(1))).Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            ((Telerik.WinControls.Primitives.TextPrimitive)(this.radGroupBox1.GetChildAt(0).GetChildAt(1).GetChildAt(2).GetChildAt(1))).Alignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ClassificationEggClassesesContainer
            // 
            this.ClassificationEggClassesesContainer.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ClassificationEggClassesesContainer.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.ClassificationEggClassesesContainer.Location = new System.Drawing.Point(5, 21);
            this.ClassificationEggClassesesContainer.Name = "ClassificationEggClassesesContainer";
            this.ClassificationEggClassesesContainer.Size = new System.Drawing.Size(1002, 288);
            this.ClassificationEggClassesesContainer.TabIndex = 0;
            // 
            // radLabel1
            // 
            this.radLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radLabel1.Location = new System.Drawing.Point(15, 59);
            this.radLabel1.Name = "radLabel1";
            this.radLabel1.Size = new System.Drawing.Size(50, 21);
            this.radLabel1.TabIndex = 1;
            this.radLabel1.Text = "Fecha";
            // 
            // dpClassificationDate
            // 
            this.dpClassificationDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dpClassificationDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dpClassificationDate.Location = new System.Drawing.Point(20, 84);
            this.dpClassificationDate.Name = "dpClassificationDate";
            this.dpClassificationDate.Size = new System.Drawing.Size(103, 25);
            this.dpClassificationDate.TabIndex = 15;
            this.dpClassificationDate.TabStop = false;
            this.dpClassificationDate.Text = "18/12/2015";
            this.dpClassificationDate.Value = new System.DateTime(2015, 12, 18, 18, 9, 16, 211);
            // 
            // lbTitle
            // 
            this.lbTitle.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitle.Location = new System.Drawing.Point(12, 12);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(301, 41);
            this.lbTitle.TabIndex = 14;
            this.lbTitle.Text = "{{Create Or Edit Title}}";
            // 
            // FrmCreateEditClassification
            // 
            this.AcceptButton = this.btnSave;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(1043, 490);
            this.Controls.Add(this.radGroupBox1);
            this.Controls.Add(this.radLabel1);
            this.Controls.Add(this.dpClassificationDate);
            this.Controls.Add(this.lbTitle);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnCancel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "FrmCreateEditClassification";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "{{Create Or Edit Title}}";
            this.Load += new System.EventHandler(this.FrmCreateEditClassification_Load);
            ((System.ComponentModel.ISupportInitialize)(this.btnSave)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCancel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox1)).EndInit();
            this.radGroupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dpClassificationDate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lbTitle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Telerik.WinControls.UI.RadButton btnCancel;
        private Telerik.WinControls.UI.RadButton btnSave;
        private Telerik.WinControls.UI.RadLabel lbTitle;
        private Telerik.WinControls.UI.RadDateTimePicker dpClassificationDate;
        private Telerik.WinControls.UI.RadLabel radLabel1;
        private Telerik.WinControls.UI.RadGroupBox radGroupBox1;
        private System.Windows.Forms.FlowLayoutPanel ClassificationEggClassesesContainer;
    }
}
