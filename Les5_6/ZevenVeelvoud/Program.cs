using System;

namespace ZevenVeelvoud
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("van welk getal wil je veelvouden berekenen?: ");
            int getal = int.Parse(Console.ReadLine());

            Console.WriteLine("tot welke veelvoud wil je gaan?(met nul meegerekend): ");
            int veelvoud = int.Parse(Console.ReadLine());

            for (int i = 0; i < veelvoud +1; i++)
            {
                Console.WriteLine(i + ": " + i*getal);
            }
        }
    }
}
