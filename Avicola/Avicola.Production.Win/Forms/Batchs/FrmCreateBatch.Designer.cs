namespace Avicola.Production.Win.Forms.Batchs
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
            this.ddlGeneticLine = new Telerik.WinControls.UI.RadDropDownList();
            this.radLabel4 = new Telerik.WinControls.UI.RadLabel();
            this.radLabel2 = new Telerik.WinControls.UI.RadLabel();
            this.dtpDateOfBirth = new Telerik.WinControls.UI.RadDateTimePicker();
            this.txtNumber = new Telerik.WinControls.UI.RadTextBox();
            this.metroLabel1 = new Telerik.WinControls.UI.RadLabel();
            this.BtnGuardar = new Telerik.WinControls.UI.RadButton();
            this.BtnCancelar = new Telerik.WinControls.UI.RadButton();
            this.pbvBatch = new System.Windows.Forms.ErrorProvider(this.components);
            this.ucAssignBarns = new Avicola.Production.Win.UserControls.UcAssignBarns();
            this.txtInitialBirds = new Telerik.WinControls.UI.RadSpinEditor();
            this.radLabel1 = new Telerik.WinControls.UI.RadLabel();
            this.ucStageSelection = new Avicola.Production.Win.UserControls.UcStageSelection();
            this.radLabel3 = new Telerik.WinControls.UI.RadLabel();
            this.radLabel6 = new Telerik.WinControls.UI.RadLabel();
            this.dtpEntranceDate = new Telerik.WinControls.UI.RadDateTimePicker();
            this.radLabel7 = new Telerik.WinControls.UI.RadLabel();
            this.txtStartingFood = new Telerik.WinControls.UI.RadSpinEditor();
            this.ddlFoodClass = new Telerik.WinControls.UI.RadDropDownList();
            this.radLabel5 = new Telerik.WinControls.UI.RadLabel();
            ((System.ComponentModel.ISupportInitialize)(this.ddlGeneticLine)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpDateOfBirth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNumber)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.metroLabel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnGuardar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnCancelar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbvBatch)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtInitialBirds)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpEntranceDate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtStartingFood)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ddlFoodClass)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // ddlGeneticLine
            // 
            this.ddlGeneticLine.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ddlGeneticLine.Location = new System.Drawing.Point(568, 50);
            this.ddlGeneticLine.Margin = new System.Windows.Forms.Padding(2);
            this.ddlGeneticLine.Name = "ddlGeneticLine";
            this.ddlGeneticLine.Size = new System.Drawing.Size(150, 25);
            this.ddlGeneticLine.TabIndex = 94;
            // 
            // radLabel4
            // 
            this.radLabel4.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radLabel4.Location = new System.Drawing.Point(567, 25);
            this.radLabel4.Margin = new System.Windows.Forms.Padding(2);
            this.radLabel4.Name = "radLabel4";
            this.radLabel4.Size = new System.Drawing.Size(107, 24);
            this.radLabel4.TabIndex = 91;
            this.radLabel4.Text = "Línea Genética";
            this.radLabel4.ThemeName = "TelerikMetroBlue";
            // 
            // radLabel2
            // 
            this.radLabel2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radLabel2.Location = new System.Drawing.Point(204, 25);
            this.radLabel2.Margin = new System.Windows.Forms.Padding(2);
            this.radLabel2.Name = "radLabel2";
            this.radLabel2.Size = new System.Drawing.Size(107, 24);
            this.radLabel2.TabIndex = 88;
            this.radLabel2.Text = "Fecha  de Nac.";
            this.radLabel2.ThemeName = "TelerikMetroBlue";
            // 
            // dtpDateOfBirth
            // 
            this.dtpDateOfBirth.CustomFormat = "";
            this.dtpDateOfBirth.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDateOfBirth.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDateOfBirth.Location = new System.Drawing.Point(208, 50);
            this.dtpDateOfBirth.Margin = new System.Windows.Forms.Padding(2);
            this.dtpDateOfBirth.Name = "dtpDateOfBirth";
            this.dtpDateOfBirth.Size = new System.Drawing.Size(145, 25);
            this.dtpDateOfBirth.TabIndex = 87;
            this.dtpDateOfBirth.TabStop = false;
            this.dtpDateOfBirth.Text = "14/09/2015";
            this.dtpDateOfBirth.Value = new System.DateTime(2015, 9, 14, 10, 20, 19, 820);
            // 
            // txtNumber
            // 
            this.txtNumber.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumber.Location = new System.Drawing.Point(28, 50);
            this.txtNumber.Margin = new System.Windows.Forms.Padding(2);
            this.txtNumber.MaxLength = 50;
            this.txtNumber.Name = "txtNumber";
            this.txtNumber.Size = new System.Drawing.Size(145, 25);
            this.txtNumber.TabIndex = 81;
            this.txtNumber.TabStop = false;
            this.txtNumber.ThemeName = "TelerikMetroBlue";
            // 
            // metroLabel1
            // 
            this.metroLabel1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.metroLabel1.Location = new System.Drawing.Point(26, 25);
            this.metroLabel1.Margin = new System.Windows.Forms.Padding(2);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(64, 24);
            this.metroLabel1.TabIndex = 84;
            this.metroLabel1.Text = "Número";
            this.metroLabel1.ThemeName = "TelerikMetroBlue";
            // 
            // BtnGuardar
            // 
            this.BtnGuardar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnGuardar.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.BtnGuardar.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnGuardar.Location = new System.Drawing.Point(567, 491);
            this.BtnGuardar.Margin = new System.Windows.Forms.Padding(2);
            this.BtnGuardar.Name = "BtnGuardar";
            this.BtnGuardar.Size = new System.Drawing.Size(75, 24);
            this.BtnGuardar.TabIndex = 82;
            this.BtnGuardar.Text = "Guardar";
            this.BtnGuardar.ThemeName = "TelerikMetroBlue";
            this.BtnGuardar.Click += new System.EventHandler(this.BtnGuardar_Click);
            // 
            // BtnCancelar
            // 
            this.BtnCancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BtnCancelar.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCancelar.Location = new System.Drawing.Point(652, 491);
            this.BtnCancelar.Margin = new System.Windows.Forms.Padding(2);
            this.BtnCancelar.Name = "BtnCancelar";
            this.BtnCancelar.Size = new System.Drawing.Size(75, 24);
            this.BtnCancelar.TabIndex = 83;
            this.BtnCancelar.Text = "Cancelar";
            this.BtnCancelar.ThemeName = "TelerikMetroBlue";
            this.BtnCancelar.Click += new System.EventHandler(this.BtnCancelar_Click);
            // 
            // pbvBatch
            // 
            this.pbvBatch.ContainerControl = this;
            // 
            // ucAssignBarns
            // 
            this.ucAssignBarns.CurrentBatchBirds = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.ucAssignBarns.Enabled = false;
            this.ucAssignBarns.FormFactory = null;
            this.ucAssignBarns.Location = new System.Drawing.Point(28, 159);
            this.ucAssignBarns.MessageBoxDisplayService = null;
            this.ucAssignBarns.Name = "ucAssignBarns";
            this.ucAssignBarns.Size = new System.Drawing.Size(690, 298);
            this.ucAssignBarns.StageId = new System.Guid("00000000-0000-0000-0000-000000000000");
            this.ucAssignBarns.TabIndex = 96;
            // 
            // txtInitialBirds
            // 
            this.txtInitialBirds.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInitialBirds.Location = new System.Drawing.Point(208, 120);
            this.txtInitialBirds.Name = "txtInitialBirds";
            this.txtInitialBirds.Size = new System.Drawing.Size(145, 25);
            this.txtInitialBirds.TabIndex = 97;
            this.txtInitialBirds.TabStop = false;
            this.txtInitialBirds.ValueChanged += new System.EventHandler(this.txtInitialBirds_ValueChanged);
            // 
            // radLabel1
            // 
            this.radLabel1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radLabel1.Location = new System.Drawing.Point(210, 91);
            this.radLabel1.Margin = new System.Windows.Forms.Padding(2);
            this.radLabel1.Name = "radLabel1";
            this.radLabel1.Size = new System.Drawing.Size(170, 24);
            this.radLabel1.TabIndex = 85;
            this.radLabel1.Text = "Cantidad de Aves Inicial";
            this.radLabel1.ThemeName = "TelerikMetroBlue";
            // 
            // ucStageSelection
            // 
            this.ucStageSelection.Location = new System.Drawing.Point(28, 120);
            this.ucStageSelection.Name = "ucStageSelection";
            this.ucStageSelection.Size = new System.Drawing.Size(145, 25);
            this.ucStageSelection.TabIndex = 98;
            // 
            // radLabel3
            // 
            this.radLabel3.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radLabel3.Location = new System.Drawing.Point(26, 91);
            this.radLabel3.Margin = new System.Windows.Forms.Padding(2);
            this.radLabel3.Name = "radLabel3";
            this.radLabel3.Size = new System.Drawing.Size(53, 24);
            this.radLabel3.TabIndex = 86;
            this.radLabel3.Text = "Estado";
            this.radLabel3.ThemeName = "TelerikMetroBlue";
            // 
            // radLabel6
            // 
            this.radLabel6.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radLabel6.Location = new System.Drawing.Point(387, 25);
            this.radLabel6.Margin = new System.Windows.Forms.Padding(2);
            this.radLabel6.Name = "radLabel6";
            this.radLabel6.Size = new System.Drawing.Size(102, 24);
            this.radLabel6.TabIndex = 90;
            this.radLabel6.Text = "Fecha Ingreso";
            this.radLabel6.ThemeName = "TelerikMetroBlue";
            // 
            // dtpEntranceDate
            // 
            this.dtpEntranceDate.CustomFormat = "";
            this.dtpEntranceDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpEntranceDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpEntranceDate.Location = new System.Drawing.Point(388, 50);
            this.dtpEntranceDate.Margin = new System.Windows.Forms.Padding(2);
            this.dtpEntranceDate.Name = "dtpEntranceDate";
            this.dtpEntranceDate.Size = new System.Drawing.Size(145, 25);
            this.dtpEntranceDate.TabIndex = 89;
            this.dtpEntranceDate.TabStop = false;
            this.dtpEntranceDate.Text = "14/09/2015";
            this.dtpEntranceDate.Value = new System.DateTime(2015, 9, 14, 10, 20, 19, 820);
            // 
            // radLabel7
            // 
            this.radLabel7.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radLabel7.Location = new System.Drawing.Point(390, 91);
            this.radLabel7.Margin = new System.Windows.Forms.Padding(2);
            this.radLabel7.Name = "radLabel7";
            this.radLabel7.Size = new System.Drawing.Size(144, 24);
            this.radLabel7.TabIndex = 98;
            this.radLabel7.Text = "Alimento Inicial (Kg)";
            this.radLabel7.ThemeName = "TelerikMetroBlue";
            // 
            // txtStartingFood
            // 
            this.txtStartingFood.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStartingFood.Location = new System.Drawing.Point(388, 120);
            this.txtStartingFood.Name = "txtStartingFood";
            this.txtStartingFood.Size = new System.Drawing.Size(145, 25);
            this.txtStartingFood.TabIndex = 99;
            this.txtStartingFood.TabStop = false;
            // 
            // ddlFoodClass
            // 
            this.ddlFoodClass.DropDownStyle = Telerik.WinControls.RadDropDownStyle.DropDownList;
            this.ddlFoodClass.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ddlFoodClass.Location = new System.Drawing.Point(568, 120);
            this.ddlFoodClass.Margin = new System.Windows.Forms.Padding(2);
            this.ddlFoodClass.Name = "ddlFoodClass";
            this.ddlFoodClass.Size = new System.Drawing.Size(150, 25);
            this.ddlFoodClass.TabIndex = 101;
            ((Telerik.WinControls.UI.RadDropDownListElement)(this.ddlFoodClass.GetChildAt(0))).DropDownStyle = Telerik.WinControls.RadDropDownStyle.DropDownList;
            ((Telerik.WinControls.UI.RadDropDownTextBoxElement)(this.ddlFoodClass.GetChildAt(0).GetChildAt(2).GetChildAt(0).GetChildAt(0))).Visibility = Telerik.WinControls.ElementVisibility.Hidden;
            ((Telerik.WinControls.UI.RadTextBoxItem)(this.ddlFoodClass.GetChildAt(0).GetChildAt(2).GetChildAt(0).GetChildAt(0).GetChildAt(0))).TextOrientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // radLabel5
            // 
            this.radLabel5.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radLabel5.Location = new System.Drawing.Point(567, 91);
            this.radLabel5.Margin = new System.Windows.Forms.Padding(2);
            this.radLabel5.Name = "radLabel5";
            this.radLabel5.Size = new System.Drawing.Size(123, 24);
            this.radLabel5.TabIndex = 100;
            this.radLabel5.Text = "Tipo de alimento";
            this.radLabel5.ThemeName = "TelerikMetroBlue";
            // 
            // FrmCreateBatch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(737, 526);
            this.ControlBox = false;
            this.Controls.Add(this.ddlFoodClass);
            this.Controls.Add(this.radLabel5);
            this.Controls.Add(this.radLabel7);
            this.Controls.Add(this.txtStartingFood);
            this.Controls.Add(this.radLabel6);
            this.Controls.Add(this.dtpEntranceDate);
            this.Controls.Add(this.radLabel3);
            this.Controls.Add(this.ucStageSelection);
            this.Controls.Add(this.radLabel1);
            this.Controls.Add(this.txtInitialBirds);
            this.Controls.Add(this.ucAssignBarns);
            this.Controls.Add(this.ddlGeneticLine);
            this.Controls.Add(this.radLabel4);
            this.Controls.Add(this.radLabel2);
            this.Controls.Add(this.dtpDateOfBirth);
            this.Controls.Add(this.txtNumber);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.BtnGuardar);
            this.Controls.Add(this.BtnCancelar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(2);
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
            ((System.ComponentModel.ISupportInitialize)(this.ddlGeneticLine)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpDateOfBirth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNumber)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.metroLabel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnGuardar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnCancelar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbvBatch)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtInitialBirds)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpEntranceDate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtStartingFood)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ddlFoodClass)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Telerik.WinControls.UI.RadTextBox txtNumber;
        private Telerik.WinControls.UI.RadLabel metroLabel1;
        private Telerik.WinControls.UI.RadButton BtnGuardar;
        private Telerik.WinControls.UI.RadButton BtnCancelar;
        private Telerik.WinControls.UI.RadDateTimePicker dtpDateOfBirth;
        private Telerik.WinControls.UI.RadLabel radLabel2;
        private Telerik.WinControls.UI.RadLabel radLabel4;
        private Telerik.WinControls.UI.RadDropDownList ddlGeneticLine;
        private System.Windows.Forms.ErrorProvider pbvBatch;
        private UserControls.UcAssignBarns ucAssignBarns;
        private Telerik.WinControls.UI.RadLabel radLabel1;
        private Telerik.WinControls.UI.RadSpinEditor txtInitialBirds;
        private Telerik.WinControls.UI.RadLabel radLabel3;
        private UserControls.UcStageSelection ucStageSelection;
        private Telerik.WinControls.UI.RadLabel radLabel6;
        private Telerik.WinControls.UI.RadDateTimePicker dtpEntranceDate;
        private Telerik.WinControls.UI.RadDropDownList ddlFoodClass;
        private Telerik.WinControls.UI.RadLabel radLabel5;
        private Telerik.WinControls.UI.RadLabel radLabel7;
        private Telerik.WinControls.UI.RadSpinEditor txtStartingFood;
    }
}
