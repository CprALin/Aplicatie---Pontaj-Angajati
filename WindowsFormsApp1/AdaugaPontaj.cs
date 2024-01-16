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

namespace WindowsFormsApp1
{
    public partial class AdaugaPontaj : Form
    {
        FormPontaje formPontaje;
        public AdaugaPontaj(FormPontaje formPontaje)
        {
            InitializeComponent();
            this.formPontaje = formPontaje;
        }
        private new bool Validate()
        {
            if (txtCnpAngajat.Text == "")
            {
                MessageBox.Show("Introduceți un Nume Angajat !");
                txtCnpAngajat.Focus();
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

        private void Adauga()
        {
            try
            {
                using (OleDbConnection con = new OleDbConnection(pontajTableAdapter1.Connection.ConnectionString))
                {
                    con.Open();

                    // Obținere idAngajat din Angajati
                    using (OleDbCommand cmdAngajat = new OleDbCommand())
                    {
                        cmdAngajat.Connection = con;
                        cmdAngajat.CommandText = $"SELECT idAngajat FROM Angajati WHERE CNP = '{txtCnpAngajat.Text}'";
                        object idAngajat = cmdAngajat.ExecuteScalar();

                        // Adăugare în Pontaj
                        using (OleDbCommand cmdPontaj = new OleDbCommand())
                        {
                            cmdPontaj.Connection = con;
                            cmdPontaj.CommandText = "INSERT INTO Pontaj (idAngajat, An, Luna) VALUES (?, ?, ?)";
                            cmdPontaj.Parameters.AddWithValue("idAngajat", idAngajat);
                            cmdPontaj.Parameters.AddWithValue("An", txtAn.Text);
                            cmdPontaj.Parameters.AddWithValue("Luna", txtLuna.Text);
                            cmdPontaj.ExecuteNonQuery();

                            // Obținere idPontaj din Pontaj
                            cmdPontaj.CommandText = "SELECT @@IDENTITY";
                            object idPontaj = cmdPontaj.ExecuteScalar();

                            // Actualizare în PontajContinut
                            string listaValoriPontajContinut = "idPontaj, Nrc, Zi, TarifOra, NrOre";
                            string listaValoriContinut = $"'{idPontaj}', '{txtNrc.Text}', '{txtZi.Text}', '{txtTarif.Text}', '{txtNrOre.Text}'";

                            using (OleDbCommand cmdContinut = new OleDbCommand())
                            {
                                cmdContinut.Connection = con;
                                cmdContinut.CommandText = $"INSERT INTO PontajContinut ({listaValoriPontajContinut}) VALUES ({listaValoriContinut})";
                                cmdContinut.ExecuteNonQuery();
                            }
                        }
                    }

                    // Actualizam grila
                    formPontaje.refreshGrid();
                    new FormPontaje().refreshGrid();

                    MessageBox.Show("Adaugare cu success !");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        private void btnAdauga_Click(object sender, EventArgs e)
        {
            if(!Validate())
            {
                return;
            }

            Adauga();
        }
    }
}
