namespace De.Provision.Databases
{
    partial class frmMain
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtTables = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtProvisionScopeName = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnProvision = new System.Windows.Forms.Button();
            this.txtProvisionRemoteDatabase = new System.Windows.Forms.TextBox();
            this.txtProvisionLocalDatabase = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lblProgress = new System.Windows.Forms.ToolStripStatusLabel();
            this.tspProgress = new System.Windows.Forms.ToolStripProgressBar();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtDeprovisionScopeName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnDeprovision = new System.Windows.Forms.Button();
            this.txtDeprovisionRemoteDatabase = new System.Windows.Forms.TextBox();
            this.txtDeprovisionLocalDatabase = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.bgwProvisionProgress = new System.ComponentModel.BackgroundWorker();
            this.bgwDeprovisionProgress = new System.ComponentModel.BackgroundWorker();
            this.txtDeprovisionSchema = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtProvisionSchema = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.errorSync = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBox1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorSync)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtProvisionSchema);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.txtTables);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txtProvisionScopeName);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.btnProvision);
            this.groupBox1.Controls.Add(this.txtProvisionRemoteDatabase);
            this.groupBox1.Controls.Add(this.txtProvisionLocalDatabase);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(2, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(730, 284);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Provision";
            // 
            // txtTables
            // 
            this.txtTables.Location = new System.Drawing.Point(104, 159);
            this.txtTables.Multiline = true;
            this.txtTables.Name = "txtTables";
            this.txtTables.Size = new System.Drawing.Size(463, 45);
            this.txtTables.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(10, 175);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(42, 13);
            this.label7.TabIndex = 11;
            this.label7.Text = "Tablas:";
            // 
            // txtProvisionScopeName
            // 
            this.txtProvisionScopeName.Location = new System.Drawing.Point(104, 133);
            this.txtProvisionScopeName.Name = "txtProvisionScopeName";
            this.txtProvisionScopeName.Size = new System.Drawing.Size(248, 20);
            this.txtProvisionScopeName.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(10, 137);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Scope name:";
            // 
            // btnProvision
            // 
            this.btnProvision.Location = new System.Drawing.Point(649, 255);
            this.btnProvision.Name = "btnProvision";
            this.btnProvision.Size = new System.Drawing.Size(75, 23);
            this.btnProvision.TabIndex = 4;
            this.btnProvision.Text = "Provision";
            this.btnProvision.UseVisualStyleBackColor = true;
            this.btnProvision.Click += new System.EventHandler(this.btnProvision_Click);
            // 
            // txtProvisionRemoteDatabase
            // 
            this.txtProvisionRemoteDatabase.Location = new System.Drawing.Point(104, 81);
            this.txtProvisionRemoteDatabase.Multiline = true;
            this.txtProvisionRemoteDatabase.Name = "txtProvisionRemoteDatabase";
            this.txtProvisionRemoteDatabase.Size = new System.Drawing.Size(463, 45);
            this.txtProvisionRemoteDatabase.TabIndex = 3;
            // 
            // txtProvisionLocalDatabase
            // 
            this.txtProvisionLocalDatabase.Location = new System.Drawing.Point(104, 29);
            this.txtProvisionLocalDatabase.Multiline = true;
            this.txtProvisionLocalDatabase.Name = "txtProvisionLocalDatabase";
            this.txtProvisionLocalDatabase.Size = new System.Drawing.Size(463, 45);
            this.txtProvisionLocalDatabase.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Remote database:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Local database:";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblProgress,
            this.tspProgress});
            this.statusStrip1.Location = new System.Drawing.Point(0, 506);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(748, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // lblProgress
            // 
            this.lblProgress.Name = "lblProgress";
            this.lblProgress.Size = new System.Drawing.Size(114, 17);
            this.lblProgress.Text = "Proceso no iniciado:";
            // 
            // tspProgress
            // 
            this.tspProgress.MarqueeAnimationSpeed = 10;
            this.tspProgress.Name = "tspProgress";
            this.tspProgress.Size = new System.Drawing.Size(100, 16);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtDeprovisionSchema);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.txtDeprovisionScopeName);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.btnDeprovision);
            this.groupBox2.Controls.Add(this.txtDeprovisionRemoteDatabase);
            this.groupBox2.Controls.Add(this.txtDeprovisionLocalDatabase);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Location = new System.Drawing.Point(6, 306);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(730, 185);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Deprovision";
            // 
            // txtDeprovisionScopeName
            // 
            this.txtDeprovisionScopeName.Location = new System.Drawing.Point(100, 129);
            this.txtDeprovisionScopeName.Name = "txtDeprovisionScopeName";
            this.txtDeprovisionScopeName.Size = new System.Drawing.Size(248, 20);
            this.txtDeprovisionScopeName.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 133);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Scope name:";
            // 
            // btnDeprovision
            // 
            this.btnDeprovision.Location = new System.Drawing.Point(649, 153);
            this.btnDeprovision.Name = "btnDeprovision";
            this.btnDeprovision.Size = new System.Drawing.Size(75, 23);
            this.btnDeprovision.TabIndex = 8;
            this.btnDeprovision.Text = "Deprovision";
            this.btnDeprovision.UseVisualStyleBackColor = true;
            this.btnDeprovision.Click += new System.EventHandler(this.btnDeprovision_Click);
            // 
            // txtDeprovisionRemoteDatabase
            // 
            this.txtDeprovisionRemoteDatabase.Location = new System.Drawing.Point(100, 77);
            this.txtDeprovisionRemoteDatabase.Multiline = true;
            this.txtDeprovisionRemoteDatabase.Name = "txtDeprovisionRemoteDatabase";
            this.txtDeprovisionRemoteDatabase.Size = new System.Drawing.Size(463, 45);
            this.txtDeprovisionRemoteDatabase.TabIndex = 7;
            // 
            // txtDeprovisionLocalDatabase
            // 
            this.txtDeprovisionLocalDatabase.Location = new System.Drawing.Point(100, 25);
            this.txtDeprovisionLocalDatabase.Multiline = true;
            this.txtDeprovisionLocalDatabase.Name = "txtDeprovisionLocalDatabase";
            this.txtDeprovisionLocalDatabase.Size = new System.Drawing.Size(463, 45);
            this.txtDeprovisionLocalDatabase.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Remote database:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 41);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Local database:";
            // 
            // bgwProvisionProgress
            // 
            this.bgwProvisionProgress.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bgwProvisionProgress_DoWork);
            this.bgwProvisionProgress.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.bgwProvisionProgress_ProgressChanged);
            this.bgwProvisionProgress.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bgwProvisionProgress_RunWorkerCompleted);
            // 
            // bgwDeprovisionProgress
            // 
            this.bgwDeprovisionProgress.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bgwDeprovisionProgress_DoWork);
            this.bgwDeprovisionProgress.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.bgwDeprovisionProgress_ProgressChanged);
            this.bgwDeprovisionProgress.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bgwDeprovisionProgress_RunWorkerCompleted);
            // 
            // txtDeprovisionSchema
            // 
            this.txtDeprovisionSchema.Location = new System.Drawing.Point(100, 155);
            this.txtDeprovisionSchema.Name = "txtDeprovisionSchema";
            this.txtDeprovisionSchema.Size = new System.Drawing.Size(248, 20);
            this.txtDeprovisionSchema.TabIndex = 12;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 159);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(49, 13);
            this.label8.TabIndex = 11;
            this.label8.Text = "Schema:";
            // 
            // txtProvisionSchema
            // 
            this.txtProvisionSchema.Location = new System.Drawing.Point(104, 211);
            this.txtProvisionSchema.Name = "txtProvisionSchema";
            this.txtProvisionSchema.Size = new System.Drawing.Size(248, 20);
            this.txtProvisionSchema.TabIndex = 14;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(10, 215);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(49, 13);
            this.label9.TabIndex = 13;
            this.label9.Text = "Schema:";
            // 
            // errorSync
            // 
            this.errorSync.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorSync.ContainerControl = this;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(748, 528);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmMain";
            this.Text = "Provision - Deprovision";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorSync)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel lblProgress;
        private System.Windows.Forms.ToolStripProgressBar tspProgress;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.ComponentModel.BackgroundWorker bgwProvisionProgress;
        private System.Windows.Forms.TextBox txtProvisionScopeName;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnProvision;
        private System.Windows.Forms.TextBox txtProvisionRemoteDatabase;
        private System.Windows.Forms.TextBox txtProvisionLocalDatabase;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDeprovisionScopeName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnDeprovision;
        private System.Windows.Forms.TextBox txtDeprovisionRemoteDatabase;
        private System.Windows.Forms.TextBox txtDeprovisionLocalDatabase;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.ComponentModel.BackgroundWorker bgwDeprovisionProgress;
        private System.Windows.Forms.TextBox txtTables;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtProvisionSchema;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtDeprovisionSchema;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ErrorProvider errorSync;
    }
}

