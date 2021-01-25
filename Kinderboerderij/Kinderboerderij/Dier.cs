using System;
using System.Collections.Generic;
using System.Text;

namespace Kinderboerderij
{
    class Dier
    {
        //fields and properties
        private string dierNaam { get; set; }
        public string dierSoort { get; set; }
        public int dierLeeftijd { get; set; }
        public Voedsel dierVoedsel { get; set; }
        public double dierEtenPerDag { get; set; } //in kilo
        public Zone dierZone { get; set; }
        private int dierId;
        public ConsoleMethods specialMethods = new ConsoleMethods();



        //constructors
        public Dier()
        {
            dierNaam = "Naamloos";
            dierSoort = "Soortloos";
            dierLeeftijd = 0;
            dierVoedsel = new Voedsel();
            dierEtenPerDag = 0;

        }

        public Dier(string naam, string soort, Zone zone, int leeftijd, Voedsel voedsel, double etenPerDag)
        {
            dierNaam = naam;
            dierSoort = soort;
            dierLeeftijd = leeftijd;
            dierVoedsel = voedsel;
            dierEtenPerDag = etenPerDag;
            dierZone = zone;

            dierId = zone.zoneDierId;
            zone.zoneDierId++;

            zone.dieren[zone.aantalDieren] = this;
            zone.aantalDieren++;
        }

        //methods
        public string DierInfo()
        {
            specialMethods.Foreground(ConsoleColor.Yellow);
            return string.Format($"  {dierNaam} de {dierSoort} eet { Math.Round(dierEtenPerDag, 2)   } kilo {dierVoedsel.voedselNaam} per dag. " +
                $" Dit kost {dierVoedsel.voedselKostprijs} euro per kilo. Dit is dan {Math.Round((dierVoedsel.voedselKostprijs * dierEtenPerDag), 2)} euro.");
        }

    }
}
