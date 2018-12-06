using _13_paskaita_2018_12_06.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13_paskaita_2018_12_06
{
    class Program
    {
        static void Main(string[] args)
        {
            Static.Pavadinimas();

            Mixed.Kiekis();

            Objectas objektas = new Objectas();

            Console.WriteLine(objektas.vardas);

            Static.KiekioKiekis();

            Konstruktorius.Labas();

            Medis medis = new Medis();

            //medis.Medinis();
            

            Console.ReadKey();
        }
    }
}
