using System;

namespace KleinsteGetal
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] getallen = new int[13] {2,5,8,1,33,24,15,24,1,18,17,11,4 };

            int kleinsteGetal = 100;

            for (int i = 0; i < getallen.Length; i++)
            {               

                if (kleinsteGetal > getallen[i])
                {
                    kleinsteGetal = getallen[i];
                }

                Console.WriteLine(kleinsteGetal);
            }
        }
    }
}
