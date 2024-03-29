using gsbRapports2;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gsbRapports
{
    public partial class gererVisiteurs : Form
    {
        private gsbrapportsEntities1 gV1;
        public gererVisiteurs(gsbrapportsEntities1 gV1)
        {
            InitializeComponent();
            this.gV1 = gV1;
            this.bindingSource1.DataSource = gV1.visiteur.ToList();
        }

        private void gererVisiteurs_Load(object sender, EventArgs e)
        {

        }
        private visiteur newVisiteur()
        {
            visiteur v = new visiteur();
            v.id = textBox8.Text;
            v.nom = textBox1.Text;
            v.prenom = textBox2.Text;
            v.login= textBox3.Text;
            v.mdp= textBox4.Text;
            v.adresse= textBox5.Text;
            v.cp = textBox6.Text ;
            v.ville = textBox7.Text ;
            v.dateEmbauche = dateTimePicker1.Value;
            return v ;
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            this.bindingSource1.EndEdit();
            try
            {
                this.gV1.visiteur.Add(newVisiteur());
                this.gV1.SaveChanges();
                MessageBox.Show("Enregistrement Validé");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erreur lors de l'enregistrement : {ex.Message}");
            }
        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            using (var context=new gsbrapportsEntities1())
            {
                var idASupprimer = textBox8.Text;
                var entiteASupprimer = context.visiteur.FirstOrDefault(vi => vi.id == idASupprimer);
                var rapportsASupprimer = this.gV1.rapport.Where(ra => ra.idVisiteur == idASupprimer);
                int compteur=rapportsASupprimer.Count();
                if(compteur > 0 )
                {
                    DialogResult result = MessageBox.Show($"Il y a {compteur} rapports liés à ce visiteur voulez vous les supprimer ? ","Confirmation",MessageBoxButtons.YesNo);
                    if ( result == DialogResult.Yes )
                    {
                        this.gV1.rapport.RemoveRange(rapportsASupprimer);
                        this.gV1.SaveChanges();
                        MessageBox.Show("Les rapports ont été supprimer avec succès");
                    }

                    else if(result == DialogResult.No )
                    {
                        MessageBox.Show("Suppression annulée");
                    }
                    
                }
                else if (entiteASupprimer != null)
                {

                    context.visiteur.Remove(entiteASupprimer);
                    context.SaveChanges();
                    bindingSource1.RemoveCurrent();
                    MessageBox.Show("Enregistrement supprimé");
                }
            }
        }
    }
}
