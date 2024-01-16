namespace WindowsFormsApp1
{
    partial class FormPontaje
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
            this.bntPontajNou = new System.Windows.Forms.Button();
            this.btnModificaPontaj = new System.Windows.Forms.Button();
            this.btnStergePontaj = new System.Windows.Forms.Button();
            this.pontajAngajatTableAdapter = new WindowsFormsApp1.DataSet1TableAdapters.PontajAngajatTableAdapter();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNrc = new System.Windows.Forms.TextBox();
            this.pontajTableAdapter = new WindowsFormsApp1.DataSet1TableAdapters.PontajTableAdapter();
            this.pontajContinutTableAdapter = new WindowsFormsApp1.DataSet1TableAdapters.PontajContinutTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pontajAngajatBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            this.SuspendLayout();
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
            this.dataGridView1.Location = new System.Drawing.Point(31, 232);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(991, 206);
            this.dataGridView1.TabIndex = 0;
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
            // bntPontajNou
            // 
            this.bntPontajNou.Location = new System.Drawing.Point(111, 107);
            this.bntPontajNou.Name = "bntPontajNou";
            this.bntPontajNou.Size = new System.Drawing.Size(139, 50);
            this.bntPontajNou.TabIndex = 3;
            this.bntPontajNou.Text = "Pontaj Nou";
            this.bntPontajNou.UseVisualStyleBackColor = true;
            this.bntPontajNou.Click += new System.EventHandler(this.BntPontajNou_Click);
            // 
            // btnModificaPontaj
            // 
            this.btnModificaPontaj.Location = new System.Drawing.Point(455, 107);
            this.btnModificaPontaj.Name = "btnModificaPontaj";
            this.btnModificaPontaj.Size = new System.Drawing.Size(139, 50);
            this.btnModificaPontaj.TabIndex = 4;
            this.btnModificaPontaj.Text = "Modifica Pontaj";
            this.btnModificaPontaj.UseVisualStyleBackColor = true;
            this.btnModificaPontaj.Click += new System.EventHandler(this.BtnModificaPontaj_Click);
            // 
            // btnStergePontaj
            // 
            this.btnStergePontaj.Location = new System.Drawing.Point(801, 107);
            this.btnStergePontaj.Name = "btnStergePontaj";
            this.btnStergePontaj.Size = new System.Drawing.Size(139, 50);
            this.btnStergePontaj.TabIndex = 5;
            this.btnStergePontaj.Text = "Sterge Pontaj";
            this.btnStergePontaj.UseVisualStyleBackColor = true;
            this.btnStergePontaj.Click += new System.EventHandler(this.BtnStergePontaj_Click);
            // 
            // pontajAngajatTableAdapter
            // 
            this.pontajAngajatTableAdapter.ClearBeforeFill = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(449, 34);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 16);
            this.label3.TabIndex = 21;
            this.label3.Text = "Nrc";
            // 
            // txtNrc
            // 
            this.txtNrc.Location = new System.Drawing.Point(483, 31);
            this.txtNrc.Name = "txtNrc";
            this.txtNrc.Size = new System.Drawing.Size(100, 22);
            this.txtNrc.TabIndex = 22;
            // 
            // pontajTableAdapter
            // 
            this.pontajTableAdapter.ClearBeforeFill = true;
            // 
            // pontajContinutTableAdapter
            // 
            this.pontajContinutTableAdapter.ClearBeforeFill = true;
            // 
            // FormPontaje
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1055, 450);
            this.Controls.Add(this.txtNrc);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnStergePontaj);
            this.Controls.Add(this.btnModificaPontaj);
            this.Controls.Add(this.bntPontajNou);
            this.Controls.Add(this.dataGridView1);
            this.MaximumSize = new System.Drawing.Size(1073, 497);
            this.MinimumSize = new System.Drawing.Size(1073, 497);
            this.Name = "FormPontaje";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormPontaje";
            this.Load += new System.EventHandler(this.FormPontaje_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pontajAngajatBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button bntPontajNou;
        private System.Windows.Forms.Button btnModificaPontaj;
        private System.Windows.Forms.Button btnStergePontaj;
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
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNrc;
        private DataSet1TableAdapters.PontajTableAdapter pontajTableAdapter;
        private DataSet1TableAdapters.PontajContinutTableAdapter pontajContinutTableAdapter;
    }
}