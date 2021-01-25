using System;

namespace TexBasedGame3
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
                verzin iets op een skil met waarde: 0
                potion: zoveel percent van u max stat.

            */


            //optie geven om een volledige champion te maken, maar liever niet, want we gaan toch customizen
            Champion c1 = new Champion();
            c1.healPotions = 3;
            c1.strengthPotions = 3;
            Enemy e1 = new Enemy();


            //customizen

            Console.WriteLine(c1.Customize());
            //Champion c2 = new Champion("Sven", 300, 3, 3, 1,100);
            Enemy e2 = new Enemy("Murlough", 500, 3, 3, 4);
            Battle b1 = new Battle(e2, c1);
            Console.WriteLine("jij:");
            //Console.WriteLine(c2.ShowStats());
            Console.WriteLine(c1.ShowStats());
            Console.WriteLine("Jouw enemy:");
            Console.WriteLine(e2.ShowStats());


            //start de battle
            Console.ResetColor();

            b1.Gevecht();


            //testomgeving

            /*
            Champion c2 = new Champion("Sven", 300, 3, 3, 1);
            Enemy e2 = new Enemy("Murlough", 500, 3, 3, 4);
            Battle b2 = new Battle(e2, c2);
            b2.Gevecht();
            */


        }
    }
}
