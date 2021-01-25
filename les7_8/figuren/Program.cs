using figuren.methods;
using System;

namespace figuren
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Welk figuur zijn oppevlakte wil je berekenen?: \n" +
                "vierkant\n" +
                "rechthoek\n" +
                "driehoek\n" +
                "cirkel\n");

            switch (Console.ReadLine()) {

                case "vierkant":
                    Console.WriteLine(Oppervlakten.vierkant());
                    break;
                case "rechthoek":
                    Console.WriteLine(Oppervlakten.rechthoek());
                    break;
                case "driehoek":
                    Console.WriteLine(Oppervlakten.driehoek());
                    break;
                case "cirkel":
                    Console.WriteLine(Oppervlakten.cirkel());
                    break;

                default:
                    Console.WriteLine("oei, er is iets misgelopen.");
                    break;
            }




        }
    }
}
