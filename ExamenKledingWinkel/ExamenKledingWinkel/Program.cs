using System;

namespace ExamenKledingWinkel
{
    class Program
    {
        static void Main(string[] args)
        {
            string geslacht = "";

            string[] manKledij = new string[5] { "hemd", "broek", "blazer", "kostum", "das" };
            double[] manPrijs = new double[5] { 10, 20, 25, 50, 5 };
            string[] vrouwKledij = new string[3] { "galakleed", "zwart kleedje", "rood kleedje" };
            double[] vrouwPrijs = new double[3] { 50, 30, 30 };

            int aantalKleren;
            double prijsZonderBtwEnWaarborg = 0;
            int geleendeDagen;
            double totaalPrijs = 0;
            double btw = 1.21;


            Console.WriteLine("Hallo, bent u een man of een vrouw?: ");
            geslacht = Console.ReadLine();

            if (geslacht == "man")
            {
                Console.WriteLine("Dit zijn de kleren voor mannen: ");
                for (int i = 0; i < manKledij.Length; i++)
                {
                    Console.WriteLine($"Kledingstuk {i + 1}: {manKledij[i]} {manPrijs[i]} euro.");

                }
            }
            else
            {
                Console.WriteLine("Dit zijn de kleren voor vrouwen: ");
                for (int i = 0; i < vrouwKledij.Length; i++)
                {
                    Console.WriteLine($"Kledingstuk {i + 1}: {vrouwKledij[i]} {vrouwPrijs[i]} euro.");

                }
            }

            Console.WriteLine("\nHoeveel kleren wilt u lenen?:");
            aantalKleren = int.Parse(Console.ReadLine());

            string[] klerenLijst = new string[20];

            //kleren in een lijst steken.
            for (int i = 0; i < aantalKleren; i++)
            {

                Console.WriteLine($"Geef kleed {i + 1} in: ");
                klerenLijst[i] = Console.ReadLine();

            }




            if (geslacht == "man")
            {

                if (klerenLijst[0] == "das" || klerenLijst[1] == "das" || klerenLijst[2] == "das" || klerenLijst[3] == "das" || klerenLijst[4] == "das")
                {
                    prijsZonderBtwEnWaarborg += 5;
                }

                if (klerenLijst[0] == "hemd" || klerenLijst[1] == "hemd" || klerenLijst[2] == "hemd" || klerenLijst[3] == "hemd" || klerenLijst[4] == "hemd")
                {
                    prijsZonderBtwEnWaarborg += 10;
                }

                if (klerenLijst[0] == "broek" || klerenLijst[1] == "broek" || klerenLijst[2] == "broek" || klerenLijst[3] == "broek" || klerenLijst[4] == "broek")
                {
                    prijsZonderBtwEnWaarborg += 20;
                }

                if (klerenLijst[0] == "blazer" || klerenLijst[1] == "blazer" || klerenLijst[2] == "blazer" || klerenLijst[3] == "blazer" || klerenLijst[4] == "blazer")
                {
                    prijsZonderBtwEnWaarborg += 25;
                }

                if (klerenLijst[0] == "kostum" || klerenLijst[1] == "kostum" || klerenLijst[2] == "kostum" || klerenLijst[3] == "kostum" || klerenLijst[4] == "kostum")
                {
                    prijsZonderBtwEnWaarborg += 50;
                }

            }
            else
            {
                if (klerenLijst[0] == "galakleed" || klerenLijst[1] == "galakleed" || klerenLijst[2] == "galakleed")
                {
                    prijsZonderBtwEnWaarborg += 50;
                }

                if (klerenLijst[0] == "zwart kleedje" || klerenLijst[1] == "zwart kleedje" || klerenLijst[2] == "zwart kleedje")
                {
                    prijsZonderBtwEnWaarborg += 30;
                }

                if (klerenLijst[0] == "rood kleedje" || klerenLijst[1] == "rood kleedje" || klerenLijst[2] == "rood kleedje")
                {
                    prijsZonderBtwEnWaarborg += 30;
                }


            }

            Console.WriteLine($"\nDe prijs voor deze kleren bedraagt {prijsZonderBtwEnWaarborg} euro. Niet vergeten: dit is zonder btw en een eventuele prijsverhoging!");

            Console.WriteLine("U mag ondertussen al 25 euro waarborg betalen.");
            //zeg hoeveel extra ze moeten betalen als hij of zij te laat is.
            Console.WriteLine("Als u 1 dag leent, dan moet u de normale prijs betalen.");
            Console.WriteLine("Als u 2 dagen leent dan moet u 25% extra betalen (zonder btw)");
            Console.WriteLine("Als u 3 dagen leent dan moet u 50% extra betalen (zonder btw)");
            Console.WriteLine("...");
            Console.WriteLine("Hoeveel dagen heeft de klant geleend?");

            geleendeDagen = int.Parse(Console.ReadLine());

            double prijsMetBoete = 0;

            if (geleendeDagen == 2)
            {
                prijsMetBoete = prijsZonderBtwEnWaarborg * 1.25;
            }
            else if (geleendeDagen == 3)
            {
                prijsMetBoete = prijsZonderBtwEnWaarborg * 1.50;
            }

            double berekenBTW(double bedragExBtw, double btwTarief)
            {



                totaalPrijs = bedragExBtw * btwTarief;
                return totaalPrijs;

            }

            Console.WriteLine($"Oke u hebt {geleendeDagen} dagen geleend. U krijgt u waarborg van 25 terug.");

            Console.WriteLine($"De totale prijs met boete en btw bedraagt: {berekenBTW(prijsMetBoete, btw)} euro.");




        }
    }
}
