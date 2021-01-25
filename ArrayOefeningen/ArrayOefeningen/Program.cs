using System;

namespace ArrayOefeningen
{
    class Program
    {
        static void Main(string[] args)
        {

            double[] punten = new double[6];
            double gemiddelde = 0;

            Console.WriteLine("Geef de punten maar in he.");
            for (int i = 0; i < punten.Length; i++)
            {
                //punten op 20

                if (punten[i] <= 20)
                {
                    punten[i] = double.Parse(Console.ReadLine());
                }
                else { 
                    Console.WriteLine("Euh sorry dat mag niet."); 
                }

                
            }

            //feedback

            for (int i = 0; i < punten.Length; i++)
            {

                gemiddelde += punten[i];

            }

            gemiddelde = gemiddelde / 6;

            Console.WriteLine("Het gemiddelde is:" + gemiddelde);

            if (gemiddelde < 30)
            {
                Console.WriteLine("Zware onvoldoende");
            }
            else if (gemiddelde < 50)
            {
                Console.WriteLine("onvoldoende");
            }
            else if (gemiddelde < 60)
            {
                Console.WriteLine("voldoende");
            }
            else if (gemiddelde < 75)
            {
                Console.WriteLine("goed");
            }
            else if (gemiddelde < 90)
            {
                Console.WriteLine("Zeer goed");
            }
            else if (gemiddelde > 90 && gemiddelde <=100)
            {
                Console.WriteLine("uitstekend");
            }
            else {
                Console.WriteLine("Onmogelijk");
            }






        }
    }
}
