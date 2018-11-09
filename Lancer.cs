using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Molkky_t
{
    class Lancer
    {
        private int num_lancer;
        private int nb_point;
        List<Joueur> lesJoueurs = new List<Joueur>();


        public Lancer() { }

        public Lancer(int num_lancer, int nb_point, List<Joueur> lesJoueurs)
        {
            this.num_lancer = num_lancer;
            this.nb_point = nb_point;
            this.lesJoueurs = lesJoueurs;
        }

        public int Num_lancer { get => num_lancer; set => num_lancer = value; }
        public int Nb_point { get => nb_point; set => nb_point = value; }
        internal List<Joueur> LesJoueurs { get => lesJoueurs; set => lesJoueurs = value; }
    }
}
