using System;
using System.Linq;

namespace LangsteNaam
{
    class Program
    {
        static void Main(string[] args)
        {

            string[] namen = new string[5] {"test","jan","grishian","hallow","jawade" };

            int grootte = 0;
            string grootsteNaam = "";

            for (int i = 0; i < namen.Length; i++)
            {

                if (grootte<namen[i].Length)
                {
                    grootte = namen[i].Length;
                    grootsteNaam = namen[i];

                }

                Console.WriteLine(grootsteNaam);

            }



        }
    }
}
