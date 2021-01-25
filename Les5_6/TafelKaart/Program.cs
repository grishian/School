using System;

namespace TafelKaart
{
    class Program
    {
        static void Main(string[] args)
        {

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("veelvoud " + (i + 1) + " :");
                for (int y = 0; y < 10; y++)
                {

                    int uitkomst = (i + 1) * (y + 1);

                    Console.WriteLine( i+1 +" : " + uitkomst);

                }
            }
        }
    }
}
