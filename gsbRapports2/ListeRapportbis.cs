using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;

namespace gsbRapports2
{
    public partial class ListeRapportbis : Form
    {
        gsbrapportsEntities1 gsb;
        List<rapport> lstRapports;
        public ListeRapportbis(gsbrapportsEntities1 gsb)
        {
            InitializeComponent();
            this.gsb = gsb;
            this.dataGridView1.AutoGenerateColumns = false;
            this.comboBox1.DataSource= gsb.visiteur.ToList();
            this.comboBox1.DisplayMember = "id";
            this.comboBox1.ValueMember = "id";

            
            
        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            var idVisiteurr = comboBox1.SelectedValue;
            
            dataGridView1.DataSource = gsb.rapport.Where(ra => ra.idVisiteur == idVisiteurr).ToList();
            DataGridViewTextBoxColumn motif = new DataGridViewTextBoxColumn();
            motif.HeaderText = "Motif";
            motif.Name = "motif";
            motif.DataPropertyName = "motif";
            this.dataGridView1.Columns.Add(motif);      
      
            DataGridViewTextBoxColumn bilan=new DataGridViewTextBoxColumn();
            bilan.HeaderText = "Bilan";
            bilan.Name = "bilan";
            bilan.DataPropertyName = "bilan";
            this.dataGridView1 .Columns.Add(bilan);

            DataGridViewTextBoxColumn idMedecin=new DataGridViewTextBoxColumn();
            idMedecin.HeaderText = "Id du médecin";
            idMedecin.Name = "idMedecin";
            idMedecin.DataPropertyName = "idMedecin";
            this.dataGridView1.Columns.Add(idMedecin);

            DataGridViewTextBoxColumn idVisitant=new DataGridViewTextBoxColumn();
            idVisitant.HeaderText = "Id du visiteur";
            idVisitant.Name = "idVisiteur";
            idVisitant.DataPropertyName = "idVisiteur";
            this.dataGridView1.Columns.Add (idVisitant);

            DataGridViewTextBoxColumn dateeee = new DataGridViewTextBoxColumn();
            dateeee.HeaderText = "Date de consultation";
            dateeee.Name = "date";
            dateeee.DataPropertyName = "date";
            this.dataGridView1.Columns.Add(dateeee);
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            var idVisiteurr = comboBox1.SelectedValue;
            var lesRapports=gsb.rapport.Where(ra=>ra.idVisiteur==idVisiteurr);
            
            XElement xmlRapport = new XElement("Rapports");
            foreach(var unRapport in lesRapports)
            {
                string date =unRapport.date.ToString().Split(' ')[0];
                xmlRapport.Add(
                    new XElement("Rapport",
                    new XElement("date", date),
                    new XElement("motif", unRapport.motif),
                    new XElement("bilan", unRapport.bilan),
                    new XElement("idVisiteur", unRapport.idVisiteur),
                    new XElement("médecin", unRapport.idMedecin)));
            }
            xmlRapport.Save("C://mission_3xml/rapports.xml");
            
        }

        

    }
}
