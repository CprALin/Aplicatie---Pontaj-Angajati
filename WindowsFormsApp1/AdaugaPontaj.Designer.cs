namespace WindowsFormsApp1
{
    partial class AdaugaPontaj
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
            this.btnAdauga = new System.Windows.Forms.Button();
            this.dataSet1 = new WindowsFormsApp1.DataSet1();
            this.pontajContinutTableAdapter1 = new WindowsFormsApp1.DataSet1TableAdapters.PontajContinutTableAdapter();
            this.pontajTableAdapter1 = new WindowsFormsApp1.DataSet1TableAdapters.PontajTableAdapter();
            this.lblAn = new System.Windows.Forms.Label();
            this.lblLuna = new System.Windows.Forms.Label();
            this.txtAn = new System.Windows.Forms.TextBox();
            this.txtLuna = new System.Windows.Forms.TextBox();
            this.txtNrOre = new System.Windows.Forms.TextBox();
            this.txtTarif = new System.Windows.Forms.TextBox();
            this.txtZi = new System.Windows.Forms.TextBox();
            this.lblNrOre = new System.Windows.Forms.Label();
            this.lblTarif = new System.Windows.Forms.Label();
            this.lblZi = new System.Windows.Forms.Label();
            this.txtNrc = new System.Windows.Forms.TextBox();
            this.lblNrc = new System.Windows.Forms.Label();
            this.lblIdAngajat = new System.Windows.Forms.Label();
            this.txtCnpAngajat = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAdauga
            // 
            this.btnAdauga.Location = new System.Drawing.Point(513, 193);
            this.btnAdauga.Name = "btnAdauga";
            this.btnAdauga.Size = new System.Drawing.Size(140, 41);
            this.btnAdauga.TabIndex = 24;
            this.btnAdauga.Text = "Adauga";
            this.btnAdauga.UseVisualStyleBackColor = true;
            this.btnAdauga.Click += new System.EventHandler(this.btnAdauga_Click);
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pontajContinutTableAdapter1
            // 
            this.pontajContinutTableAdapter1.ClearBeforeFill = true;
            // 
            // pontajTableAdapter1
            // 
            this.pontajTableAdapter1.ClearBeforeFill = true;
            // 
            // lblAn
            // 
            this.lblAn.AutoSize = true;
            this.lblAn.Location = new System.Drawing.Point(122, 205);
            this.lblAn.Name = "lblAn";
            this.lblAn.Size = new System.Drawing.Size(23, 16);
            this.lblAn.TabIndex = 42;
            this.lblAn.Text = "An";
            // 
            // lblLuna
            // 
            this.lblLuna.AutoSize = true;
            this.lblLuna.Location = new System.Drawing.Point(122, 242);
            this.lblLuna.Name = "lblLuna";
            this.lblLuna.Size = new System.Drawing.Size(36, 16);
            this.lblLuna.TabIndex = 41;
            this.lblLuna.Text = "Luna";
            // 
            // txtAn
            // 
            this.txtAn.Location = new System.Drawing.Point(194, 202);
            this.txtAn.Name = "txtAn";
            this.txtAn.Size = new System.Drawing.Size(100, 22);
            this.txtAn.TabIndex = 40;
            // 
            // txtLuna
            // 
            this.txtLuna.Location = new System.Drawing.Point(194, 239);
            this.txtLuna.Name = "txtLuna";
            this.txtLuna.Size = new System.Drawing.Size(100, 22);
            this.txtLuna.TabIndex = 39;
            // 
            // txtNrOre
            // 
            this.txtNrOre.Location = new System.Drawing.Point(194, 318);
            this.txtNrOre.Name = "txtNrOre";
            this.txtNrOre.Size = new System.Drawing.Size(100, 22);
            this.txtNrOre.TabIndex = 38;
            // 
            // txtTarif
            // 
            this.txtTarif.Location = new System.Drawing.Point(194, 280);
            this.txtTarif.Name = "txtTarif";
            this.txtTarif.Size = new System.Drawing.Size(100, 22);
            this.txtTarif.TabIndex = 37;
            // 
            // txtZi
            // 
            this.txtZi.Location = new System.Drawing.Point(194, 165);
            this.txtZi.Name = "txtZi";
            this.txtZi.Size = new System.Drawing.Size(100, 22);
            this.txtZi.TabIndex = 36;
            // 
            // lblNrOre
            // 
            this.lblNrOre.AutoSize = true;
            this.lblNrOre.Location = new System.Drawing.Point(122, 321);
            this.lblNrOre.Name = "lblNrOre";
            this.lblNrOre.Size = new System.Drawing.Size(46, 16);
            this.lblNrOre.TabIndex = 35;
            this.lblNrOre.Text = "Nr Ore";
            // 
            // lblTarif
            // 
            this.lblTarif.AutoSize = true;
            this.lblTarif.Location = new System.Drawing.Point(122, 283);
            this.lblTarif.Name = "lblTarif";
            this.lblTarif.Size = new System.Drawing.Size(66, 16);
            this.lblTarif.TabIndex = 34;
            this.lblTarif.Text = "Tarif / Ora";
            // 
            // lblZi
            // 
            this.lblZi.AutoSize = true;
            this.lblZi.Location = new System.Drawing.Point(122, 168);
            this.lblZi.Name = "lblZi";
            this.lblZi.Size = new System.Drawing.Size(18, 16);
            this.lblZi.TabIndex = 33;
            this.lblZi.Text = "Zi";
            // 
            // txtNrc
            // 
            this.txtNrc.Location = new System.Drawing.Point(194, 125);
            this.txtNrc.Name = "txtNrc";
            this.txtNrc.Size = new System.Drawing.Size(100, 22);
            this.txtNrc.TabIndex = 32;
            // 
            // lblNrc
            // 
            this.lblNrc.AutoSize = true;
            this.lblNrc.Location = new System.Drawing.Point(122, 125);
            this.lblNrc.Name = "lblNrc";
            this.lblNrc.Size = new System.Drawing.Size(28, 16);
            this.lblNrc.TabIndex = 31;
            this.lblNrc.Text = "Nrc";
            // 
            // lblIdAngajat
            // 
            this.lblIdAngajat.AutoSize = true;
            this.lblIdAngajat.Location = new System.Drawing.Point(99, 85);
            this.lblIdAngajat.Name = "lblIdAngajat";
            this.lblIdAngajat.Size = new System.Drawing.Size(84, 16);
            this.lblIdAngajat.TabIndex = 44;
            this.lblIdAngajat.Text = "CNP Angajat";
            // 
            // txtCnpAngajat
            // 
            this.txtCnpAngajat.Location = new System.Drawing.Point(194, 82);
            this.txtCnpAngajat.Name = "txtCnpAngajat";
            this.txtCnpAngajat.Size = new System.Drawing.Size(122, 22);
            this.txtCnpAngajat.TabIndex = 43;
            // 
            // AdaugaPontaj
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblIdAngajat);
            this.Controls.Add(this.txtCnpAngajat);
            this.Controls.Add(this.lblAn);
            this.Controls.Add(this.lblLuna);
            this.Controls.Add(this.txtAn);
            this.Controls.Add(this.txtLuna);
            this.Controls.Add(this.txtNrOre);
            this.Controls.Add(this.txtTarif);
            this.Controls.Add(this.txtZi);
            this.Controls.Add(this.lblNrOre);
            this.Controls.Add(this.lblTarif);
            this.Controls.Add(this.lblZi);
            this.Controls.Add(this.txtNrc);
            this.Controls.Add(this.lblNrc);
            this.Controls.Add(this.btnAdauga);
            this.MaximumSize = new System.Drawing.Size(818, 497);
            this.MinimumSize = new System.Drawing.Size(818, 497);
            this.Name = "AdaugaPontaj";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AdaugaPontaj";
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnAdauga;
        private DataSet1 dataSet1;
        private DataSet1TableAdapters.PontajContinutTableAdapter pontajContinutTableAdapter1;
        private DataSet1TableAdapters.PontajTableAdapter pontajTableAdapter1;
        private System.Windows.Forms.Label lblAn;
        private System.Windows.Forms.Label lblLuna;
        private System.Windows.Forms.TextBox txtAn;
        private System.Windows.Forms.TextBox txtLuna;
        private System.Windows.Forms.TextBox txtNrOre;
        private System.Windows.Forms.TextBox txtTarif;
        private System.Windows.Forms.TextBox txtZi;
        private System.Windows.Forms.Label lblNrOre;
        private System.Windows.Forms.Label lblTarif;
        private System.Windows.Forms.Label lblZi;
        private System.Windows.Forms.TextBox txtNrc;
        private System.Windows.Forms.Label lblNrc;
        private System.Windows.Forms.Label lblIdAngajat;
        private System.Windows.Forms.TextBox txtCnpAngajat;
    }
}