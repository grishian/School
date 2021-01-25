using System;
using System.Collections.Generic;
using System.Text;

namespace Teambuilding
{
    class Muurklimmen : Activiteit
    {

        public Muurklimmen(bool indoor, Begeleider begeleider, double prijs)
        {
            base.naam = "Muurklimmen";
            base.indoor = indoor;
            base.begeleider = begeleider;
            base.prijs = prijs;
        }

        public override string ToString()
        {
            return $"Muurklimmen:\n" +
                $"Indoor: {indoor}\n" +
                $"Begeleider: {begeleider}\n" +
                $"Prijs: {prijs} euro";
        }




    }
}
