using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13_paskaita_2018_12_06.Classes
{
    class Mixed
    {
        private static int kiekis { get; set; } = 3;
        private string modelis { get; set; } = "Ascona";

        public Mixed()
        {

        }

        public static void Kiekis()
        {
            Console.WriteLine(kiekis);
        }

        public void Modelis()
        {
            Console.WriteLine(modelis);
        }
    }
}
