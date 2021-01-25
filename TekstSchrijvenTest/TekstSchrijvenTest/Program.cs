using System;
using System.Collections.Generic;
using System.IO;  //namespace 
using System.Security.Cryptography;
using System.Text;

namespace TekstSchrijvenTest
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] lines = { "First line", "Second line", "Third line" };
            System.IO.File.WriteAllLines(@"C:\Users\grish\Desktop\WriteLines.txt", lines);

            //System.IO mag weggelaten worden omdat die al in de namespace staat.


            string text = "dit is een lange zin ofo";
            System.IO.File.WriteAllText(@"C:\Users\grish\Desktop\WriteText.txt", text);

            using (System.IO.StreamWriter file = new System.IO.StreamWriter(@"C:\Users\grish\Desktop\WriteLines2.txt"))
            {
                foreach (string line in lines)
                {
                    if (!line.Contains("First"))
                    {
                        file.WriteLine(line);
                    }
                }
            }

            using (System.IO.StreamWriter file = new System.IO.StreamWriter(@"C:\Users\grish\Desktop\WriteLines2.txt", true))
            {
                file.WriteLine("fourth Line");
            }

            string test = "dit is een lange zin ofo";
            System.IO.File.WriteAllText(@"..\..\..\..\WriteText123.txt", test);

            //start echte test

            Casino c1 = new Casino();


            Speler s1 = new Speler("Grishian", "Gracida", "0001", new DateTime(1997, 11, 5), c1);
            Speler s2 = new Speler("Jorne", "Burkhard", "0002", new DateTime(1998, 1, 6), c1);
            Speler s3 = new Speler("Runy", "Gracida", "0003", new DateTime(1999, 10, 31), c1);
            Speler s4 = new Speler("Petra", "Burkhard", "0004", new DateTime(1969, 9, 2), c1);



            //nu de lijst spelers wegschrijven met methode

            c1.SchrijfSpelers();

            //hier lezen we het bestand

            Console.WriteLine("****************************");
            string lezen = File.ReadAllText(@"..\..\..\..\SpelerInfo.txt");
            Console.WriteLine(lezen);
            Console.WriteLine("********************************");



        }
    }



    //klasses:



    class Casino
    {

        List<Speler> spelers;

        public Casino()
        {
            spelers = new List<Speler>();
        }

        public void addSpelers(Speler s)
        {
            spelers.Add(s);
        }

        public void SchrijfSpelers()
        {
            using (System.IO.StreamWriter file = new System.IO.StreamWriter(@"..\..\..\..\SpelerInfo.txt", true))
            {
                foreach (Speler speler in spelers)
                {
                    file.WriteLine(speler.ToString());
                }
            }
        }
    }

    class Speler
    {
        //fields
        string naam;
        string achternaam;
        string spelerId;
        public int leeftijd = 0;
        Casino c;
        DateTime geboortedatum;


        //ctor's
        public Speler(string naam, string achternaam, string spelerId, DateTime geboortedatum, Casino c)
        {
            this.naam = naam;
            this.achternaam = achternaam;
            this.spelerId = spelerId;
            this.geboortedatum = geboortedatum;

           this.c = c;
           
           c.addSpelers(this);


            leeftijd = DateTime.Now.Year - geboortedatum.Year;
            if (DateTime.Now.DayOfYear < geboortedatum.DayOfYear)
            {
                leeftijd--;
            }

        }

        public override string ToString()
        {
            return string.Format($"" +
                $"spelerId: {spelerId}\n" +
                $"Voornaam: {naam}\n" +
                $"Achternaam: {achternaam}\n" +
                $"Leeftijd: {leeftijd}\n" +
                $"Geboortedatum: {geboortedatum.ToString("dd/MMMM/yyyy")}\n");
        }

    }
}
