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
    public partial class Vokabelabfrage : Form
    {
        private int ID;
        private int range;
        private int punkte = 0;
        private int fehlerzähler = 0;
      //  private int fehler = 1;
        private string richtigesWort;
        //string[] fehlerliste = new string[20];
        List<string> fehlerliste = new List<string>();
        Random rnd = new Random();
        public Vokabelabfrage()
        {

            try
            {
                DBmanager.SetupDatabase("127.0.0.1", "vok_sh", "root", "");
            } catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            InitializeComponent();
            labelGegSprache.Text = JLA.setlabelGeg;
            labelGesSprache.Text = JLA.setlabelGes;
            buttonCheck.Enabled = false;
        }


        private void buttonFrenchGer_Click(object sender, EventArgs e)
        {
            labelGegSprache.Text = "Französisch";
            labelGesSprache.Text = "Deutsch";
            buttonNeuWort.Enabled = true;
            buttonCheck.Enabled = true;

        }

        private void buttonEngFrench_Click(object sender, EventArgs e)
        {
            labelGesSprache.Text = "Französisch";
            labelGegSprache.Text = "Englisch";
            buttonNeuWort.Enabled = true;
            buttonCheck.Enabled = true;
        }

        private void buttonFrenchEng_Click(object sender, EventArgs e)
        {
            labelGesSprache.Text = "Englisch";
            labelGegSprache.Text = "Französisch";
            buttonNeuWort.Enabled = true;
            buttonCheck.Enabled = true;
        }


        private void buttonNeuWort_Click(object sender, EventArgs e)
        {
            String q = "select max(ID) from vokabeln;";
            MySqlDataReader reader = DBmanager.ExecuteQuery(q);
            while (reader.Read())
            {
                range = Convert.ToInt32(reader["max(ID)"]);
            }
            reader.Close();
            int VokPool = rnd.Next(1, range);
            q = "SELECT " + labelGegSprache.Text + " FROM vokabeln WHERE ID = " + VokPool + ";";
            reader = DBmanager.ExecuteQuery(q);
            while (reader.Read())
            {
                textBoxGegSprache.Text = reader[labelGegSprache.Text].ToString();
            }
            reader.Close();
            buttonCheck.Enabled = true;
        }

        public void buttonGerFrench_Click(object sender, EventArgs e)
        {
            labelGesSprache.Text = "Französisch";
            labelGegSprache.Text = "Deutsch";
            buttonNeuWort.Enabled = true;
            buttonCheck.Enabled = true;
        }
        // Modus Fran Deut
        // Geg word id holen
        // mit id und ges sprache vok auslesen
        // abgleichen mit textfeldAntwort
        private void buttonCheck_Click(object sender, EventArgs e)
        {
           // int test = 0;
            string q = "Select ID from vokabeln where "+ labelGegSprache.Text + " = " + "'" + textBoxGegSprache.Text+ "';";
            MySqlDataReader reader = DBmanager.ExecuteQuery(q);
            while (reader.Read())
            {
                ID = Convert.ToInt32(reader["ID"]);
            }
            reader.Close();
            
            q = "Select " + labelGesSprache.Text + "  from vokabeln where ID = " + ID + ";";
            reader = DBmanager.ExecuteQuery(q);
            while (reader.Read())
            {
                if(textBoxAntwort.Text == reader[labelGesSprache.Text].ToString())
                {
                    //MessageBox.Show("Richtig");
                    punkte++;
                    labelPunkte.Text = punkte.ToString();
                }
                else
                {
                    richtigesWort = reader[labelGesSprache.Text].ToString();
                    MessageBox.Show("So wäre es richtig: " + richtigesWort);
                    // Wiederholung von falschen  bzw entfernen von richtigen
                    // +Auf Zeit wenns geht 15 min 
                    // Richtige aus endlos modus rausnhemen
                    punkte--;
                    labelPunkte.Text = punkte.ToString();
                    fehlerliste.Add(richtigesWort);
                    fehlerzähler++;
                    //Console.WriteLine(fehlerzähler);
                }
            }
            reader.Close();
            buttonCheck.Enabled = false;
        }

        private void buttonBeenden_Click(object sender, EventArgs e)
        {
            this.Close();
            DBmanager.CloseDatabase();
            
        }

        private void labelGesSprache_Click(object sender, EventArgs e)
        {

        }

        private void buttonFehlerliste_Click(object sender, EventArgs e)
        {
            foreach (string fehler in fehlerliste)
            {
                if (fehler != "")
                {
                    Console.WriteLine(fehler);

                } 
            }
        }
    }
}
