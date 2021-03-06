﻿namespace Avicola.Production.Win.Forms.Measure
{
    partial class FrmEnterWeeklyMeasures
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.ucLoadWeeklyMeasures = new Avicola.Production.Win.UserControls.UcLoadWeeklyMeasures(_stateController);
            this.lbCurrentStandard = new Telerik.WinControls.UI.RadLabel();
            this.btnShowStandardSelection = new Telerik.WinControls.UI.RadButton();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lbCurrentStandard)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnShowStandardSelection)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.ucLoadWeeklyMeasures, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1061, 492);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // ucLoadWeeklyMeasures
            // 
            this.ucLoadWeeklyMeasures.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucLoadWeeklyMeasures.IsDirty = false;
            this.ucLoadWeeklyMeasures.LoadWeeklyStandardMeasures = null;
            this.ucLoadWeeklyMeasures.Location = new System.Drawing.Point(3, 53);
            this.ucLoadWeeklyMeasures.MeasureValue = null;
            this.ucLoadWeeklyMeasures.Name = "ucLoadWeeklyMeasures";
            this.ucLoadWeeklyMeasures.Size = new System.Drawing.Size(1055, 436);
            this.ucLoadWeeklyMeasures.TabIndex = 2;
            this.ucLoadWeeklyMeasures.SaveClick += new System.EventHandler(this.ucLoadWeeklyMeasures_SaveClick);
            // 
            // lbCurrentStandard
            // 
            this.lbCurrentStandard.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbCurrentStandard.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCurrentStandard.Location = new System.Drawing.Point(203, 3);
            this.lbCurrentStandard.Name = "lbCurrentStandard";
            this.lbCurrentStandard.Size = new System.Drawing.Size(849, 38);
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
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 200F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 855F));
            this.tableLayoutPanel2.Controls.Add(this.btnShowStandardSelection, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.lbCurrentStandard, 1, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1055, 44);
            this.tableLayoutPanel2.TabIndex = 5;
            // 
            // FrmEnterWeeklyMeasures
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1061, 492);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmEnterWeeklyMeasures";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.Text = "FrmBatchSelection";
            this.Load += new System.EventHandler(this.FrmEnterDailyMeasures_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.lbCurrentStandard)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnShowStandardSelection)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private UserControls.UcLoadWeeklyMeasures ucLoadWeeklyMeasures;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private Telerik.WinControls.UI.RadButton btnShowStandardSelection;
        private Telerik.WinControls.UI.RadLabel lbCurrentStandard;


    }
}
