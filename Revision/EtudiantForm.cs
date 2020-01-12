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
    public partial class EtudiantForm : Form
    {
        public EtudiantForm()
        {
            InitializeComponent();
        }
        Etudiant E = new Etudiant();
        RevisionTpEntities DB = new RevisionTpEntities();
        public void Clear()
        {
            Txt_Etudiant_Email.Text = "";
            Txt_Etudiant_Login.Text = "";
            Txt_Etudiant_Nom.Text = "";
            Txt_Etudiant_Prenom.Text = "";
            Txt_Etudiant_Tel.Text = "";
            Txt_Etudiant_IDaction.Text = "";
        }
        public string Count_ID()
        {
            int A = DB.Etudiants.Max(p => p.id)+1;
            return A.ToString();
        }
        private void Btn_Etudiant_Ajouter_Click(object sender, EventArgs e)
        {
            E.nom = Txt_Etudiant_Nom.Text;
            E.prenom = Txt_Etudiant_Prenom.Text;
            E.email = Txt_Etudiant_Email.Text;
            E.login = Txt_Etudiant_Login.Text;
            E.tel = Txt_Etudiant_Tel.Text;
            E.password = Count_ID()+ DateTime.Today.Day ;
            DB.Etudiants.Add(E);
            DB.SaveChanges();
            MessageBox.Show("Donnee Inserer ! Ton MDP :"+E.password, "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Clear();
        }


        private void Btn_Etudiant_Modifier_Click(object sender, EventArgs e)
        {
            DialogResult D = MessageBox.Show("Voulez-vous modifier cette etudiant ?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (D == DialogResult.Yes)
            {
                int ID = int.Parse(Txt_Etudiant_IDaction.Text);
                Etudiant Etu = DB.Etudiants.Where(x => x.id == ID).First();
                Etu.nom = Txt_Etudiant_Nom.Text;
                Etu.prenom = Txt_Etudiant_Prenom.Text;
                Etu.email = Txt_Etudiant_Email.Text;
                Etu.login = Txt_Etudiant_Login.Text;
                Etu.tel = Txt_Etudiant_Tel.Text;
                DB.SaveChanges();
                MessageBox.Show("Donnee Etudiant Modifier ! (Mot de passe reste le meme : '"+Etu.password+"')", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }
        private void Btn_Etudiant_Supprimer_Click(object sender, EventArgs e)
        {
            DialogResult D = MessageBox.Show("Voulez-vous supprimer cette etudiant ?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (D == DialogResult.Yes)
            {
                int ID = int.Parse(Txt_Etudiant_IDaction.Text);
                Etudiant Etu = DB.Etudiants.Where(x => x.id == ID).First();
                DB.Etudiants.Remove(Etu);
                DB.SaveChanges();
                Clear();
            }
        }
        private void Btn_Etudiant_Lister_Click(object sender, EventArgs e)
        {
            int ID = int.Parse(Txt_Etudiant_IDaction.Text);
            Etudiant Etu = DB.Etudiants.Where(x => x.id == ID).First();
            Txt_Etudiant_Nom.Text=Etu.nom ;
            Txt_Etudiant_Prenom.Text=Etu.prenom  ;
            Txt_Etudiant_Email.Text=Etu.email  ;
            Txt_Etudiant_Login.Text=Etu.login ;
            Txt_Etudiant_Tel.Text=Etu.tel;
        }
    }
}
