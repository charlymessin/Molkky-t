using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using System.IO;

namespace Molkky_t
{
    public partial class ChoixJoueurSolo : MetroFramework.Forms.MetroForm
    {
        List<Joueur> lesJoueurs;
        List<Joueur> lesJoueursAjouter;

        public ChoixJoueurSolo()
        {
            InitializeComponent();

            using (StreamReader file = File.OpenText(@"\\Mac\Home\Documents\Molkky-t-test\Resources\lesJoueurs.json"))
            {
                JsonSerializer newS = new JsonSerializer();
                lesJoueurs = (List<Joueur>)newS.Deserialize(file, typeof(List<Joueur>));
            }
            listJoueurSolo.DataSource = lesJoueurs;
            lesJoueursAjouter = new List<Joueur>();
        }

        private void btnAjouterJSolo_Click(object sender, EventArgs e)
        {
            Joueur joueur = (Joueur)listJoueurSolo.SelectedItem;
            lesJoueursAjouter.Add(joueur);
            listAjoutJoueur.DataSource = null;
            listAjoutJoueur.DataSource = lesJoueursAjouter;
            lesJoueurs.Remove(joueur);
            listJoueurSolo.DataSource = null;
            listJoueurSolo.DataSource = lesJoueurs;


        }

        private void btnRetirJsolo_Click(object sender, EventArgs e)
        {
            Joueur joueurR = (Joueur)listAjoutJoueur.SelectedItem;
            listAjoutJoueur.Items.Remove(joueurR);
            lesJoueurs.Add(joueurR);
            listJoueurSolo.DataSource = null;
            listJoueurSolo.DataSource = lesJoueurs;
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            Partie p = new Partie();
            p.LesJoueurs =(List<Joueur>) listAjoutJoueur.DataSource;
            //MessageBox.Show(p.LesJoueurs.Count.ToString());
        }
    }
}
