using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13_paskaita_2018_12_06.Classes
{
    class Medis
    {
        private string pavadinimas = "Berzas";
        private string vieta = "Miskas";
        private int kiekis = 10;

        public Medis()
        {
            
        }

        public Medis(int kiekis)
        {

        }

        public Medis(int kiekis, string pavadinimas)
        {

        }


        public void MedzioPavadinimas()
        {
            Console.WriteLine("Sis medis yra " + pavadinimas);
        }

        public void KurAuga()
        {
            Console.WriteLine(vieta);
        }
    }
}
