using System;
using System.Collections.Generic;

using System.Text;


namespace Teambuilding
{
    class Begeleider : Persoon
    {
        //fields and properties
        public List<string> attesten = new List<string>(); //moet een juist attest hebben voor een bepaalde activiteit.
        public static List<Begeleider> begeleiders = new List<Begeleider>();


        //ctor's
        public Begeleider(string voornaam, string achternaam, int leeftijd)
        {
            base.voornaam = voornaam;
            base.achternaam = achternaam;
            base.leeftijd = leeftijd;

            begeleiders.Add(this);
        }

        public void AddAttest(string attest)
        {
            attesten.Add(attest);
        }

        public void ShowAttests()
        {
            foreach (string attest in attesten)
            {
                Console.WriteLine(attest);
            }
        }

        public override string ToString()
        {
            return string.Format($"{voornaam} {achternaam}\n" +
                $"  -leeftijd: {leeftijd}\n" +
                $"  -attesten: {attesten[0]},...");
        }



    }
}
