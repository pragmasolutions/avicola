﻿namespace Avicola.Production.Win.Forms.Batchs
{
    partial class FrmBatchManager
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmBatchManager));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.btnShowBatchSelectionView = new Telerik.WinControls.UI.RadButton();
            this.lbBatchTitle = new System.Windows.Forms.Label();
            this.radPanel1 = new Telerik.WinControls.UI.RadPanel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtFechaIngresoGalpon = new System.Windows.Forms.TextBox();
            this.txtGalpon = new System.Windows.Forms.TextBox();
            this.txtSemanaActual = new System.Windows.Forms.TextBox();
            this.txtEtapa = new System.Windows.Forms.TextBox();
            this.txtLineaGenetica = new System.Windows.Forms.TextBox();
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnEliminarLote = new System.Windows.Forms.Button();
            this.btnEndBatch = new System.Windows.Forms.Button();
            this.btnGalpon = new System.Windows.Forms.Button();
            this.btnObservaciones = new System.Windows.Forms.Button();
            this.btnVacunas = new System.Windows.Forms.Button();
            this.btnEstandares = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnShowBatchSelectionView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radPanel1)).BeginInit();
            this.radPanel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.radPanel1, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 90F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1029, 688);
            this.tableLayoutPanel1.TabIndex = 13;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 200F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 855F));
            this.tableLayoutPanel3.Controls.Add(this.btnShowBatchSelectionView, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.lbBatchTitle, 1, 0);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(1018, 44);
            this.tableLayoutPanel3.TabIndex = 16;
            // 
            // btnShowBatchSelectionView
            // 
            this.btnShowBatchSelectionView.Location = new System.Drawing.Point(3, 3);
            this.btnShowBatchSelectionView.Name = "btnShowBatchSelectionView";
            this.btnShowBatchSelectionView.Size = new System.Drawing.Size(177, 36);
            this.btnShowBatchSelectionView.TabIndex = 1;
            this.btnShowBatchSelectionView.Text = "Ir a Selección de Lote";
            this.btnShowBatchSelectionView.Click += new System.EventHandler(this.btnShowBatchSelectionView_Click);
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
            // radPanel1
            // 
            this.radPanel1.Controls.Add(this.groupBox2);
            this.radPanel1.Controls.Add(this.groupBox1);
            this.radPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.radPanel1.Location = new System.Drawing.Point(3, 71);
            this.radPanel1.Name = "radPanel1";
            this.radPanel1.Size = new System.Drawing.Size(1023, 614);
            this.radPanel1.TabIndex = 14;
            ((Telerik.WinControls.Primitives.BorderPrimitive)(this.radPanel1.GetChildAt(0).GetChildAt(1))).Visibility = Telerik.WinControls.ElementVisibility.Collapsed;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtFechaIngresoGalpon);
            this.groupBox2.Controls.Add(this.txtGalpon);
            this.groupBox2.Controls.Add(this.txtSemanaActual);
            this.groupBox2.Controls.Add(this.txtEtapa);
            this.groupBox2.Controls.Add(this.txtLineaGenetica);
            this.groupBox2.Controls.Add(this.txtNumero);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(3, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1000, 222);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Detall de lote";
            // 
            // txtFechaIngresoGalpon
            // 
            this.txtFechaIngresoGalpon.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFechaIngresoGalpon.Location = new System.Drawing.Point(643, 153);
            this.txtFechaIngresoGalpon.Name = "txtFechaIngresoGalpon";
            this.txtFechaIngresoGalpon.ReadOnly = true;
            this.txtFechaIngresoGalpon.Size = new System.Drawing.Size(205, 33);
            this.txtFechaIngresoGalpon.TabIndex = 11;
            // 
            // txtGalpon
            // 
            this.txtGalpon.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGalpon.Location = new System.Drawing.Point(643, 65);
            this.txtGalpon.Name = "txtGalpon";
            this.txtGalpon.ReadOnly = true;
            this.txtGalpon.Size = new System.Drawing.Size(205, 33);
            this.txtGalpon.TabIndex = 10;
            // 
            // txtSemanaActual
            // 
            this.txtSemanaActual.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSemanaActual.Location = new System.Drawing.Point(358, 153);
            this.txtSemanaActual.Name = "txtSemanaActual";
            this.txtSemanaActual.ReadOnly = true;
            this.txtSemanaActual.Size = new System.Drawing.Size(205, 33);
            this.txtSemanaActual.TabIndex = 9;
            // 
            // txtEtapa
            // 
            this.txtEtapa.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEtapa.Location = new System.Drawing.Point(358, 65);
            this.txtEtapa.Name = "txtEtapa";
            this.txtEtapa.ReadOnly = true;
            this.txtEtapa.Size = new System.Drawing.Size(205, 33);
            this.txtEtapa.TabIndex = 8;
            // 
            // txtLineaGenetica
            // 
            this.txtLineaGenetica.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLineaGenetica.Location = new System.Drawing.Point(39, 153);
            this.txtLineaGenetica.Name = "txtLineaGenetica";
            this.txtLineaGenetica.ReadOnly = true;
            this.txtLineaGenetica.Size = new System.Drawing.Size(205, 33);
            this.txtLineaGenetica.TabIndex = 7;
            // 
            // txtNumero
            // 
            this.txtNumero.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumero.Location = new System.Drawing.Point(39, 65);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.ReadOnly = true;
            this.txtNumero.Size = new System.Drawing.Size(205, 33);
            this.txtNumero.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(354, 37);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 25);
            this.label6.TabIndex = 5;
            this.label6.Text = "Etapa";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(639, 126);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(208, 25);
            this.label5.TabIndex = 4;
            this.label5.Text = "Fecha ingreso a galpón";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(354, 126);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(137, 25);
            this.label4.TabIndex = 3;
            this.label4.Text = "Semana Actual";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(639, 37);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Galpón";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(35, 126);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(136, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Línea Genética";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(35, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Número";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnEliminarLote);
            this.groupBox1.Controls.Add(this.btnEndBatch);
            this.groupBox1.Controls.Add(this.btnGalpon);
            this.groupBox1.Controls.Add(this.btnObservaciones);
            this.groupBox1.Controls.Add(this.btnVacunas);
            this.groupBox1.Controls.Add(this.btnEstandares);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(3, 231);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1000, 364);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Operación";
            // 
            // btnEliminarLote
            // 
            this.btnEliminarLote.Image = ((System.Drawing.Image)(resources.GetObject("btnEliminarLote.Image")));
            this.btnEliminarLote.Location = new System.Drawing.Point(280, 198);
            this.btnEliminarLote.Name = "btnEliminarLote";
            this.btnEliminarLote.Size = new System.Drawing.Size(230, 159);
            this.btnEliminarLote.TabIndex = 13;
            this.btnEliminarLote.Text = "Eliminar lote";
            this.btnEliminarLote.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnEliminarLote.UseVisualStyleBackColor = true;
            this.btnEliminarLote.Click += new System.EventHandler(this.btnEliminarLote_Click);
            // 
            // btnEndBatch
            // 
            this.btnEndBatch.Image = ((System.Drawing.Image)(resources.GetObject("btnEndBatch.Image")));
            this.btnEndBatch.Location = new System.Drawing.Point(39, 198);
            this.btnEndBatch.Name = "btnEndBatch";
            this.btnEndBatch.Size = new System.Drawing.Size(230, 159);
            this.btnEndBatch.TabIndex = 12;
            this.btnEndBatch.Text = "Finalizar lote";
            this.btnEndBatch.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnEndBatch.UseVisualStyleBackColor = true;
            this.btnEndBatch.Click += new System.EventHandler(this.btnEndBatch_Click);
            // 
            // btnGalpon
            // 
            this.btnGalpon.Image = ((System.Drawing.Image)(resources.GetObject("btnGalpon.Image")));
            this.btnGalpon.Location = new System.Drawing.Point(760, 25);
            this.btnGalpon.Name = "btnGalpon";
            this.btnGalpon.Size = new System.Drawing.Size(230, 159);
            this.btnGalpon.TabIndex = 11;
            this.btnGalpon.Text = "Asignar galpón";
            this.btnGalpon.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnGalpon.UseVisualStyleBackColor = true;
            this.btnGalpon.Click += new System.EventHandler(this.btnGalpon_Click);
            // 
            // btnObservaciones
            // 
            this.btnObservaciones.Image = ((System.Drawing.Image)(resources.GetObject("btnObservaciones.Image")));
            this.btnObservaciones.Location = new System.Drawing.Point(519, 25);
            this.btnObservaciones.Name = "btnObservaciones";
            this.btnObservaciones.Size = new System.Drawing.Size(230, 159);
            this.btnObservaciones.TabIndex = 10;
            this.btnObservaciones.Text = "Registrar Observación";
            this.btnObservaciones.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnObservaciones.UseVisualStyleBackColor = true;
            this.btnObservaciones.Click += new System.EventHandler(this.btnObservaciones_Click);
            // 
            // btnVacunas
            // 
            this.btnVacunas.Image = ((System.Drawing.Image)(resources.GetObject("btnVacunas.Image")));
            this.btnVacunas.Location = new System.Drawing.Point(280, 25);
            this.btnVacunas.Name = "btnVacunas";
            this.btnVacunas.Size = new System.Drawing.Size(230, 159);
            this.btnVacunas.TabIndex = 9;
            this.btnVacunas.Text = "Registrar vacunación";
            this.btnVacunas.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnVacunas.UseVisualStyleBackColor = true;
            this.btnVacunas.Click += new System.EventHandler(this.btnVacunas_Click);
            // 
            // btnEstandares
            // 
            this.btnEstandares.Image = ((System.Drawing.Image)(resources.GetObject("btnEstandares.Image")));
            this.btnEstandares.Location = new System.Drawing.Point(39, 25);
            this.btnEstandares.Name = "btnEstandares";
            this.btnEstandares.Size = new System.Drawing.Size(230, 159);
            this.btnEstandares.TabIndex = 8;
            this.btnEstandares.Text = "Ingresar valores de estandares";
            this.btnEstandares.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnEstandares.UseVisualStyleBackColor = true;
            this.btnEstandares.Click += new System.EventHandler(this.btnEstandares_Click);
            // 
            // FrmBatchManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1029, 688);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmBatchManager";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.Text = "FrmBatchSelection";
            this.Load += new System.EventHandler(this.FrmBatchManager_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnShowBatchSelectionView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radPanel1)).EndInit();
            this.radPanel1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtFechaIngresoGalpon;
        private System.Windows.Forms.TextBox txtGalpon;
        private System.Windows.Forms.TextBox txtSemanaActual;
        private System.Windows.Forms.TextBox txtEtapa;
        private System.Windows.Forms.TextBox txtLineaGenetica;
        private System.Windows.Forms.TextBox txtNumero;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnGalpon;
        private System.Windows.Forms.Button btnObservaciones;
        private System.Windows.Forms.Button btnVacunas;
        private System.Windows.Forms.Button btnEstandares;
        private System.Windows.Forms.Label lbBatchTitle;
        private System.Windows.Forms.Button btnEndBatch;
        private System.Windows.Forms.Button btnEliminarLote;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private Telerik.WinControls.UI.RadPanel radPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private Telerik.WinControls.UI.RadButton btnShowBatchSelectionView;


    }
}
