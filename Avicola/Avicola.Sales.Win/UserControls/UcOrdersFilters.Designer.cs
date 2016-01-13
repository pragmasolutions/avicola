namespace Avicola.Sales.Win.UserControls
{
    partial class UcOrdersFilters
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
            this.txtClient = new Telerik.WinControls.UI.RadTextBox();
            this.radLabel2 = new Telerik.WinControls.UI.RadLabel();
            this.radLabel3 = new Telerik.WinControls.UI.RadLabel();
            this.radLabel4 = new Telerik.WinControls.UI.RadLabel();
            this.dtpFromDate = new Telerik.WinControls.UI.RadDateTimePicker();
            this.dtpToDate = new Telerik.WinControls.UI.RadDateTimePicker();
            this.radLabel1 = new Telerik.WinControls.UI.RadLabel();
            this.radLabel5 = new Telerik.WinControls.UI.RadLabel();
            this.radLabel6 = new Telerik.WinControls.UI.RadLabel();
            this.ucTruckSelection = new Avicola.Sales.Win.UserControls.UcTruckSelection();
            this.ucDriverSelection = new Avicola.Sales.Win.UserControls.UcDriverSelection();
            this.ucOrderStatusSelection = new Avicola.Sales.Win.UserControls.UcOrderStatusSelection();
            ((System.ComponentModel.ISupportInitialize)(this.txtClient)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpFromDate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpToDate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel6)).BeginInit();
            this.SuspendLayout();
            // 
            // txtClient
            // 
            this.txtClient.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtClient.Location = new System.Drawing.Point(16, 39);
            this.txtClient.Name = "txtClient";
            this.txtClient.Size = new System.Drawing.Size(224, 28);
            this.txtClient.TabIndex = 1;
            this.txtClient.TextChanged += new System.EventHandler(this.txtClient_TextChanged);
            // 
            // radLabel2
            // 
            this.radLabel2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radLabel2.Location = new System.Drawing.Point(16, 12);
            this.radLabel2.Name = "radLabel2";
            this.radLabel2.Size = new System.Drawing.Size(55, 24);
            this.radLabel2.TabIndex = 4;
            this.radLabel2.Text = "Cliente";
            // 
            // radLabel3
            // 
            this.radLabel3.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radLabel3.Location = new System.Drawing.Point(16, 73);
            this.radLabel3.Name = "radLabel3";
            this.radLabel3.Size = new System.Drawing.Size(53, 24);
            this.radLabel3.TabIndex = 4;
            this.radLabel3.Text = "Estado";
            // 
            // radLabel4
            // 
            this.radLabel4.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radLabel4.Location = new System.Drawing.Point(260, 12);
            this.radLabel4.Name = "radLabel4";
            this.radLabel4.Size = new System.Drawing.Size(50, 24);
            this.radLabel4.TabIndex = 6;
            this.radLabel4.Text = "Desde";
            // 
            // dtpFromDate
            // 
            this.dtpFromDate.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFromDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFromDate.Location = new System.Drawing.Point(260, 39);
            this.dtpFromDate.Name = "dtpFromDate";
            this.dtpFromDate.Size = new System.Drawing.Size(103, 28);
            this.dtpFromDate.TabIndex = 7;
            this.dtpFromDate.TabStop = false;
            this.dtpFromDate.Value = new System.DateTime(((long)(0)));
            this.dtpFromDate.ValueChanged += new System.EventHandler(this.dtpFromDate_ValueChanged);
            // 
            // dtpToDate
            // 
            this.dtpToDate.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpToDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpToDate.Location = new System.Drawing.Point(381, 39);
            this.dtpToDate.Name = "dtpToDate";
            this.dtpToDate.Size = new System.Drawing.Size(103, 28);
            this.dtpToDate.TabIndex = 9;
            this.dtpToDate.TabStop = false;
            this.dtpToDate.Value = new System.DateTime(((long)(0)));
            this.dtpToDate.ValueChanged += new System.EventHandler(this.dtpToDate_ValueChanged);
            // 
            // radLabel1
            // 
            this.radLabel1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radLabel1.Location = new System.Drawing.Point(381, 12);
            this.radLabel1.Name = "radLabel1";
            this.radLabel1.Size = new System.Drawing.Size(46, 24);
            this.radLabel1.TabIndex = 8;
            this.radLabel1.Text = "Hasta";
            // 
            // radLabel5
            // 
            this.radLabel5.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radLabel5.Location = new System.Drawing.Point(505, 12);
            this.radLabel5.Name = "radLabel5";
            this.radLabel5.Size = new System.Drawing.Size(79, 24);
            this.radLabel5.TabIndex = 5;
            this.radLabel5.Text = "Conductor";
            // 
            // radLabel6
            // 
            this.radLabel6.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radLabel6.Location = new System.Drawing.Point(260, 73);
            this.radLabel6.Name = "radLabel6";
            this.radLabel6.Size = new System.Drawing.Size(60, 24);
            this.radLabel6.TabIndex = 6;
            this.radLabel6.Text = "Camión";
            // 
            // ucTruckSelection
            // 
            this.ucTruckSelection.Location = new System.Drawing.Point(260, 99);
            this.ucTruckSelection.Name = "ucTruckSelection";
            this.ucTruckSelection.Size = new System.Drawing.Size(224, 28);
            this.ucTruckSelection.TabIndex = 12;
            this.ucTruckSelection.TruckSelected += new System.EventHandler<Avicola.Sales.Entities.Truck>(this.ucTruckSelection_TruckSelected);
            // 
            // ucDriverSelection
            // 
            this.ucDriverSelection.Location = new System.Drawing.Point(505, 39);
            this.ucDriverSelection.Name = "ucDriverSelection";
            this.ucDriverSelection.Size = new System.Drawing.Size(224, 28);
            this.ucDriverSelection.TabIndex = 11;
            this.ucDriverSelection.DriverSelected += new System.EventHandler<Avicola.Sales.Entities.Driver>(this.ucDriverSelection_DriverSelected);
            // 
            // ucOrderStatusSelection
            // 
            this.ucOrderStatusSelection.Location = new System.Drawing.Point(16, 99);
            this.ucOrderStatusSelection.Name = "ucOrderStatusSelection";
            this.ucOrderStatusSelection.Size = new System.Drawing.Size(224, 28);
            this.ucOrderStatusSelection.TabIndex = 10;
            this.ucOrderStatusSelection.OrderStatusSelected += new System.EventHandler<Avicola.Sales.Entities.OrderStatus>(this.ucOrderStatusSelection_OrderStatusSelected);
            // 
            // UcOrdersFilters
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ucTruckSelection);
            this.Controls.Add(this.radLabel6);
            this.Controls.Add(this.ucDriverSelection);
            this.Controls.Add(this.radLabel5);
            this.Controls.Add(this.ucOrderStatusSelection);
            this.Controls.Add(this.dtpFromDate);
            this.Controls.Add(this.dtpToDate);
            this.Controls.Add(this.radLabel1);
            this.Controls.Add(this.radLabel4);
            this.Controls.Add(this.radLabel3);
            this.Controls.Add(this.radLabel2);
            this.Controls.Add(this.txtClient);
            this.Name = "UcOrdersFilters";
            this.Size = new System.Drawing.Size(862, 137);
            ((System.ComponentModel.ISupportInitialize)(this.txtClient)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpFromDate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpToDate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel6)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Telerik.WinControls.UI.RadTextBox txtClient;
        private Telerik.WinControls.UI.RadLabel radLabel2;
        private Telerik.WinControls.UI.RadLabel radLabel3;
        private Telerik.WinControls.UI.RadLabel radLabel4;
        private Telerik.WinControls.UI.RadDateTimePicker dtpFromDate;
        private Telerik.WinControls.UI.RadDateTimePicker dtpToDate;
        private Telerik.WinControls.UI.RadLabel radLabel1;
        private UcOrderStatusSelection ucOrderStatusSelection;
        private Telerik.WinControls.UI.RadLabel radLabel5;
        private UcDriverSelection ucDriverSelection;
        private Telerik.WinControls.UI.RadLabel radLabel6;
        private UcTruckSelection ucTruckSelection;

    }
}
