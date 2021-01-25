using System;
using System.Collections.Generic;
using System.Text;

namespace Kinderboerderij
{
    class Bezoeker
    {
        //fields and properties
        public string bezoekerNaam { get; set; }
        public int bezoekerLeeftijd { get; set; }
        public bool bezoekerStudentenkaart { get; set; }

        public Boerderij bezoekerBoerderij;
        public double bezoekerPrijs { get; set; }


        //constructors
        public Bezoeker(Boerderij boerderij)
        {
            bezoekerNaam = "naamloos";
            bezoekerLeeftijd = 0;
            bezoekerStudentenkaart = false;

            bezoekerBoerderij = boerderij;
            boerderij.bezoekers[boerderij.bezoekerCounter] = this;
            boerderij.bezoekerCounter++;

            ToonBezoekerPrijs();
        }

        public Bezoeker(string naam, int leeftijd, bool studentenkaart, Boerderij boerderij)
        {

            bezoekerNaam = naam;
            bezoekerLeeftijd = leeftijd;
            bezoekerStudentenkaart = studentenkaart;

            bezoekerBoerderij = boerderij;
            boerderij.bezoekers[boerderij.bezoekerCounter] = this;
            boerderij.bezoekerCounter++;

            ToonBezoekerPrijs();

        }


        //methods

        public void ToonBezoekerPrijs()
        {
            if (bezoekerStudentenkaart)
            {
                bezoekerPrijs = 5;
                Console.WriteLine("Dat is dan 5 euro aub.");
                
            }
            else if (bezoekerLeeftijd < 10)
            {
                Console.WriteLine("Dat is gratis, ga maar binnen.");
                bezoekerPrijs = 0;
            } else if (bezoekerLeeftijd < 16)
            {
                Console.WriteLine("Dat is dan 5 euro aub.");
                bezoekerPrijs = 5;
            } else if (bezoekerLeeftijd < 18)
            {
                Console.WriteLine("Dat is da 7 euro aub.");
                bezoekerPrijs = 7;
            } else
            {
                Console.WriteLine("Dat is dan 10 euro aub.");
                bezoekerPrijs = 10;
            }
        }

        public string ToonBezoeker()
        {

            return string.Format($"  {bezoekerNaam} is {bezoekerLeeftijd} oud en heeft {bezoekerPrijs} euro betaald.");
        }

    }
}
