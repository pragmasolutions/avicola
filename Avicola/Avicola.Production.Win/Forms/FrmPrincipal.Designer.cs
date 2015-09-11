namespace Avicola.Production.Win.Forms
{
    partial class FrmPrincipal
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
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn7 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn8 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn9 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn10 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn11 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn12 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewCommandColumn gridViewCommandColumn2 = new Telerik.WinControls.UI.GridViewCommandColumn();
            Telerik.WinControls.UI.TableViewDefinition tableViewDefinition2 = new Telerik.WinControls.UI.TableViewDefinition();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.MainMenu = new Telerik.WinControls.UI.RadMenu();
            this.miMeasuresHistory = new Telerik.WinControls.UI.RadMenuItem();
            this.miCreateMeasures = new Telerik.WinControls.UI.RadMenuItem();
            this.radMenuItem3 = new Telerik.WinControls.UI.RadMenuItem();
            this.PnlBotones = new Telerik.WinControls.UI.RadPanel();
            this.wizard = new Telerik.WinControls.UI.RadWizard();
            this.wizardCompletionPage1 = new Telerik.WinControls.UI.WizardCompletionPage();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.gvBatches = new Telerik.WinControls.UI.RadGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.wizardWelcomePage1 = new Telerik.WinControls.UI.WizardWelcomePage();
            this.wizardPage1 = new Telerik.WinControls.UI.WizardPage();
            this.wpSelectStandard = new Telerik.WinControls.UI.WizardPage();
            this.ucStandardSelecction = new Avicola.Production.Win.UserControls.UcStandardSelecction();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MainMenu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PnlBotones)).BeginInit();
            this.PnlBotones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.wizard)).BeginInit();
            this.wizard.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvBatches)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvBatches.MasterTemplate)).BeginInit();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.Controls.Add(this.MainMenu, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1082, 24);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // MainMenu
            // 
            this.MainMenu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainMenu.Items.AddRange(new Telerik.WinControls.RadItem[] {
            this.miMeasuresHistory});
            this.MainMenu.Location = new System.Drawing.Point(3, 3);
            this.MainMenu.Name = "MainMenu";
            this.MainMenu.Size = new System.Drawing.Size(1076, 20);
            this.MainMenu.TabIndex = 0;
            // 
            // miMeasuresHistory
            // 
            this.miMeasuresHistory.AccessibleDescription = "Medidas";
            this.miMeasuresHistory.AccessibleName = "Medidas";
            this.miMeasuresHistory.Items.AddRange(new Telerik.WinControls.RadItem[] {
            this.miCreateMeasures,
            this.radMenuItem3});
            this.miMeasuresHistory.Name = "miMeasuresHistory";
            this.miMeasuresHistory.Text = "Medidas";
            // 
            // miCreateMeasures
            // 
            this.miCreateMeasures.AccessibleDescription = "Cargar Medidas";
            this.miCreateMeasures.AccessibleName = "Cargar Medidas";
            this.miCreateMeasures.Name = "miCreateMeasures";
            this.miCreateMeasures.Text = "Cargar Medidas";
            this.miCreateMeasures.Click += new System.EventHandler(this.miCreateMeasures_Click);
            // 
            // radMenuItem3
            // 
            this.radMenuItem3.AccessibleDescription = "Historial";
            this.radMenuItem3.AccessibleName = "Historial";
            this.radMenuItem3.Name = "radMenuItem3";
            this.radMenuItem3.Text = "Historial";
            this.radMenuItem3.Click += new System.EventHandler(this.miMeasuresHistory_Click);
            // 
            // PnlBotones
            // 
            this.PnlBotones.Controls.Add(this.wizard);
            this.PnlBotones.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PnlBotones.Location = new System.Drawing.Point(0, 24);
            this.PnlBotones.Name = "PnlBotones";
            this.PnlBotones.Size = new System.Drawing.Size(1082, 543);
            this.PnlBotones.TabIndex = 2;
            // 
            // wizard
            // 
            this.wizard.CompletionPage = this.wizardCompletionPage1;
            this.wizard.Controls.Add(this.panel1);
            this.wizard.Controls.Add(this.panel2);
            this.wizard.Controls.Add(this.panel3);
            this.wizard.Controls.Add(this.panel4);
            this.wizard.Dock = System.Windows.Forms.DockStyle.Fill;
            this.wizard.Location = new System.Drawing.Point(0, 0);
            this.wizard.Name = "wizard";
            this.wizard.PageHeaderIcon = null;
            this.wizard.Pages.Add(this.wizardWelcomePage1);
            this.wizard.Pages.Add(this.wizardPage1);
            this.wizard.Pages.Add(this.wpSelectStandard);
            this.wizard.Pages.Add(this.wizardCompletionPage1);
            this.wizard.Size = new System.Drawing.Size(1082, 543);
            this.wizard.TabIndex = 0;
            this.wizard.Text = "wizard";
            this.wizard.WelcomePage = this.wizardWelcomePage1;
            this.wizard.SelectedPageChanging += new Telerik.WinControls.UI.SelectedPageChangingEventHandler(this.wizzard_SelectedPageChanging);
            this.wizard.SelectedPageChanged += new Telerik.WinControls.UI.SelectedPageChangedEventHandler(this.wizard_SelectedPageChanged);
            // 
            // wizardCompletionPage1
            // 
            this.wizardCompletionPage1.ContentArea = this.panel3;
            this.wizardCompletionPage1.Header = "Page header";
            this.wizardCompletionPage1.Name = "wizardCompletionPage1";
            this.wizardCompletionPage1.Title = "Page title";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Location = new System.Drawing.Point(150, 56);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(932, 439);
            this.panel3.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.tableLayoutPanel2);
            this.panel1.Location = new System.Drawing.Point(150, 56);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(932, 439);
            this.panel1.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.gvBatches, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 90F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(932, 439);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // gvBatches
            // 
            this.gvBatches.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gvBatches.Location = new System.Drawing.Point(4, 4);
            this.gvBatches.Margin = new System.Windows.Forms.Padding(4);
            // 
            // 
            // 
            this.gvBatches.MasterTemplate.AllowAddNewRow = false;
            this.gvBatches.MasterTemplate.AllowDeleteRow = false;
            this.gvBatches.MasterTemplate.AllowDragToGroup = false;
            this.gvBatches.MasterTemplate.AllowEditRow = false;
            this.gvBatches.MasterTemplate.AutoGenerateColumns = false;
            this.gvBatches.MasterTemplate.AutoSizeColumnsMode = Telerik.WinControls.UI.GridViewAutoSizeColumnsMode.Fill;
            gridViewTextBoxColumn7.FieldName = "Number";
            gridViewTextBoxColumn7.HeaderText = "Número";
            gridViewTextBoxColumn7.Name = "Number";
            gridViewTextBoxColumn7.Width = 123;
            gridViewTextBoxColumn8.FieldName = "GeneticLineName";
            gridViewTextBoxColumn8.HeaderText = "Linea Genética";
            gridViewTextBoxColumn8.Name = "GeneticLineName";
            gridViewTextBoxColumn8.Width = 203;
            gridViewTextBoxColumn9.FieldName = "DateOfBirth";
            gridViewTextBoxColumn9.FormatString = "{0: dd/M/yyyy}";
            gridViewTextBoxColumn9.HeaderText = "Fecha de Nacimiento";
            gridViewTextBoxColumn9.MinWidth = 100;
            gridViewTextBoxColumn9.Name = "DateOfBirth";
            gridViewTextBoxColumn9.Width = 166;
            gridViewTextBoxColumn10.FieldName = "Week";
            gridViewTextBoxColumn10.HeaderText = "Semana Actual";
            gridViewTextBoxColumn10.Name = "Week";
            gridViewTextBoxColumn10.Width = 116;
            gridViewTextBoxColumn11.FieldName = "StageName";
            gridViewTextBoxColumn11.HeaderText = "Estado";
            gridViewTextBoxColumn11.Name = "StageName";
            gridViewTextBoxColumn11.Width = 55;
            gridViewTextBoxColumn12.FieldName = "BarnNumber";
            gridViewTextBoxColumn12.HeaderText = "Galpón";
            gridViewTextBoxColumn12.MinWidth = 80;
            gridViewTextBoxColumn12.Name = "BarnNumber";
            gridViewTextBoxColumn12.Width = 97;
            gridViewCommandColumn2.AllowResize = false;
            gridViewCommandColumn2.AllowSort = false;
            gridViewCommandColumn2.DefaultText = "Seleccionar";
            gridViewCommandColumn2.HeaderText = "";
            gridViewCommandColumn2.Name = "SelectColumn";
            gridViewCommandColumn2.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            gridViewCommandColumn2.UseDefaultText = true;
            gridViewCommandColumn2.Width = 150;
            this.gvBatches.MasterTemplate.Columns.AddRange(new Telerik.WinControls.UI.GridViewDataColumn[] {
            gridViewTextBoxColumn7,
            gridViewTextBoxColumn8,
            gridViewTextBoxColumn9,
            gridViewTextBoxColumn10,
            gridViewTextBoxColumn11,
            gridViewTextBoxColumn12,
            gridViewCommandColumn2});
            this.gvBatches.MasterTemplate.ViewDefinition = tableViewDefinition2;
            this.gvBatches.Name = "gvBatches";
            this.gvBatches.Size = new System.Drawing.Size(924, 387);
            this.gvBatches.TabIndex = 1;
            this.gvBatches.CommandCellClick += new Telerik.WinControls.UI.CommandCellClickEventHandler(this.gvBatches_CommandCellClick);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Location = new System.Drawing.Point(0, 81);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1082, 414);
            this.panel2.TabIndex = 1;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.Controls.Add(this.ucStandardSelecction);
            this.panel4.Location = new System.Drawing.Point(0, 64);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1082, 431);
            this.panel4.TabIndex = 3;
            // 
            // wizardWelcomePage1
            // 
            this.wizardWelcomePage1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.wizardWelcomePage1.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.wizardWelcomePage1.BackColor3 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.wizardWelcomePage1.ContentArea = this.panel1;
            this.wizardWelcomePage1.Header = "Page header";
            this.wizardWelcomePage1.Name = "wizardWelcomePage1";
            this.wizardWelcomePage1.Title = "Seleccionar Lote";
            // 
            // wizardPage1
            // 
            this.wizardPage1.ContentArea = this.panel2;
            this.wizardPage1.Header = "Seleccionar Operación";
            this.wizardPage1.Name = "wizardPage1";
            this.wizardPage1.Title = "Seleccionar Operación";
            // 
            // wpSelectStandard
            // 
            this.wpSelectStandard.ContentArea = this.panel4;
            this.wpSelectStandard.Header = "";
            this.wpSelectStandard.Name = "wpSelectStandard";
            this.wpSelectStandard.Title = "Seleccionar Indicador";
            // 
            // ucStandardSelecction
            // 
            this.ucStandardSelecction.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucStandardSelecction.Location = new System.Drawing.Point(0, 0);
            this.ucStandardSelecction.Name = "ucStandardSelecction";
            this.ucStandardSelecction.Size = new System.Drawing.Size(1082, 431);
            this.ucStandardSelecction.TabIndex = 0;
            this.ucStandardSelecction.StandardSelected += new System.EventHandler<Avicola.Office.Entities.Standard>(this.ucStandardSelecction_StandardSelected);
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1082, 567);
            this.Controls.Add(this.PnlBotones);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "FrmPrincipal";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.Text = "Sistema de gestión Avicola Santa Ana";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmPrincipal_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MainMenu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PnlBotones)).EndInit();
            this.PnlBotones.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.wizard)).EndInit();
            this.wizard.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gvBatches.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvBatches)).EndInit();
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private Telerik.WinControls.UI.RadMenu MainMenu;
        private Telerik.WinControls.UI.RadMenuItem miMeasuresHistory;
        private Telerik.WinControls.UI.RadPanel PnlBotones;
        private Telerik.WinControls.UI.RadMenuItem miCreateMeasures;
        private Telerik.WinControls.UI.RadMenuItem radMenuItem3;
        private Telerik.WinControls.UI.RadWizard wizard;
        private Telerik.WinControls.UI.WizardCompletionPage wizardCompletionPage1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private Telerik.WinControls.UI.WizardWelcomePage wizardWelcomePage1;
        private Telerik.WinControls.UI.WizardPage wizardPage1;
        private System.Windows.Forms.Panel panel4;
        private Telerik.WinControls.UI.WizardPage wpSelectStandard;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private Telerik.WinControls.UI.RadGridView gvBatches;
        private UserControls.UcStandardSelecction ucStandardSelecction;
    }
}
