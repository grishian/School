using System;

namespace kwadraatTwee
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < Math.Sqrt(10000) ; i++)
            {
                Console.Write("Kwadraat van: " + i+ ": ");
                Console.WriteLine(Math.Pow(i, 2));
            }
        }
    }
}
