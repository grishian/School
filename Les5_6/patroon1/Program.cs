using System;

namespace patroon1
{
    class Program
    {
        static void Main(string[] args)
        {

            /* Maak dit patroon
             X
             XX
             XXX
             XXXX
                 */

            for (int i = 0; i < 10; i++)
            {
                int x = i;

                while (x>1)
                {
                    Console.Write("X");
                    x--;
                }
                Console.WriteLine();             
            }
        }
    }
}
