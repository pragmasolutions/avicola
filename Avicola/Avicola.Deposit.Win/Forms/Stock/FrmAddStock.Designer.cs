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
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.lbTitle = new Telerik.WinControls.UI.RadLabel();
            this.btnBackToDepositManager = new Telerik.WinControls.UI.RadButton();
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
            this.ucEggsAmount = new Avicola.Deposit.Win.UserControls.UcEggsAmount();
            ((System.ComponentModel.ISupportInitialize)(this.pbvStockEntry)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lbTitle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnBackToDepositManager)).BeginInit();
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
            this.splitContainer1.Panel2.Controls.Add(this.ucEggsAmount);
            this.splitContainer1.Size = new System.Drawing.Size(701, 605);
            this.splitContainer1.SplitterDistance = 70;
            this.splitContainer1.TabIndex = 0;
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
            this.tableLayoutPanel2.Size = new System.Drawing.Size(701, 70);
            this.tableLayoutPanel2.TabIndex = 10;
            // 
            // lbTitle
            // 
            this.lbTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbTitle.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitle.Location = new System.Drawing.Point(116, 3);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(582, 41);
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
            // ddlProducts
            // 
            this.ddlProducts.AutoSize = false;
            this.ddlProducts.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.ddlProducts.Location = new System.Drawing.Point(49, 110);
            this.ddlProducts.Name = "ddlProducts";
            this.ddlProducts.Size = new System.Drawing.Size(284, 27);
            this.ddlProducts.TabIndex = 15;
            this.ddlProducts.ThemeName = "TelerikMetroBlue";
            // 
            // radLabel6
            // 
            this.radLabel6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.radLabel6.Location = new System.Drawing.Point(50, 82);
            this.radLabel6.Name = "radLabel6";
            this.radLabel6.Size = new System.Drawing.Size(69, 21);
            this.radLabel6.TabIndex = 28;
            this.radLabel6.Text = "Producto";
            this.radLabel6.ThemeName = "TelerikMetroBlue";
            // 
            // ucDepositSelection
            // 
            this.ucDepositSelection.Location = new System.Drawing.Point(49, 48);
            this.ucDepositSelection.Name = "ucDepositSelection";
            this.ucDepositSelection.Size = new System.Drawing.Size(284, 28);
            this.ucDepositSelection.TabIndex = 14;
            // 
            // radLabel5
            // 
            this.radLabel5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.radLabel5.Location = new System.Drawing.Point(50, 20);
            this.radLabel5.Name = "radLabel5";
            this.radLabel5.Size = new System.Drawing.Size(69, 21);
            this.radLabel5.TabIndex = 13;
            this.radLabel5.Text = "Depósito";
            this.radLabel5.ThemeName = "TelerikMetroBlue";
            // 
            // ddlProviders
            // 
            this.ddlProviders.AutoSize = false;
            this.ddlProviders.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.ddlProviders.Location = new System.Drawing.Point(49, 193);
            this.ddlProviders.Name = "ddlProviders";
            this.ddlProviders.Size = new System.Drawing.Size(284, 27);
            this.ddlProviders.TabIndex = 16;
            this.ddlProviders.ThemeName = "TelerikMetroBlue";
            this.ddlProviders.Visible = false;
            // 
            // ckdProvider
            // 
            this.ckdProvider.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.ckdProvider.Location = new System.Drawing.Point(50, 168);
            this.ckdProvider.Name = "ckdProvider";
            this.ckdProvider.Size = new System.Drawing.Size(95, 21);
            this.ckdProvider.TabIndex = 27;
            this.ckdProvider.TabStop = false;
            this.ckdProvider.Text = "Proveedor";
            this.ckdProvider.ThemeName = "TelerikMetroBlue";
            this.ckdProvider.ToggleStateChanged += new Telerik.WinControls.UI.StateChangedEventHandler(this.ckdProvider_ToggleStateChanged);
            // 
            // ckdOwn
            // 
            this.ckdOwn.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ckdOwn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.ckdOwn.Location = new System.Drawing.Point(50, 143);
            this.ckdOwn.Name = "ckdOwn";
            this.ckdOwn.Size = new System.Drawing.Size(109, 21);
            this.ckdOwn.TabIndex = 25;
            this.ckdOwn.Text = "Stock propio";
            this.ckdOwn.ThemeName = "TelerikMetroBlue";
            this.ckdOwn.ToggleState = Telerik.WinControls.Enumerations.ToggleState.On;
            this.ckdOwn.ToggleStateChanged += new Telerik.WinControls.UI.StateChangedEventHandler(this.ckdOwn_ToggleStateChanged);
            // 
            // ddlShifts
            // 
            this.ddlShifts.AutoSize = false;
            this.ddlShifts.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.ddlShifts.Location = new System.Drawing.Point(49, 254);
            this.ddlShifts.Name = "ddlShifts";
            this.ddlShifts.Size = new System.Drawing.Size(284, 27);
            this.ddlShifts.TabIndex = 19;
            this.ddlShifts.ThemeName = "TelerikMetroBlue";
            // 
            // radLabel4
            // 
            this.radLabel4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.radLabel4.Location = new System.Drawing.Point(50, 226);
            this.radLabel4.Name = "radLabel4";
            this.radLabel4.Size = new System.Drawing.Size(48, 21);
            this.radLabel4.TabIndex = 23;
            this.radLabel4.Text = "Turno";
            this.radLabel4.ThemeName = "TelerikMetroBlue";
            // 
            // btnCancelar
            // 
            this.btnCancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancelar.Location = new System.Drawing.Point(614, 495);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 24);
            this.btnCancelar.TabIndex = 26;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.ThemeName = "TelerikMetroBlue";
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnAceptar
            // 
            this.btnAceptar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAceptar.Location = new System.Drawing.Point(533, 495);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(75, 24);
            this.btnAceptar.TabIndex = 24;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.ThemeName = "TelerikMetroBlue";
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // ucEggsAmount
            // 
            this.ucEggsAmount.Location = new System.Drawing.Point(15, 260);
            this.ucEggsAmount.Name = "ucEggsAmount";
            this.ucEggsAmount.Size = new System.Drawing.Size(363, 249);
            this.ucEggsAmount.TabIndex = 29;
            // 
            // FrmAddStock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(701, 605);
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
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lbTitle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnBackToDepositManager)).EndInit();
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
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private Telerik.WinControls.UI.RadLabel lbTitle;
        private Telerik.WinControls.UI.RadButton btnBackToDepositManager;
        private UserControls.UcEggsAmount ucEggsAmount;
    }
}
