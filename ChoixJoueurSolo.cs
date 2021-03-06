﻿using System;
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

            using (StreamReader file = File.OpenText(@"C:\Users\hugob\source\repos\molkky-t\Resources\lesJoueurs.json"))
            {
                JsonSerializer newS = new JsonSerializer();
                lesJoueurs = (List<Joueur>)newS.Deserialize(file, typeof(List<Joueur>));
            }
            listJoueurSolo.DataSource = lesJoueurs;
            lesJoueursAjouter = new List<Joueur>();
            
        }

        private void btnAjouterJSolo_Click(object sender, EventArgs e)
        {
            if (listJoueurSolo.Items.Count == 0 || listJoueurSolo.SelectedItem == null) { }
            else
            {
                Joueur joueur = (Joueur)listJoueurSolo.SelectedItem;
                lesJoueursAjouter.Add(joueur);
                listAjoutJoueur.DataSource = null;
                listAjoutJoueur.DataSource = lesJoueursAjouter;
                lesJoueurs.Remove(joueur);
                listJoueurSolo.DataSource = null;
                listJoueurSolo.DataSource = lesJoueurs;
            }


        }

        private void btnRetirJsolo_Click(object sender, EventArgs e)
        {   
            Joueur joueurR = (Joueur)listAjoutJoueur.SelectedItem;
            lesJoueursAjouter.Remove(joueurR);
            listAjoutJoueur.DataSource = null;
            listAjoutJoueur.DataSource = lesJoueursAjouter;
            //listAjoutJoueur.Items.Remove(joueurR);
            lesJoueurs.Add(joueurR);
            listJoueurSolo.DataSource = null;
            listJoueurSolo.DataSource = lesJoueurs;
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            Partie p = new Partie();
            p.LesJoueurs = (List<Joueur>)listAjoutJoueur.DataSource;
            if (p.LesJoueurs == null || p.LesJoueurs.Count == 0)
            {
                MessageBox.Show("Il n'y a aucun joueur selectionné");
            }
            else if (p.LesJoueurs.Count == 1)
            {
                MessageBox.Show("Il y a qu'un seul joueur selectionné, veuillez en selectionner au moins deux");
            }
            else
            {              
                
            }

            JoueurSoloPartie jsp = new JoueurSoloPartie(p, Joueur.getNbrAleatoire(p.LesJoueurs.Count));
            this.Close();
            jsp.ShowDialog();
        }
    }
}
