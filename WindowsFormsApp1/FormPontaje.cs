using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.DataSet1TableAdapters;

namespace WindowsFormsApp1
{
    public partial class FormPontaje : Form
    {
    
        public FormPontaje()
        {
            InitializeComponent();
        }

        public void refreshGrid()
        {
            this.pontajAngajatTableAdapter.Fill(this.dataSet1.PontajAngajat);
        }

        private void A1()
        {
   
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.ReadOnly = true;

            txtNrc.ReadOnly = true;

            SelectedId();

        }

        private void SelectedId()
        {
            txtNrc.DataBindings.Add("Text", pontajAngajatBindingSource, "Nrc");
        }

        private void FormPontaje_Load(object sender, EventArgs e)
        {
            A1();
            refreshGrid();
        }

        private void BtnModificaPontaj_Click(object sender, EventArgs e)
        {
            FormModificaPontaj form = new FormModificaPontaj(this);
            form.Show();
        }

        public void Stergere()
        {
            try
            {
                using (OleDbConnection con = new OleDbConnection(pontajContinutTableAdapter.Connection.ConnectionString))
                using (OleDbCommand cmd = new OleDbCommand())
                {
                    con.Open();

                    cmd.Connection = con; // Adaugă această linie pentru a stabili conexiunea pentru comandă

                    cmd.CommandText = $"SELECT idPontaj FROM PontajContinut WHERE Nrc = '{txtNrc.Text}'";
                    object idPontaj = cmd.ExecuteScalar();

                    if (idPontaj != null)
                    {
                        // Modifică înregistrarea
                        cmd.CommandText = $"DELETE FROM PontajContinut WHERE idPontaj = {idPontaj}";
                        cmd.ExecuteNonQuery();

                        cmd.CommandText = $"DELETE FROM Pontaj WHERE idPontaj = {idPontaj}";
                        cmd.ExecuteNonQuery();

                        MessageBox.Show("Înregistrarea a fost ștearsă!");
                        refreshGrid();
                    }
                    else
                    {
                        MessageBox.Show("Înregistrarea nu a fost găsită!");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        private void BtnStergePontaj_Click(object sender, EventArgs e)
        {
            const string mesaj = "Confirmati stergerea";
            const string titlu = "Stergere inregistrare";
            var rezultat = MessageBox.Show(mesaj, titlu, MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (rezultat == DialogResult.No) return;
            //stergere
            Stergere();
        }

        private void BntPontajNou_Click(object sender, EventArgs e)
        {
            AdaugaPontaj form = new AdaugaPontaj(this);
            form.Show();
        }
    }
}
