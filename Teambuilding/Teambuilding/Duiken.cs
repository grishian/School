using System;
using System.Collections.Generic;
using System.Text;

namespace Teambuilding
{
    class Duiken : Activiteit
    {
        public Duiken(bool indoor, Begeleider begeleider, double prijs)
        {
            base.naam = "Duiken";
            base.indoor = indoor;
            base.begeleider = begeleider;
            base.prijs = prijs;
        }


        public override string ToString()
        {
            return $"Duiken:\n" +
                $"Indoor: {indoor}\n" +
                $"Begeleider: {begeleider}\n" +
                $"Prijs: {prijs} euro";
        }
    }
}
