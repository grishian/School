using System;
using System.Collections.Generic;
using System.Text;

namespace ramenWasser.methods
{
    class Kost
    {
        public static double raamOppervlak()
        {
            Console.WriteLine("Hoeveel ramen zijn er?: ");
            double hoeveelheid = double.Parse(Console.ReadLine());

            Console.WriteLine("Wat is de hoogte?: ");
            double hoogte = double.Parse(Console.ReadLine());

            Console.WriteLine("Wat is de breedte?: ");
            double breedte = double.Parse(Console.ReadLine());

            return hoeveelheid * hoogte * breedte;
        }

        public static double kost(double raamOppervlak)
        {

            double materiaalKost = 0.8;

            return materiaalKost * raamOppervlak;

        }

        public static double loon(double raamOppervlak)
        {
            double oppervlaktePerUur = 25;
            double uurLoon = 22;

            return (raamOppervlak / oppervlaktePerUur) * uurLoon;

        }

        public static double totaalLoon(double loon, double kost)
        {
            return loon + kost;
        }

    }
}
