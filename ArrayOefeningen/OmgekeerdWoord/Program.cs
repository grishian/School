using System;

namespace OmgekeerdWoord
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Geef een woord in: ");
            string woord = Console.ReadLine();

            string[] omgekeerdWoord = new string[woord.Length];

            for (int i = woord.Length-1; i >= 0; i--)
            {


                Console.Write(woord[i]);
            }
        }
    }
}
