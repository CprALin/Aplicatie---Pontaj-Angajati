namespace WindowsFormsApp1
{
    partial class FormAngajati
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
            this.btnAdaugare = new System.Windows.Forms.Button();
            this.btnModificare = new System.Windows.Forms.Button();
            this.btnStergere = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataSet11 = new WindowsFormsApp1.DataSet1();
            this.dataSet1 = new WindowsFormsApp1.DataSet1();
            this.btnRenuntare = new System.Windows.Forms.Button();
            this.btnConfirmare = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtAngajat = new System.Windows.Forms.TextBox();
            this.lblAngajat = new System.Windows.Forms.Label();
            this.txtDepartament = new System.Windows.Forms.TextBox();
            this.txtImagine = new System.Windows.Forms.TextBox();
            this.txtTarif = new System.Windows.Forms.TextBox();
            this.txtPost = new System.Windows.Forms.TextBox();
            this.txtCNP = new System.Windows.Forms.TextBox();
            this.lblDepartament = new System.Windows.Forms.Label();
            this.lblImagine = new System.Windows.Forms.Label();
            this.lblTarif = new System.Windows.Forms.Label();
            this.lblPost = new System.Windows.Forms.Label();
            this.lblCNP = new System.Windows.Forms.Label();
            this.txtNume = new System.Windows.Forms.TextBox();
            this.lblNume = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.angajatiTableAdapter = new WindowsFormsApp1.DataSet1TableAdapters.AngajatiTableAdapter();
            this.lblOp = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.angajatiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.idAngajatDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numeAngajatDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cNPDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.postDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tarifOraDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.spImagineDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idDepartamentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.angajatiBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAdaugare
            // 
            this.btnAdaugare.Location = new System.Drawing.Point(26, 29);
            this.btnAdaugare.Name = "btnAdaugare";
            this.btnAdaugare.Size = new System.Drawing.Size(166, 41);
            this.btnAdaugare.TabIndex = 0;
            this.btnAdaugare.Text = "Adaugare";
            this.btnAdaugare.UseVisualStyleBackColor = true;
            this.btnAdaugare.Click += new System.EventHandler(this.btnAdaugare_Click);
            // 
            // btnModificare
            // 
            this.btnModificare.Location = new System.Drawing.Point(212, 29);
            this.btnModificare.Name = "btnModificare";
            this.btnModificare.Size = new System.Drawing.Size(166, 41);
            this.btnModificare.TabIndex = 1;
            this.btnModificare.Text = "Modificare";
            this.btnModificare.UseVisualStyleBackColor = true;
            this.btnModificare.Click += new System.EventHandler(this.btnModificare_Click);
            // 
            // btnStergere
            // 
            this.btnStergere.Location = new System.Drawing.Point(395, 29);
            this.btnStergere.Name = "btnStergere";
            this.btnStergere.Size = new System.Drawing.Size(166, 41);
            this.btnStergere.TabIndex = 2;
            this.btnStergere.Text = "Stergere";
            this.btnStergere.UseVisualStyleBackColor = true;
            this.btnStergere.Click += new System.EventHandler(this.btnStergere_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idAngajatDataGridViewTextBoxColumn,
            this.numeAngajatDataGridViewTextBoxColumn,
            this.cNPDataGridViewTextBoxColumn,
            this.postDataGridViewTextBoxColumn,
            this.tarifOraDataGridViewTextBoxColumn,
            this.spImagineDataGridViewTextBoxColumn,
            this.idDepartamentDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.angajatiBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 101);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(786, 306);
            this.dataGridView1.TabIndex = 3;
            // 
            // dataSet11
            // 
            this.dataSet11.DataSetName = "DataSet1";
            this.dataSet11.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnRenuntare
            // 
            this.btnRenuntare.Location = new System.Drawing.Point(985, 29);
            this.btnRenuntare.Name = "btnRenuntare";
            this.btnRenuntare.Size = new System.Drawing.Size(138, 41);
            this.btnRenuntare.TabIndex = 4;
            this.btnRenuntare.Text = "Renuntare";
            this.btnRenuntare.UseVisualStyleBackColor = true;
            this.btnRenuntare.Click += new System.EventHandler(this.btnRenuntare_Click);
            // 
            // btnConfirmare
            // 
            this.btnConfirmare.Location = new System.Drawing.Point(816, 29);
            this.btnConfirmare.Name = "btnConfirmare";
            this.btnConfirmare.Size = new System.Drawing.Size(140, 41);
            this.btnConfirmare.TabIndex = 5;
            this.btnConfirmare.Text = "Confirmare";
            this.btnConfirmare.UseVisualStyleBackColor = true;
            this.btnConfirmare.Click += new System.EventHandler(this.btnConfirmare_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtAngajat);
            this.panel1.Controls.Add(this.lblAngajat);
            this.panel1.Controls.Add(this.txtDepartament);
            this.panel1.Controls.Add(this.txtImagine);
            this.panel1.Controls.Add(this.txtTarif);
            this.panel1.Controls.Add(this.txtPost);
            this.panel1.Controls.Add(this.txtCNP);
            this.panel1.Controls.Add(this.lblDepartament);
            this.panel1.Controls.Add(this.lblImagine);
            this.panel1.Controls.Add(this.lblTarif);
            this.panel1.Controls.Add(this.lblPost);
            this.panel1.Controls.Add(this.lblCNP);
            this.panel1.Controls.Add(this.txtNume);
            this.panel1.Controls.Add(this.lblNume);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(816, 97);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(469, 310);
            this.panel1.TabIndex = 6;
            // 
            // txtAngajat
            // 
            this.txtAngajat.Location = new System.Drawing.Point(361, 14);
            this.txtAngajat.Name = "txtAngajat";
            this.txtAngajat.Size = new System.Drawing.Size(72, 22);
            this.txtAngajat.TabIndex = 14;
            // 
            // lblAngajat
            // 
            this.lblAngajat.AutoSize = true;
            this.lblAngajat.Location = new System.Drawing.Point(286, 17);
            this.lblAngajat.Name = "lblAngajat";
            this.lblAngajat.Size = new System.Drawing.Size(69, 16);
            this.lblAngajat.TabIndex = 13;
            this.lblAngajat.Text = "ID Angajat";
            // 
            // txtDepartament
            // 
            this.txtDepartament.Location = new System.Drawing.Point(125, 256);
            this.txtDepartament.Name = "txtDepartament";
            this.txtDepartament.Size = new System.Drawing.Size(146, 22);
            this.txtDepartament.TabIndex = 12;
            // 
            // txtImagine
            // 
            this.txtImagine.Location = new System.Drawing.Point(89, 212);
            this.txtImagine.Name = "txtImagine";
            this.txtImagine.Size = new System.Drawing.Size(146, 22);
            this.txtImagine.TabIndex = 11;
            // 
            // txtTarif
            // 
            this.txtTarif.Location = new System.Drawing.Point(89, 172);
            this.txtTarif.Name = "txtTarif";
            this.txtTarif.Size = new System.Drawing.Size(146, 22);
            this.txtTarif.TabIndex = 10;
            // 
            // txtPost
            // 
            this.txtPost.Location = new System.Drawing.Point(89, 126);
            this.txtPost.Name = "txtPost";
            this.txtPost.Size = new System.Drawing.Size(146, 22);
            this.txtPost.TabIndex = 9;
            // 
            // txtCNP
            // 
            this.txtCNP.Location = new System.Drawing.Point(89, 83);
            this.txtCNP.Name = "txtCNP";
            this.txtCNP.Size = new System.Drawing.Size(146, 22);
            this.txtCNP.TabIndex = 8;
            // 
            // lblDepartament
            // 
            this.lblDepartament.AutoSize = true;
            this.lblDepartament.Location = new System.Drawing.Point(18, 259);
            this.lblDepartament.Name = "lblDepartament";
            this.lblDepartament.Size = new System.Drawing.Size(101, 16);
            this.lblDepartament.TabIndex = 7;
            this.lblDepartament.Text = "ID Departament";
            // 
            // lblImagine
            // 
            this.lblImagine.AutoSize = true;
            this.lblImagine.Location = new System.Drawing.Point(18, 215);
            this.lblImagine.Name = "lblImagine";
            this.lblImagine.Size = new System.Drawing.Size(55, 16);
            this.lblImagine.TabIndex = 6;
            this.lblImagine.Text = "Imagine";
            // 
            // lblTarif
            // 
            this.lblTarif.AutoSize = true;
            this.lblTarif.Location = new System.Drawing.Point(18, 175);
            this.lblTarif.Name = "lblTarif";
            this.lblTarif.Size = new System.Drawing.Size(66, 16);
            this.lblTarif.TabIndex = 5;
            this.lblTarif.Text = "Tarif / Ora";
            // 
            // lblPost
            // 
            this.lblPost.AutoSize = true;
            this.lblPost.Location = new System.Drawing.Point(18, 129);
            this.lblPost.Name = "lblPost";
            this.lblPost.Size = new System.Drawing.Size(34, 16);
            this.lblPost.TabIndex = 4;
            this.lblPost.Text = "Post";
            // 
            // lblCNP
            // 
            this.lblCNP.AutoSize = true;
            this.lblCNP.Location = new System.Drawing.Point(18, 86);
            this.lblCNP.Name = "lblCNP";
            this.lblCNP.Size = new System.Drawing.Size(35, 16);
            this.lblCNP.TabIndex = 3;
            this.lblCNP.Text = "CNP";
            // 
            // txtNume
            // 
            this.txtNume.Location = new System.Drawing.Point(125, 39);
            this.txtNume.Name = "txtNume";
            this.txtNume.Size = new System.Drawing.Size(146, 22);
            this.txtNume.TabIndex = 2;
            // 
            // lblNume
            // 
            this.lblNume.AutoSize = true;
            this.lblNume.Location = new System.Drawing.Point(18, 39);
            this.lblNume.Name = "lblNume";
            this.lblNume.Size = new System.Drawing.Size(43, 16);
            this.lblNume.TabIndex = 1;
            this.lblNume.Text = "Nume";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(264, 67);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(190, 180);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.SpImagine);
            // 
            // angajatiTableAdapter
            // 
            this.angajatiTableAdapter.ClearBeforeFill = true;
            // 
            // lblOp
            // 
            this.lblOp.AutoSize = true;
            this.lblOp.Location = new System.Drawing.Point(1174, 41);
            this.lblOp.Name = "lblOp";
            this.lblOp.Size = new System.Drawing.Size(39, 16);
            this.lblOp.TabIndex = 7;
            this.lblOp.Text = "lblOp";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // angajatiBindingSource
            // 
            this.angajatiBindingSource.DataMember = "Angajati";
            this.angajatiBindingSource.DataSource = this.dataSet11;
            // 
            // idAngajatDataGridViewTextBoxColumn
            // 
            this.idAngajatDataGridViewTextBoxColumn.DataPropertyName = "idAngajat";
            this.idAngajatDataGridViewTextBoxColumn.HeaderText = "idAngajat";
            this.idAngajatDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idAngajatDataGridViewTextBoxColumn.Name = "idAngajatDataGridViewTextBoxColumn";
            this.idAngajatDataGridViewTextBoxColumn.Width = 125;
            // 
            // numeAngajatDataGridViewTextBoxColumn
            // 
            this.numeAngajatDataGridViewTextBoxColumn.DataPropertyName = "NumeAngajat";
            this.numeAngajatDataGridViewTextBoxColumn.HeaderText = "NumeAngajat";
            this.numeAngajatDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.numeAngajatDataGridViewTextBoxColumn.Name = "numeAngajatDataGridViewTextBoxColumn";
            this.numeAngajatDataGridViewTextBoxColumn.Width = 125;
            // 
            // cNPDataGridViewTextBoxColumn
            // 
            this.cNPDataGridViewTextBoxColumn.DataPropertyName = "CNP";
            this.cNPDataGridViewTextBoxColumn.HeaderText = "CNP";
            this.cNPDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.cNPDataGridViewTextBoxColumn.Name = "cNPDataGridViewTextBoxColumn";
            this.cNPDataGridViewTextBoxColumn.Width = 125;
            // 
            // postDataGridViewTextBoxColumn
            // 
            this.postDataGridViewTextBoxColumn.DataPropertyName = "Post";
            this.postDataGridViewTextBoxColumn.HeaderText = "Post";
            this.postDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.postDataGridViewTextBoxColumn.Name = "postDataGridViewTextBoxColumn";
            this.postDataGridViewTextBoxColumn.Width = 125;
            // 
            // tarifOraDataGridViewTextBoxColumn
            // 
            this.tarifOraDataGridViewTextBoxColumn.DataPropertyName = "TarifOra";
            this.tarifOraDataGridViewTextBoxColumn.HeaderText = "TarifOra";
            this.tarifOraDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.tarifOraDataGridViewTextBoxColumn.Name = "tarifOraDataGridViewTextBoxColumn";
            this.tarifOraDataGridViewTextBoxColumn.Width = 125;
            // 
            // spImagineDataGridViewTextBoxColumn
            // 
            this.spImagineDataGridViewTextBoxColumn.DataPropertyName = "SpImagine";
            this.spImagineDataGridViewTextBoxColumn.HeaderText = "SpImagine";
            this.spImagineDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.spImagineDataGridViewTextBoxColumn.Name = "spImagineDataGridViewTextBoxColumn";
            this.spImagineDataGridViewTextBoxColumn.Width = 125;
            // 
            // idDepartamentDataGridViewTextBoxColumn
            // 
            this.idDepartamentDataGridViewTextBoxColumn.DataPropertyName = "idDepartament";
            this.idDepartamentDataGridViewTextBoxColumn.HeaderText = "idDepartament";
            this.idDepartamentDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idDepartamentDataGridViewTextBoxColumn.Name = "idDepartamentDataGridViewTextBoxColumn";
            this.idDepartamentDataGridViewTextBoxColumn.Width = 125;
            // 
            // FormAngajati
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1297, 450);
            this.Controls.Add(this.lblOp);
            this.Controls.Add(this.btnRenuntare);
            this.Controls.Add(this.btnConfirmare);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnStergere);
            this.Controls.Add(this.btnModificare);
            this.Controls.Add(this.btnAdaugare);
            this.MaximumSize = new System.Drawing.Size(1315, 497);
            this.MinimumSize = new System.Drawing.Size(1315, 497);
            this.Name = "FormAngajati";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormAngajati";
            this.Load += new System.EventHandler(this.FormAngajati_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.angajatiBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAdaugare;
        private System.Windows.Forms.Button btnModificare;
        private System.Windows.Forms.Button btnStergere;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnRenuntare;
        private System.Windows.Forms.Button btnConfirmare;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtNume;
        private System.Windows.Forms.Label lblNume;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtDepartament;
        private System.Windows.Forms.TextBox txtImagine;
        private System.Windows.Forms.TextBox txtTarif;
        private System.Windows.Forms.TextBox txtPost;
        private System.Windows.Forms.TextBox txtCNP;
        private System.Windows.Forms.Label lblDepartament;
        private System.Windows.Forms.Label lblImagine;
        private System.Windows.Forms.Label lblTarif;
        private System.Windows.Forms.Label lblPost;
        private System.Windows.Forms.Label lblCNP;
        private DataSet1 dataSet1;
        private DataSet1TableAdapters.AngajatiTableAdapter angajatiTableAdapter;
        private System.Windows.Forms.Label lblOp;
        private System.Windows.Forms.TextBox txtAngajat;
        private System.Windows.Forms.Label lblAngajat;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private DataSet1 dataSet11;
        private System.Windows.Forms.DataGridViewTextBoxColumn idAngajatDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numeAngajatDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cNPDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn postDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tarifOraDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn spImagineDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDepartamentDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource angajatiBindingSource;
    }
}