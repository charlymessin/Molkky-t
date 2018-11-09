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
    public partial class Joueurs : MetroFramework.Forms.MetroForm
    {
        List<Joueur> lesJoueurs;
        public Joueurs()
        {
            InitializeComponent();
            using (StreamReader file = File.OpenText(@"\\Mac\Home\Documents\Molkky-t-test\Resources\lesJoueurs.json"))
            {
                JsonSerializer newS = new JsonSerializer();
                lesJoueurs = (List<Joueur>)newS.Deserialize(file, typeof(List<Joueur>));
            }

            listeJoueur.DataSource = lesJoueurs;

        }

        private void listeJoueur_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
        private void Creat_j_Click(object sender, EventArgs e)
        {
            CreationJ cj = new CreationJ();
            this.Close();
            cj.ShowDialog();
        }

        private void btn_supprJ_Click(object sender, EventArgs e)
        {
            //listeJoueur.Select;
        }
    }
}
