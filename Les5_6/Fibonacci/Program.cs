using System;

namespace Fibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            ulong[] fibonacci = new ulong[100];
            fibonacci[0] = 0;
            fibonacci[1] = 1;

            Console.WriteLine(":)" + 0 + " :" + fibonacci[0]);
            Console.WriteLine(":)" + 1 + " :" + fibonacci[1]);

            for (int i = 2; i < 98; i++)
            {
                fibonacci[i] = fibonacci[i - 2] + fibonacci[i - 1];

                Console.WriteLine(":)" + i + " :" + fibonacci[i]);

            }
        }
    }
}
