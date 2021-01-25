using System;
using System.Collections.Generic;
using System.Text;

namespace figuren.methods
{
    class Oppervlakten
    {


        public static double vierkant()
        {
            Console.WriteLine("Geef een zijde: ");
            double zijde = double.Parse(Console.ReadLine());

            return zijde * zijde;
        }

        public static double rechthoek()
        {
            Console.WriteLine("Geef de lengte en de breedte in: ");
            double lengte = double.Parse(Console.ReadLine());
            double breedte = double.Parse(Console.ReadLine());

            return lengte * breedte;
        }

        public static double driehoek()
        {
            Console.WriteLine("Geef de hoogte en de basis in: ");
            double basis = double.Parse(Console.ReadLine());
            double hoogte = double.Parse(Console.ReadLine());

            return (basis * hoogte)/2;
        }

        public static double cirkel()
        {
            Console.WriteLine("Geef de straal in: ");
            double straal = double.Parse(Console.ReadLine());


            return straal*straal*Math.PI;
        }








    }
}
