using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gsbRapports2
{
    public partial class listeRapports : Form
    {
        private gsbrapportsEntities1 gv1;
        public listeRapports(gsbrapportsEntities1 gv1)
        {
            InitializeComponent();
            this.rapportGv.AutoGenerateColumns = false;
            this.gv1 = gv1;
            this.bdgVisiteur.DataSource= gv1.visiteur.ToList();
            this.comboBox1.DataSource= gv1.visiteur.ToList();
            this.comboBox1.DisplayMember = "id";
            this.comboBox1.ValueMember="id";
            var idVisiteur = comboBox1.SelectedItem;
            var lesRapports = this.gv1.rapport.Where(ra => ra.idVisiteur == idVisiteur);
            
        }

        private void listeRapports_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var idRapport = comboBox1.SelectedValue;
            DataGridTextBoxColumn txtMotif= new DataGridTextBoxColumn();
            txtMotif.HeaderText = "Date";
           
            
        }
    }
}
