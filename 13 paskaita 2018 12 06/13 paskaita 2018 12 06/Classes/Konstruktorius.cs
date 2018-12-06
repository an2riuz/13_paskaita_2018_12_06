using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13_paskaita_2018_12_06.Classes
{
    class Konstruktorius
    {
        private Konstruktorius()
        {
            Console.WriteLine("Helperis");
        }

        public static void Labas()
        {
            Konstruktorius naujas = new Konstruktorius();
        }
    }
}
