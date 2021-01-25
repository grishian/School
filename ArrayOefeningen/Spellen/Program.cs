using System;

namespace Spellen
{
    class Program
    {
        static void Main(string[] args)
        {

            /* Maak een array waarin opnieuw gespeld wordt met een extra letter. Dus het woord voetbal.
            V vo voe voet voetb voetba voetbal. */

            Console.WriteLine("Geef een woord in: ");
            string woord = Console.ReadLine();



            char[] letters = new char[woord.Length];

            for (int i = 0; i < letters.Length; i++)
            {

                letters[i] = woord[i];

                for (int y = 0; y < letters.Length; y++)
                {
                    Console.Write(letters[y]);
                }

            }
        }
    }
}
