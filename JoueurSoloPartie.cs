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
    public partial class JoueurSoloPartie : MetroFramework.Forms.MetroForm
    {
        Partie partie;
        Joueur premierJoueur;
        string lblAjout;
        string lblAjout2;
        List<int> scoreJoueurs = new List<int>();
        public JoueurSoloPartie(Partie p, int numJoueur)
        {
            InitializeComponent();
            partie = p;
            premierJoueur = partie.LesJoueurs[numJoueur];
            labelTourJoueur.Text = partie.LesJoueurs[0].ToString();
            
            lblAjout = "";
            for (int i = 0; i < partie.LesJoueurs.Count; i++)
            {
                lblClassement.Text = lblAjout + partie.LesJoueurs[i].ToString();
                lblAjout = lblAjout + partie.LesJoueurs[i].ToString() + "\n";
            }
            foreach (Joueur r in partie.LesJoueurs)
            {
                scoreJoueurs.Add(0);
            }
        }
        int i = 1;
        int j = 0;
        
        private void btnJoueurSuivant_Click(object sender, EventArgs e)
        {
            int nbChecke = 0;
            string nameCb = "";
            
            foreach (MetroFramework.Controls.MetroCheckBox checkBox in metroPanel1.Controls.OfType<MetroFramework.Controls.MetroCheckBox>())
            {
                if (checkBox.Checked)
                {
                    nbChecke++;
                    nameCb = checkBox.Name.ToString();
                }
            }
            
            char[] MyChar = { 'c', 'b' };
            
            if (nbChecke == 1)
            {
                string splitNameCb = nameCb.TrimStart(MyChar);
                int convertSplit = int.Parse(splitNameCb);

                scoreJoueurs[j] = scoreJoueurs[j] + convertSplit;
                j++;
            }
            else if (nbChecke > 1)
            {
                scoreJoueurs[j] = scoreJoueurs[j] + nbChecke;
                j++;
            }
            else
            {
                j++;
            }
            lblClassement.Text = "";
            if (scoreJoueurs[j - 1] == 50)
            {
                MessageBox.Show(partie.LesJoueurs[i - 1].ToString() + " a gagné.");
            }
            else if (scoreJoueurs[j - 1] > 50)
            {
                MessageBox.Show("toto");
                scoreJoueurs[j - 1] = 25;
            }
            for (int a = 0; a < partie.LesJoueurs.Count; a++)
            {
                lblAjout2 =  lblAjout2 + partie.LesJoueurs[a].ToString() + " " + scoreJoueurs[a].ToString() + "\n";
                lblClassement.Text = lblAjout2;
            }
            lblAjout2 = "";

            if (i < partie.LesJoueurs.Count)
            {
                labelTourJoueur.Text = partie.LesJoueurs[i].ToString();
                i++;
            }
            else {
                i = 0;
                j = 0;
                labelTourJoueur.Text = partie.LesJoueurs[i].ToString();
                i++;
            }
            

        }
        
    }
}
