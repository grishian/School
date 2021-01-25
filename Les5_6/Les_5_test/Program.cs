using System;

namespace Les_5_test
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Geef je getal:");

            int getal = int.Parse(Console.ReadLine());

            if (getal < 1000)
            {
                string speciaalGetal = Convert.ToString(getal);

                Console.WriteLine("eenheid: " + speciaalGetal[speciaalGetal.Length - 1]);
                Console.WriteLine("tiental: " + speciaalGetal[speciaalGetal.Length - 2]);
                Console.WriteLine("honderdtal: " + speciaalGetal[speciaalGetal.Length - 3]);
            }
        }
    }
}
