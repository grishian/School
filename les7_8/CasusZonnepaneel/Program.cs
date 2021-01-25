using CasusZonnepaneel.prijzen;
using System;

namespace CasusZonnepaneel
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Casus zonnepaneelreiniger\n" +
                "******************************");

            Prijs prijs = new Prijs();
            Console.WriteLine(prijs.keuze());

            Console.WriteLine("\nHoeveel km bent u van ons gelegen?: ");
            prijs.afstand = double.Parse(Console.ReadLine());

            Console.WriteLine("De vervoerskost zou dan: " + prijs.vervoerskost() + " euro zijn.");

            Console.WriteLine("\nWelk daksoort heeft u? Keuzen tussen: \n" +
                "- kleine daken \textra info: <200m^2\n" +
                "- grote daken\n" +
                "- platte daken");
            prijs.daksoort = Console.ReadLine();

            Console.WriteLine("Hoeveel oppervlak bedraagt uw dak?: ");
            prijs.oppervlakDaken = double.Parse(Console.ReadLine());

            Console.WriteLine(prijs.prijs()+ " euro.");

        }
    }
}
