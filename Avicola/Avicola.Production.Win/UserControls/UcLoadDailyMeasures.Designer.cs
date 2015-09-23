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
            this.txtTotal = new Telerik.WinControls.UI.RadTextBox();
            this.lbAggregate = new Telerik.WinControls.UI.RadLabel();
            this.btnSave = new Telerik.WinControls.UI.RadButton();
            this.ucWeekSelection = new Avicola.Production.Win.UserControls.UcWeekSelection();
            ((System.ComponentModel.ISupportInitialize)(this.gvDailyMeasures)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvDailyMeasures.MasterTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTotal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lbAggregate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSave)).BeginInit();
            this.SuspendLayout();
            // 
            // gvDailyMeasures
            // 
            this.gvDailyMeasures.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gvDailyMeasures.Location = new System.Drawing.Point(3, 81);
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
            gridViewTextBoxColumn1.Width = 135;
            gridViewTextBoxColumn2.FieldName = "Date";
            gridViewTextBoxColumn2.FormatString = "{0: dd/M/yyyy}";
            gridViewTextBoxColumn2.HeaderText = "Fecha";
            gridViewTextBoxColumn2.Name = "Date";
            gridViewTextBoxColumn2.ReadOnly = true;
            gridViewTextBoxColumn2.Width = 110;
            gridViewDecimalColumn1.EnableExpressionEditor = false;
            gridViewDecimalColumn1.Expression = "";
            gridViewDecimalColumn1.FieldName = "Value";
            gridViewDecimalColumn1.FormatString = "{0:N2}";
            gridViewDecimalColumn1.HeaderText = "Valor";
            gridViewDecimalColumn1.Name = "Value";
            gridViewDecimalColumn1.Width = 317;
            this.gvDailyMeasures.MasterTemplate.Columns.AddRange(new Telerik.WinControls.UI.GridViewDataColumn[] {
            gridViewTextBoxColumn1,
            gridViewTextBoxColumn2,
            gridViewDecimalColumn1});
            this.gvDailyMeasures.MasterTemplate.ViewDefinition = tableViewDefinition1;
            this.gvDailyMeasures.Name = "gvDailyMeasures";
            this.gvDailyMeasures.Size = new System.Drawing.Size(580, 216);
            this.gvDailyMeasures.TabIndex = 5;
            this.gvDailyMeasures.CellBeginEdit += new Telerik.WinControls.UI.GridViewCellCancelEventHandler(this.gvDailyMeasures_CellBeginEdit);
            this.gvDailyMeasures.CellValueChanged += new Telerik.WinControls.UI.GridViewCellEventHandler(this.gvDailyMeasures_CellValueChanged);
            // 
            // txtTotal
            // 
            this.txtTotal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtTotal.Enabled = false;
            this.txtTotal.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotal.Location = new System.Drawing.Point(95, 303);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(100, 41);
            this.txtTotal.TabIndex = 6;
            // 
            // lbAggregate
            // 
            this.lbAggregate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lbAggregate.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAggregate.Location = new System.Drawing.Point(3, 303);
            this.lbAggregate.Name = "lbAggregate";
            this.lbAggregate.Size = new System.Drawing.Size(86, 41);
            this.lbAggregate.TabIndex = 7;
            this.lbAggregate.Text = "Total:";
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.Location = new System.Drawing.Point(473, 303);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(110, 41);
            this.btnSave.TabIndex = 8;
            this.btnSave.Text = "Guardar";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // ucWeekSelection
            // 
            this.ucWeekSelection.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ucWeekSelection.Current = 0;
            this.ucWeekSelection.Location = new System.Drawing.Point(3, 5);
            this.ucWeekSelection.MinimumSize = new System.Drawing.Size(0, 70);
            this.ucWeekSelection.Name = "ucWeekSelection";
            this.ucWeekSelection.NumberOfWeek = 0;
            this.ucWeekSelection.Size = new System.Drawing.Size(580, 70);
            this.ucWeekSelection.TabIndex = 0;
            this.ucWeekSelection.CurrentWeekChanged += new System.EventHandler<int>(this.ucWeekSelection_CurrentWeekChanged);
            // 
            // UcLoadDailyMeasures
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.lbAggregate);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.gvDailyMeasures);
            this.Controls.Add(this.ucWeekSelection);
            this.Name = "UcLoadDailyMeasures";
            this.Size = new System.Drawing.Size(586, 352);
            ((System.ComponentModel.ISupportInitialize)(this.gvDailyMeasures.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvDailyMeasures)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTotal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lbAggregate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSave)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private UcWeekSelection ucWeekSelection;
        private Telerik.WinControls.UI.RadGridView gvDailyMeasures;
        private Telerik.WinControls.UI.RadTextBox txtTotal;
        private Telerik.WinControls.UI.RadLabel lbAggregate;
        private Telerik.WinControls.UI.RadButton btnSave;
    }
}
