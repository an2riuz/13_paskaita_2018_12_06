using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13_paskaita_2018_12_06.Classes
{
    class Static
    {
        private static int kiekis { get; set; } = 0;
        public static string pavadinimas { get; set; } = "Kamuolys";

        public Static()
        {

        }

        private static void Kiek()
        {
            kiekis += 30;
            Console.WriteLine(kiekis);
        }

        public static void Pavadinimas()
        {
            Console.WriteLine(pavadinimas);
        }

        public static void KiekioKiekis()
        {
            Kiek();
        }
    }
}
