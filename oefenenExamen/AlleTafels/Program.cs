using System;

namespace AlleTafels
{
    class Program
    {
        static void Main(string[] args)
        {
            //maak een tabel met alle tafels

            //int[] getalX = new int[10];
            //int[] getalY = new int[10];
            int[,] tabel = new int[10, 10];

            /*Dus te moeilijk gemaakt: enkel de laatste 2 forloops zijn in deze oefening nodig.
            //getalX array invullen met getallen 1-10
            for (int x = 0; x < getalX.Length; x++)
            {
                getalX[x] = x+1;
            }

            //getalY array invullen met getallen 1-10
            for (int y = 0; y < getalY.Length; y++)
            {
                getalY[y] = y+1;
            }
            */

            //tabel vullen met de tafels tot en met 100
            for (int x = 0; x < tabel.GetLength(0); x++)
            {
                for (int y = 0; y < tabel.GetLength(1); y++)
                {
                    tabel[x, y] = (x + 1) * (y + 1);
                }
            }

            //tabel met tafels afdrukken in console
            for (int x = 0; x < tabel.GetLength(0); x++)
            {
                for (int y = 0; y < tabel.GetLength(1); y++)
                {
                    Console.Write(tabel[x,y] + " ");
                }
                Console.WriteLine("\n");
            }
        }
    }
}
