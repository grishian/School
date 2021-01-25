using System;
using System.Collections.Generic;
using System.Text;

namespace Kinderboerderij
{
    class Voedsel
    {
        //fields and properties
        public string voedselNaam { get; set; }
        public double voedselGewicht { get; set; }
        public double voedselKostprijs { get; set; }

        //constructors
        public Voedsel()
        {
            voedselNaam = "Naamloos";
            voedselGewicht = 0;
            voedselKostprijs = 0;
        }

        public Voedsel(string naam, double gewicht, double kostprijs)
        {
            voedselNaam = naam;
            voedselGewicht = gewicht;
            voedselKostprijs = kostprijs;
        }

        //methods
    }
}
