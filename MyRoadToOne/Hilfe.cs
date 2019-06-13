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
    public partial class Hilfe : Form
    {
        public Hilfe()
        {
            InitializeComponent();
            // Label Für Hilfe Text
            Hilfetxt.Text = " Wilkommen bei unserem Vokabeltrainer\n\n" +
                            " Sie können Vokabel vertiefen im Trainer,\n" +
                            " oder neue Vokabeln in die Abfrage einbringen im Vokabelhinzufügen-Form \n" +
                            " Test wird implementiert .\n" +
                            " \n" +
                            " \n" +
                            " "; 
        }

        private void Schliessenhilfe_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
