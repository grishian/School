using System;

namespace TekstHerhalen
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Geef mij de tekst dat je wilt herhalen: ");
            string tekst = Console.ReadLine();

            Console.WriteLine("hoeveel keer wil je het heralen?: ");
            int aantal = int.Parse(Console.ReadLine());

            for (int i = 0; i < aantal; i++) {

                Console.WriteLine(tekst);
            
            
            }





        }
    }
}
