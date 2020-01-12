using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Revision
{
    public partial class InscriptionForm : Form
    {
        public InscriptionForm()
        {
            InitializeComponent();
        }
        RevisionTpEntities DB = new RevisionTpEntities();
        Inscription I = new Inscription();
        public void Clear()
        {
            Txt_Date_Debut.Text = "";
            Txt_Duree.Text = "";
            Txt_Montant.Text = "";
            Txt_Publication.Text = "";
            CB_Etudiants.Text="";
            CB_Matieres.Text = "";
        }
        public string Count_ID()
        {
            int A = DB.Inscriptions.Max(p => p.id) + 1;
            return A.ToString();
        }
        private void Btn_Inscription_Ajouter_Click(object sender, EventArgs e)
        {
            int A = int.Parse(CB_Etudiants.SelectedItem.ToString());
            if (DB.Paiements.ToList().Exists(c => c.Inscription.Etudiant.id == A) == true) { 
            try { 
                I.date_debut = DateTime.Parse(Txt_Date_Debut.Text);
                I.duree = int.Parse(Txt_Duree.Text);
                I.date_publication = DateTime.Parse(Txt_Publication.Text);
                I.montant = float.Parse(Txt_Montant.Text);
                I.id_etudiant=int.Parse(CB_Etudiants.SelectedItem.ToString());
                I.id_matiere= int.Parse(CB_Matieres.SelectedItem.ToString());
                DB.Inscriptions.Add(I);
                DB.SaveChanges();
                Clear();
            }
            catch
            {
                MessageBox.Show("Respecter la format des Dates dd/mm/yyyy", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            }
            else MessageBox.Show("Veuillez Regulariser les anciens paiments", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void InscriptionForm_Load(object sender, EventArgs e)
        {
            foreach (Etudiant E in DB.Etudiants)
            {
                CB_Etudiants.Items.Add(E.id);
            }
            foreach (Matiere M in DB.Matieres)
            {
                CB_Matieres.Items.Add(M.id);
            }
        }
    }
}
