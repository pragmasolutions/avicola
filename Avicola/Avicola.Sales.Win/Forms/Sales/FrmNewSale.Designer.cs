namespace Avicola.Sales.Win.Forms.Sales
{
    partial class FrmNewSale
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
            this.lbTitle = new Telerik.WinControls.UI.RadLabel();
            this.txtPhone = new Telerik.WinControls.UI.RadTextBox();
            this.txtCity = new Telerik.WinControls.UI.RadTextBox();
            this.txtAddress = new Telerik.WinControls.UI.RadTextBox();
            this.radLabel4 = new Telerik.WinControls.UI.RadLabel();
            this.radLabel2 = new Telerik.WinControls.UI.RadLabel();
            this.radLabel1 = new Telerik.WinControls.UI.RadLabel();
            this.ddlClient = new Telerik.WinControls.UI.RadDropDownList();
            this.lblClient = new Telerik.WinControls.UI.RadLabel();
            this.btnCancelar = new Telerik.WinControls.UI.RadButton();
            this.btnAceptar = new Telerik.WinControls.UI.RadButton();
            this.btnAddClient = new System.Windows.Forms.Button();
            this.radGroupBox1 = new Telerik.WinControls.UI.RadGroupBox();
            this.radGroupBox2 = new Telerik.WinControls.UI.RadGroupBox();
            this.flpProducts = new System.Windows.Forms.FlowLayoutPanel();
            this.btnBack = new Telerik.WinControls.UI.RadButton();
            ((System.ComponentModel.ISupportInitialize)(this.pbvStockEntry)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lbTitle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPhone)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAddress)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ddlClient)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblClient)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCancelar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAceptar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox1)).BeginInit();
            this.radGroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox2)).BeginInit();
            this.radGroupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnBack)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // pbvStockEntry
            // 
            this.pbvStockEntry.ContainerControl = this;
            // 
            // lbTitle
            // 
            this.lbTitle.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitle.Location = new System.Drawing.Point(134, 19);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(179, 41);
            this.lbTitle.TabIndex = 42;
            this.lbTitle.Text = "Nueva Venta";
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(31, 288);
            this.txtPhone.Margin = new System.Windows.Forms.Padding(2);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(253, 24);
            this.txtPhone.TabIndex = 39;
            // 
            // txtCity
            // 
            this.txtCity.Location = new System.Drawing.Point(31, 216);
            this.txtCity.Margin = new System.Windows.Forms.Padding(2);
            this.txtCity.Name = "txtCity";
            this.txtCity.Size = new System.Drawing.Size(253, 24);
            this.txtCity.TabIndex = 37;
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(31, 145);
            this.txtAddress.Margin = new System.Windows.Forms.Padding(2);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(253, 24);
            this.txtAddress.TabIndex = 38;
            // 
            // radLabel4
            // 
            this.radLabel4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.radLabel4.Location = new System.Drawing.Point(31, 265);
            this.radLabel4.Name = "radLabel4";
            this.radLabel4.Size = new System.Drawing.Size(68, 21);
            this.radLabel4.TabIndex = 44;
            this.radLabel4.Text = "Teléfono";
            this.radLabel4.ThemeName = "TelerikMetroBlue";
            // 
            // radLabel2
            // 
            this.radLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.radLabel2.Location = new System.Drawing.Point(31, 121);
            this.radLabel2.Name = "radLabel2";
            this.radLabel2.Size = new System.Drawing.Size(72, 21);
            this.radLabel2.TabIndex = 45;
            this.radLabel2.Text = "Dirección";
            this.radLabel2.ThemeName = "TelerikMetroBlue";
            // 
            // radLabel1
            // 
            this.radLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.radLabel1.Location = new System.Drawing.Point(31, 193);
            this.radLabel1.Name = "radLabel1";
            this.radLabel1.Size = new System.Drawing.Size(57, 21);
            this.radLabel1.TabIndex = 43;
            this.radLabel1.Text = "Ciudad";
            this.radLabel1.ThemeName = "TelerikMetroBlue";
            // 
            // ddlClient
            // 
            this.ddlClient.AutoSize = false;
            this.ddlClient.Location = new System.Drawing.Point(29, 72);
            this.ddlClient.Margin = new System.Windows.Forms.Padding(2);
            this.ddlClient.Name = "ddlClient";
            this.ddlClient.Size = new System.Drawing.Size(202, 27);
            this.ddlClient.TabIndex = 36;
            this.ddlClient.Text = " ";
            this.ddlClient.ThemeName = "TelerikMetroBlue";
            this.ddlClient.SelectedIndexChanged += new Telerik.WinControls.UI.Data.PositionChangedEventHandler(this.ddlClient_SelectedIndexChanged);
            // 
            // lblClient
            // 
            this.lblClient.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.lblClient.Location = new System.Drawing.Point(31, 49);
            this.lblClient.Name = "lblClient";
            this.lblClient.Size = new System.Drawing.Size(56, 21);
            this.lblClient.TabIndex = 41;
            this.lblClient.Text = "Cliente";
            this.lblClient.ThemeName = "TelerikMetroBlue";
            // 
            // btnCancelar
            // 
            this.btnCancelar.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Location = new System.Drawing.Point(779, 458);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(79, 24);
            this.btnCancelar.TabIndex = 47;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.ThemeName = "TelerikMetroBlue";
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnAceptar
            // 
            this.btnAceptar.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAceptar.Location = new System.Drawing.Point(689, 458);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(84, 24);
            this.btnAceptar.TabIndex = 46;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.ThemeName = "TelerikMetroBlue";
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // btnAddClient
            // 
            this.btnAddClient.Image = global::Avicola.Sales.Win.Properties.Resources.plus;
            this.btnAddClient.Location = new System.Drawing.Point(255, 72);
            this.btnAddClient.Margin = new System.Windows.Forms.Padding(2);
            this.btnAddClient.Name = "btnAddClient";
            this.btnAddClient.Size = new System.Drawing.Size(28, 28);
            this.btnAddClient.TabIndex = 49;
            this.btnAddClient.UseVisualStyleBackColor = true;
            this.btnAddClient.Click += new System.EventHandler(this.btnAddClient_Click);
            // 
            // radGroupBox1
            // 
            this.radGroupBox1.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping;
            this.radGroupBox1.Controls.Add(this.lblClient);
            this.radGroupBox1.Controls.Add(this.btnAddClient);
            this.radGroupBox1.Controls.Add(this.ddlClient);
            this.radGroupBox1.Controls.Add(this.radLabel1);
            this.radGroupBox1.Controls.Add(this.txtPhone);
            this.radGroupBox1.Controls.Add(this.radLabel2);
            this.radGroupBox1.Controls.Add(this.txtCity);
            this.radGroupBox1.Controls.Add(this.radLabel4);
            this.radGroupBox1.Controls.Add(this.txtAddress);
            this.radGroupBox1.HeaderText = "Información de Cliente";
            this.radGroupBox1.Location = new System.Drawing.Point(28, 70);
            this.radGroupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.radGroupBox1.Name = "radGroupBox1";
            this.radGroupBox1.Padding = new System.Windows.Forms.Padding(2, 15, 2, 2);
            this.radGroupBox1.Size = new System.Drawing.Size(322, 353);
            this.radGroupBox1.TabIndex = 50;
            this.radGroupBox1.Text = "Información de Cliente";
            ((Telerik.WinControls.UI.RadGroupBoxElement)(this.radGroupBox1.GetChildAt(0))).Padding = new System.Windows.Forms.Padding(2, 15, 2, 2);
            ((Telerik.WinControls.Primitives.TextPrimitive)(this.radGroupBox1.GetChildAt(0).GetChildAt(1).GetChildAt(2).GetChildAt(1))).Text = "Información de Cliente";
            ((Telerik.WinControls.Primitives.TextPrimitive)(this.radGroupBox1.GetChildAt(0).GetChildAt(1).GetChildAt(2).GetChildAt(1))).Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            ((Telerik.WinControls.Primitives.TextPrimitive)(this.radGroupBox1.GetChildAt(0).GetChildAt(1).GetChildAt(2).GetChildAt(1))).Alignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // radGroupBox2
            // 
            this.radGroupBox2.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping;
            this.radGroupBox2.Controls.Add(this.flpProducts);
            this.radGroupBox2.HeaderText = "Productos";
            this.radGroupBox2.Location = new System.Drawing.Point(371, 70);
            this.radGroupBox2.Margin = new System.Windows.Forms.Padding(2);
            this.radGroupBox2.Name = "radGroupBox2";
            this.radGroupBox2.Padding = new System.Windows.Forms.Padding(2, 15, 2, 2);
            this.radGroupBox2.Size = new System.Drawing.Size(487, 354);
            this.radGroupBox2.TabIndex = 51;
            this.radGroupBox2.Text = "Productos";
            ((Telerik.WinControls.UI.RadGroupBoxElement)(this.radGroupBox2.GetChildAt(0))).Padding = new System.Windows.Forms.Padding(2, 15, 2, 2);
            ((Telerik.WinControls.Primitives.TextPrimitive)(this.radGroupBox2.GetChildAt(0).GetChildAt(1).GetChildAt(2).GetChildAt(1))).Text = "Productos";
            ((Telerik.WinControls.Primitives.TextPrimitive)(this.radGroupBox2.GetChildAt(0).GetChildAt(1).GetChildAt(2).GetChildAt(1))).Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            ((Telerik.WinControls.Primitives.TextPrimitive)(this.radGroupBox2.GetChildAt(0).GetChildAt(1).GetChildAt(2).GetChildAt(1))).Alignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // flpProducts
            // 
            this.flpProducts.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flpProducts.Location = new System.Drawing.Point(24, 33);
            this.flpProducts.Margin = new System.Windows.Forms.Padding(2);
            this.flpProducts.Name = "flpProducts";
            this.flpProducts.Size = new System.Drawing.Size(438, 317);
            this.flpProducts.TabIndex = 0;
            // 
            // btnBack
            // 
            this.btnBack.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(28, 29);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(100, 24);
            this.btnBack.TabIndex = 47;
            this.btnBack.Text = "Volver";
            this.btnBack.ThemeName = "TelerikMetroBlue";
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // FrmNewSale
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(867, 494);
            this.ControlBox = false;
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.radGroupBox2);
            this.Controls.Add(this.radGroupBox1);
            this.Controls.Add(this.lbTitle);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAceptar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimizeBox = false;
            this.Name = "FrmNewSale";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.Text = "Ingresar stock";
            this.Load += new System.EventHandler(this.FrmNewSale_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbvStockEntry)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lbTitle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPhone)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAddress)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ddlClient)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblClient)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCancelar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAceptar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox1)).EndInit();
            this.radGroupBox1.ResumeLayout(false);
            this.radGroupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox2)).EndInit();
            this.radGroupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnBack)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ErrorProvider pbvStockEntry;
        private Telerik.WinControls.UI.RadLabel lbTitle;
        private Telerik.WinControls.UI.RadTextBox txtPhone;
        private Telerik.WinControls.UI.RadTextBox txtCity;
        private Telerik.WinControls.UI.RadTextBox txtAddress;
        private Telerik.WinControls.UI.RadLabel radLabel4;
        private Telerik.WinControls.UI.RadLabel radLabel2;
        private Telerik.WinControls.UI.RadLabel radLabel1;
        private Telerik.WinControls.UI.RadDropDownList ddlClient;
        private Telerik.WinControls.UI.RadLabel lblClient;
        private Telerik.WinControls.UI.RadButton btnCancelar;
        private Telerik.WinControls.UI.RadButton btnAceptar;
        private System.Windows.Forms.Button btnAddClient;
        private Telerik.WinControls.UI.RadGroupBox radGroupBox1;
        private Telerik.WinControls.UI.RadGroupBox radGroupBox2;
        private System.Windows.Forms.FlowLayoutPanel flpProducts;
        private Telerik.WinControls.UI.RadButton btnBack;
    }
}
