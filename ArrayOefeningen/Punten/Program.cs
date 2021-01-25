using System;

namespace Punten
{
    class Program
    {
        static void Main(string[] args)
        {
            //Maak een array waarin de punten worden ingegeven door de gebruiker. 
            //Er worden 10 punten ingegeven, punten gaan tot 20. Druk af hoeveel 
            //buizen de student heeft.

            int[] punten = new int[10];
            int count = 0;

            Console.WriteLine("vul 10 punten op 20 in.");

            for (int i = 0; i < 10; i++)
            {
                    punten[i] = int.Parse(Console.ReadLine());
                
                if (punten[i] >20) {

                    Console.WriteLine("sorry maar dat kan niet, je zal in de hoek moeten staan.");
                }
            }

            for (int i = 0; i < 10; i++)
            {
                if (punten[i]<10)
                {
                    count++;
                }
            }
            Console.WriteLine("De student heeft " + count + " buizen.");
        }
    }
}
