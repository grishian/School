using System;

namespace Operatoroverloading
{
    class Program
    {
        static void Main(string[] args)
        {
            Breuk breuk1 = new Breuk(388, 6677);
            Console.WriteLine("The breuk 1 is: {0}", breuk1.ToString());
            Breuk breuk2 = new Breuk(205, 47);
            Console.WriteLine("the bruek2 is: {0}", breuk2.ToString());
            Breuk sum = breuk1 + breuk2;
            Console.WriteLine("The output of breuk1+breuk2 is: {0}", sum.ToString());



        }
    }
}
