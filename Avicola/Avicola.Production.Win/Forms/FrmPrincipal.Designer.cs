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
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn1 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn2 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn3 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn4 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn5 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn6 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewCommandColumn gridViewCommandColumn1 = new Telerik.WinControls.UI.GridViewCommandColumn();
            Telerik.WinControls.UI.TableViewDefinition tableViewDefinition1 = new Telerik.WinControls.UI.TableViewDefinition();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPrincipal));
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
            this.btnCreateBatch = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnEliminarLote = new System.Windows.Forms.Button();
            this.btnFinalizar = new System.Windows.Forms.Button();
            this.btnGalpon = new System.Windows.Forms.Button();
            this.btnObservaciones = new System.Windows.Forms.Button();
            this.btnVacunas = new System.Windows.Forms.Button();
            this.btnEstandares = new System.Windows.Forms.Button();
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
            this.panel4 = new System.Windows.Forms.Panel();
            this.wizardWelcomePage1 = new Telerik.WinControls.UI.WizardWelcomePage();
            this.wizardPage1 = new Telerik.WinControls.UI.WizardPage();
            this.wpSelectStandard = new Telerik.WinControls.UI.WizardPage();
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
            this.panel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.panel5.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
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
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1466, 24);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // MainMenu
            // 
            this.MainMenu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainMenu.Items.AddRange(new Telerik.WinControls.RadItem[] {
            this.miMeasuresHistory});
            this.MainMenu.Location = new System.Drawing.Point(3, 3);
            this.MainMenu.Name = "MainMenu";
            this.MainMenu.Size = new System.Drawing.Size(1076, 18);
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
            this.PnlBotones.Size = new System.Drawing.Size(1466, 477);
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
            this.wizard.Size = new System.Drawing.Size(1466, 477);
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
            this.panel3.Size = new System.Drawing.Size(932, 391);
            this.panel3.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.tableLayoutPanel2);
            this.panel1.Location = new System.Drawing.Point(150, 56);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1316, 366);
            this.panel1.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.gvBatches, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.btnCreateBatch, 0, 1);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 90F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1316, 366);
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
            gridViewTextBoxColumn1.FieldName = "Number";
            gridViewTextBoxColumn1.HeaderText = "Número";
            gridViewTextBoxColumn1.Name = "Number";
            gridViewTextBoxColumn1.Width = 185;
            gridViewTextBoxColumn2.FieldName = "GeneticLineName";
            gridViewTextBoxColumn2.HeaderText = "Linea Genética";
            gridViewTextBoxColumn2.Name = "GeneticLineName";
            gridViewTextBoxColumn2.Width = 306;
            gridViewTextBoxColumn3.FieldName = "DateOfBirth";
            gridViewTextBoxColumn3.FormatString = "{0: dd/M/yyyy}";
            gridViewTextBoxColumn3.HeaderText = "Fecha de Nacimiento";
            gridViewTextBoxColumn3.MinWidth = 100;
            gridViewTextBoxColumn3.Name = "DateOfBirth";
            gridViewTextBoxColumn3.Width = 250;
            gridViewTextBoxColumn4.FieldName = "Week";
            gridViewTextBoxColumn4.HeaderText = "Semana Actual";
            gridViewTextBoxColumn4.Name = "Week";
            gridViewTextBoxColumn4.Width = 174;
            gridViewTextBoxColumn5.FieldName = "StageName";
            gridViewTextBoxColumn5.HeaderText = "Estado";
            gridViewTextBoxColumn5.Name = "StageName";
            gridViewTextBoxColumn5.Width = 83;
            gridViewTextBoxColumn6.FieldName = "BarnNumber";
            gridViewTextBoxColumn6.HeaderText = "Galpón";
            gridViewTextBoxColumn6.MinWidth = 80;
            gridViewTextBoxColumn6.Name = "BarnNumber";
            gridViewTextBoxColumn6.Width = 146;
            gridViewCommandColumn1.AllowResize = false;
            gridViewCommandColumn1.AllowSort = false;
            gridViewCommandColumn1.DefaultText = "Seleccionar";
            gridViewCommandColumn1.HeaderText = "";
            gridViewCommandColumn1.Name = "SelectColumn";
            gridViewCommandColumn1.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            gridViewCommandColumn1.UseDefaultText = true;
            gridViewCommandColumn1.Width = 150;
            this.gvBatches.MasterTemplate.Columns.AddRange(new Telerik.WinControls.UI.GridViewDataColumn[] {
            gridViewTextBoxColumn1,
            gridViewTextBoxColumn2,
            gridViewTextBoxColumn3,
            gridViewTextBoxColumn4,
            gridViewTextBoxColumn5,
            gridViewTextBoxColumn6,
            gridViewCommandColumn1});
            this.gvBatches.MasterTemplate.ViewDefinition = tableViewDefinition1;
            this.gvBatches.Name = "gvBatches";
            this.gvBatches.Size = new System.Drawing.Size(1308, 321);
            this.gvBatches.TabIndex = 1;
            this.gvBatches.CommandCellClick += new Telerik.WinControls.UI.CommandCellClickEventHandler(this.gvBatches_CommandCellClick);
            // 
            // btnCreateBatch
            // 
            this.btnCreateBatch.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnCreateBatch.Location = new System.Drawing.Point(1151, 332);
            this.btnCreateBatch.Name = "btnCreateBatch";
            this.btnCreateBatch.Size = new System.Drawing.Size(162, 30);
            this.btnCreateBatch.TabIndex = 2;
            this.btnCreateBatch.Text = "Crear Lote";
            this.btnCreateBatch.UseVisualStyleBackColor = true;
            this.btnCreateBatch.Click += new System.EventHandler(this.btnCreateBatch_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.tableLayoutPanel3);
            this.panel2.Location = new System.Drawing.Point(0, 81);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1466, 336);
            this.panel2.TabIndex = 1;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Controls.Add(this.panel5, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.groupBox2, 0, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 2;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 175F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(1466, 336);
            this.tableLayoutPanel3.TabIndex = 0;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.groupBox1);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(3, 178);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1460, 155);
            this.panel5.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnEliminarLote);
            this.groupBox1.Controls.Add(this.btnFinalizar);
            this.groupBox1.Controls.Add(this.btnGalpon);
            this.groupBox1.Controls.Add(this.btnObservaciones);
            this.groupBox1.Controls.Add(this.btnVacunas);
            this.groupBox1.Controls.Add(this.btnEstandares);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1460, 155);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Operación";
            // 
            // btnEliminarLote
            // 
            this.btnEliminarLote.Image = ((System.Drawing.Image)(resources.GetObject("btnEliminarLote.Image")));
            this.btnEliminarLote.Location = new System.Drawing.Point(1240, 25);
            this.btnEliminarLote.Name = "btnEliminarLote";
            this.btnEliminarLote.Size = new System.Drawing.Size(230, 159);
            this.btnEliminarLote.TabIndex = 13;
            this.btnEliminarLote.Text = "Eliminar Lote";
            this.btnEliminarLote.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnEliminarLote.UseVisualStyleBackColor = true;
            this.btnEliminarLote.Click += new System.EventHandler(this.btnEliminarLote_Click);
            // 
            // btnFinalizar
            // 
            this.btnFinalizar.Image = ((System.Drawing.Image)(resources.GetObject("btnFinalizar.Image")));
            this.btnFinalizar.Location = new System.Drawing.Point(1000, 25);
            this.btnFinalizar.Name = "btnFinalizar";
            this.btnFinalizar.Size = new System.Drawing.Size(230, 159);
            this.btnFinalizar.TabIndex = 12;
            this.btnFinalizar.Text = "Finalizar Lote";
            this.btnFinalizar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnFinalizar.UseVisualStyleBackColor = true;
            this.btnFinalizar.Click += new System.EventHandler(this.btnFinalizar_Click);
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
            // 
            // btnObservaciones
            // 
            this.btnObservaciones.Image = ((System.Drawing.Image)(resources.GetObject("btnObservaciones.Image")));
            this.btnObservaciones.Location = new System.Drawing.Point(519, 25);
            this.btnObservaciones.Name = "btnObservaciones";
            this.btnObservaciones.Size = new System.Drawing.Size(230, 159);
            this.btnObservaciones.TabIndex = 10;
            this.btnObservaciones.Text = "Registrar notas";
            this.btnObservaciones.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnObservaciones.UseVisualStyleBackColor = true;
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
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(3, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1460, 169);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Detall de lote";
            // 
            // txtFechaIngresoGalpon
            // 
            this.txtFechaIngresoGalpon.Location = new System.Drawing.Point(643, 148);
            this.txtFechaIngresoGalpon.Name = "txtFechaIngresoGalpon";
            this.txtFechaIngresoGalpon.ReadOnly = true;
            this.txtFechaIngresoGalpon.Size = new System.Drawing.Size(205, 20);
            this.txtFechaIngresoGalpon.TabIndex = 11;
            // 
            // txtGalpon
            // 
            this.txtGalpon.Location = new System.Drawing.Point(643, 59);
            this.txtGalpon.Name = "txtGalpon";
            this.txtGalpon.ReadOnly = true;
            this.txtGalpon.Size = new System.Drawing.Size(205, 20);
            this.txtGalpon.TabIndex = 10;
            // 
            // txtSemanaActual
            // 
            this.txtSemanaActual.Location = new System.Drawing.Point(358, 148);
            this.txtSemanaActual.Name = "txtSemanaActual";
            this.txtSemanaActual.ReadOnly = true;
            this.txtSemanaActual.Size = new System.Drawing.Size(205, 20);
            this.txtSemanaActual.TabIndex = 9;
            // 
            // txtEtapa
            // 
            this.txtEtapa.Location = new System.Drawing.Point(358, 59);
            this.txtEtapa.Name = "txtEtapa";
            this.txtEtapa.ReadOnly = true;
            this.txtEtapa.Size = new System.Drawing.Size(205, 20);
            this.txtEtapa.TabIndex = 8;
            // 
            // txtLineaGenetica
            // 
            this.txtLineaGenetica.Location = new System.Drawing.Point(39, 148);
            this.txtLineaGenetica.Name = "txtLineaGenetica";
            this.txtLineaGenetica.ReadOnly = true;
            this.txtLineaGenetica.Size = new System.Drawing.Size(205, 20);
            this.txtLineaGenetica.TabIndex = 7;
            // 
            // txtNumero
            // 
            this.txtNumero.Location = new System.Drawing.Point(39, 59);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.ReadOnly = true;
            this.txtNumero.Size = new System.Drawing.Size(205, 20);
            this.txtNumero.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(354, 37);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(36, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Etapa";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(639, 126);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(128, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Fecha ingreso a galpón";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(354, 126);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Semana Actual";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(639, 37);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Galpón";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 126);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Línea Genética";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Número";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.Location = new System.Drawing.Point(0, 81);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1082, 366);
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
            this.wpSelectStandard.Header = "Page header";
            this.wpSelectStandard.Name = "wpSelectStandard";
            this.wpSelectStandard.Title = "Page title";
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1466, 501);
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
            this.panel2.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
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
        private System.Windows.Forms.Button btnCreateBatch;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnGalpon;
        private System.Windows.Forms.Button btnObservaciones;
        private System.Windows.Forms.Button btnVacunas;
        private System.Windows.Forms.Button btnEstandares;
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
        private System.Windows.Forms.Button btnFinalizar;
        private System.Windows.Forms.Button btnEliminarLote;
    }
}
