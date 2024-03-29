using gsbRapports;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace gsbRapports2
{
    public partial class Form1 : Form
    {
        private gsbrapportsEntities1 mesDonneesVisiteur;
        public Form1()
        {
            this.InitializeComponent();
            this.mesDonneesVisiteur = new gsbrapportsEntities1();
        }

        private void fichierToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void gérerToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            gererVisiteurs gV1 = new gererVisiteurs(mesDonneesVisiteur);
            //gV1.MdiParent = this;
            gV1.Show();
        }

        private void rapportToolStripMenuItem1_Click(object sender, EventArgs e)
        {

            listeRapports lv1 = new listeRapports(mesDonneesVisiteur);
            lv1.Show();
        }

        private void rechercherBisToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ListeRapportbis lv1=new ListeRapportbis(mesDonneesVisiteur);
            lv1.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
