using System;

namespace Teambuilding
{
    class Program
    {
        static void Main(string[] args)
        {


            
            Deelnemer deelnemer1 = new Deelnemer("Jos", "Smith", 20);
            Deelnemer deelnemer2 = new Deelnemer("Luci", "De devil", 20);
            Deelnemer deelnemer3 = new Deelnemer("Zod", "King", 20);
            Deelnemer deelnemer4 = new Deelnemer("Bean", "Princes", 20);
            Deelnemer deelnemer5 = new Deelnemer("Geralt", "River", 20);
            Deelnemer deelnemer6 = new Deelnemer("Ash", "Ketchup", 20);
            Deelnemer deelnemer7 = new Deelnemer("Brok", "Stone", 20);
            Deelnemer deelnemer8 = new Deelnemer("Misty", "Fish", 20);
            Deelnemer deelnemer9 = new Deelnemer("Meliodas", "Deamon", 20);
            Deelnemer deelnemer10 = new Deelnemer("Spirit", "Horse", 20);
            Deelnemer deelnemer11 = new Deelnemer("Lime", "Juice", 20);
            Deelnemer deelnemer12 = new Deelnemer("Euhm", "Ja", 20);


            Begeleider begeleider1 = new Begeleider("Zeke", "De Donder", 30);
            Begeleider begeleider2 = new Begeleider("Dennis", "Vanhoven", 30);
            Begeleider begeleider3 = new Begeleider("Derik", "Von dreamland", 30);

            begeleider1.AddAttest("muurklimattest");
            begeleider1.AddAttest("duikattest");
            begeleider1.AddAttest("parachuteattest");
            begeleider2.AddAttest("parachuteattest");
            begeleider3.AddAttest("duikattest");
            begeleider3.AddAttest("muurklimattest");

            Activiteit activiteit1 = new Muurklimmen(false, begeleider1, 10.5);
            Activiteit activiteit2 = new ParachuteSpringen(true, begeleider2, 12);
            Activiteit activiteit3 = new Duiken(true, begeleider3, 12);


            Inschrijving inschrijving1 = new Inschrijving(deelnemer1, activiteit1, new DateTime(2020, 12, 26, 10, 30, 0));
            Inschrijving inschrijving2 = new Inschrijving(deelnemer2, activiteit2, new DateTime(2020, 12, 26, 10, 30, 0));
            Inschrijving inschrijving3 = new Inschrijving(deelnemer3, activiteit3, new DateTime(2020, 12, 26, 10, 30, 0));
            Inschrijving inschrijving4 = new Inschrijving(deelnemer4, activiteit1, new DateTime(2020, 12, 26, 10, 30, 0));
            Inschrijving inschrijving5 = new Inschrijving(deelnemer5, activiteit2, new DateTime(2020, 12, 26, 10, 30, 0));
            Inschrijving inschrijving6 = new Inschrijving(deelnemer6, activiteit3, new DateTime(2020, 12, 26, 10, 30, 0));
            Inschrijving inschrijving7 = new Inschrijving(deelnemer7, activiteit1, new DateTime(2020, 12, 26, 10, 30, 0));
            Inschrijving inschrijving8 = new Inschrijving(deelnemer8, activiteit2, new DateTime(2020, 12, 26, 10, 30, 0));
            Inschrijving inschrijving9 = new Inschrijving(deelnemer9, activiteit3, new DateTime(2020, 12, 26, 10, 30, 0));
            Inschrijving inschrijving10 = new Inschrijving(deelnemer10, activiteit1, new DateTime(2020, 12, 26, 10, 30, 0));
            Inschrijving inschrijving11 = new Inschrijving(deelnemer11, activiteit2, new DateTime(2020, 12, 26, 10, 30, 0));
            Inschrijving inschrijving12 = new Inschrijving(deelnemer12, activiteit3, new DateTime(2020, 12, 26, 10, 30, 0));

            //nieuwe inschrijving doen voor een deelnemer door gewoon een nieuwe "Inschrijving" te maken.
            Inschrijving inschrijving13 = new Inschrijving(deelnemer7, activiteit2, new DateTime(2020, 12, 26, 10, 30, 0));



            //dit is de lijst van al de activiteiten met bijhorende inschrijvingen.
            foreach (Activiteit activiteit in Activiteit.activiteiten)
            {
                Console.WriteLine($"{activiteit}:\nInschrijvingen:\n");

                foreach (Inschrijving inschrijving in activiteit.inschrijvingenBijActiviteit)
                {
                    Console.WriteLine((activiteit.inschrijvingenBijActiviteit.IndexOf(inschrijving) + 1 )+ "\n" + inschrijving.ToString());
                }
            }


            //Dit is de methode om dingen op te zoeken

            Console.WriteLine("***");
            Activiteit.ZoekIetsOp(begeleider1);
            Console.WriteLine("***");
            Activiteit.ZoekIetsOp(deelnemer7);
            Console.WriteLine("***");
            Activiteit.ZoekIetsOp(activiteit2);
            Console.WriteLine("***");

        }
    }
}
