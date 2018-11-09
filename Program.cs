using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Newtonsoft.Json;

namespace Molkky_t
{
    static class Program
    {
        /// <summary>
        /// Point d'entrée principal de l'application.
        /// </summary>
        [STAThread]
        public static void Main()
        {

            /*List<Joueur> jList = new List<Joueur>();
            Joueur j1 = new Joueur("jamy");
            Joueur j4 = new Joueur("Charly");
            Joueur j2 = new Joueur("michel");
            Joueur j3 = new Joueur("Hugo");

            jList.Add(j1);
            jList.Add(j4);
            jList.Add(j2);
            jList.Add(j3);




            string testJson = JsonConvert.SerializeObject(jList, Formatting.Indented);
            File.WriteAllText(@"\\Mac\Home\Documents\Molkky-t-test\Resources\lesJoueurs.json", testJson);*/

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Accueil());

           
        }
    }
}
