using System;

namespace KlasseVB
{
    class Program
    {
        static void Main(string[] args)
        {
            Persoon p = new Persoon();
            Persoon p2 = new Persoon("Jantje");
            Persoon p3 = new Persoon("Sofie", 19);

            p.DrukId();
            p2.DrukId();
            p3.DrukId();
            p3.DrukAantalPersonen();
            p.DrukAantalPersonen();

            Random randomGenerator = new Random();

            int eersteGetal = randomGenerator.Next();
            int tweedeGetal = randomGenerator.Next();

            Console.WriteLine(eersteGetal + " " + tweedeGetal);
        }
    }
}
