using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;


namespace MyRoadToOne
{
    public partial class Vokabel_Hinzufügen : Form
    {
        public Vokabel_Hinzufügen()
        {
            InitializeComponent();
            try
            {
                DBmanager.SetupDatabase("127.0.0.1", "vok_sh", "root", "");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            MessageBox.Show("Vor der Eingabe, bitte Verbindung herstellen.");
            Hinzufügen.Enabled = false;
        }
        MySqlConnection conn = new MySqlConnection("Server=127.0.0.1; Database=vok_sh; user= root; pwd=; ");
        MySqlCommand cmd = new MySqlCommand();
        


        private void Beenden_Click(object sender, EventArgs e)
        {
            this.Close();
            DBmanager.CloseDatabase();
            
        }
        private void Hinzufügen_Click(object sender, EventArgs e)

        {
            if (textBoxLektion.Text == "")
            {
                try
                {
                    string myInsertQuery = "insert into vokabeln (Deutsch, Englisch, Französisch) " +
                    "values ('" + textBoxDeutsch.Text + "','" + textBoxEnglisch.Text + "','" + textBoxFranzösisch.Text + "');";
                    cmd.CommandText = myInsertQuery;
                    cmd.ExecuteNonQuery(); // insert query?
                    MessageBox.Show("Vokabel erfolgreich hinzugefügt.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                    throw;
                }

            }
            else
            {
                try
                {
                    string myInsertQuery = "insert into vokabeln (Deutsch, Englisch, Französisch, Lektion) " +
                    "values ('" + textBoxDeutsch.Text + "','" + textBoxEnglisch.Text + "','" + textBoxFranzösisch.Text + "'," +
                    textBoxLektion.Text.ToString() + ");";
                    cmd.CommandText = myInsertQuery;
                    cmd.ExecuteNonQuery(); // insert query?
                    MessageBox.Show("Vokabel erfolgreich hinzugefügt.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                    throw;
                }
            }
            textBoxDeutsch.Clear();
            textBoxEnglisch.Clear();
            textBoxFranzösisch.Clear();
        }

        private void buttonVerbinden_Click(object sender, EventArgs e)
        {
            cmd.Connection = conn;
            conn.Open();
            buttonVerbinden.Enabled = false;
            Hinzufügen.Enabled = true;
        }

        private void buttonTrennen_Click(object sender, EventArgs e)
        {
            conn.Close();
            buttonVerbinden.Enabled = true;
        }
    }
}
