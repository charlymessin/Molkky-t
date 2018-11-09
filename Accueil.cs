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
    public partial class Accueil : MetroFramework.Forms.MetroForm
    {
        
        public Accueil()
        {
            InitializeComponent();
        }

        
        //Boutton joueurs
        private void metroButton2_Click(object sender, EventArgs e)
        {
            Joueurs joueur = new Joueurs();

            joueur.ShowDialog();
        }

        //Boutton actus
        private void metroButton3_Click(object sender, EventArgs e)
        {
            Actualites actus = new Actualites();
            
            actus.ShowDialog();
        }

        //Boutton regles
        private void metroButton4_Click(object sender, EventArgs e)
        {
            Regle regle = new Regle();
            
            regle.ShowDialog();
        }

        //Boutton jouer
        private void metroButton1_Click(object sender, EventArgs e)
        {
            ChoixMode choixmode = new ChoixMode();

            choixmode.ShowDialog();
        }
    }
}
