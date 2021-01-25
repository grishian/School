using System;

namespace DeelbaarDoorTwee
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("We gaan berekenen hoeveel keer een getal deelbaar door 2 is.\nGeef een getal: ");
            long getal = long.Parse(Console.ReadLine());

            int index = 1;

            while (getal % 2 == 0) {          

                getal = getal / 2;
                Console.WriteLine(index + ": " + getal);
                index++;
            }
        }
    }
}
