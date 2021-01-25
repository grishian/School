using System;

namespace Kinderboerderij
{
    class Program
    {
        static void Main(string[] args)
        {
            //hoofklasse nodig om bepaalde klasses te verbinden (niets overgeerfd)
            Boerderij kinderBoerderij = new Boerderij();

            //verzorgers aannemen
            Verzorger verzorgerOne = new Verzorger("De bakker", "Simon", 19, 1550, "Wolvertem", kinderBoerderij);
            Verzorger verzorgerTwo = new Verzorger("Jansens", "Robin", 25, 1650, "Lier", kinderBoerderij);
            Verzorger verzorgerThree = new Verzorger("Schuermans", "Marijke", 19, 1600, "Lubbeek", kinderBoerderij);
            Verzorger verzorgerFour = new Verzorger("Walschearts", "Wim", 22, 1700, "Antwerpen", kinderBoerderij);
            Verzorger verzorgerFive = new Verzorger("Gracida", "Grishian", 23, 4000, "Morkhoven", kinderBoerderij);


            //zone aanmaken
            Zone zoneOne = new Zone("Het kippenhok", verzorgerOne, 200, 30, kinderBoerderij);
            Zone zoneTwo = new Zone("De geitenstal", verzorgerTwo, 400, 30, kinderBoerderij);
            Zone zoneThree = new Zone("De ganzentuin", verzorgerThree, 500, 40, kinderBoerderij);
            Zone zoneFour = new Zone("De schapenweide", verzorgerFour, 500, 30, kinderBoerderij);
            Zone zoneFive = new Zone("De ezelsprairie", verzorgerFive, 500, 10, kinderBoerderij);

            //voedsel inkopen
            Voedsel voedselOne = new Voedsel("Mais", 800, 1.3 ); //soortelijk gewicht kg/m^3    1.3 euro/kilo
            Voedsel voedselTwo = new Voedsel("Hooibaal", 20, 0.2); //gewicht kleine baal        0.2 euro/kilo
                                                                   //dieren eten natuurlijk meer gevarieerd.

            //*****************************************************************************************************************************
            //kippen maken
            Dier k1 = new Dier("Sven", "kip", zoneOne, 2, voedselOne, 0.150);

            zoneOne.KindVan(k1,20);         //vader is sven, kinderen:20

            //geiten maken
            Dier g1 = new Dier("Zeno", "geit",zoneTwo, 3, voedselTwo, 0.4);

            zoneTwo.KindVan(g1, 15);        //vader is zeno, kinderen:15

            //ganzen maken
            Dier s1 = new Dier("Dirk", "gans", zoneThree, 4, voedselOne, 0.2);

            zoneThree.KindVan(s1, 25);        //vader is dirk, kinderen:25

            //schapen maken
            Dier sch1 = new Dier("Dennis", "schaap", zoneFour, 3, voedselTwo, 0.4);

            zoneTwo.KindVan(sch1, 15);        //vader is dennis, kinderen:15

            //ezels maken
            Dier e1 = new Dier("Vincent", "ezel", zoneFive, 7, voedselTwo, 0.8);

            zoneTwo.KindVan(e1, 8);        //vader is vincent, kinderen:8


            //Bezoekers maken
            Console.WriteLine($"Overzicht bezoekers kinderboerderij: momenteel {kinderBoerderij.bezoekerCounter} bezoekers\n");

            Bezoeker b1 = new Bezoeker("Tim", 3, false, kinderBoerderij);
            Bezoeker b2 = new Bezoeker("Elisabeth", 15, false, kinderBoerderij);
            Bezoeker b3 = new Bezoeker("Tes", 17, false, kinderBoerderij);
            Bezoeker b4 = new Bezoeker("Best", 20, true, kinderBoerderij);

            Console.WriteLine($"\nDe stand momenteel bedraagt: {kinderBoerderij.bezoekerCounter} bezoekers");






            //output
            Console.WriteLine("\n\n");
            
            kinderBoerderij.BoerderijToonZones();

            /*Waarschuwming: zet in comment als teveel text*/
            Console.ResetColor();
            Console.WriteLine("Alle dieren in de zoneOne + totaalprijs\n");
            Console.WriteLine(zoneOne.ZoneInfo());
            zoneOne.ZoneAlleDierInfo();                                   
            Console.WriteLine(zoneOne.ZoneDierVoederKostTotaal());

            Console.ResetColor();
            Console.WriteLine("\n\nAlle dieren in de zoneTwo + totaalprijs\n");
            Console.WriteLine(zoneTwo.ZoneInfo());
            zoneTwo.ZoneAlleDierInfo();
            Console.WriteLine(zoneTwo.ZoneDierVoederKostTotaal());

            Console.ResetColor();
            Console.WriteLine("\n\nAlle dieren in de zoneThree + totaalprijs\n");
            Console.WriteLine(zoneThree.ZoneInfo());
            zoneThree.ZoneAlleDierInfo();
            Console.WriteLine(zoneThree.ZoneDierVoederKostTotaal());

            Console.ResetColor();
            Console.WriteLine("\n\nAlle dieren in de zoneFour + totaalprijs\n");
            Console.WriteLine(zoneFour.ZoneInfo());
            zoneFour.ZoneAlleDierInfo();
            Console.WriteLine(zoneFour.ZoneDierVoederKostTotaal());

            Console.ResetColor();
            Console.WriteLine("\n\nAlle dieren in de zoneFour + totaalprijs\n");
            Console.WriteLine(zoneFive.ZoneInfo());
            zoneFive.ZoneAlleDierInfo();
            Console.WriteLine(zoneFive.ZoneDierVoederKostTotaal());

            Console.WriteLine($"De totale kost van alle zones samen bedraagt: {kinderBoerderij.TotaalKostAlleZones()} euro voor 1 dag.");

            Console.ResetColor();
            Console.WriteLine("\n\nAl de verzorgers: ");
            kinderBoerderij.BoerderijToonVerzorgers();
            //kosten van verzorgers eventueel weergeven
            Console.ResetColor();

            Console.WriteLine("\n\nAl de bezoekers: ");
            kinderBoerderij.BoerderijToonBezoekers();
            Console.WriteLine($"De totale opbrengst voor vandaag van de bezoekers bedraagt: {kinderBoerderij.BoerderijTotaalprijsBezoekers()} euro.");




            //extra output

           
            //public Dier(string naam, string soort, Zone zone, int leeftijd, Voedsel voedsel, double etenPerDag)


            //geef de verzorgers nog opslag!
            Console.ResetColor();
        }
    }
}
