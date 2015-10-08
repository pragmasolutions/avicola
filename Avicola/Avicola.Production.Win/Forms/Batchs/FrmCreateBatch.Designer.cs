﻿namespace Avicola.Production.Win.Forms.Batchs
{
    partial class FrmCreateBatch
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
            this.components = new System.ComponentModel.Container();
            this.ddlFoodClass = new Telerik.WinControls.UI.RadDropDownList();
            this.ddlGeneticLine = new Telerik.WinControls.UI.RadDropDownList();
            this.txtInitialFood = new System.Windows.Forms.NumericUpDown();
            this.radLabel5 = new Telerik.WinControls.UI.RadLabel();
            this.radLabel4 = new Telerik.WinControls.UI.RadLabel();
            this.radLabel3 = new Telerik.WinControls.UI.RadLabel();
            this.radLabel2 = new Telerik.WinControls.UI.RadLabel();
            this.dtpDateOfBirth = new Telerik.WinControls.UI.RadDateTimePicker();
            this.txtInitialBirds = new System.Windows.Forms.NumericUpDown();
            this.radLabel1 = new Telerik.WinControls.UI.RadLabel();
            this.txtNumber = new Telerik.WinControls.UI.RadTextBox();
            this.metroLabel1 = new Telerik.WinControls.UI.RadLabel();
            this.BtnGuardar = new Telerik.WinControls.UI.RadButton();
            this.BtnCancelar = new Telerik.WinControls.UI.RadButton();
            this.pbvBatch = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.ddlFoodClass)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ddlGeneticLine)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtInitialFood)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpDateOfBirth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtInitialBirds)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNumber)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.metroLabel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnGuardar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnCancelar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbvBatch)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // ddlFoodClass
            // 
            this.ddlFoodClass.Location = new System.Drawing.Point(373, 247);
            this.ddlFoodClass.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ddlFoodClass.Name = "ddlFoodClass";
            this.ddlFoodClass.Size = new System.Drawing.Size(161, 24);
            this.ddlFoodClass.TabIndex = 95;
            // 
            // ddlGeneticLine
            // 
            this.ddlGeneticLine.Location = new System.Drawing.Point(37, 247);
            this.ddlGeneticLine.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ddlGeneticLine.Name = "ddlGeneticLine";
            this.ddlGeneticLine.Size = new System.Drawing.Size(197, 24);
            this.ddlGeneticLine.TabIndex = 94;
            // 
            // txtInitialFood
            // 
            this.txtInitialFood.DecimalPlaces = 2;
            this.txtInitialFood.Location = new System.Drawing.Point(373, 154);
            this.txtInitialFood.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtInitialFood.Maximum = new decimal(new int[] {
            100000000,
            0,
            0,
            0});
            this.txtInitialFood.Name = "txtInitialFood";
            this.txtInitialFood.Size = new System.Drawing.Size(159, 22);
            this.txtInitialFood.TabIndex = 93;
            // 
            // radLabel5
            // 
            this.radLabel5.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radLabel5.Location = new System.Drawing.Point(373, 212);
            this.radLabel5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radLabel5.Name = "radLabel5";
            this.radLabel5.Size = new System.Drawing.Size(153, 29);
            this.radLabel5.TabIndex = 92;
            this.radLabel5.Text = "Tipo de alimento";
            this.radLabel5.ThemeName = "TelerikMetroBlue";
            // 
            // radLabel4
            // 
            this.radLabel4.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radLabel4.Location = new System.Drawing.Point(37, 212);
            this.radLabel4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radLabel4.Name = "radLabel4";
            this.radLabel4.Size = new System.Drawing.Size(133, 29);
            this.radLabel4.TabIndex = 91;
            this.radLabel4.Text = "Línea Genética";
            this.radLabel4.ThemeName = "TelerikMetroBlue";
            // 
            // radLabel3
            // 
            this.radLabel3.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radLabel3.Location = new System.Drawing.Point(373, 117);
            this.radLabel3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radLabel3.Name = "radLabel3";
            this.radLabel3.Size = new System.Drawing.Size(178, 29);
            this.radLabel3.TabIndex = 90;
            this.radLabel3.Text = "Alimento Inicial (kg)";
            this.radLabel3.ThemeName = "TelerikMetroBlue";
            // 
            // radLabel2
            // 
            this.radLabel2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radLabel2.Location = new System.Drawing.Point(37, 117);
            this.radLabel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radLabel2.Name = "radLabel2";
            this.radLabel2.Size = new System.Drawing.Size(193, 29);
            this.radLabel2.TabIndex = 88;
            this.radLabel2.Text = "Fecha  de Nacimiento";
            this.radLabel2.ThemeName = "TelerikMetroBlue";
            // 
            // dtpDateOfBirth
            // 
            this.dtpDateOfBirth.CustomFormat = "";
            this.dtpDateOfBirth.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDateOfBirth.Location = new System.Drawing.Point(37, 153);
            this.dtpDateOfBirth.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtpDateOfBirth.Name = "dtpDateOfBirth";
            this.dtpDateOfBirth.Size = new System.Drawing.Size(193, 24);
            this.dtpDateOfBirth.TabIndex = 87;
            this.dtpDateOfBirth.TabStop = false;
            this.dtpDateOfBirth.Text = "14/09/2015";
            this.dtpDateOfBirth.Value = new System.DateTime(2015, 9, 14, 10, 20, 19, 820);
            // 
            // txtInitialBirds
            // 
            this.txtInitialBirds.Location = new System.Drawing.Point(373, 69);
            this.txtInitialBirds.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtInitialBirds.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.txtInitialBirds.Name = "txtInitialBirds";
            this.txtInitialBirds.Size = new System.Drawing.Size(159, 22);
            this.txtInitialBirds.TabIndex = 86;
            // 
            // radLabel1
            // 
            this.radLabel1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radLabel1.Location = new System.Drawing.Point(373, 31);
            this.radLabel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radLabel1.Name = "radLabel1";
            this.radLabel1.Size = new System.Drawing.Size(121, 29);
            this.radLabel1.TabIndex = 85;
            this.radLabel1.Text = "Aves Iniciales";
            this.radLabel1.ThemeName = "TelerikMetroBlue";
            // 
            // txtNumber
            // 
            this.txtNumber.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNumber.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumber.Location = new System.Drawing.Point(37, 62);
            this.txtNumber.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNumber.MaxLength = 50;
            this.txtNumber.Name = "txtNumber";
            this.txtNumber.Size = new System.Drawing.Size(193, 30);
            this.txtNumber.TabIndex = 81;
            this.txtNumber.TabStop = false;
            this.txtNumber.ThemeName = "TelerikMetroBlue";
            // 
            // metroLabel1
            // 
            this.metroLabel1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.metroLabel1.Location = new System.Drawing.Point(37, 31);
            this.metroLabel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(79, 29);
            this.metroLabel1.TabIndex = 84;
            this.metroLabel1.Text = "Número";
            this.metroLabel1.ThemeName = "TelerikMetroBlue";
            // 
            // BtnGuardar
            // 
            this.BtnGuardar.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.BtnGuardar.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnGuardar.Location = new System.Drawing.Point(324, 322);
            this.BtnGuardar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnGuardar.Name = "BtnGuardar";
            this.BtnGuardar.Size = new System.Drawing.Size(100, 30);
            this.BtnGuardar.TabIndex = 82;
            this.BtnGuardar.Text = "Guardar";
            this.BtnGuardar.ThemeName = "TelerikMetroBlue";
            this.BtnGuardar.Click += new System.EventHandler(this.BtnGuardar_Click);
            // 
            // BtnCancelar
            // 
            this.BtnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BtnCancelar.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCancelar.Location = new System.Drawing.Point(437, 322);
            this.BtnCancelar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnCancelar.Name = "BtnCancelar";
            this.BtnCancelar.Size = new System.Drawing.Size(100, 30);
            this.BtnCancelar.TabIndex = 83;
            this.BtnCancelar.Text = "Cancelar";
            this.BtnCancelar.ThemeName = "TelerikMetroBlue";
            this.BtnCancelar.Click += new System.EventHandler(this.BtnCancelar_Click);
            // 
            // pbvBatch
            // 
            this.pbvBatch.ContainerControl = this;
            // 
            // FrmCreateBatch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(598, 386);
            this.ControlBox = false;
            this.Controls.Add(this.ddlFoodClass);
            this.Controls.Add(this.ddlGeneticLine);
            this.Controls.Add(this.txtInitialFood);
            this.Controls.Add(this.radLabel5);
            this.Controls.Add(this.radLabel4);
            this.Controls.Add(this.radLabel3);
            this.Controls.Add(this.radLabel2);
            this.Controls.Add(this.dtpDateOfBirth);
            this.Controls.Add(this.txtInitialBirds);
            this.Controls.Add(this.radLabel1);
            this.Controls.Add(this.txtNumber);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.BtnGuardar);
            this.Controls.Add(this.BtnCancelar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MinimizeBox = false;
            this.Name = "FrmCreateBatch";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Crear Lote";
            this.Load += new System.EventHandler(this.FrmCreateBatch_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ddlFoodClass)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ddlGeneticLine)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtInitialFood)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpDateOfBirth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtInitialBirds)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNumber)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.metroLabel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnGuardar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnCancelar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbvBatch)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Telerik.WinControls.UI.RadTextBox txtNumber;
        private Telerik.WinControls.UI.RadLabel metroLabel1;
        private Telerik.WinControls.UI.RadButton BtnGuardar;
        private Telerik.WinControls.UI.RadButton BtnCancelar;
        private Telerik.WinControls.UI.RadLabel radLabel1;
        private System.Windows.Forms.NumericUpDown txtInitialBirds;
        private Telerik.WinControls.UI.RadDateTimePicker dtpDateOfBirth;
        private Telerik.WinControls.UI.RadLabel radLabel2;
        private Telerik.WinControls.UI.RadLabel radLabel3;
        private Telerik.WinControls.UI.RadLabel radLabel4;
        private Telerik.WinControls.UI.RadLabel radLabel5;
        private System.Windows.Forms.NumericUpDown txtInitialFood;
        private Telerik.WinControls.UI.RadDropDownList ddlGeneticLine;
        private Telerik.WinControls.UI.RadDropDownList ddlFoodClass;
        private System.Windows.Forms.ErrorProvider pbvBatch;
    }
}
