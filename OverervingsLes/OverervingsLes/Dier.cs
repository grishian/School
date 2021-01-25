using System;
using System.Collections.Generic;
using System.Text;

namespace OverervingsLes
{
    class Dier
    {
        public string naam { get; set; }
        public int leeftijd { get; set; }



        public void DrukInfo()
        {
            Console.WriteLine($"{naam} is {leeftijd} jaar oud.");
        }

        public Dier()
        {
            naam = "geen naam";
            leeftijd = 0;
        }

        public Dier(string naam, int leeftijd)
        {
            naam = this.naam;
            leeftijd = this.leeftijd;
        }

        public string GeefDierInfo()
        {
            return naam + " en is " + leeftijd + " jaar oud.";
         } 


    }
}
