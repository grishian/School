using System;
using System.Collections.Generic;
using System.Text;

namespace CasinoLotte
{
    class Speler
    {
        //fields
        private string voornaam = "Unassigned";
        private string achternaam = "Unassigned";
        private DateTime geboortedatum; //enkel date? default van dateTime? wat als enkel datum wordt meegegeven?


        //getters en setters
        public string Voornaam
        {
            get { return voornaam; }
            set { voornaam = value; }
        }

        public string Achternaam
        {
            get { return achternaam; }
            set { achternaam = value; }
        }

        public DateTime Geboortedatum
        {
            get { return geboortedatum; }
            set { geboortedatum = value; }
        }

        //constructor
        public Speler()
        {
        }

        public Speler(string v, string a, DateTime g)
        {
            this.Voornaam = v;
            this.Achternaam = a;
            this.Geboortedatum = g;

            //je mag ook dit doen:
            /*
             * Voornaam = v;
             * Achternaam = a
             * ...
             * 
             * => want this gebruik je in jou geval omdat er verwarring is(maar is bij jou niet het geval)
             * verwarring voorbeeld:
             * 
             * this.naam = naam;
             * this.achternaam = achternaam;
             * 
             * als beide namen hetzelfde zijn gebruik je best this
             */
        }

    }
}
