using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Molkky_t
{
    class Molkky
    {
        private int id;
        List<Partie> lesParties = new List<Partie>();

        public Molkky() { }
        public Molkky(int id, List<Partie> lesParties)
        {
            this.id = id;
            this.lesParties = lesParties;
        }

        public int Id { get => id; set => id = value; }
        internal List<Partie> LesParties { get => lesParties; set => lesParties = value; }
    }
}
