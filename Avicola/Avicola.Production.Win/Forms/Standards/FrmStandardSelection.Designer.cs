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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.btnShowBatchManagerView = new Telerik.WinControls.UI.RadButton();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnShowBatchManagerView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // lbBatchTitle
            // 
            this.lbBatchTitle.AutoSize = true;
            this.lbBatchTitle.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbBatchTitle.Location = new System.Drawing.Point(203, 0);
            this.lbBatchTitle.Name = "lbBatchTitle";
            this.lbBatchTitle.Size = new System.Drawing.Size(194, 37);
            this.lbBatchTitle.TabIndex = 12;
            this.lbBatchTitle.Text = "{{Batch Title}}";
            // 
            // ucStandardSelecction
            // 
            this.ucStandardSelecction.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucStandardSelecction.Location = new System.Drawing.Point(3, 53);
            this.ucStandardSelecction.Name = "ucStandardSelecction";
            this.ucStandardSelecction.Size = new System.Drawing.Size(1018, 445);
            this.ucStandardSelecction.TabIndex = 13;
            this.ucStandardSelecction.StandardSelected += new System.EventHandler<Avicola.Office.Entities.Standard>(this.ucStandardSelecction_StandardSelected);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.ucStandardSelecction, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 90F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1024, 501);
            this.tableLayoutPanel1.TabIndex = 14;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 200F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 855F));
            this.tableLayoutPanel3.Controls.Add(this.btnShowBatchManagerView, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.lbBatchTitle, 1, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(1018, 44);
            this.tableLayoutPanel3.TabIndex = 15;
            // 
            // btnShowBatchManagerView
            // 
            this.btnShowBatchManagerView.Location = new System.Drawing.Point(3, 3);
            this.btnShowBatchManagerView.Name = "btnShowBatchManagerView";
            this.btnShowBatchManagerView.Size = new System.Drawing.Size(177, 36);
            this.btnShowBatchManagerView.TabIndex = 1;
            this.btnShowBatchManagerView.Text = "Ir a Detalle del Lote";
            this.btnShowBatchManagerView.Click += new System.EventHandler(this.btnShowBatchManagerView_Click);
            // 
            // FrmStandardSelection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1024, 501);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmStandardSelection";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.Text = "FrmBatchSelection";
            this.Load += new System.EventHandler(this.FrmBatchManager_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnShowBatchManagerView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbBatchTitle;
        private UserControls.UcStandardSelecction ucStandardSelecction;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private Telerik.WinControls.UI.RadButton btnShowBatchManagerView;


    }
}
