using System;
using System.Collections.Generic;
using System.Text;

namespace gras.methods
{
    class Betaling
    {
        public static string kost() {

            double prijsPerUur = 15;
            double snelheid = 0.00008;

            Console.WriteLine("Hoeveel heeft hij afgereden in vierkante km?: ");
            double oppervlakte = double.Parse(Console.ReadLine());

            return oppervlakte/snelheid*prijsPerUur + " euro moet je hem betalen";
        }
    }
}
