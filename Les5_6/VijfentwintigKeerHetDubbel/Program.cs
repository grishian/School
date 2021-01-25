using System;
using System.Dynamic;

namespace VijfentwintigKeerHetDubbel
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("geef een getal, we doen het 25 keer het dubbel: ");

            int getal = int.Parse(Console.ReadLine());

            for (int i = 1; i < 25; i++)
            {

                getal = getal * 2;
                Console.WriteLine(i + " : " + getal);

            }
        }
    }
}
