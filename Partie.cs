using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Molkky_t
{
    class Partie
    {
        private int num_partie;
        private DateTime date_partie;
        List<Joueur> lesJoueurs = new List<Joueur>();
        List<Lancer> lesLancers = new List<Lancer>();

        public Partie()
        {

        }

        public Partie(int num_partie, DateTime date_partie)
        {
            this.Num_partie = num_partie;
            this.Date_partie = date_partie;
        }

        public Partie(int num_partie, DateTime date_partie, List<Joueur> lesJoueurs)
        {
            this.num_partie = num_partie;
            this.date_partie = date_partie;
            this.lesJoueurs = lesJoueurs;
        }

        public int Num_partie { get => num_partie; set => num_partie = value; }
        public DateTime Date_partie { get => date_partie; set => date_partie = value; }
        internal List<Joueur> LesJoueurs { get => lesJoueurs; set => lesJoueurs = value; }
        internal List<Lancer> LesLancers { get => lesLancers; set => lesLancers = value; }


    }
}
