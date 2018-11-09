using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Molkky_t
{
    class Equipe
    {
        private int num_equipe;
        private string nom_equipe;
        private int score;
        private List<Joueur> lesJoueurs = new List<Joueur>();


        public Equipe() { }
        public Equipe(int num_equipe, string nom_equipe, int nb_joueur)
        {
            this.Num_equipe = num_equipe;
            this.Nom_equipe = nom_equipe;
            this.Nb_joueur = nb_joueur;

        }

        public Equipe(int num_equipe, string nom_equipe, int score, List<Joueur> lesJoueurs)
        {
            this.num_equipe = num_equipe;
            this.nom_equipe = nom_equipe;
            this.score = score;
            this.LesJoueurs = lesJoueurs;
        }

        public int Num_equipe { get => num_equipe; set => num_equipe = value; }
        public string Nom_equipe { get => nom_equipe; set => nom_equipe = value; }
        public int Nb_joueur { get => score; set => score = value; }
        public List<Joueur> LesJoueurs { get => lesJoueurs; set => lesJoueurs = value; }
    }
}
