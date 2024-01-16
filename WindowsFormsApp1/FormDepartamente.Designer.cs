namespace WindowsFormsApp1
{
    partial class FormDepartamente
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
            this.btnConfirmare = new System.Windows.Forms.Button();
            this.btnRenuntare = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtSefDepartament = new System.Windows.Forms.TextBox();
            this.lblSefDepartament = new System.Windows.Forms.Label();
            this.txtDenumire = new System.Windows.Forms.TextBox();
            this.lblDenumire = new System.Windows.Forms.Label();
            this.lblOp = new System.Windows.Forms.Label();
            this.angajatiTableAdapter = new WindowsFormsApp1.DataSet1TableAdapters.AngajatiTableAdapter();
            this.dataSet1 = new WindowsFormsApp1.DataSet1();
            this.departamenteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.departamenteTableAdapter = new WindowsFormsApp1.DataSet1TableAdapters.DepartamenteTableAdapter();
            this.denumireDepartamentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numeAngajatDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.departamenteBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAdaugare
            // 
            this.btnAdaugare.Location = new System.Drawing.Point(12, 28);
            this.btnAdaugare.Name = "btnAdaugare";
            this.btnAdaugare.Size = new System.Drawing.Size(166, 41);
            this.btnAdaugare.TabIndex = 1;
            this.btnAdaugare.Text = "Adaugare";
            this.btnAdaugare.UseVisualStyleBackColor = true;
            this.btnAdaugare.Click += new System.EventHandler(this.btnAdaugare_Click);
            // 
            // btnModificare
            // 
            this.btnModificare.Location = new System.Drawing.Point(194, 28);
            this.btnModificare.Name = "btnModificare";
            this.btnModificare.Size = new System.Drawing.Size(166, 41);
            this.btnModificare.TabIndex = 2;
            this.btnModificare.Text = "Modificare";
            this.btnModificare.UseVisualStyleBackColor = true;
            this.btnModificare.Click += new System.EventHandler(this.btnModificare_Click);
            // 
            // btnStergere
            // 
            this.btnStergere.Location = new System.Drawing.Point(386, 28);
            this.btnStergere.Name = "btnStergere";
            this.btnStergere.Size = new System.Drawing.Size(166, 41);
            this.btnStergere.TabIndex = 3;
            this.btnStergere.Text = "Stergere";
            this.btnStergere.UseVisualStyleBackColor = true;
            this.btnStergere.Click += new System.EventHandler(this.btnStergere_Click);
            // 
            // btnConfirmare
            // 
            this.btnConfirmare.Location = new System.Drawing.Point(847, 163);
            this.btnConfirmare.Name = "btnConfirmare";
            this.btnConfirmare.Size = new System.Drawing.Size(140, 41);
            this.btnConfirmare.TabIndex = 6;
            this.btnConfirmare.Text = "Confirmare";
            this.btnConfirmare.UseVisualStyleBackColor = true;
            this.btnConfirmare.Click += new System.EventHandler(this.btnConfirmare_Click);
            // 
            // btnRenuntare
            // 
            this.btnRenuntare.Location = new System.Drawing.Point(1114, 163);
            this.btnRenuntare.Name = "btnRenuntare";
            this.btnRenuntare.Size = new System.Drawing.Size(138, 41);
            this.btnRenuntare.TabIndex = 7;
            this.btnRenuntare.Text = "Renuntare";
            this.btnRenuntare.UseVisualStyleBackColor = true;
            this.btnRenuntare.Click += new System.EventHandler(this.btnRenuntare_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.denumireDepartamentDataGridViewTextBoxColumn,
            this.numeAngajatDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.departamenteBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 105);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(750, 306);
            this.dataGridView1.TabIndex = 8;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtSefDepartament);
            this.panel1.Controls.Add(this.lblSefDepartament);
            this.panel1.Controls.Add(this.txtDenumire);
            this.panel1.Controls.Add(this.lblDenumire);
            this.panel1.Location = new System.Drawing.Point(797, 242);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(469, 144);
            this.panel1.TabIndex = 9;
            // 
            // txtSefDepartament
            // 
            this.txtSefDepartament.Location = new System.Drawing.Point(240, 88);
            this.txtSefDepartament.Name = "txtSefDepartament";
            this.txtSefDepartament.Size = new System.Drawing.Size(188, 22);
            this.txtSefDepartament.TabIndex = 4;
            // 
            // lblSefDepartament
            // 
            this.lblSefDepartament.AutoSize = true;
            this.lblSefDepartament.Location = new System.Drawing.Point(74, 91);
            this.lblSefDepartament.Name = "lblSefDepartament";
            this.lblSefDepartament.Size = new System.Drawing.Size(115, 16);
            this.lblSefDepartament.TabIndex = 3;
            this.lblSefDepartament.Text = "Nume Angajat Sef";
            // 
            // txtDenumire
            // 
            this.txtDenumire.Location = new System.Drawing.Point(240, 35);
            this.txtDenumire.Name = "txtDenumire";
            this.txtDenumire.Size = new System.Drawing.Size(188, 22);
            this.txtDenumire.TabIndex = 2;
            // 
            // lblDenumire
            // 
            this.lblDenumire.AutoSize = true;
            this.lblDenumire.Location = new System.Drawing.Point(74, 38);
            this.lblDenumire.Name = "lblDenumire";
            this.lblDenumire.Size = new System.Drawing.Size(65, 16);
            this.lblDenumire.TabIndex = 1;
            this.lblDenumire.Text = "Denumire";
            // 
            // lblOp
            // 
            this.lblOp.AutoSize = true;
            this.lblOp.Location = new System.Drawing.Point(1022, 105);
            this.lblOp.Name = "lblOp";
            this.lblOp.Size = new System.Drawing.Size(39, 16);
            this.lblOp.TabIndex = 8;
            this.lblOp.Text = "lblOp";
            // 
            // angajatiTableAdapter
            // 
            this.angajatiTableAdapter.ClearBeforeFill = true;
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // departamenteBindingSource
            // 
            this.departamenteBindingSource.DataMember = "Departamente";
            this.departamenteBindingSource.DataSource = this.dataSet1;
            // 
            // departamenteTableAdapter
            // 
            this.departamenteTableAdapter.ClearBeforeFill = true;
            // 
            // denumireDepartamentDataGridViewTextBoxColumn
            // 
            this.denumireDepartamentDataGridViewTextBoxColumn.DataPropertyName = "DenumireDepartament";
            this.denumireDepartamentDataGridViewTextBoxColumn.HeaderText = "DenumireDepartament";
            this.denumireDepartamentDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.denumireDepartamentDataGridViewTextBoxColumn.Name = "denumireDepartamentDataGridViewTextBoxColumn";
            this.denumireDepartamentDataGridViewTextBoxColumn.Width = 125;
            // 
            // numeAngajatDataGridViewTextBoxColumn
            // 
            this.numeAngajatDataGridViewTextBoxColumn.DataPropertyName = "NumeAngajat";
            this.numeAngajatDataGridViewTextBoxColumn.HeaderText = "NumeAngajat";
            this.numeAngajatDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.numeAngajatDataGridViewTextBoxColumn.Name = "numeAngajatDataGridViewTextBoxColumn";
            this.numeAngajatDataGridViewTextBoxColumn.Width = 125;
            // 
            // FormDepartamente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1297, 450);
            this.Controls.Add(this.lblOp);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnRenuntare);
            this.Controls.Add(this.btnConfirmare);
            this.Controls.Add(this.btnStergere);
            this.Controls.Add(this.btnModificare);
            this.Controls.Add(this.btnAdaugare);
            this.MaximumSize = new System.Drawing.Size(1315, 497);
            this.MinimumSize = new System.Drawing.Size(1315, 497);
            this.Name = "FormDepartamente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormDepartamente";
            this.Load += new System.EventHandler(this.FormDepartamente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.departamenteBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAdaugare;
        private System.Windows.Forms.Button btnModificare;
        private System.Windows.Forms.Button btnStergere;
        private System.Windows.Forms.Button btnConfirmare;
        private System.Windows.Forms.Button btnRenuntare;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblSefDepartament;
        private System.Windows.Forms.TextBox txtDenumire;
        private System.Windows.Forms.Label lblDenumire;
        private System.Windows.Forms.TextBox txtSefDepartament;
        private System.Windows.Forms.Label lblOp;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDepartamentDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idSefDepartamentDataGridViewTextBoxColumn;
        private DataSet1TableAdapters.AngajatiTableAdapter angajatiTableAdapter;
        private DataSet1 dataSet1;
        private System.Windows.Forms.BindingSource departamenteBindingSource;
        private DataSet1TableAdapters.DepartamenteTableAdapter departamenteTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn denumireDepartamentDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numeAngajatDataGridViewTextBoxColumn;
    }
}