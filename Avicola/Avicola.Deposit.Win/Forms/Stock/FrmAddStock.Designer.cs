namespace Avicola.Deposit.Win.Forms.Stock
{
    partial class FrmAddStock
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
            this.pbvStockEntry = new System.Windows.Forms.ErrorProvider(this.components);
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.ddlProducts = new Telerik.WinControls.UI.RadDropDownList();
            this.radLabel6 = new Telerik.WinControls.UI.RadLabel();
            this.ucDepositSelection = new Avicola.Deposit.Win.UserControls.UcDepositSelection();
            this.radLabel5 = new Telerik.WinControls.UI.RadLabel();
            this.ddlProviders = new Telerik.WinControls.UI.RadDropDownList();
            this.ckdProvider = new Telerik.WinControls.UI.RadRadioButton();
            this.ckdOwn = new Telerik.WinControls.UI.RadRadioButton();
            this.ddlShifts = new Telerik.WinControls.UI.RadDropDownList();
            this.radLabel4 = new Telerik.WinControls.UI.RadLabel();
            this.btnCancelar = new Telerik.WinControls.UI.RadButton();
            this.btnAceptar = new Telerik.WinControls.UI.RadButton();
            this.txtEggs = new Framework.Common.Win.Controls.CustomSpinEditor();
            this.radLabel3 = new Telerik.WinControls.UI.RadLabel();
            this.txtMaples = new Framework.Common.Win.Controls.CustomSpinEditor();
            this.txtBoxes = new Framework.Common.Win.Controls.CustomSpinEditor();
            this.radLabel2 = new Telerik.WinControls.UI.RadLabel();
            this.radLabel1 = new Telerik.WinControls.UI.RadLabel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.lbTitle = new Telerik.WinControls.UI.RadLabel();
            this.btnBackToDepositManager = new Telerik.WinControls.UI.RadButton();
            ((System.ComponentModel.ISupportInitialize)(this.pbvStockEntry)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ddlProducts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ddlProviders)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ckdProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ckdOwn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ddlShifts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCancelar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAceptar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEggs)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaples)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBoxes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lbTitle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnBackToDepositManager)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // pbvStockEntry
            // 
            this.pbvStockEntry.ContainerControl = this;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.tableLayoutPanel2);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.ddlProducts);
            this.splitContainer1.Panel2.Controls.Add(this.radLabel6);
            this.splitContainer1.Panel2.Controls.Add(this.ucDepositSelection);
            this.splitContainer1.Panel2.Controls.Add(this.radLabel5);
            this.splitContainer1.Panel2.Controls.Add(this.ddlProviders);
            this.splitContainer1.Panel2.Controls.Add(this.ckdProvider);
            this.splitContainer1.Panel2.Controls.Add(this.ckdOwn);
            this.splitContainer1.Panel2.Controls.Add(this.ddlShifts);
            this.splitContainer1.Panel2.Controls.Add(this.radLabel4);
            this.splitContainer1.Panel2.Controls.Add(this.btnCancelar);
            this.splitContainer1.Panel2.Controls.Add(this.btnAceptar);
            this.splitContainer1.Panel2.Controls.Add(this.txtEggs);
            this.splitContainer1.Panel2.Controls.Add(this.radLabel3);
            this.splitContainer1.Panel2.Controls.Add(this.txtMaples);
            this.splitContainer1.Panel2.Controls.Add(this.txtBoxes);
            this.splitContainer1.Panel2.Controls.Add(this.radLabel2);
            this.splitContainer1.Panel2.Controls.Add(this.radLabel1);
            this.splitContainer1.Size = new System.Drawing.Size(701, 495);
            this.splitContainer1.SplitterDistance = 58;
            this.splitContainer1.TabIndex = 0;
            // 
            // ddlProducts
            // 
            this.ddlProducts.AutoSize = false;
            this.ddlProducts.Location = new System.Drawing.Point(124, 60);
            this.ddlProducts.Name = "ddlProducts";
            this.ddlProducts.Size = new System.Drawing.Size(284, 27);
            this.ddlProducts.TabIndex = 15;
            this.ddlProducts.ThemeName = "TelerikMetroBlue";
            // 
            // radLabel6
            // 
            this.radLabel6.Location = new System.Drawing.Point(29, 62);
            this.radLabel6.Name = "radLabel6";
            this.radLabel6.Size = new System.Drawing.Size(74, 22);
            this.radLabel6.TabIndex = 28;
            this.radLabel6.Text = "Producto";
            this.radLabel6.ThemeName = "TelerikMetroBlue";
            // 
            // ucDepositSelection
            // 
            this.ucDepositSelection.Location = new System.Drawing.Point(124, 17);
            this.ucDepositSelection.Name = "ucDepositSelection";
            this.ucDepositSelection.Size = new System.Drawing.Size(284, 28);
            this.ucDepositSelection.TabIndex = 14;
            // 
            // radLabel5
            // 
            this.radLabel5.Location = new System.Drawing.Point(29, 20);
            this.radLabel5.Name = "radLabel5";
            this.radLabel5.Size = new System.Drawing.Size(73, 22);
            this.radLabel5.TabIndex = 13;
            this.radLabel5.Text = "Depósito";
            this.radLabel5.ThemeName = "TelerikMetroBlue";
            // 
            // ddlProviders
            // 
            this.ddlProviders.AutoSize = false;
            this.ddlProviders.Location = new System.Drawing.Point(124, 139);
            this.ddlProviders.Name = "ddlProviders";
            this.ddlProviders.Size = new System.Drawing.Size(284, 27);
            this.ddlProviders.TabIndex = 16;
            this.ddlProviders.ThemeName = "TelerikMetroBlue";
            this.ddlProviders.Visible = false;
            // 
            // ckdProvider
            // 
            this.ckdProvider.Location = new System.Drawing.Point(29, 143);
            this.ckdProvider.Name = "ckdProvider";
            this.ckdProvider.Size = new System.Drawing.Size(79, 19);
            this.ckdProvider.TabIndex = 27;
            this.ckdProvider.TabStop = false;
            this.ckdProvider.Text = "Proveedor";
            this.ckdProvider.ThemeName = "TelerikMetroBlue";
            this.ckdProvider.ToggleStateChanged += new Telerik.WinControls.UI.StateChangedEventHandler(this.ckdProvider_ToggleStateChanged);
            // 
            // ckdOwn
            // 
            this.ckdOwn.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ckdOwn.Location = new System.Drawing.Point(29, 104);
            this.ckdOwn.Name = "ckdOwn";
            this.ckdOwn.Size = new System.Drawing.Size(92, 19);
            this.ckdOwn.TabIndex = 25;
            this.ckdOwn.Text = "Stock propio";
            this.ckdOwn.ThemeName = "TelerikMetroBlue";
            this.ckdOwn.ToggleState = Telerik.WinControls.Enumerations.ToggleState.On;
            this.ckdOwn.ToggleStateChanged += new Telerik.WinControls.UI.StateChangedEventHandler(this.ckdOwn_ToggleStateChanged);
            // 
            // ddlShifts
            // 
            this.ddlShifts.AutoSize = false;
            this.ddlShifts.Location = new System.Drawing.Point(124, 180);
            this.ddlShifts.Name = "ddlShifts";
            this.ddlShifts.Size = new System.Drawing.Size(125, 27);
            this.ddlShifts.TabIndex = 19;
            this.ddlShifts.ThemeName = "TelerikMetroBlue";
            // 
            // radLabel4
            // 
            this.radLabel4.Location = new System.Drawing.Point(29, 182);
            this.radLabel4.Name = "radLabel4";
            this.radLabel4.Size = new System.Drawing.Size(51, 22);
            this.radLabel4.TabIndex = 23;
            this.radLabel4.Text = "Turno";
            this.radLabel4.ThemeName = "TelerikMetroBlue";
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(333, 386);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 24);
            this.btnCancelar.TabIndex = 26;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.ThemeName = "TelerikMetroBlue";
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(252, 386);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(75, 24);
            this.btnAceptar.TabIndex = 24;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.ThemeName = "TelerikMetroBlue";
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // txtEggs
            // 
            this.txtEggs.Location = new System.Drawing.Point(124, 306);
            this.txtEggs.Name = "txtEggs";
            this.txtEggs.NullableValue = null;
            this.txtEggs.Size = new System.Drawing.Size(125, 27);
            this.txtEggs.TabIndex = 22;
            this.txtEggs.TabStop = false;
            this.txtEggs.ThemeName = "TelerikMetroBlue";
            // 
            // radLabel3
            // 
            this.radLabel3.Location = new System.Drawing.Point(29, 308);
            this.radLabel3.Name = "radLabel3";
            this.radLabel3.Size = new System.Drawing.Size(78, 22);
            this.radLabel3.TabIndex = 18;
            this.radLabel3.Text = "Unidades";
            this.radLabel3.ThemeName = "TelerikMetroBlue";
            // 
            // txtMaples
            // 
            this.txtMaples.Location = new System.Drawing.Point(124, 264);
            this.txtMaples.Name = "txtMaples";
            this.txtMaples.NullableValue = null;
            this.txtMaples.Size = new System.Drawing.Size(125, 27);
            this.txtMaples.TabIndex = 21;
            this.txtMaples.TabStop = false;
            this.txtMaples.ThemeName = "TelerikMetroBlue";
            // 
            // txtBoxes
            // 
            this.txtBoxes.Location = new System.Drawing.Point(124, 222);
            this.txtBoxes.Name = "txtBoxes";
            this.txtBoxes.NullableValue = null;
            this.txtBoxes.Size = new System.Drawing.Size(125, 27);
            this.txtBoxes.TabIndex = 20;
            this.txtBoxes.TabStop = false;
            this.txtBoxes.ThemeName = "TelerikMetroBlue";
            // 
            // radLabel2
            // 
            this.radLabel2.Location = new System.Drawing.Point(29, 266);
            this.radLabel2.Name = "radLabel2";
            this.radLabel2.Size = new System.Drawing.Size(61, 22);
            this.radLabel2.TabIndex = 17;
            this.radLabel2.Text = "Maples";
            this.radLabel2.ThemeName = "TelerikMetroBlue";
            // 
            // radLabel1
            // 
            this.radLabel1.Location = new System.Drawing.Point(29, 224);
            this.radLabel1.Name = "radLabel1";
            this.radLabel1.Size = new System.Drawing.Size(50, 22);
            this.radLabel1.TabIndex = 12;
            this.radLabel1.Text = "Cajas";
            this.radLabel1.ThemeName = "TelerikMetroBlue";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.26248F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 83.73752F));
            this.tableLayoutPanel2.Controls.Add(this.lbTitle, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.btnBackToDepositManager, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(701, 58);
            this.tableLayoutPanel2.TabIndex = 10;
            // 
            // lbTitle
            // 
            this.lbTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbTitle.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitle.Location = new System.Drawing.Point(116, 3);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(199, 41);
            this.lbTitle.TabIndex = 13;
            this.lbTitle.Text = "Ingresar Stock";
            // 
            // btnBackToDepositManager
            // 
            this.btnBackToDepositManager.Location = new System.Drawing.Point(8, 12);
            this.btnBackToDepositManager.Margin = new System.Windows.Forms.Padding(8, 12, 8, 8);
            this.btnBackToDepositManager.Name = "btnBackToDepositManager";
            this.btnBackToDepositManager.Size = new System.Drawing.Size(87, 24);
            this.btnBackToDepositManager.TabIndex = 10;
            this.btnBackToDepositManager.Text = "Volver";
            this.btnBackToDepositManager.Click += new System.EventHandler(this.btnBackToDepositManager_Click);
            // 
            // FrmAddStock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(701, 495);
            this.ControlBox = false;
            this.Controls.Add(this.splitContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MinimizeBox = false;
            this.Name = "FrmAddStock";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.Text = "Ingresar stock";
            this.Load += new System.EventHandler(this.FrmAddStock_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbvStockEntry)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ddlProducts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ddlProviders)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ckdProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ckdOwn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ddlShifts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCancelar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAceptar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEggs)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaples)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBoxes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lbTitle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnBackToDepositManager)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ErrorProvider pbvStockEntry;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private Telerik.WinControls.UI.RadDropDownList ddlProducts;
        private Telerik.WinControls.UI.RadLabel radLabel6;
        private UserControls.UcDepositSelection ucDepositSelection;
        private Telerik.WinControls.UI.RadLabel radLabel5;
        private Telerik.WinControls.UI.RadDropDownList ddlProviders;
        private Telerik.WinControls.UI.RadRadioButton ckdProvider;
        private Telerik.WinControls.UI.RadRadioButton ckdOwn;
        private Telerik.WinControls.UI.RadDropDownList ddlShifts;
        private Telerik.WinControls.UI.RadLabel radLabel4;
        private Telerik.WinControls.UI.RadButton btnCancelar;
        private Telerik.WinControls.UI.RadButton btnAceptar;
        private Framework.Common.Win.Controls.CustomSpinEditor txtEggs;
        private Telerik.WinControls.UI.RadLabel radLabel3;
        private Framework.Common.Win.Controls.CustomSpinEditor txtMaples;
        private Framework.Common.Win.Controls.CustomSpinEditor txtBoxes;
        private Telerik.WinControls.UI.RadLabel radLabel2;
        private Telerik.WinControls.UI.RadLabel radLabel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private Telerik.WinControls.UI.RadLabel lbTitle;
        private Telerik.WinControls.UI.RadButton btnBackToDepositManager;
    }
}
