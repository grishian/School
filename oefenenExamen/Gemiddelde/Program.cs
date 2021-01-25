using System;

namespace Gemiddelde
{
    class Program
    {
        static void Main(string[] args)
        {

            /*
             * Schrijf een programma dat het gemiddelde berekent van alle
             * elementen in een array(waardes in code)
             */

            double[] punten = new double[10] { 2,5,1,8,5,6,4,7,5,4 };

            double totaal = 0;
            

            foreach(double punt in punten)
            {

                totaal += punt;
               

            }
            double gemiddelde = totaal / 10;
            Console.WriteLine($"Het gemiddelde is {gemiddelde} :)");

        }
    }
}
