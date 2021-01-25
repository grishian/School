using System;

namespace DeelbaarDoorVijf
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] getallen = new int[13] { 2, 5, 8, 1, 33, 24, 15, 24, 1, 18, 17, 11, 4 };
            int count = 0;

            for (int i = 0; i < getallen.Length; i++)
            {

                if (getallen[i]%5==0)
                {
                    count++;
                }

            }

            Console.WriteLine("Er zijn " + count + " getallen die deelbaar zijn door vijf");




        }
    }
}
