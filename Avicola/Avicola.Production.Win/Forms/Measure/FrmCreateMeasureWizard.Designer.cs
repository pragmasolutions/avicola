namespace Avicola.Production.Win.Forms.Measure
{
    partial class FrmCreateMeasureWizard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCreateMeasureWizard));
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn1 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn2 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn3 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn4 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewCommandColumn gridViewCommandColumn1 = new Telerik.WinControls.UI.GridViewCommandColumn();
            Telerik.WinControls.UI.TableViewDefinition tableViewDefinition1 = new Telerik.WinControls.UI.TableViewDefinition();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn5 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn6 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewDateTimeColumn gridViewDateTimeColumn1 = new Telerik.WinControls.UI.GridViewDateTimeColumn();
            Telerik.WinControls.UI.GridViewDecimalColumn gridViewDecimalColumn1 = new Telerik.WinControls.UI.GridViewDecimalColumn();
            Telerik.WinControls.UI.TableViewDefinition tableViewDefinition2 = new Telerik.WinControls.UI.TableViewDefinition();
            this.createMeasureWizard = new Telerik.WinControls.UI.RadWizard();
            this.wizardCompletionPage1 = new Telerik.WinControls.UI.WizardCompletionPage();
            this.panel3 = new System.Windows.Forms.Panel();
            this.ucLoadMeasuresSummary = new Avicola.Production.Win.UserControls.UcLoadMeasuresSummary();
            this.panel2 = new System.Windows.Forms.Panel();
            this.gvBatches = new Telerik.WinControls.UI.RadGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.gvMeasures = new Telerik.WinControls.UI.RadGridView();
            this.wizardPage1 = new Telerik.WinControls.UI.WizardPage();
            this.wizardPage2 = new Telerik.WinControls.UI.WizardPage();
            ((System.ComponentModel.ISupportInitialize)(this.createMeasureWizard)).BeginInit();
            this.createMeasureWizard.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvBatches)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvBatches.MasterTemplate)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvMeasures)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvMeasures.MasterTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // createMeasureWizard
            // 
            this.createMeasureWizard.CompletionPage = this.wizardCompletionPage1;
            this.createMeasureWizard.Controls.Add(this.panel2);
            this.createMeasureWizard.Controls.Add(this.panel3);
            this.createMeasureWizard.Controls.Add(this.panel1);
            this.createMeasureWizard.Dock = System.Windows.Forms.DockStyle.Fill;
            this.createMeasureWizard.HideCompletionImage = true;
            this.createMeasureWizard.Location = new System.Drawing.Point(0, 0);
            this.createMeasureWizard.Name = "createMeasureWizard";
            this.createMeasureWizard.PageHeaderIcon = ((System.Drawing.Image)(resources.GetObject("createMeasureWizard.PageHeaderIcon")));
            this.createMeasureWizard.Pages.Add(this.wizardPage1);
            this.createMeasureWizard.Pages.Add(this.wizardPage2);
            this.createMeasureWizard.Pages.Add(this.wizardCompletionPage1);
            this.createMeasureWizard.Size = new System.Drawing.Size(827, 547);
            this.createMeasureWizard.TabIndex = 0;
            this.createMeasureWizard.WelcomePage = null;
            this.createMeasureWizard.Finish += new System.EventHandler(this.createMeasureWizard_Finish);
            this.createMeasureWizard.Cancel += new System.EventHandler(this.createMeasureWizard_Cancel);
            this.createMeasureWizard.SelectedPageChanging += new Telerik.WinControls.UI.SelectedPageChangingEventHandler(this.createMeasureWizard_SelectedPageChanging);
            this.createMeasureWizard.SelectedPageChanged += new Telerik.WinControls.UI.SelectedPageChangedEventHandler(this.createMeasureWizard_SelectedPageChanged);
            // 
            // wizardCompletionPage1
            // 
            this.wizardCompletionPage1.ContentArea = this.panel3;
            this.wizardCompletionPage1.Header = "";
            this.wizardCompletionPage1.Name = "wizardCompletionPage1";
            this.wizardCompletionPage1.Title = "Resumen";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Controls.Add(this.ucLoadMeasuresSummary);
            this.panel3.Location = new System.Drawing.Point(0, 56);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(827, 443);
            this.panel3.TabIndex = 2;
            // 
            // ucLoadMeasuresSummary
            // 
            this.ucLoadMeasuresSummary.Location = new System.Drawing.Point(12, 14);
            this.ucLoadMeasuresSummary.Name = "ucLoadMeasuresSummary";
            this.ucLoadMeasuresSummary.Size = new System.Drawing.Size(488, 248);
            this.ucLoadMeasuresSummary.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.gvBatches);
            this.panel2.Location = new System.Drawing.Point(0, 64);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(827, 435);
            this.panel2.TabIndex = 1;
            // 
            // gvBatches
            // 
            this.gvBatches.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gvBatches.Location = new System.Drawing.Point(0, 0);
            // 
            // 
            // 
            this.gvBatches.MasterTemplate.AllowAddNewRow = false;
            this.gvBatches.MasterTemplate.AllowDeleteRow = false;
            this.gvBatches.MasterTemplate.AllowDragToGroup = false;
            this.gvBatches.MasterTemplate.AllowEditRow = false;
            this.gvBatches.MasterTemplate.AutoGenerateColumns = false;
            this.gvBatches.MasterTemplate.AutoSizeColumnsMode = Telerik.WinControls.UI.GridViewAutoSizeColumnsMode.Fill;
            gridViewTextBoxColumn1.FieldName = "Number";
            gridViewTextBoxColumn1.HeaderText = "Número";
            gridViewTextBoxColumn1.Name = "Number";
            gridViewTextBoxColumn1.Width = 187;
            gridViewTextBoxColumn2.FieldName = "GeneticLineName";
            gridViewTextBoxColumn2.HeaderText = "Linea Genética";
            gridViewTextBoxColumn2.Name = "GeneticLineName";
            gridViewTextBoxColumn2.Width = 187;
            gridViewTextBoxColumn3.FieldName = "StageName";
            gridViewTextBoxColumn3.HeaderText = "Estado";
            gridViewTextBoxColumn3.Name = "StageName";
            gridViewTextBoxColumn3.Width = 133;
            gridViewTextBoxColumn4.FieldName = "CreatedDate";
            gridViewTextBoxColumn4.FormatString = "{0: dd/M/yyyy}";
            gridViewTextBoxColumn4.HeaderText = "Fecha Creación";
            gridViewTextBoxColumn4.MinWidth = 100;
            gridViewTextBoxColumn4.Name = "CreatedDate";
            gridViewTextBoxColumn4.Width = 100;
            gridViewCommandColumn1.AllowResize = false;
            gridViewCommandColumn1.AllowSort = false;
            gridViewCommandColumn1.DefaultText = "Seleccionar";
            gridViewCommandColumn1.HeaderText = "";
            gridViewCommandColumn1.Name = "SelectColumn";
            gridViewCommandColumn1.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            gridViewCommandColumn1.UseDefaultText = true;
            gridViewCommandColumn1.Width = 204;
            this.gvBatches.MasterTemplate.Columns.AddRange(new Telerik.WinControls.UI.GridViewDataColumn[] {
            gridViewTextBoxColumn1,
            gridViewTextBoxColumn2,
            gridViewTextBoxColumn3,
            gridViewTextBoxColumn4,
            gridViewCommandColumn1});
            this.gvBatches.MasterTemplate.ViewDefinition = tableViewDefinition1;
            this.gvBatches.Name = "gvBatches";
            this.gvBatches.Size = new System.Drawing.Size(827, 435);
            this.gvBatches.TabIndex = 0;
            this.gvBatches.CommandCellClick += new Telerik.WinControls.UI.CommandCellClickEventHandler(this.gvBatches_CommandCellClick);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.gvMeasures);
            this.panel1.Location = new System.Drawing.Point(0, 81);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(827, 418);
            this.panel1.TabIndex = 3;
            // 
            // gvMeasures
            // 
            this.gvMeasures.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gvMeasures.Location = new System.Drawing.Point(0, 0);
            // 
            // 
            // 
            this.gvMeasures.MasterTemplate.AllowAddNewRow = false;
            this.gvMeasures.MasterTemplate.AllowColumnReorder = false;
            this.gvMeasures.MasterTemplate.AllowDeleteRow = false;
            this.gvMeasures.MasterTemplate.AllowDragToGroup = false;
            this.gvMeasures.MasterTemplate.AutoGenerateColumns = false;
            this.gvMeasures.MasterTemplate.AutoSizeColumnsMode = Telerik.WinControls.UI.GridViewAutoSizeColumnsMode.Fill;
            gridViewTextBoxColumn5.FieldName = "Name";
            gridViewTextBoxColumn5.HeaderText = "Nombre";
            gridViewTextBoxColumn5.Name = "Name";
            gridViewTextBoxColumn5.ReadOnly = true;
            gridViewTextBoxColumn5.Width = 466;
            gridViewTextBoxColumn6.FieldName = "MeasureUnity";
            gridViewTextBoxColumn6.HeaderText = "Unidad de Medida";
            gridViewTextBoxColumn6.Name = "MeasureUnity";
            gridViewTextBoxColumn6.ReadOnly = true;
            gridViewTextBoxColumn6.Width = 139;
            gridViewDateTimeColumn1.ExcelExportType = Telerik.WinControls.UI.Export.DisplayFormatType.ShortDate;
            gridViewDateTimeColumn1.FieldName = "CreatedDate";
            gridViewDateTimeColumn1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            gridViewDateTimeColumn1.FormatString = "{0: dd/M/yyyy}";
            gridViewDateTimeColumn1.HeaderText = "Fecha";
            gridViewDateTimeColumn1.Name = "CreatedDate";
            gridViewDateTimeColumn1.Width = 103;
            gridViewDecimalColumn1.EnableExpressionEditor = false;
            gridViewDecimalColumn1.Expression = "";
            gridViewDecimalColumn1.FieldName = "Value";
            gridViewDecimalColumn1.HeaderText = "Valor";
            gridViewDecimalColumn1.Name = "Value";
            gridViewDecimalColumn1.Width = 102;
            this.gvMeasures.MasterTemplate.Columns.AddRange(new Telerik.WinControls.UI.GridViewDataColumn[] {
            gridViewTextBoxColumn5,
            gridViewTextBoxColumn6,
            gridViewDateTimeColumn1,
            gridViewDecimalColumn1});
            this.gvMeasures.MasterTemplate.ViewDefinition = tableViewDefinition2;
            this.gvMeasures.Name = "gvMeasures";
            this.gvMeasures.Size = new System.Drawing.Size(827, 418);
            this.gvMeasures.TabIndex = 4;
            // 
            // wizardPage1
            // 
            this.wizardPage1.ContentArea = this.panel2;
            this.wizardPage1.Header = "";
            this.wizardPage1.Name = "wizardPage1";
            this.wizardPage1.Title = "Seleccionar Lote";
            // 
            // wizardPage2
            // 
            this.wizardPage2.ContentArea = this.panel1;
            this.wizardPage2.Header = "Estandares";
            this.wizardPage2.Name = "wizardPage2";
            this.wizardPage2.Title = "Ingreso de Valores";
            // 
            // FrmCreateMeasureWizard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(827, 547);
            this.Controls.Add(this.createMeasureWizard);
            this.Name = "FrmCreateMeasureWizard";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.Text = "Cargar Medidas";
            this.Load += new System.EventHandler(this.FrmCreateMeasureWizard_Load);
            ((System.ComponentModel.ISupportInitialize)(this.createMeasureWizard)).EndInit();
            this.createMeasureWizard.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gvBatches.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvBatches)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gvMeasures.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvMeasures)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Telerik.WinControls.UI.RadWizard createMeasureWizard;
        private Telerik.WinControls.UI.WizardCompletionPage wizardCompletionPage1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private Telerik.WinControls.UI.WizardPage wizardPage1;
        private Telerik.WinControls.UI.WizardPage wizardPage2;
        private Telerik.WinControls.UI.RadGridView gvBatches;
        private Telerik.WinControls.UI.RadGridView gvMeasures;
        private UserControls.UcLoadMeasuresSummary ucLoadMeasuresSummary;
    }
}
