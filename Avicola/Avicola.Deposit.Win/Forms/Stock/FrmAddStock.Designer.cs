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
            this.ddlBarn = new Telerik.WinControls.UI.RadDropDownList();
            this.ddlProducts = new Telerik.WinControls.UI.RadDropDownList();
            this.radLabel6 = new Telerik.WinControls.UI.RadLabel();
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
            ((System.ComponentModel.ISupportInitialize)(this.ddlBarn)).BeginInit();
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
            this.splitContainer1.Panel2.Controls.Add(this.ddlBarn);
            this.splitContainer1.Panel2.Controls.Add(this.ddlProducts);
            this.splitContainer1.Panel2.Controls.Add(this.radLabel6);
            this.splitContainer1.Panel2.Controls.Add(this.radLabel5);
            this.splitContainer1.Panel2.Controls.Add(this.ddlProviders);
            this.splitContainer1.Panel2.Controls.Add(this.ckdProvider);
            this.splitContainer1.Panel2.Controls.Add(this.ckdOwn);
            this.splitContainer1.Panel2.Controls.Add(this.ddlShifts);
            this.splitContainer1.Panel2.Controls.Add(this.radLabel4);
            this.splitContainer1.Panel2.Controls.Add(this.btnCancelar);
            this.splitContainer1.Panel2.Controls.Add(this.btnAceptar);
            this.splitContainer1.Panel2.Controls.Add(this.ucEggsAmount);
            this.splitContainer1.Size = new System.Drawing.Size(1004, 605);
            this.splitContainer1.SplitterDistance = 69;
            this.splitContainer1.TabIndex = 0;
            this.splitContainer1.TabStop = false;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.lbTitle, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.btnBackToDepositManager, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1004, 69);
            this.tableLayoutPanel2.TabIndex = 10;
            // 
            // lbTitle
            // 
            this.lbTitle.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lbTitle.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitle.Location = new System.Drawing.Point(119, 14);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(199, 41);
            this.lbTitle.TabIndex = 14;
            this.lbTitle.Text = "Ingresar Stock";
            // 
            // btnBackToDepositManager
            // 
            this.btnBackToDepositManager.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBackToDepositManager.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBackToDepositManager.Image = global::Avicola.Deposit.Win.Properties.Resources.back;
            this.btnBackToDepositManager.Location = new System.Drawing.Point(8, 24);
            this.btnBackToDepositManager.Margin = new System.Windows.Forms.Padding(8, 12, 8, 8);
            this.btnBackToDepositManager.Name = "btnBackToDepositManager";
            this.btnBackToDepositManager.Size = new System.Drawing.Size(100, 24);
            this.btnBackToDepositManager.TabIndex = 0;
            this.btnBackToDepositManager.Text = "Volver";
            this.btnBackToDepositManager.Click += new System.EventHandler(this.btnBackToDepositManager_Click);
            // 
            // ddlBarn
            // 
            this.ddlBarn.AutoSize = false;
            this.ddlBarn.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.ddlBarn.Location = new System.Drawing.Point(16, 37);
            this.ddlBarn.Name = "ddlBarn";
            this.ddlBarn.Size = new System.Drawing.Size(284, 27);
            this.ddlBarn.TabIndex = 0;
            this.ddlBarn.ThemeName = "TelerikMetroBlue";
            // 
            // ddlProducts
            // 
            this.ddlProducts.AutoSize = false;
            this.ddlProducts.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.ddlProducts.Location = new System.Drawing.Point(15, 95);
            this.ddlProducts.Name = "ddlProducts";
            this.ddlProducts.Size = new System.Drawing.Size(284, 27);
            this.ddlProducts.TabIndex = 1;
            this.ddlProducts.ThemeName = "TelerikMetroBlue";
            // 
            // radLabel6
            // 
            this.radLabel6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.radLabel6.Location = new System.Drawing.Point(16, 72);
            this.radLabel6.Name = "radLabel6";
            this.radLabel6.Size = new System.Drawing.Size(69, 21);
            this.radLabel6.TabIndex = 28;
            this.radLabel6.Text = "Producto";
            this.radLabel6.ThemeName = "TelerikMetroBlue";
            // 
            // radLabel5
            // 
            this.radLabel5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.radLabel5.Location = new System.Drawing.Point(15, 13);
            this.radLabel5.Name = "radLabel5";
            this.radLabel5.Size = new System.Drawing.Size(169, 21);
            this.radLabel5.TabIndex = 13;
            this.radLabel5.Text = "Galpón de Procedencia";
            this.radLabel5.ThemeName = "TelerikMetroBlue";
            // 
            // ddlProviders
            // 
            this.ddlProviders.AutoSize = false;
            this.ddlProviders.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.ddlProviders.Location = new System.Drawing.Point(14, 236);
            this.ddlProviders.Name = "ddlProviders";
            this.ddlProviders.Size = new System.Drawing.Size(284, 27);
            this.ddlProviders.TabIndex = 5;
            this.ddlProviders.ThemeName = "TelerikMetroBlue";
            this.ddlProviders.Visible = false;
            // 
            // ckdProvider
            // 
            this.ckdProvider.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.ckdProvider.Location = new System.Drawing.Point(15, 211);
            this.ckdProvider.Name = "ckdProvider";
            this.ckdProvider.Size = new System.Drawing.Size(95, 21);
            this.ckdProvider.TabIndex = 4;
            this.ckdProvider.TabStop = false;
            this.ckdProvider.Text = "Proveedor";
            this.ckdProvider.ThemeName = "TelerikMetroBlue";
            this.ckdProvider.ToggleStateChanged += new Telerik.WinControls.UI.StateChangedEventHandler(this.ckdProvider_ToggleStateChanged);
            // 
            // ckdOwn
            // 
            this.ckdOwn.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ckdOwn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.ckdOwn.Location = new System.Drawing.Point(15, 186);
            this.ckdOwn.Name = "ckdOwn";
            this.ckdOwn.Size = new System.Drawing.Size(109, 21);
            this.ckdOwn.TabIndex = 3;
            this.ckdOwn.Text = "Stock propio";
            this.ckdOwn.ThemeName = "TelerikMetroBlue";
            this.ckdOwn.ToggleState = Telerik.WinControls.Enumerations.ToggleState.On;
            this.ckdOwn.ToggleStateChanged += new Telerik.WinControls.UI.StateChangedEventHandler(this.ckdOwn_ToggleStateChanged);
            // 
            // ddlShifts
            // 
            this.ddlShifts.AutoSize = false;
            this.ddlShifts.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.ddlShifts.Location = new System.Drawing.Point(15, 152);
            this.ddlShifts.Name = "ddlShifts";
            this.ddlShifts.Size = new System.Drawing.Size(284, 27);
            this.ddlShifts.TabIndex = 2;
            this.ddlShifts.ThemeName = "TelerikMetroBlue";
            // 
            // radLabel4
            // 
            this.radLabel4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.radLabel4.Location = new System.Drawing.Point(16, 128);
            this.radLabel4.Name = "radLabel4";
            this.radLabel4.Size = new System.Drawing.Size(48, 21);
            this.radLabel4.TabIndex = 23;
            this.radLabel4.Text = "Turno";
            this.radLabel4.ThemeName = "TelerikMetroBlue";
            // 
            // btnCancelar
            // 
            this.btnCancelar.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Location = new System.Drawing.Point(578, 306);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(96, 24);
            this.btnCancelar.TabIndex = 8;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.ThemeName = "TelerikMetroBlue";
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnAceptar
            // 
            this.btnAceptar.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAceptar.Location = new System.Drawing.Point(476, 306);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(96, 24);
            this.btnAceptar.TabIndex = 7;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.ThemeName = "TelerikMetroBlue";
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // ucEggsAmount
            // 
            this.ucEggsAmount.Location = new System.Drawing.Point(338, 7);
            this.ucEggsAmount.Margin = new System.Windows.Forms.Padding(4);
            this.ucEggsAmount.Name = "ucEggsAmount";
            this.ucEggsAmount.Size = new System.Drawing.Size(363, 292);
            this.ucEggsAmount.TabIndex = 6;
            // 
            // FrmAddStock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(1004, 605);
            this.ControlBox = false;
            this.Controls.Add(this.splitContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
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
            ((System.ComponentModel.ISupportInitialize)(this.ddlBarn)).EndInit();
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
        private Telerik.WinControls.UI.RadLabel radLabel5;
        private Telerik.WinControls.UI.RadDropDownList ddlProviders;
        private Telerik.WinControls.UI.RadRadioButton ckdProvider;
        private Telerik.WinControls.UI.RadRadioButton ckdOwn;
        private Telerik.WinControls.UI.RadDropDownList ddlShifts;
        private Telerik.WinControls.UI.RadLabel radLabel4;
        private Telerik.WinControls.UI.RadButton btnCancelar;
        private Telerik.WinControls.UI.RadButton btnAceptar;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private UserControls.UcEggsAmount ucEggsAmount;
        private Telerik.WinControls.UI.RadLabel lbTitle;
        private Telerik.WinControls.UI.RadButton btnBackToDepositManager;
        private Telerik.WinControls.UI.RadDropDownList ddlBarn;
    }
}
