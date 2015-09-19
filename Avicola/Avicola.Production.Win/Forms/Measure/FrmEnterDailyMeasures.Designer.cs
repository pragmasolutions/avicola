﻿namespace Avicola.Production.Win.Forms.Measure
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.lbCurrentStandard = new Telerik.WinControls.UI.RadLabel();
            this.btnShowStandardSelection = new Telerik.WinControls.UI.RadButton();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lbCurrentStandard)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnShowStandardSelection)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // ucLoadDailyMeasures
            // 
            this.ucLoadDailyMeasures.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucLoadDailyMeasures.IsDirty = false;
            this.ucLoadDailyMeasures.LoadDailyStandardMeasures = null;
            this.ucLoadDailyMeasures.Location = new System.Drawing.Point(3, 53);
            this.ucLoadDailyMeasures.Name = "ucLoadDailyMeasures";
            this.ucLoadDailyMeasures.Size = new System.Drawing.Size(1055, 416);
            this.ucLoadDailyMeasures.TabIndex = 0;
            this.ucLoadDailyMeasures.SaveClick += new System.EventHandler(this.ucLoadDailyMeasures_SaveClick);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.ucLoadDailyMeasures, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1061, 492);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 200F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 200F));
            this.tableLayoutPanel2.Controls.Add(this.lbCurrentStandard, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.btnShowStandardSelection, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1055, 44);
            this.tableLayoutPanel2.TabIndex = 4;
            // 
            // lbCurrentStandard
            // 
            this.lbCurrentStandard.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbCurrentStandard.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCurrentStandard.Location = new System.Drawing.Point(203, 3);
            this.lbCurrentStandard.Name = "lbCurrentStandard";
            this.lbCurrentStandard.Size = new System.Drawing.Size(278, 41);
            this.lbCurrentStandard.TabIndex = 2;
            this.lbCurrentStandard.Text = "{{Current Standard}}";
            // 
            // btnShowStandardSelection
            // 
            this.btnShowStandardSelection.Location = new System.Drawing.Point(3, 3);
            this.btnShowStandardSelection.Name = "btnShowStandardSelection";
            this.btnShowStandardSelection.Size = new System.Drawing.Size(177, 38);
            this.btnShowStandardSelection.TabIndex = 1;
            this.btnShowStandardSelection.Text = "Ir Seleccionar Indicador";
            this.btnShowStandardSelection.Click += new System.EventHandler(this.btnShowStandardSelection_Click);
            // 
            // FrmEnterDailyMeasures
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1061, 492);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmEnterDailyMeasures";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.Text = "FrmBatchSelection";
            this.Load += new System.EventHandler(this.FrmEnterDailyMeasures_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lbCurrentStandard)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnShowStandardSelection)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private UserControls.UcLoadDailyMeasures ucLoadDailyMeasures;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private Telerik.WinControls.UI.RadButton btnShowStandardSelection;
        private Telerik.WinControls.UI.RadLabel lbCurrentStandard;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;


    }
}
