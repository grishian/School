using System;

namespace CasusZonnepaneel.prijzen
{
    class Prijs
    {

        public double[] starttarief = new double[3] { 50,25,15 };
        public double[] materiaalkostPerVierkanteMeter = new double[3] { 1.8, 1.6, 1.5 };
        public double[] uurtarief = new double[3] { 35, 32, 28 };
        public string[] daken = new string[3] { "kleine daken", "grote daken", "platte daken" };

        public double afstand;
        //private double totaalPrijs;
        public double vervoerkost;
        public double oppervlakDaken;
        public string daksoort;

        public string keuze()
        {

            Console.WriteLine("Alles in euro:\n" +
                "******************************");

            return string.Format("\t\t\t\t\t{0}\t{1}\t{2}\n" +
                "starttarief: \t\t\t\t{3}\t\t{4}\t\t{5}" +
                "\nmateriaalkost per vierkante meter: \t{6}\t\t{7}\t\t{8}" +
                "\nuurtarief: \t\t\t\t{9}\t\t{10}\t\t{11}", daken[0], daken[1], daken[2], starttarief[0]
                , starttarief[1], starttarief[2]
                , materiaalkostPerVierkanteMeter[0], materiaalkostPerVierkanteMeter[1], materiaalkostPerVierkanteMeter[2]
                , uurtarief[0], uurtarief[1], uurtarief[2]);

        }

        public double vervoerskost()
        {

            double vervoerskost = 0.0;

            if (afstand < 10)
            {
                vervoerskost =  0.0;
            }
            else if (afstand < 50)
            {
                vervoerskost = (afstand * 0.8) - 8;
            }
            else if (afstand <= 100)
            {
                vervoerskost = 40 + ((0.5 * afstand) - 25);
            }
            else if (afstand > 100)
            {
                Console.WriteLine("Afstand te groot. Geen prijs mogelijk");
                vervoerskost = -1.0;
            }

            vervoerkost = vervoerskost;
            return Math.Round(vervoerskost, 2);
        }

        public double prijs() {

            double starttariefPrijs = starttarief[Array.IndexOf(daken, daksoort)];
            double materiaalKostPrijs = materiaalkostPerVierkanteMeter[Array.IndexOf(daken, daksoort)] * oppervlakDaken;
            double uurtariefPrijs = uurtarief[Array.IndexOf(daken, daksoort)] * (oppervlakDaken / 40);

            Console.WriteLine("\nTotaal bedrag is dan(+vervoerskost): ");
            return starttariefPrijs+materiaalKostPrijs+uurtariefPrijs+vervoerkost;
        }

    }
}
