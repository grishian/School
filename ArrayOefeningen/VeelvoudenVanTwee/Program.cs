using System;

namespace VeelvoudenVanTwee
{
    class Program
    {
        static void Main(string[] args)
        {
            //Maak een array waarin alle veelvouden 
            //van 2 tot 100 worden in opgeslagen. Druk enkel de 
            //getallen af die deelbaar door 4 zijn.

            int[] veelvouden = new int[100 / 2];

            for (int i = 0; i < veelvouden.Length; i++)
            {
                veelvouden[i] = (2 * i)+2;
            }

            for (int i = 0; i < veelvouden.Length; i++)
            {
                if (veelvouden[i]%4==0)
                {
                    Console.WriteLine("getal " + veelvouden[i]+ " is deelbaar door 4");
                }
            }
        }
    }
}
