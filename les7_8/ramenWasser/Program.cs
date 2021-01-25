using ramenWasser.methods;
using System;

namespace ramenWasser
{
    class Program
    {
        static void Main(string[] args)
        {

            double oppervlakte = Kost.raamOppervlak();

            double kost = Kost.kost(oppervlakte);
            double loon = Kost.loon(oppervlakte);
            double totaalLoon = Kost.totaalLoon(loon, kost);

            Console.WriteLine(string.Format("De prijs zonder kosten is: {0} euro\n" +
                "de kosten zijn : {1} euro\n" +
                "de totaalprijs zal dan {2} euro zijn", loon, kost, totaalLoon));
        }
    }
}
