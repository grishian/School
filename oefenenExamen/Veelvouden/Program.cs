using System;

namespace Veelvouden
{
    class Program
    {
        static void Main(string[] args)
        {

            //maak tabel met veelvouden van 2: tabel 5 op 5

            int[,] veelvouden = new int[5,5];
            int veelvoudVan = 2;
            int zoveelsteVeelvoud = 0;

            for (int i = 0; i < veelvouden.GetLength(0); i++)
            {
                for (int y = 0; y < veelvouden.GetLength(1); y++)
                {
                    veelvouden[i, y] = veelvoudVan * zoveelsteVeelvoud;

                    zoveelsteVeelvoud++;
                }
            }

            for (int i = 0; i < veelvouden.GetLength(0); i++)
            {
                for (int y = 0; y < veelvouden.GetLength(1); y++)
                {
                    Console.Write(veelvouden[i, y] + " ");
                }
                Console.WriteLine();
            }








        }
    }
}
