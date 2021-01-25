using System;

namespace TabelVeelvouden2
{
    class Program
    {
        static void Main(string[] args)
        {

            int[,] veelvoudenVanTwee = new int[5, 5];
            int veelvoud = 2;
            int teller = 1;

            for (int i = 0; i < veelvoudenVanTwee.GetLength(0); i++)
            {
                for (int y = 0; y < veelvoudenVanTwee.GetLength(1); y++)
                {
                    veelvoudenVanTwee[i, y] = teller * veelvoud;
                    teller++;
                }
            }

            for (int i = 0; i < veelvoudenVanTwee.GetLength(0); i ++)
            {
                for (int y = 0; y < veelvoudenVanTwee.GetLength(1); y ++)
                {
                    Console.Write(veelvoudenVanTwee[i,y]+ " ");
                }
                Console.WriteLine("\n");
            }
        }
    }
}
