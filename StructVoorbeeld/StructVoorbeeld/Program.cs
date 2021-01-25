using System;

namespace StructVoorbeeld
{
    class Program
    {
        static void Main(string[] args)
        {

            persoon p = new persoon();
            p.geslacht = "meneer";
            p.woonplaats = "Mechelen";
            p.naam = "bjorn";
            p.leeftijd = 25;
            p.ID();

            persoon p2 = new persoon("Bert", 20);
            p2.ID();

            Console.WriteLine(p2.geboorteJaar());
            p.persoonsInfo();

            //*****************************


            Dier d = new Dier("Fifi", "Woef!", "Bruin", 15);
            d.DierInfo();

            //******************************************
            Vierkant vierkant = new Vierkant(5, 10);
            vierkant.OppEnOmtr();
            vierkant.GeefFiguurInfo();

            Console.WriteLine("****************************");

            Random rndGen = new Random();
            Console.WriteLine(rndGen.Next(0, 11));

        }

        struct Vierkant
        {
            //fields
            public double basis;
            public double hoogte;
            public double opp;
            public double omtr;

            //constructor
            public Vierkant(double basis, double hoogte)
            {
                this.basis = basis;
                this.hoogte = hoogte;
                opp = 0;
                omtr = 0;
            }

            //methods
            public void OppEnOmtr()
            {
                opp = basis * hoogte;
                omtr = (basis * 2) + (hoogte * 2);
                Console.WriteLine($"De oppervlakte is: {opp} en de omtrek is: {omtr}");
            }

            public void GeefFiguurInfo()
            {
                Console.WriteLine($"Deze figuur is een vierkant met als oppervlakte: {opp} en als omtrek: {omtr}");
            }

        }

        struct Vierhoek
        {
            //fields
            public double zijde1;
            public double zijde2;
            public double zijde3;
            public double zijde4;

            //constructor

            //methods

        }

        struct Cirkel
        {
            //fields
            public double straal;

            //constructor

            //methods

        }




        struct Dier
        {

            public string naam;
            public string geluid;
            public string kleur;
            public double gewicht;

            //constructor
            public Dier(string naam, string geluid, string kleur, double gewicht)
            {
                this.naam = naam;
                this.geluid = geluid;
                this.kleur = kleur;
                this.gewicht = gewicht;
            }


            //methode
            public void DierInfo()
            {
                Console.WriteLine($"naam: {naam} gewicht: {gewicht} kleur: {kleur} geluid: {geluid}");
            }

            public void Geluid()
            {
                Console.WriteLine(geluid);
            }

        }


        struct persoon
        {

            //Pas het programma aan zodat er ook een woonplaats, geslacht, en burgerlijkste staat kan ingeven worden. 
            //Maak een methode persoonsInfo dat volgende afdruk geeft.
            //Mevrouw/Juffrouw/Meneer woont in “” is geboren in het jaar en is “burgerlijke staat”


            public string woonplaats;
            public string geslacht;
            public string burgerlijkeStaat;
            public string naam;
            public int leeftijd;


            //constructor

            public persoon(string n = "", int lft = 0, string wnplts = "", string gesl = "", string burg = "")
            {
                woonplaats = wnplts;
                geslacht = gesl;
                burgerlijkeStaat = burg;
                naam = n;
                leeftijd = lft;
            }

            public void ID()
            {
                Console.WriteLine("De persoon heet {0} en is {1} jaar oud ", naam, leeftijd);
            }

            public int geboorteJaar()
            {
                return 2020 - leeftijd;
            }

            public void persoonsInfo()
            {
                Console.WriteLine($"{geslacht} {naam} woont in {woonplaats} is geboren in het jaar {geboorteJaar()} en is {leeftijd}");

            }
        }

    }
}
