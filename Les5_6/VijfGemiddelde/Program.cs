using System;

namespace VijfGemiddelde
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Geef mij 5 getallen aub: ");
            int[] getallen = new int[5];
            double optelling = 0;

            for (int i = 0; i < 5; i++)
            {

                getallen[i] = int.Parse(Console.ReadLine());


            }

            for (int i = 0; i < 5; i++)
            {

                optelling += getallen[i];

            }

            Console.WriteLine("Het gemiddelde van deze 5 getallen is: " + optelling/5);

        }
    }
}
