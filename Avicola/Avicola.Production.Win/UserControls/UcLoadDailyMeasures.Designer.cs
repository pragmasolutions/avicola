namespace Avicola.Production.Win.UserControls
{
    partial class UcLoadDailyMeasures
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
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn3 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn4 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewDecimalColumn gridViewDecimalColumn2 = new Telerik.WinControls.UI.GridViewDecimalColumn();
            Telerik.WinControls.UI.TableViewDefinition tableViewDefinition2 = new Telerik.WinControls.UI.TableViewDefinition();
            this.gvDailyMeasures = new Telerik.WinControls.UI.RadGridView();
            this.ucWeekSelection = new Avicola.Production.Win.UserControls.UcWeekSelection();
            this.txtTotal = new Telerik.WinControls.UI.RadTextBox();
            this.radLabel1 = new Telerik.WinControls.UI.RadLabel();
            this.btnSave = new Telerik.WinControls.UI.RadButton();
            ((System.ComponentModel.ISupportInitialize)(this.gvDailyMeasures)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvDailyMeasures.MasterTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTotal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSave)).BeginInit();
            this.SuspendLayout();
            // 
            // gvDailyMeasures
            // 
            this.gvDailyMeasures.Location = new System.Drawing.Point(3, 56);
            // 
            // 
            // 
            this.gvDailyMeasures.MasterTemplate.AllowAddNewRow = false;
            this.gvDailyMeasures.MasterTemplate.AllowColumnReorder = false;
            this.gvDailyMeasures.MasterTemplate.AllowDeleteRow = false;
            this.gvDailyMeasures.MasterTemplate.AllowDragToGroup = false;
            this.gvDailyMeasures.MasterTemplate.AutoGenerateColumns = false;
            this.gvDailyMeasures.MasterTemplate.AutoSizeColumnsMode = Telerik.WinControls.UI.GridViewAutoSizeColumnsMode.Fill;
            gridViewTextBoxColumn3.FieldName = "Day";
            gridViewTextBoxColumn3.HeaderText = "Día";
            gridViewTextBoxColumn3.Name = "Day";
            gridViewTextBoxColumn3.ReadOnly = true;
            gridViewTextBoxColumn3.Width = 135;
            gridViewTextBoxColumn4.FieldName = "Date";
            gridViewTextBoxColumn4.HeaderText = "Fecha";
            gridViewTextBoxColumn4.Name = "Date";
            gridViewTextBoxColumn4.ReadOnly = true;
            gridViewTextBoxColumn4.Width = 110;
            gridViewDecimalColumn2.EnableExpressionEditor = false;
            gridViewDecimalColumn2.Expression = "";
            gridViewDecimalColumn2.FieldName = "Value";
            gridViewDecimalColumn2.HeaderText = "Valor";
            gridViewDecimalColumn2.Name = "Value";
            gridViewDecimalColumn2.Width = 317;
            this.gvDailyMeasures.MasterTemplate.Columns.AddRange(new Telerik.WinControls.UI.GridViewDataColumn[] {
            gridViewTextBoxColumn3,
            gridViewTextBoxColumn4,
            gridViewDecimalColumn2});
            this.gvDailyMeasures.MasterTemplate.ViewDefinition = tableViewDefinition2;
            this.gvDailyMeasures.Name = "gvDailyMeasures";
            this.gvDailyMeasures.Size = new System.Drawing.Size(580, 200);
            this.gvDailyMeasures.TabIndex = 5;
            // 
            // ucWeekSelection
            // 
            this.ucWeekSelection.Current = 0;
            this.ucWeekSelection.Location = new System.Drawing.Point(3, 5);
            this.ucWeekSelection.Name = "ucWeekSelection";
            this.ucWeekSelection.NumberOfWeek = 0;
            this.ucWeekSelection.Size = new System.Drawing.Size(580, 45);
            this.ucWeekSelection.TabIndex = 0;
            this.ucWeekSelection.CurrentWeekChanged += new System.EventHandler<int>(this.ucWeekSelection_CurrentWeekChanged);
            // 
            // txtTotal
            // 
            this.txtTotal.Enabled = false;
            this.txtTotal.Location = new System.Drawing.Point(61, 272);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(100, 20);
            this.txtTotal.TabIndex = 6;
            // 
            // radLabel1
            // 
            this.radLabel1.Location = new System.Drawing.Point(21, 273);
            this.radLabel1.Name = "radLabel1";
            this.radLabel1.Size = new System.Drawing.Size(34, 18);
            this.radLabel1.TabIndex = 7;
            this.radLabel1.Text = "Total:";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(448, 270);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(110, 24);
            this.btnSave.TabIndex = 8;
            this.btnSave.Text = "Guardar";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // UcLoadDailyMeasures
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.radLabel1);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.gvDailyMeasures);
            this.Controls.Add(this.ucWeekSelection);
            this.Name = "UcLoadDailyMeasures";
            this.Size = new System.Drawing.Size(586, 311);
            ((System.ComponentModel.ISupportInitialize)(this.gvDailyMeasures.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvDailyMeasures)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTotal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSave)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private UcWeekSelection ucWeekSelection;
        private Telerik.WinControls.UI.RadGridView gvDailyMeasures;
        private Telerik.WinControls.UI.RadTextBox txtTotal;
        private Telerik.WinControls.UI.RadLabel radLabel1;
        private Telerik.WinControls.UI.RadButton btnSave;
    }
}
