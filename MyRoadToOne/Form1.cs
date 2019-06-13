using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace MyRoadToOne
{
    public partial class JLA : Form
    {
        public JLA()
        {
            InitializeComponent();
            labelDatum.BackColor = Color.FromArgb(247, 248, 243);
            labelDatum.Text = DateTime.Now.ToString("dd/MM/yyyy");  // Buttons die direkt zur Abfrage führen auf den Flaggen
            
        }
        public static string setlabelGes = "";
        public static string setlabelGeg = "";
        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

        private void hi8lfToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void beendenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
            this.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void wasMussIchMachenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Hilfe H1 = new Hilfe();
            H1.Show();
        }

        private void vokabeltrainerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Vokabelabfrage VokTrainer = new Vokabelabfrage();
            VokTrainer.Show();
        }

        private void vokabelnHinzufügenToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Vokabel_Hinzufügen VokAdd = new Vokabel_Hinzufügen();
            VokAdd.Show();
        }
        public void button1_Click(object sender, EventArgs e)
        {
            setlabelGes = "Deutsch";
            setlabelGeg = "Französisch";
            Vokabelabfrage VokAbfr = new Vokabelabfrage();
            VokAbfr.Show();
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            setlabelGes = "Französisch";
            setlabelGeg = "Deutsch";
            Vokabelabfrage VokAbfr = new Vokabelabfrage();
            VokAbfr.Show();
        }
        
        private void button3_Click(object sender, EventArgs e)
        {
            setlabelGes = "Englisch";
            setlabelGeg = "Französisch";
            Vokabelabfrage VokAbfr = new Vokabelabfrage();
            VokAbfr.Show();
        }

        private void buttonSchließen_Click(object sender, EventArgs e)
        {
            Application.Exit();
            
        }
    }
}
