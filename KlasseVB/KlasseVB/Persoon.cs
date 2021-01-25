using System;
using System.Collections.Generic;
using System.Text;

namespace KlasseVB
{
    class Persoon
    {
        public string naam;
        Random lft = new Random();
        public int leeftijd; // = lft.Next(0, 101);

        //constructors
        public Persoon()
        {
            naam = "onbekend";
            leeftijd = lft.Next(0,101);
            aantalPersonen++;
        }
        public Persoon(string naam)
        {
            this.naam = naam;
            leeftijd = 18;
            aantalPersonen++;
        }

        public Persoon(string naam, int leeftijd)
        {
            this.naam = naam;
            this.leeftijd = leeftijd;
               aantalPersonen++;
        }

        //methods
        public void DrukId()
        {
            Console.WriteLine($"De persoon heet {naam} en is {leeftijd} jaar oud.");

        }

        static int aantalPersonen = 0;

        public void DrukAantalPersonen()
        {
            Console.WriteLine($"Aantal personen is {aantalPersonen}");
        }

    }
}
