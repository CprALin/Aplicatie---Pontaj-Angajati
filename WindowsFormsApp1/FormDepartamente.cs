using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.DataSet1TableAdapters;

namespace WindowsFormsApp1
{
    public partial class FormDepartamente : Form
    {
        object _result;
        string idDepartament;

        public FormDepartamente()
        {
            InitializeComponent();
        }

        private void A1()
        {
            this.departamenteTableAdapter.Fill(this.dataSet1.Departamente);

            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.ReadOnly = true;

           // txtIdDepartament.ReadOnly = true;

            A3();
        }

        private void A2()
        {
            configureazaButoane(false);
            legareControale(false);
            protectiePanel(false);
           // legareDepartament(false);
           
            lblOp.Text = "ADAUGARE";

            txtDenumire.Focus();

            golireCampuri();
        }

        private void A3()
        {
            lblOp.Text = "";

            configureazaButoane(true);

            protectiePanel(true);

            legareControale(true);

           // legareDepartament(true);
        }

        public void A4()
        {
            if (lblOp.Text == "ADAUGARE")
            {
                if (!validareCampuri())
                {
                    return;
                }

                adaugaInregistrare();
                golireCampuri();

                //Pune cursor pe primul camp
                txtDenumire.Focus();
                refreshGrid(departamenteBindingSource.Position);
            }
            else if (lblOp.Text == "MODIFICARE")
            {
                modificaInregistrare();
                refreshGrid(departamenteBindingSource.Position);
                A3();
            }
            else
            {
                MessageBox.Show("Operatie actualizare neefectuata");
            }
        }

        private void A7()
        {
            try
            {
                using (OleDbConnection con = new OleDbConnection(departamenteTableAdapter.Connection.ConnectionString))
                using (OleDbCommand cmd = new OleDbCommand())
                {
                    con.Open();

                    // Obține idDepartament
                    cmd.Connection = con;
                    cmd.CommandText = $"SELECT idDepartament FROM Departamente WHERE DenumireDepartament = '{txtDenumire.Text}'";
                    _result = cmd.ExecuteScalar();

                    if (_result != null)
                    {
                        idDepartament = _result.ToString();

                        // Salvează ID-ul departamentului pentru utilizare ulterioară

                        //Configurare butoane
                        configureazaButoane(false);

                        //Dezlegare Controale Panel
                        legareControale(false);

                        //Ridicare protectie control Panel
                        protectiePanel(false);

                        //legareDepartament(false);

                        //Modificare lblOp
                        lblOp.Text = "MODIFICARE";

                        //Pozitionare cursor pe primul camp
                        txtDenumire.Focus();
                    }
                    else
                    {
                        MessageBox.Show("Nu s-a găsit nicio înregistrare cu denumirea specificată pentru departament.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        /*
        private void A7()
        {
         
            //Configurare butoane
            configureazaButoane(false);

            //Dezlegare Controale Panel
            legareControale(false);

            //Ridicare protectie control Panel
            protectiePanel(false);

            //legareDepartament(false);
            
            //Modificare lblOp
            lblOp.Text = "MODIFICARE";

            //Pozitionare cursor pe primul camp
            txtDenumire.Focus();
        }

        
        private void A8()
        {
            try
            {

                OleDbConnection con = new OleDbConnection();
                OleDbCommand cmd = new OleDbCommand();


                con.ConnectionString = departamenteTableAdapter.Connection.ConnectionString;
                cmd.Connection = con;

                con.Open();

                cmd.CommandText = $"SELECT idDepartament FROM Departamente WHERE DenumireDepartament = '{txtDenumire.Text}'";
                string idDepartament = cmd.ExecuteScalar().ToString();

               
                cmd.ExecuteNonQuery();
                con.Close();

                con.ConnectionString = departamenteTableAdapter.Connection.ConnectionString;

                cmd.Connection = con;

                cmd.CommandText = $"DELETE FROM Departamente WHERE idDepartament = {idDepartament}";

                //MessageBox.Show(cmd.CommandText);

                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();

                refreshGrid(departamenteBindingSource.Position);
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        */

        private void A8()
        {
            try
            {
                using (OleDbConnection con = new OleDbConnection(departamenteTableAdapter.Connection.ConnectionString))
                using (OleDbCommand cmd = new OleDbCommand())
                {
                    con.Open();

                    // Obține idDepartament
                    cmd.Connection = con;
                    cmd.CommandText = $"SELECT idDepartament FROM Departamente WHERE DenumireDepartament = '{txtDenumire.Text}'";
                    object result = cmd.ExecuteScalar();

                    if (result != null) // Verifică dacă s-a găsit un rezultat
                    {
                        // Șterge înregistrarea
                        cmd.CommandText = $"DELETE FROM Departamente WHERE idDepartament = {idDepartament}";
                        cmd.ExecuteNonQuery();

                        MessageBox.Show("Înregistrarea a fost ștearsă!");
                        refreshGrid(departamenteBindingSource.Position);
                    }
                    else
                    {
                        MessageBox.Show("Nu s-a găsit nicio înregistrare cu denumirea specificată.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }




        private void FormDepartamente_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet1.Departamente' table. You can move, or remove it, as needed.
            this.departamenteTableAdapter.Fill(this.dataSet1.Departamente);
            A1();
        }

        private void configureazaButoane(bool v)
        {
            btnConfirmare.Visible = !v;
            btnRenuntare.Visible = !v;

            btnAdaugare.Enabled = v;
            btnModificare.Enabled = v;
            btnStergere.Enabled = v;
        }

        /*
        private void legareDepartament(bool v)
        {
            if(v)
            {
                txtIdDepartament.DataBindings.Add("Text" , departamenteBindingSource , "idDepartament");
            }
            else
            {
                txtIdDepartament.DataBindings.Clear();
            }
        }
        */

        private void legareControale(bool v)
        {
            if(v)
            {
                txtDenumire.DataBindings.Add("Text", departamenteBindingSource, "DenumireDepartament");
                txtSefDepartament.DataBindings.Add("Text", departamenteBindingSource, "NumeAngajat");
            }
            else
            {
                txtDenumire.DataBindings.Clear();
                txtSefDepartament.DataBindings.Clear();
            }
        }

        private void protectiePanel(bool v)
        {
            txtDenumire.ReadOnly = v;
            txtSefDepartament.ReadOnly = v;
        }

        private void golireCampuri()
        {
            txtDenumire.Text = "";
            txtSefDepartament.Text = "";
        }

        private bool validareCampuri()
        {
            if(txtDenumire.Text == "")
            {
                MessageBox.Show("Completati Denumirea !");
                txtDenumire.Focus();
                return false;
            }

            if(txtSefDepartament.Text == "")
            {
                MessageBox.Show("Completati Nume Sef Departament !");
                txtSefDepartament.Focus();
                return false;
            }

            return true;
        }

        private void refreshGrid(int p)
        {
            this.departamenteTableAdapter.Fill(this.dataSet1.Departamente);
            departamenteBindingSource.Position = p;
        }

        /*
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

                con.Open();

                cmd.CommandText = $"SELECT idAngajat FROM Angajati WHERE NumeAngajat = '{txtSefDepartament}'";
                string idAngajat = cmd.ExecuteScalar().ToString();

               
                cmd.ExecuteNonQuery();
                con.Close();

                con.ConnectionString = departamenteTableAdapter.Connection.ConnectionString;
                cmd.Connection = con;

                listaCampuri = "DenumireDepartament , idSefDepartament";
                listaValori = $@"'{txtDenumire.Text}', '{idAngajat}'";

                cmd.CommandText = $"INSERT INTO Departamente({listaCampuri}) SELECT {listaValori}";

                //MessageBox.Show(cmd.CommandText);
                MessageBox.Show("Inregistrarea a fost adaugata !");

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
                string listaValori , idDepartament;

                OleDbConnection con = new OleDbConnection();
                OleDbCommand cmd = new OleDbCommand();

                con.ConnectionString = departamenteTableAdapter.Connection.ConnectionString;
                cmd.Connection = con;

                con.Open();

                cmd.CommandText = $"SELECT idDepartament FROM Departamente WHERE DenumireDepartament = '{txtDenumire.Text}'";
                idDepartament = cmd.ExecuteScalar().ToString();

                
                cmd.ExecuteNonQuery();
                con.Close();

                con.ConnectionString = departamenteTableAdapter.Connection.ConnectionString;
                cmd.Connection = con;

                listaValori = $@"DenumireDepartament = '{txtDenumire.Text}',
                                 NumeAngajat = '{txtSefDepartament.Text}'";

                cmd.CommandText = $"UPDATE Departamente SET {listaValori} WHERE idDepartament = {idDepartament}";

                //MessageBox.Show(cmd.CommandText);
                MessageBox.Show("Departamentul a fost modificat !");

                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }*/

        private void adaugaInregistrare()
        {
            try
            {
                using (OleDbConnection con = new OleDbConnection(departamenteTableAdapter.Connection.ConnectionString))
                using (OleDbCommand cmd = new OleDbCommand())
                {
                    con.Open();

                    // Obține idAngajat
                    cmd.Connection = con;
                    cmd.CommandText = $"SELECT idAngajat FROM Angajati WHERE NumeAngajat = '{txtSefDepartament.Text}'";
                    object result = cmd.ExecuteScalar();

                    if (result != null) // Verifică dacă s-a găsit un rezultat
                    {
                        string idAngajat = result.ToString();

                        // Adaugă înregistrarea
                        cmd.CommandText = $"INSERT INTO Departamente(DenumireDepartament, idSefDepartament) VALUES('{txtDenumire.Text}', {idAngajat})";
                        cmd.ExecuteNonQuery();

                        MessageBox.Show("Înregistrarea a fost adăugată!");
                        refreshGrid(departamenteBindingSource.Position);
                    }
                    else
                    {
                        MessageBox.Show("Nu s-a găsit nicio înregistrare cu numele specificat pentru șeful de departament.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        private void modificaInregistrare()
        {
            OleDbConnection con = null;

            try
            {
                con = new OleDbConnection(departamenteTableAdapter.Connection.ConnectionString);
                con.Open();


                // Modifică înregistrarea
                using (OleDbCommand cmd = new OleDbCommand())
                {
                    // Obține idAngajat
                    cmd.Connection = con;
                    cmd.CommandText = $"SELECT idAngajat FROM Angajati WHERE NumeAngajat = '{txtSefDepartament.Text}'";
                    object result = cmd.ExecuteScalar();


                    if(result != null)
                    {
                        string idAngajat = result.ToString();

                        cmd.Connection = con;
                        cmd.CommandText = $"UPDATE Departamente SET DenumireDepartament = '{txtDenumire.Text}', idSefDepartament = '{idAngajat}' WHERE idDepartament = {idDepartament}";
                        cmd.ExecuteNonQuery();

                        MessageBox.Show("Înregistrarea a fost modificată!");
                    }
                    else
                    {
                        MessageBox.Show("Introdu un nume Angajat valid !");
                    }

                    
                }

                refreshGrid(departamenteBindingSource.Position);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                if (con != null && con.State == ConnectionState.Open)
                {
                    con.Close(); // Asigurați-vă că conexiunea este închisă în orice caz
                }
            }
        }



        private void btnAdaugare_Click(object sender, EventArgs e)
        {
            A2();
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

        private void btnConfirmare_Click(object sender, EventArgs e)
        {
            A4();
        }

        private void btnRenuntare_Click(object sender, EventArgs e)
        {
            A3();
        }
    }
}
