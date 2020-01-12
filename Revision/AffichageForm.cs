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
    public partial class AffichageForm : Form
    {
        public AffichageForm()
        {
            InitializeComponent();
        }
        Etudiant E = new Etudiant();
        RevisionTpEntities DB = new RevisionTpEntities();

        private void CB_Etudiants_SelectedIndexChanged(object sender, EventArgs e)
        {
            int X = int.Parse(CB_Etudiants.SelectedItem.ToString());
            Etudiant Etu = DB.Etudiants.Where(x => x.id == X).First();
            string A = Etu.nom.ToUpper();
            string B = Etu.prenom;
            Lab_Resultat.Text = B+" - "+A;
            DGV.DataSource = DB.Inscriptions.Where(x=>x.id ==X).Select(p => new { ID = p.id, ID_Mat = p.id_matiere, Montant = p.montant }).ToList();
            for(int i = 0; i < DGV.Rows.Count; i++) { 
            if (DB.Paiements.ToList().Exists(c => c.Inscription.Etudiant.id == X) == true)
            {
                DGV.Rows[i].Cells[2].Style.BackColor = Color.Green;
            }
            else DGV.Rows[i].Cells[2].Style.BackColor = Color.Red;
            }
        }
        private void AffichageForm_Load(object sender, EventArgs e)
        {
            foreach (Etudiant E in DB.Etudiants)
            {
                CB_Etudiants.Items.Add(E.id);
            }
        }
    }
}
