using System;

namespace SpelWoord
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welk woord gaan we spellen? : ");
            string woord = Console.ReadLine();

            Console.WriteLine("gespeld woord: ");
            for (int i = 0; i < woord.Length; i++)
            {
                Console.WriteLine(woord[i]);  
            }
        }
    }
}
