using System;

namespace VeelvoudenAcht
{
    class Program
    {
        static void Main(string[] args)
        {

            int getal = 8;
            // met een while is nog efficienter
            for (int i = 0; i < 200/8; i++)
            {
                Console.WriteLine(getal*i);
            }
        }
    }
}
