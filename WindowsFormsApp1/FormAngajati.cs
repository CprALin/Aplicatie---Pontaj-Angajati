using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.DataSet1TableAdapters;

namespace WindowsFormsApp1
{
    public partial class FormAngajati : Form
    {

        public FormAngajati()
        {
            InitializeComponent();
        }

        private void A1()
        {

            //Umple cu date obiectele DataTable: Persoane, Localitati (din DataSet):
            this.angajatiTableAdapter.Fill(this.dataSet11.Angajati);

            //Configurare PB
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;

            //Protectie grid 
            protectieGrid();

            txtAngajat.ReadOnly = true;

            A3();
        }

        private void A2()
        {

            //Configurare Butoane
            configureazaButoane(false);

            //Dezlegare controale panel
            legareControale(false);

            //Ridicare protectie panel
            protectiePanel(false);

            legareIdAngajat(false);

            setPictureNull();

            setariImagine(false);

            //Modificare lbl
            lblOp.Text = "ADAUGARE";

            //Pozitionare cursor pe primul camp
            txtNume.Focus();

            //Golire campuri
            golireCampuri();
        }

        private void A3()
        {
            //initializare lblOp
            lblOp.Text = "";

            //Configurare (butoane)
            configureazaButoane(true);

            //Protectie controale Panel
            protectiePanel(true);

            //Legare Controale
            legareControale(true);

            legareIdAngajat(true);

            setariImagine(true);

        }

        public void A4()
        {
            if(lblOp.Text == "ADAUGARE")
            {
                if(!validareCampuriObligatorii())
                {
                    return;
                }

                adaugaInregistrare();
                golireCampuri();

                //Pune cursor pe primul camp
                txtNume.Focus();
                refreshGrid(angajatiBindingSource.Position);        
            }else if(lblOp.Text == "MODIFICARE")
            {
                modificaInregistrare();
                refreshGrid(angajatiBindingSource.Position);
                A3();  
            }else
            {
                MessageBox.Show("Operatie actualizare neefectuata");
            }                   
        }

        private void A6()
        {
            if(lblOp.Text == "")
            {
                return;
            }

            if(openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                txtImagine.Text = openFileDialog1.FileName;
                pictureBox1.ImageLocation = txtImagine.Text;
            }
        }

        private void A7()
        {
            //Configurare butoane
            configureazaButoane(false);

            //Dezlegare Controale Panel
            legareControale(false);

            //Ridicare protectie control Panel
            protectiePanel(false);

            legareIdAngajat(false);

            setariImagine(false);

            //Modificare lblOp
            lblOp.Text = "MODIFICARE";

            //Pozitionare cursor pe primul camp
            txtNume.Focus();
        }

        private void A8()
        {
            try
            {

                OleDbConnection con = new OleDbConnection();
                OleDbCommand cmd = new OleDbCommand();
                OleDbDataReader r;

                con.ConnectionString = angajatiTableAdapter.Connection.ConnectionString;

                cmd.Connection = con;

                cmd.CommandText = $"SELECT idAngajat FROM Pontaj WHERE idAngajat = {txtAngajat.Text}";

                con.Open();

                r = cmd.ExecuteReader();

                if (r.Read())
                {
                    MessageBox.Show("Angajat referit in tabela Pontaj ! Nu se poate sterge!");
                    con.Close();
                    return;
                }

                con.Close();

                cmd.CommandText = $"DELETE FROM Angajati WHERE idAngajat = {txtAngajat.Text}";

                MessageBox.Show(cmd.CommandText);

                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();

                refreshGrid(angajatiBindingSource.Position);
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void FormAngajati_Load(object sender, EventArgs e)
        {
            A1();
        }

        private void configureazaButoane(bool v)
        {
            btnRenuntare.Visible = !v;
            btnConfirmare.Visible = !v;

            btnAdaugare.Enabled = v;
            btnModificare.Enabled = v;
            btnStergere.Enabled = v;
        }

        private void legareIdAngajat(bool v)
        {
            if(v)
            {
                txtAngajat.DataBindings.Add("Text", angajatiBindingSource, "idAngajat");
            }
            else
            {
                txtAngajat.DataBindings.Clear();
            }
        }

        private void setariImagine(bool v)
        {
            if(v)
            {
                pictureBox1.DataBindings.Add("ImageLocation", angajatiBindingSource, "SpImagine");
            }
            else
            {
                pictureBox1.DataBindings.Clear();
            }
        }

        public void setPictureNull()
        {
            pictureBox1.Image = null;
        }

        private void legareControale(bool v)
        {
            if (v)
            {
                txtNume.DataBindings.Add("Text", angajatiBindingSource, "NumeAngajat");
                txtCNP.DataBindings.Add("Text", angajatiBindingSource, "CNP");
                txtPost.DataBindings.Add("Text", angajatiBindingSource, "Post");
                txtTarif.DataBindings.Add("Text", angajatiBindingSource, "TarifOra");
                txtImagine.DataBindings.Add("Text", angajatiBindingSource, "SpImagine");
                txtDepartament.DataBindings.Add("Text", angajatiBindingSource, "idDepartament");
            }
            else
            {
                txtNume.DataBindings.Clear();
                txtCNP.DataBindings.Clear();
                txtPost.DataBindings.Clear();
                txtTarif.DataBindings.Clear();
                txtImagine.DataBindings.Clear();
                txtDepartament.DataBindings.Clear();
            }
        }

        private void protectiePanel(bool v)
        {
            txtNume.ReadOnly = v;
            txtCNP.ReadOnly = v;
            txtPost.ReadOnly = v;
            txtTarif.ReadOnly = v;
            txtImagine.ReadOnly = v;
            txtDepartament.ReadOnly = v;
        }

        private void golireCampuri()
        {
            txtAngajat.Text = "";
            txtNume.Text = "";
            txtCNP.Text = "";
            txtPost.Text = "";
            txtTarif.Text = "";
            txtImagine.Text = "";
            txtDepartament.Text = "";
        }

        private bool validareCampuriObligatorii()
        {
            //Validare de completare obligatorie campurile: Nume, CNP, Salariu, Localitate
            if(txtNume.Text == "")
            {
                MessageBox.Show("Completati Numele !");
                txtNume.Focus();
                return false;
            }

            if(txtCNP.Text == "")
            {
                MessageBox.Show("Completati CNP !");
                txtCNP.Focus();
                return false;
            }

            if(txtPost.Text == "")
            {
                MessageBox.Show("Completati Post !");
                txtPost.Focus();
                return false;
            }

            if(txtTarif.Text == "")
            {
                MessageBox.Show("Completati Tarif !");
                txtTarif.Focus();
                return false;
            }

            if(txtDepartament.Text == "")
            {
                MessageBox.Show("Completati Departament !");
                txtDepartament.Focus();
                return false;
            }

            return true;
        }

        public void protectieGrid()
        {
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.ReadOnly = true;
        }

        private void adaugaInregistrare()
        {
            try
            {
                string listaCampuri;
                string listaValori;

                OleDbConnection con = new OleDbConnection();
                OleDbCommand cmd = new OleDbCommand();

                con.ConnectionString = angajatiTableAdapter.Connection.ConnectionString;
                cmd.Connection = con;

                listaCampuri = "NumeAngajat , CNP , Post , TarifOra , SpImagine , idDepartament";
                listaValori = $@"'{txtNume.Text}', '{txtCNP.Text}', '{txtPost.Text}', '{txtTarif.Text}', '{txtImagine.Text}', '{txtDepartament.Text}'";

                cmd.CommandText = $"INSERT INTO Angajati({listaCampuri}) SELECT {listaValori}";

                //MessageBox.Show(cmd.CommandText);

                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        private void modificaInregistrare()
        {
            try
            {
                string listaValori;

                OleDbConnection con = new OleDbConnection();
                OleDbCommand cmd = new OleDbCommand();

                con.ConnectionString = angajatiTableAdapter.Connection.ConnectionString;
                cmd.Connection = con;

                listaValori = $@"NumeAngajat = '{txtNume.Text}', 
                                 CNP = '{txtCNP.Text}', Post = '{txtPost.Text}', 
                                 TarifOra = '{txtTarif.Text}', 
                                 SpImagine = '{txtImagine.Text}', 
                                 idDepartament = '{txtDepartament.Text}'";

                cmd.CommandText = $"UPDATE Angajati SET {listaValori} WHERE idAngajat = {txtAngajat.Text}";

                //MessageBox.Show(cmd.CommandText);

                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }    
        }

        private void refreshGrid(int p)
        {
            this.angajatiTableAdapter.Fill(this.dataSet11.Angajati);
            angajatiBindingSource.Position = p;
        }

        private void btnAdaugare_Click(object sender, EventArgs e)
        {
            A2();
        }

        private void btnRenuntare_Click(object sender, EventArgs e)
        {
            A3();
        }

        private void btnConfirmare_Click(object sender, EventArgs e)
        {
            A4();
        }

        private void btnModificare_Click(object sender, EventArgs e)
        {
            A7();
        }

        private void btnStergere_Click(object sender, EventArgs e)
        {
            const string mesaj = "Confirmati stergerea";
            const string titlu = "Stergere inregistrare";
            var rezultat = MessageBox.Show(mesaj, titlu, MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (rezultat == DialogResult.No) return;
            A8();
        }

        private void SpImagine(object sender, MouseEventArgs e)
        {
            A6();
        }
    }
}
