using System;

namespace Les7
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] getallen = new double[4];
            double kleinsteGetal = 999999999;

            Console.WriteLine("Geef 4 getallen in:");

            for (int i = 0; i < getallen.Length; i++)
            {
                getallen[i] = double.Parse(Console.ReadLine());
            }

            for (int i = 0; i < getallen.Length; i++)
            {

                if (getallen[i] < kleinsteGetal)
                {
                    kleinsteGetal = getallen[i];

                }

            }
            Console.WriteLine("dit is het kleinste getal: ");
            Console.WriteLine(kleinsteGetal);
            //blijkbaar werken kommagetallen niet.
        }
    }
}
