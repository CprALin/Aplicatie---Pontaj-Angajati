namespace WindowsFormsApp1
{
    partial class FormModificaPontaj
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
            this.lblNrc = new System.Windows.Forms.Label();
            this.txtNrc = new System.Windows.Forms.TextBox();
            this.lblZi = new System.Windows.Forms.Label();
            this.lblTarif = new System.Windows.Forms.Label();
            this.lblNrOre = new System.Windows.Forms.Label();
            this.txtZi = new System.Windows.Forms.TextBox();
            this.txtTarif = new System.Windows.Forms.TextBox();
            this.txtNrOre = new System.Windows.Forms.TextBox();
            this.btnConfirmare = new System.Windows.Forms.Button();
            this.txtLuna = new System.Windows.Forms.TextBox();
            this.txtAn = new System.Windows.Forms.TextBox();
            this.lblLuna = new System.Windows.Forms.Label();
            this.lblAn = new System.Windows.Forms.Label();
            this.txtNumeAngajat = new System.Windows.Forms.TextBox();
            this.lblIdAngajat = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.numeAngajatDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nrcDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ziDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.anDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lunaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tarifOraDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nrOreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pontajAngajatBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet1 = new WindowsFormsApp1.DataSet1();
            this.pontajAngajatTableAdapter = new WindowsFormsApp1.DataSet1TableAdapters.PontajAngajatTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pontajAngajatBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNrc
            // 
            this.lblNrc.AutoSize = true;
            this.lblNrc.Location = new System.Drawing.Point(28, 20);
            this.lblNrc.Name = "lblNrc";
            this.lblNrc.Size = new System.Drawing.Size(28, 16);
            this.lblNrc.TabIndex = 1;
            this.lblNrc.Text = "Nrc";
            // 
            // txtNrc
            // 
            this.txtNrc.Location = new System.Drawing.Point(100, 20);
            this.txtNrc.Name = "txtNrc";
            this.txtNrc.Size = new System.Drawing.Size(100, 22);
            this.txtNrc.TabIndex = 2;
            // 
            // lblZi
            // 
            this.lblZi.AutoSize = true;
            this.lblZi.Location = new System.Drawing.Point(28, 63);
            this.lblZi.Name = "lblZi";
            this.lblZi.Size = new System.Drawing.Size(18, 16);
            this.lblZi.TabIndex = 3;
            this.lblZi.Text = "Zi";
            // 
            // lblTarif
            // 
            this.lblTarif.AutoSize = true;
            this.lblTarif.Location = new System.Drawing.Point(28, 178);
            this.lblTarif.Name = "lblTarif";
            this.lblTarif.Size = new System.Drawing.Size(66, 16);
            this.lblTarif.TabIndex = 4;
            this.lblTarif.Text = "Tarif / Ora";
            // 
            // lblNrOre
            // 
            this.lblNrOre.AutoSize = true;
            this.lblNrOre.Location = new System.Drawing.Point(28, 216);
            this.lblNrOre.Name = "lblNrOre";
            this.lblNrOre.Size = new System.Drawing.Size(46, 16);
            this.lblNrOre.TabIndex = 5;
            this.lblNrOre.Text = "Nr Ore";
            // 
            // txtZi
            // 
            this.txtZi.Location = new System.Drawing.Point(100, 60);
            this.txtZi.Name = "txtZi";
            this.txtZi.Size = new System.Drawing.Size(100, 22);
            this.txtZi.TabIndex = 6;
            // 
            // txtTarif
            // 
            this.txtTarif.Location = new System.Drawing.Point(100, 175);
            this.txtTarif.Name = "txtTarif";
            this.txtTarif.Size = new System.Drawing.Size(100, 22);
            this.txtTarif.TabIndex = 7;
            // 
            // txtNrOre
            // 
            this.txtNrOre.Location = new System.Drawing.Point(100, 213);
            this.txtNrOre.Name = "txtNrOre";
            this.txtNrOre.Size = new System.Drawing.Size(100, 22);
            this.txtNrOre.TabIndex = 8;
            // 
            // btnConfirmare
            // 
            this.btnConfirmare.Location = new System.Drawing.Point(583, 163);
            this.btnConfirmare.Name = "btnConfirmare";
            this.btnConfirmare.Size = new System.Drawing.Size(140, 41);
            this.btnConfirmare.TabIndex = 9;
            this.btnConfirmare.Text = "Confirmare";
            this.btnConfirmare.UseVisualStyleBackColor = true;
            this.btnConfirmare.Click += new System.EventHandler(this.BtnConfirmare_Click);
            // 
            // txtLuna
            // 
            this.txtLuna.Location = new System.Drawing.Point(100, 134);
            this.txtLuna.Name = "txtLuna";
            this.txtLuna.Size = new System.Drawing.Size(100, 22);
            this.txtLuna.TabIndex = 10;
            // 
            // txtAn
            // 
            this.txtAn.Location = new System.Drawing.Point(100, 97);
            this.txtAn.Name = "txtAn";
            this.txtAn.Size = new System.Drawing.Size(100, 22);
            this.txtAn.TabIndex = 11;
            // 
            // lblLuna
            // 
            this.lblLuna.AutoSize = true;
            this.lblLuna.Location = new System.Drawing.Point(28, 137);
            this.lblLuna.Name = "lblLuna";
            this.lblLuna.Size = new System.Drawing.Size(36, 16);
            this.lblLuna.TabIndex = 12;
            this.lblLuna.Text = "Luna";
            // 
            // lblAn
            // 
            this.lblAn.AutoSize = true;
            this.lblAn.Location = new System.Drawing.Point(28, 100);
            this.lblAn.Name = "lblAn";
            this.lblAn.Size = new System.Drawing.Size(23, 16);
            this.lblAn.TabIndex = 13;
            this.lblAn.Text = "An";
            // 
            // txtNumeAngajat
            // 
            this.txtNumeAngajat.Location = new System.Drawing.Point(648, 57);
            this.txtNumeAngajat.Name = "txtNumeAngajat";
            this.txtNumeAngajat.Size = new System.Drawing.Size(122, 22);
            this.txtNumeAngajat.TabIndex = 14;
            // 
            // lblIdAngajat
            // 
            this.lblIdAngajat.AutoSize = true;
            this.lblIdAngajat.Location = new System.Drawing.Point(553, 60);
            this.lblIdAngajat.Name = "lblIdAngajat";
            this.lblIdAngajat.Size = new System.Drawing.Size(89, 16);
            this.lblIdAngajat.TabIndex = 15;
            this.lblIdAngajat.Text = "NumeAngajat";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(304, 114);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 16);
            this.label1.TabIndex = 16;
            this.label1.Text = "Total";
            // 
            // txtTotal
            // 
            this.txtTotal.Location = new System.Drawing.Point(374, 111);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(100, 22);
            this.txtTotal.TabIndex = 17;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.numeAngajatDataGridViewTextBoxColumn,
            this.nrcDataGridViewTextBoxColumn,
            this.ziDataGridViewTextBoxColumn,
            this.anDataGridViewTextBoxColumn,
            this.lunaDataGridViewTextBoxColumn,
            this.tarifOraDataGridViewTextBoxColumn,
            this.nrOreDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.pontajAngajatBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 288);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(776, 150);
            this.dataGridView1.TabIndex = 18;
            // 
            // numeAngajatDataGridViewTextBoxColumn
            // 
            this.numeAngajatDataGridViewTextBoxColumn.DataPropertyName = "NumeAngajat";
            this.numeAngajatDataGridViewTextBoxColumn.HeaderText = "NumeAngajat";
            this.numeAngajatDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.numeAngajatDataGridViewTextBoxColumn.Name = "numeAngajatDataGridViewTextBoxColumn";
            this.numeAngajatDataGridViewTextBoxColumn.Width = 125;
            // 
            // nrcDataGridViewTextBoxColumn
            // 
            this.nrcDataGridViewTextBoxColumn.DataPropertyName = "Nrc";
            this.nrcDataGridViewTextBoxColumn.HeaderText = "Nrc";
            this.nrcDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nrcDataGridViewTextBoxColumn.Name = "nrcDataGridViewTextBoxColumn";
            this.nrcDataGridViewTextBoxColumn.Width = 125;
            // 
            // ziDataGridViewTextBoxColumn
            // 
            this.ziDataGridViewTextBoxColumn.DataPropertyName = "Zi";
            this.ziDataGridViewTextBoxColumn.HeaderText = "Zi";
            this.ziDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.ziDataGridViewTextBoxColumn.Name = "ziDataGridViewTextBoxColumn";
            this.ziDataGridViewTextBoxColumn.Width = 125;
            // 
            // anDataGridViewTextBoxColumn
            // 
            this.anDataGridViewTextBoxColumn.DataPropertyName = "An";
            this.anDataGridViewTextBoxColumn.HeaderText = "An";
            this.anDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.anDataGridViewTextBoxColumn.Name = "anDataGridViewTextBoxColumn";
            this.anDataGridViewTextBoxColumn.Width = 125;
            // 
            // lunaDataGridViewTextBoxColumn
            // 
            this.lunaDataGridViewTextBoxColumn.DataPropertyName = "Luna";
            this.lunaDataGridViewTextBoxColumn.HeaderText = "Luna";
            this.lunaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.lunaDataGridViewTextBoxColumn.Name = "lunaDataGridViewTextBoxColumn";
            this.lunaDataGridViewTextBoxColumn.Width = 125;
            // 
            // tarifOraDataGridViewTextBoxColumn
            // 
            this.tarifOraDataGridViewTextBoxColumn.DataPropertyName = "TarifOra";
            this.tarifOraDataGridViewTextBoxColumn.HeaderText = "TarifOra";
            this.tarifOraDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.tarifOraDataGridViewTextBoxColumn.Name = "tarifOraDataGridViewTextBoxColumn";
            this.tarifOraDataGridViewTextBoxColumn.Width = 125;
            // 
            // nrOreDataGridViewTextBoxColumn
            // 
            this.nrOreDataGridViewTextBoxColumn.DataPropertyName = "NrOre";
            this.nrOreDataGridViewTextBoxColumn.HeaderText = "NrOre";
            this.nrOreDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nrOreDataGridViewTextBoxColumn.Name = "nrOreDataGridViewTextBoxColumn";
            this.nrOreDataGridViewTextBoxColumn.Width = 125;
            // 
            // pontajAngajatBindingSource
            // 
            this.pontajAngajatBindingSource.DataMember = "PontajAngajat";
            this.pontajAngajatBindingSource.DataSource = this.dataSet1;
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pontajAngajatTableAdapter
            // 
            this.pontajAngajatTableAdapter.ClearBeforeFill = true;
            // 
            // FormModificaPontaj
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblIdAngajat);
            this.Controls.Add(this.txtNumeAngajat);
            this.Controls.Add(this.lblAn);
            this.Controls.Add(this.lblLuna);
            this.Controls.Add(this.txtAn);
            this.Controls.Add(this.txtLuna);
            this.Controls.Add(this.btnConfirmare);
            this.Controls.Add(this.txtNrOre);
            this.Controls.Add(this.txtTarif);
            this.Controls.Add(this.txtZi);
            this.Controls.Add(this.lblNrOre);
            this.Controls.Add(this.lblTarif);
            this.Controls.Add(this.lblZi);
            this.Controls.Add(this.txtNrc);
            this.Controls.Add(this.lblNrc);
            this.MaximumSize = new System.Drawing.Size(818, 497);
            this.MinimumSize = new System.Drawing.Size(818, 497);
            this.Name = "FormModificaPontaj";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormModificaPontaj";
            this.Load += new System.EventHandler(this.FormModificaPontaj_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pontajAngajatBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblNrc;
        private System.Windows.Forms.TextBox txtNrc;
        private System.Windows.Forms.Label lblZi;
        private System.Windows.Forms.Label lblTarif;
        private System.Windows.Forms.Label lblNrOre;
        private System.Windows.Forms.TextBox txtZi;
        private System.Windows.Forms.TextBox txtTarif;
        private System.Windows.Forms.TextBox txtNrOre;
        private System.Windows.Forms.Button btnConfirmare;
        private System.Windows.Forms.TextBox txtLuna;
        private System.Windows.Forms.TextBox txtAn;
        private System.Windows.Forms.Label lblLuna;
        private System.Windows.Forms.Label lblAn;
        private System.Windows.Forms.TextBox txtNumeAngajat;
        private System.Windows.Forms.Label lblIdAngajat;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.DataGridView dataGridView1;
        private DataSet1 dataSet1;
        private System.Windows.Forms.BindingSource pontajAngajatBindingSource;
        private DataSet1TableAdapters.PontajAngajatTableAdapter pontajAngajatTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn numeAngajatDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nrcDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ziDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn anDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lunaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tarifOraDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nrOreDataGridViewTextBoxColumn;
    }
}