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
    public partial class CreationJ : MetroFramework.Forms.MetroForm
    {
        List<Joueur> lesJoueurs;
        public CreationJ()
        {
            InitializeComponent();
            using (StreamReader file = File.OpenText(@"\\Mac\Home\Documents\Molkky-t-test\Resources\lesJoueurs.json"))
            {
                JsonSerializer newS = new JsonSerializer();
                lesJoueurs = (List<Joueur>)newS.Deserialize(file, typeof(List<Joueur>));
            }


        }

        private void btnCreateJ_Click(object sender, EventArgs e)
        {
            string txtPseudoCreate = txtPseudo.Text;

            Joueur j = new Joueur(txtPseudo.Text);
            lesJoueurs.Add(j);

            string testJson = JsonConvert.SerializeObject(lesJoueurs, Formatting.Indented);
            File.WriteAllText(@"\\Mac\Home\Documents\Molkky-t-test\Resources\lesJoueurs.json", testJson);

            this.Close();
            Joueurs joueur = new Joueurs();
            joueur.ShowDialog();


        }
    }
}
