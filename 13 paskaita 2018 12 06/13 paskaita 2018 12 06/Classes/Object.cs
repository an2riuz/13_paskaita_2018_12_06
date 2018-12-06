using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13_paskaita_2018_12_06.Classes
{
    class Objectas
    {
        private int amzius { get; set; } = 23;
        public string vardas { get; set; } = "Varnas";

        public Objectas()
        {

        }

        private void Amzius()
        {
            Console.WriteLine(amzius);
        }

        public void Vardas()
        {
            Console.WriteLine(vardas);
        }
    }
}
