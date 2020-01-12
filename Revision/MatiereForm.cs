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
    public partial class GestionMatieres : Form
    {
        public GestionMatieres()
        {
            InitializeComponent();
        }
        Matiere M = new Matiere();
        RevisionTpEntities DB = new RevisionTpEntities();
        private void Btn_Matiere_Ajouter_Click(object sender, EventArgs e)
        {
            string A = Txt_Matiere_Libelle.Text;
            if (DB.Matieres.ToList().Exists(c => c.libelle == A) == true)
            {
                MessageBox.Show("Cette Matiere existe deja !", "Erreur !", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                M.libelle = Txt_Matiere_Libelle.Text;
                DB.Matieres.Add(M);
                DB.SaveChanges();
                MessageBox.Show("Donnee Inserer !", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void Btn_Matiere_Modifier_Click(object sender, EventArgs e)
        {
            DialogResult D = MessageBox.Show("Voulez-vous modifier cette matiere ?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (D == DialogResult.Yes)
            {
                int ID = int.Parse(Txt_Matiere_IDaction.Text);
                Matiere Modif = new Matiere();
                Modif.libelle = Txt_Matiere_Libelleaction.Text;
                Matiere A = DB.Matieres.Where(x => x.id == ID).First();
                A.libelle = Modif.libelle;
                DB.SaveChanges();
                MessageBox.Show("Donnee Modifier !", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void Btn_Matiere_Supprimer_Click(object sender, EventArgs e)
        {
            DialogResult D = MessageBox.Show("Voulez-vous supprimer cette matiere ?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (D == DialogResult.Yes)
            {
                int ID = int.Parse(Txt_Matiere_IDaction.Text);
                Matiere A = DB.Matieres.Where(x => x.id == ID).First();
                DB.Matieres.Remove(A);
                DB.SaveChanges();
            }
        }
    }
}
