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
    public partial class FormModificaPontaj : Form
    {
        FormPontaje formPontaj;
        public FormModificaPontaj(FormPontaje formPontaj)
        {
            InitializeComponent();
            this.formPontaj = formPontaj;
        }

        private void A1()
        {
            RefreshGrid(pontajAngajatBindingSource.Position);
            A2();

        }

        private void A2()
        {
            txtNumeAngajat.DataBindings.Add("Text" , pontajAngajatBindingSource , "NumeAngajat");
            txtAn.DataBindings.Add("Text", pontajAngajatBindingSource, "An");
            txtLuna.DataBindings.Add("Text" , pontajAngajatBindingSource, "Luna");
            txtNrc.DataBindings.Add("Text", pontajAngajatBindingSource, "Nrc");
            txtZi.DataBindings.Add("Text", pontajAngajatBindingSource, "Zi");
            txtTarif.DataBindings.Add("Text", pontajAngajatBindingSource, "TarifOra");
            txtNrOre.DataBindings.Add("Text", pontajAngajatBindingSource, "NrOre");

            txtTarif.TextChanged += TxtTarif_TextChanged;
            txtNrOre.TextChanged += TxtNrOre_TextChanged;
        }

        private void Modificare()
        {
            try
            {
                string numeAngajat = txtNumeAngajat.Text;

                using (OleDbConnection con = new OleDbConnection(pontajAngajatTableAdapter.Connection.ConnectionString))
                {
                    con.Open();

                    // Obținere idAngajat din Angajati
                    using (OleDbCommand cmdAngajati = new OleDbCommand())
                    {
                        cmdAngajati.Connection = con;
                        cmdAngajati.CommandText = $"SELECT idAngajat FROM Angajati WHERE NumeAngajat = '{numeAngajat}'";

                        string idAngajat = cmdAngajati.ExecuteScalar()?.ToString();

                        if (idAngajat != null)
                        {
                            // Actualizare în Pontaj
                            using (OleDbCommand cmdPontaj = new OleDbCommand())
                            {
                                cmdPontaj.Connection = con;

                                string listaValoriPontaj = $"An = '{txtAn.Text}', Luna = '{txtLuna.Text}'";
                                cmdPontaj.CommandText = $"UPDATE Pontaj SET {listaValoriPontaj} WHERE idAngajat = {idAngajat}";
                                cmdPontaj.ExecuteNonQuery();
                            }

                            // Obținere idPontaj din Pontaj
                            using (OleDbCommand cmdIdPontaj = new OleDbCommand())
                            {
                                cmdIdPontaj.Connection = con;
                                cmdIdPontaj.CommandText = $"SELECT idPontaj FROM Pontaj WHERE idAngajat = {idAngajat}";

                                // Obținerea valorii idPontaj dintr-un Reader
                                using (OleDbDataReader reader = cmdIdPontaj.ExecuteReader())
                                {
                                    if (reader.Read())
                                    {
                                        string idPontaj = reader["idPontaj"].ToString();

                                        reader.Close(); // Închideți cititorul de date înainte de a continua

                                        // Actualizare în PontajContinut
                                        string listaValoriPontajContinut = $"Nrc = '{txtNrc.Text}', Zi = '{txtZi.Text}', TarifOra = '{txtTarif.Text}', NrOre = '{txtNrOre.Text}'";
                                        using (OleDbCommand cmdPontajContinut = new OleDbCommand())
                                        {
                                            cmdPontajContinut.Connection = con;
                                            cmdPontajContinut.CommandText = $"UPDATE PontajContinut SET {listaValoriPontajContinut} WHERE idPontaj = {idPontaj}";
                                            cmdPontajContinut.ExecuteNonQuery();
                                        }
                                    }
                                }
                            }

                            con.Close();

                            // Actualizare grilă după modificare
                            RefreshGrid(pontajAngajatBindingSource.Position);
                            formPontaj.refreshGrid();
                            new FormPontaje().refreshGrid();

                            MessageBox.Show("Modificare cu succes !");
                        }
                        else
                        {
                            MessageBox.Show("Numele angajatului nu a fost găsit în baza de date!");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void CalzuleazaTotal()
        {
            double total = double.Parse(txtTarif.Text) * double.Parse(txtNrOre.Text);
            txtTotal.Text = total.ToString();
        }

        private void TxtTarif_TextChanged(object sender, EventArgs e)
        {
            CalzuleazaTotal();
        }

        private void TxtNrOre_TextChanged(object sender, EventArgs e)
        {
            CalzuleazaTotal();
        }

        private new bool Validate()
        {
            if (txtNumeAngajat.Text == "")
            {
                MessageBox.Show("Introduceți un Nume Angajat !");
                txtNumeAngajat.Focus();
                return false;
            }

            if (!int.TryParse(txtAn.Text, out int an) || an < 1900 || an > 2100)
            {
                MessageBox.Show("Introduceți un An valid între 1900 și 2100!");
                txtAn.Focus();
                return false;
            }

            if (!int.TryParse(txtLuna.Text, out int luna) || luna < 1 || luna > 12)
            {
                MessageBox.Show("Introduceți o lună validă între 1 și 12!");
                txtLuna.Focus();
                return false;
            }

            if (!int.TryParse(txtNrc.Text, out int nrc) || nrc < 1000)
            {
                MessageBox.Show("Introduceți un Nrc valid (mai mare sau egal cu 1000)!");
                txtNrc.Focus();
                return false;
            }

            if (!int.TryParse(txtZi.Text, out int zi) || zi < 1 || zi > 31)
            {
                MessageBox.Show("Introduceți o zi validă între 1 și 31!");
                txtZi.Focus();
                return false;
            }

            if (!double.TryParse(txtTarif.Text, out _))
            {
                MessageBox.Show("Introduceți un tarif valid!");
                txtTarif.Focus();
                return false;
            }

            if (!int.TryParse(txtNrOre.Text, out _))
            {
                MessageBox.Show("Introduceți un număr de ore valid!");
                txtNrOre.Focus();
                return false;
            }

            return true;
        }


        private void FormModificaPontaj_Load(object sender, EventArgs e)
        {
            A1();
        }

        private void RefreshGrid(int p)
        {
            this.pontajAngajatTableAdapter.Fill(this.dataSet1.PontajAngajat);
            pontajAngajatBindingSource.Position = p;
        }

        private void BtnConfirmare_Click(object sender, EventArgs e)
        {
            if (!Validate())
            {
                return;
            }

            Modificare();

        }

     
    }
}
