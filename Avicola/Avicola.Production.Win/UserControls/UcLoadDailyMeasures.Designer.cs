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
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn1 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn2 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewDecimalColumn gridViewDecimalColumn1 = new Telerik.WinControls.UI.GridViewDecimalColumn();
            Telerik.WinControls.UI.TableViewDefinition tableViewDefinition1 = new Telerik.WinControls.UI.TableViewDefinition();
            this.gvDailyMeasures = new Telerik.WinControls.UI.RadGridView();
            this.ucWeekSelection = new Avicola.Production.Win.UserControls.UcWeekSelection();
            ((System.ComponentModel.ISupportInitialize)(this.gvDailyMeasures)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvDailyMeasures.MasterTemplate)).BeginInit();
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
            gridViewTextBoxColumn1.FieldName = "Day";
            gridViewTextBoxColumn1.HeaderText = "Día";
            gridViewTextBoxColumn1.Name = "Day";
            gridViewTextBoxColumn1.ReadOnly = true;
            gridViewTextBoxColumn1.Width = 134;
            gridViewTextBoxColumn2.FieldName = "Date";
            gridViewTextBoxColumn2.HeaderText = "Fecha";
            gridViewTextBoxColumn2.Name = "Date";
            gridViewTextBoxColumn2.ReadOnly = true;
            gridViewTextBoxColumn2.Width = 109;
            gridViewDecimalColumn1.EnableExpressionEditor = false;
            gridViewDecimalColumn1.Expression = "";
            gridViewDecimalColumn1.FieldName = "Value";
            gridViewDecimalColumn1.HeaderText = "Valor";
            gridViewDecimalColumn1.Name = "Value";
            gridViewDecimalColumn1.Width = 315;
            this.gvDailyMeasures.MasterTemplate.Columns.AddRange(new Telerik.WinControls.UI.GridViewDataColumn[] {
            gridViewTextBoxColumn1,
            gridViewTextBoxColumn2,
            gridViewDecimalColumn1});
            this.gvDailyMeasures.MasterTemplate.ViewDefinition = tableViewDefinition1;
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
            // UcLoadDailyMeasures
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gvDailyMeasures);
            this.Controls.Add(this.ucWeekSelection);
            this.Name = "UcLoadDailyMeasures";
            this.Size = new System.Drawing.Size(586, 260);
            ((System.ComponentModel.ISupportInitialize)(this.gvDailyMeasures.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvDailyMeasures)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private UcWeekSelection ucWeekSelection;
        private Telerik.WinControls.UI.RadGridView gvDailyMeasures;
    }
}
