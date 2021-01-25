using System;
using System.Collections.Generic;
using System.Text;

namespace Teambuilding
{
    class Deelnemer : Persoon
    {


        //ctor's
        public Deelnemer(string voornaam, string achternaam, int leeftijd)
        {
            base.voornaam = voornaam;
            base.achternaam = achternaam;
            base.leeftijd = leeftijd;
        }


        //methods
        public override string ToString()
        {
            return string.Format($"{voornaam} {achternaam}\n" +
                $"leeftijd: {leeftijd}");
        }

    }
}
