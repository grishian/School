using System;

namespace LetterOpslagen
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Maak een array met waarin de letter 
             * van een woord worden opgeslagen de 
             * gebruiker geeft het woord in. */

            Console.WriteLine("Geef een woord in: ");

            string woord = Console.ReadLine();
            char[] letterLijst = new char[woord.Length];

            for (int i = 0; i < woord.Length; i++)
            {

                letterLijst[i] = woord[i];

                Console.WriteLine(letterLijst[i]);

            }
        }
    }
}
