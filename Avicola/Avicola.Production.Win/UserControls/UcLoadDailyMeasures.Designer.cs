using System.Collections.Generic;
using System.Linq;
using Avicola.Office.Entities;
using Avicola.Office.Services.Interfaces;
using Telerik.WinControls.UI;

namespace Avicola.Production.Win.UserControls
{
    partial class UcLoadDailyMeasures
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private readonly IServiceFactory _serviceFactory;
        private IList<FoodClass> _foodClasses;

        public IList<FoodClass> FoodClasses
        {
            get
            {
                if (_foodClasses == null)
                {
                    using (var service = _serviceFactory.Create<IFoodClassService>())
                    {
                        _foodClasses = service.GetAll().ToList();
                    }
                }
                return _foodClasses;
            }
        }

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
            Telerik.WinControls.UI.GridViewComboBoxColumn gridViewComboBoxColumn1 = new Telerik.WinControls.UI.GridViewComboBoxColumn();
            Telerik.WinControls.UI.TableViewDefinition tableViewDefinition1 = new Telerik.WinControls.UI.TableViewDefinition();
            this.gvDailyMeasures = new Telerik.WinControls.UI.RadGridView();
            this.lbAggregate = new Telerik.WinControls.UI.RadLabel();
            this.btnSave = new Telerik.WinControls.UI.RadButton();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.ucWeekSelection = new Avicola.Production.Win.UserControls.UcWeekSelection();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.txtTotal = new Telerik.WinControls.UI.RadTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.gvDailyMeasures)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvDailyMeasures.MasterTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lbAggregate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSave)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtTotal)).BeginInit();
            this.SuspendLayout();
            // 
            // gvDailyMeasures
            // 
            this.gvDailyMeasures.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gvDailyMeasures.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gvDailyMeasures.Location = new System.Drawing.Point(4, 104);
            this.gvDailyMeasures.Margin = new System.Windows.Forms.Padding(4);
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
            gridViewTextBoxColumn1.Width = 210;
            gridViewTextBoxColumn2.FieldName = "Date";
            gridViewTextBoxColumn2.FormatString = "{0: dd/M/yyyy}";
            gridViewTextBoxColumn2.HeaderText = "Fecha";
            gridViewTextBoxColumn2.Name = "Date";
            gridViewTextBoxColumn2.ReadOnly = true;
            gridViewTextBoxColumn2.Width = 171;
            gridViewDecimalColumn1.EnableExpressionEditor = false;
            gridViewDecimalColumn1.Expression = "";
            gridViewDecimalColumn1.FieldName = "Value";
            gridViewDecimalColumn1.FormatString = "{0:N2}";
            gridViewDecimalColumn1.HeaderText = "Valor";
            gridViewDecimalColumn1.Name = "Value";
            gridViewDecimalColumn1.Width = 215;
            gridViewComboBoxColumn1.DisplayMember = "Name";
            gridViewComboBoxColumn1.FieldName = "FoodClassId";
            gridViewComboBoxColumn1.HeaderText = "Clase";
            gridViewComboBoxColumn1.MinWidth = 160;
            gridViewComboBoxColumn1.DataSource = FoodClasses;
            gridViewComboBoxColumn1.Name = "FoodClassId";
            gridViewComboBoxColumn1.ValueMember = "Id";
            gridViewComboBoxColumn1.Width = 160;

            this.gvDailyMeasures.MasterTemplate.Columns.AddRange(new Telerik.WinControls.UI.GridViewDataColumn[] {
            gridViewTextBoxColumn1,
            gridViewTextBoxColumn2,
            gridViewDecimalColumn1,
            gridViewComboBoxColumn1});
            this.gvDailyMeasures.MasterTemplate.ViewDefinition = tableViewDefinition1;
            this.gvDailyMeasures.Name = "gvDailyMeasures";
            this.gvDailyMeasures.Size = new System.Drawing.Size(773, 263);
            this.gvDailyMeasures.TabIndex = 5;
            this.gvDailyMeasures.CellBeginEdit += new Telerik.WinControls.UI.GridViewCellCancelEventHandler(this.gvDailyMeasures_CellBeginEdit);
            this.gvDailyMeasures.CellValueChanged += new Telerik.WinControls.UI.GridViewCellEventHandler(this.gvDailyMeasures_CellValueChanged);
            // 
            // lbAggregate
            // 
            this.lbAggregate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lbAggregate.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAggregate.Location = new System.Drawing.Point(4, 4);
            this.lbAggregate.Margin = new System.Windows.Forms.Padding(4);
            this.lbAggregate.Name = "lbAggregate";
            this.lbAggregate.Size = new System.Drawing.Size(107, 51);
            this.lbAggregate.TabIndex = 7;
            this.lbAggregate.Text = "Total:";
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.Location = new System.Drawing.Point(686, 4);
            this.btnSave.Margin = new System.Windows.Forms.Padding(4);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(85, 48);
            this.btnSave.TabIndex = 8;
            this.btnSave.Text = "Guardar";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.ucWeekSelection, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.gvDailyMeasures, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 62F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(781, 433);
            this.tableLayoutPanel1.TabIndex = 9;
            // 
            // ucWeekSelection
            // 
            this.ucWeekSelection.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ucWeekSelection.Current = 0;
            this.ucWeekSelection.Location = new System.Drawing.Point(5, 5);
            this.ucWeekSelection.Margin = new System.Windows.Forms.Padding(5);
            this.ucWeekSelection.MinimumSize = new System.Drawing.Size(0, 86);
            this.ucWeekSelection.Name = "ucWeekSelection";
            this.ucWeekSelection.NumberOfWeek = 0;
            this.ucWeekSelection.Size = new System.Drawing.Size(771, 86);
            this.ucWeekSelection.TabIndex = 0;
            this.ucWeekSelection.CurrentWeekChanged += new System.EventHandler<int>(this.ucWeekSelection_CurrentWeekChanged);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.33238F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 83.66763F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 108F));
            this.tableLayoutPanel2.Controls.Add(this.lbAggregate, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.txtTotal, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.btnSave, 2, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 374);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(775, 56);
            this.tableLayoutPanel2.TabIndex = 6;
            // 
            // txtTotal
            // 
            this.txtTotal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtTotal.Enabled = false;
            this.txtTotal.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotal.Location = new System.Drawing.Point(112, 4);
            this.txtTotal.Margin = new System.Windows.Forms.Padding(4);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(125, 50);
            this.txtTotal.TabIndex = 6;
            // 
            // UcLoadDailyMeasures
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "UcLoadDailyMeasures";
            this.Size = new System.Drawing.Size(781, 433);
            this.Load += new System.EventHandler(this.UcLoadDailyMeasures_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gvDailyMeasures.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvDailyMeasures)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lbAggregate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSave)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtTotal)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private UcWeekSelection ucWeekSelection;
        private Telerik.WinControls.UI.RadGridView gvDailyMeasures;
        private Telerik.WinControls.UI.RadLabel lbAggregate;
        private Telerik.WinControls.UI.RadButton btnSave;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private Telerik.WinControls.UI.RadTextBox txtTotal;

    }
}
