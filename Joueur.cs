using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Molkky_t
{
    class Joueur
    {
        private string pseudo;
        //private object chemin_photo;
        private int nb_victoire;
        private int nb_defaite;

        public Joueur() { }
        public Joueur(string pseudo)
        {
            this.Pseudo = pseudo;
        }
        public Joueur(string pseudo, int nb_victoire, int nb_defaite)
        {
            this.Pseudo = pseudo;
            //this.Chemin_photo = chemin_photo;
            this.Nb_victoire = nb_victoire;
            this.Nb_defaite = nb_defaite;
        }

        public string Pseudo { get => pseudo; set => pseudo = value; }
        //public object Chemin_photo { get => chemin_photo; set => chemin_photo = value; }
        public int Nb_victoire { get => nb_victoire; set => nb_victoire = value; }
        public int Nb_defaite { get => nb_defaite; set => nb_defaite = value; }

        public void calculPts()
        {

        }
        public override string ToString()
        {
            return this.pseudo;
        }

    }
}
