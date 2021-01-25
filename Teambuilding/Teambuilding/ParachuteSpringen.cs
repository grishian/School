using System;
using System.Collections.Generic;
using System.Text;

namespace Teambuilding
{
    class ParachuteSpringen : Activiteit
    {

        public ParachuteSpringen(bool indoor, Begeleider begeleider, double prijs)
        {
            base.naam = "Parachutespringen";
            base.indoor = indoor;
            base.begeleider = begeleider;
            base.prijs = prijs;
        }

        public override string ToString()
        {
            return $"Parachutespringen:\n" +
                $"Indoor: {indoor}\n" +
                $"Begeleider: {begeleider}\n" +
                $"Prijs: {prijs} euro";
        }

    }
}
