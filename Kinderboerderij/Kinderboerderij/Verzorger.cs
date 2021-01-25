using System;
using System.Collections.Generic;
using System.Text;

namespace Kinderboerderij
{
    class Verzorger
    {
        //fields and properties
        public string verzorgerAchternaam { get; set; }
        public string verzorgerVoornaam { get; set; }
        public int verzorgerLeeftijd { get; set; }
        public double verzorgerLoon { get; set; }
        public string verzorgerGemeente { get; set; }
        public Boerderij verzorgerBoerderij;

        //constructors
        public Verzorger(Boerderij boerderij)
        {
            verzorgerVoornaam = "Naamloos";
            verzorgerAchternaam = "Naamloos";
            verzorgerLeeftijd = 0;
            verzorgerLoon = 0;

            verzorgerBoerderij = boerderij;
            boerderij.verzorgers[boerderij.verzorgerCounter] = this;
            boerderij.verzorgerCounter++;
        }

        public Verzorger(string achternaam, string voornaam, int leeftijd, double loon, string gemeente, Boerderij boerderij)
        {
            verzorgerAchternaam = achternaam;
            verzorgerVoornaam = voornaam;
            verzorgerLeeftijd = leeftijd;
            verzorgerLoon = loon;
            verzorgerGemeente = gemeente;

            verzorgerBoerderij = boerderij;
            boerderij.verzorgers[boerderij.verzorgerCounter] = this;
            boerderij.verzorgerCounter++;
        }

        //methods

        public void verzorgerOpslag(double bedrag)
        {
            verzorgerLoon += bedrag;
        }

        public void verzorgerInfo()
        {
            Console.WriteLine($"  {verzorgerVoornaam} {verzorgerAchternaam} is {verzorgerLeeftijd} jaar, woont in {verzorgerGemeente} en verdient {verzorgerLoon} euro per maand.");
        }


    }
}
