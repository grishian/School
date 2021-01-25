using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace Rekenmachine.methods
{
    class Calculator
    {

        public static double som()
        {
            Console.WriteLine("Geef twee getallen: ");
            double x = double.Parse(Console.ReadLine());
            double y = double.Parse(Console.ReadLine());

            return x+y;
        }

        public static double verschil()
        {
            Console.WriteLine("Geef twee getallen: ");
            double x = double.Parse(Console.ReadLine());
            double y = double.Parse(Console.ReadLine());

            return x - y;
        }


        public static double vermenigvuldiging()
        {
            Console.WriteLine("Geef twee getallen: ");
            double x = double.Parse(Console.ReadLine());
            double y = double.Parse(Console.ReadLine());

            return x * y;
        }

        public static double deling()
        {
            Console.WriteLine("Geef twee getallen: ");
            double x = double.Parse(Console.ReadLine());
            double y = double.Parse(Console.ReadLine());

            return x / y;
        }

        public static double dubbel ()
        {
            Console.WriteLine("Geef een getal in: ");
            double x = double.Parse(Console.ReadLine());

            return x * 2;
        }

        public static double helft()
        {
            Console.WriteLine("Geef een getal in: ");
            double x = double.Parse(Console.ReadLine());

            return x / 2;
        }

        public static bool even()
        {
            Console.WriteLine("Geef een getal in: ");
            double x = double.Parse(Console.ReadLine());

            return (x%2==0);
        }
        public static bool oneven()
        {
            Console.WriteLine("Geef een getal in: ");
            double x = double.Parse(Console.ReadLine());

            return !(x % 2 == 0);
        }
    }
}
