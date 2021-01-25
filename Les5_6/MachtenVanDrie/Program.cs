using System;

namespace MachtenVanDrie
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("we gaan is tien machten van drie laten zien:");

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("macht " + i + " van 3: " + Math.Pow(3, i));

            }
        }
    }
}
