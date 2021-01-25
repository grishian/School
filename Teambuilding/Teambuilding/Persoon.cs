using System;
using System.Collections.Generic;
using System.Text;

namespace Teambuilding
{
    class Persoon
    {
        //fields and properties
        public string voornaam { get; set; }
        public string achternaam { get; set; }
        public int leeftijd { get; set; }
        public string bedrijf { get; set; }


        //ctor's
        public Persoon()
        {
            voornaam = "";
            achternaam = "";
            leeftijd = 0;
        }
        public Persoon(string voornaam, string achternaam, int leeftijd)
        {
            this.voornaam = voornaam;
            this.achternaam = achternaam;
            this.leeftijd = leeftijd;

        }

        //methods




    }
}
