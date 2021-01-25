using System;

namespace Schrikkeljaar
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("geef mij een jaartal");
                int jaar = int.Parse(Console.ReadLine());


                if (jaar % 400 == 0 || jaar % 4 == 0)
                {

                    Console.WriteLine("getal " + (i + 1) + " is een schrikkeljaar: ");


                }
                else if (jaar % 4 == 0 && jaar % 100 == 0)
                {

                    Console.WriteLine("Nee dit is geen schrikkeljaar.");
                }
                else {

                    Console.WriteLine("Nee dit is geen schrikkeljaar.");

                }






            }




        }
    }
}
