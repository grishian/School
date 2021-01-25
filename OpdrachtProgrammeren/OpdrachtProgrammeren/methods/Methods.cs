using System;


namespace OpdrachtProgrammeren.methods
{
    class Methods
    {

        private string[] diensten = new string[3] { "","","" };
        private int leeftijdHuis;
        private double btw;
        private double afstand;
        private double kortingDiensten = 0;
        private double extraKortingDiensten = 0;
        private double extraKortingDiensten2 = 0;
        private string maand = "";

        private double lengte;
        private double breedte;

        private double totOpvMuur;
        private double totOpvDak;

        private double dakKost;
        private double muurKost;
        private double afstandsKost;
        private double gipsplaatPrijs;

        private double[,] muurEnDakPrijzen;
        private double[,] gipsplaatPrijzen;



        //constructor
        public Methods() {
            muurEnDakPrijzen = new double[6, 3] 
            {
                {40, 30, 25 },      //muur startprijs
                {2.4, 2.1, 1.8},    //muuur materiaalkost
                {36, 34, 33},       //muur uurkost
                {35, 30, 25 },      //dak startprijs
                {2.6, 2.2, 2 },     //dak materiaalkost
                {38, 36, 34 }       //dak uurkost
            };

            gipsplaatPrijzen = new double[5, 2]
            {
                {2, 35},            //2cm is 35euro
                {3, 42},
                {4, 47},
                {5, 51},
                {6, 59}
            };
        }


        //dienstenMethodes
        public void DienstenUitvoeren()
        {

            if (diensten[0].Contains("muur") || diensten[1].Contains("muur") || diensten[2].Contains("muur"))
            {
                MuurBerekening();
            }
            if (diensten[0].Contains("dak") || diensten[1].Contains("dak") || diensten[2].Contains("dak"))
            {
                DakBerekening();
            }
            if (diensten[0].Contains("gipsplaat") || diensten[1].Contains("gipsplaat") || diensten[2].Contains("gipsplaat"))
            {
                GipsplaatBerekening();
            }
        }

        public void VraagDiensten()
        {

            Console.WriteLine("\n");
            Console.WriteLine("******************************************************");
            Console.WriteLine("* Hoeveel diensten wilt u doen?(maximum 3):          *");
            Console.WriteLine("******************************************************");
            int aantalDiensten = int.Parse(Console.ReadLine());

            for (int i = 0; i < aantalDiensten; i++)
            {
                Console.WriteLine("\nVul dienst " + (i + 1) + " in(muur/dak/gipsplaat):");
                diensten[i] = Console.ReadLine();
            }

            Console.WriteLine("\nDe gekozen diensten: ");
            for (int i = 0; i < diensten.Length; i++)
            {
                Console.WriteLine($"Dienst {i + 1}: {diensten[i]}");
            }

            if (aantalDiensten > 1)
            {
                kortingDiensten = 5;
            }

            bool eersteConditie = diensten[0] == "muur" || diensten[1] == "muur" || diensten[2] == "muur";
            bool tweedeConditie = diensten[0] == "gipsplaat" || diensten[1] == "gipsplaat" || diensten[2] == "gipsplaat";

            //tweedekorting fixen
            if (eersteConditie && tweedeConditie)
            {
                extraKortingDiensten = 5;
            }

        }


        //leeftijdHuisMethode
        public void VraagLeeftijdHuis()
        {

            Console.WriteLine("\n");
            Console.WriteLine("************************************************");
            Console.WriteLine("* Wat is de leeftijd van u huis?(in jaren):    *");
            Console.WriteLine("************************************************");
            leeftijdHuis = int.Parse(Console.ReadLine());

            if (leeftijdHuis > 25)
            {
                btw = 6;
                Console.WriteLine($"De btw bedraagt dan {btw}%.");
            }
            else
            {
                btw = 21;
                Console.WriteLine($"De btw bedraagt dan {btw}%.");
            }
            Console.WriteLine("\n");
        }


        //maandMethode
        public void MaandKeuze()
        {

            //vraag maand
            Console.WriteLine("\n");
            Console.WriteLine("*************************************************");
            Console.WriteLine("* In welke maand wilt u de diensten uitvoeren?: *");
            Console.WriteLine("*************************************************");

            //steek maand in een string
            maand = Console.ReadLine();

            bool conditie = maand == "september" || maand == "oktober" || maand == "november";

            if (conditie)
            {
                extraKortingDiensten2 = 5;
            }

        }


        //afstand
        public void AfstandsKostBerekening()
        {

            Console.WriteLine("\n");
            Console.WriteLine("************************************************");
            Console.WriteLine("* Berekening voor de afstandskost:             *");
            Console.WriteLine("************************************************");

            Console.WriteLine("Wat is de afstand tot u huis in km?: ");

            afstand = double.Parse(Console.ReadLine());

            if (afstand < 15)
            {
                afstandsKost = 0;
            }
            else
            if (afstand < 50)
            {
                afstandsKost = 5 + (afstand * 0.18);
            }
            else
            if (afstand < 100)
            {
                afstandsKost = 10 + (afstand * 0.17);
            }
            else
            if (afstand > 100)
            {
                afstandsKost = 20 + (afstand * 0.15);
            }

        }


        //muur
        public void MuurKostBerekening()
        {

            int indexKolom = 0;

            double startPrijs;
            double materiaalPrijs;
            double uurKost;

            if (totOpvMuur < 100)
            {
                //doe niets, ik kan de if-statement gewoon weglaten eigenlijk.
            }
            else if (totOpvMuur < 200)
            {
                indexKolom += 1;
            }
            else if (totOpvMuur > 200)
            {
                indexKolom += 2;
            }

            startPrijs = muurEnDakPrijzen[0, indexKolom];
            materiaalPrijs = muurEnDakPrijzen[1, indexKolom] * totOpvMuur;
            uurKost = muurEnDakPrijzen[2, indexKolom] * (totOpvMuur / 30);

            muurKost = startPrijs + materiaalPrijs + uurKost;

            Console.WriteLine("* Prijsonderverdeling muurisolatie: ");
            Console.WriteLine("* Startprijs: " + startPrijs + " euro");
            Console.WriteLine("* Materiaalkost: " + Math.Round(materiaalPrijs,2) + " euro");
            Console.WriteLine("* Gewerkte tijd kost: " + Math.Round(uurKost, 2) + " euro");
            Console.WriteLine("* Totale kost voor de muurisolatie: " + Math.Round(muurKost, 2) + " euro");
        }

        public void MuurBerekening()
        {
            int aantalKamers;
            double eersteMuur;
            double tweedeMuur;

            Console.WriteLine("\n");
            Console.WriteLine("************************************************");
            Console.WriteLine("* Berekening voor de muurisolatie:             *");
            Console.WriteLine("************************************************");

            //meerdere kamers?
            Console.WriteLine("Hoeveel kamers wilt u isoleren?: ");
            aantalKamers = int.Parse(Console.ReadLine());

            for (int i = 0; i < aantalKamers; i++)
            {
                Console.WriteLine($"Kamer {i+1}: ");
                Console.WriteLine("***************");


                //eerste muur opv
                Console.WriteLine("Wat is de lengte van de eerste muur?(in m): ");
                lengte = double.Parse(Console.ReadLine());
                Console.WriteLine("Wat is de hoogte van de eerste muur?(in m): ");
                breedte = double.Parse(Console.ReadLine());

                eersteMuur = opvBerekening();

                //tweede muur opv
                Console.WriteLine("Wat is de lengte van de tweede muur?(in m): ");
                lengte = double.Parse(Console.ReadLine());
                Console.WriteLine("Wat is de hoogte van de tweede muur?(in m): ");
                breedte = double.Parse(Console.ReadLine());

                tweedeMuur = opvBerekening();

                totOpvMuur += eersteMuur + tweedeMuur;


            }
            MuurKostBerekening();
        }


        //dak
        public void DakKostBerekening()
        {

            int indexKolom = 0;

            double startPrijs;
            double materiaalPrijs;
            double uurKost;

            if (totOpvDak < 100)
            {
                //doe niets
            }
            else if (totOpvDak < 200)
            {
                indexKolom += 1;
            }
            else if (totOpvDak > 200)
            {
                indexKolom += 2;
            }

            startPrijs = muurEnDakPrijzen[3, indexKolom];
            materiaalPrijs = muurEnDakPrijzen[4, indexKolom] * totOpvDak;
            uurKost = muurEnDakPrijzen[5, indexKolom] * (totOpvDak / 25);

            dakKost = startPrijs + materiaalPrijs + uurKost;

            //debuggen

            Console.WriteLine("* Prijsonderverdeling dakisolatie: ");
            Console.WriteLine("* Startprijs: " + startPrijs + " euro");
            Console.WriteLine("* Materiaalkost: " + Math.Round(materiaalPrijs, 2) + " euro");
            Console.WriteLine("* Gewerkte tijd kost: " + Math.Round(uurKost, 2) + " euro");
            Console.WriteLine("* Totale kost voor de dakisolatie: " + Math.Round(dakKost, 2) + " euro");

        }

        public void DakBerekening()
        {

            Console.WriteLine("\n");
            Console.WriteLine("************************************************");
            Console.WriteLine("* Berekening voor de dakisolatie:              *");
            Console.WriteLine("************************************************");

            //dak opv
            Console.WriteLine("Wat is de lengte van het dak?(in m): ");
            lengte = double.Parse(Console.ReadLine());
            Console.WriteLine("Wat is de breedte van het dak?(in m): ");
            breedte = double.Parse(Console.ReadLine());

            totOpvDak = opvBerekening();

            DakKostBerekening();
        }


        //gipsplaat
        public void GipsplaatBerekening()
        {
            int gipsplaatDikte;

            Console.WriteLine("\n");
            Console.WriteLine("************************************************");
            Console.WriteLine("* Berekening voor de gipsplaat:                *");
            Console.WriteLine("************************************************");

            Console.WriteLine("Welke dikte van gipsplaat wilt u?\n" +
                "Dit zijn de mogelijkheden: ");


            //code voor maandprijs van gipsplaat met dikte 6.

            bool conditie = maand == "april" || maand == "mei";

            if (conditie)
            {
                gipsplaatPrijzen[4, 1] = 55;
            }

            for (int i = 0; i < gipsplaatPrijzen.GetLength(0); i++)
            {
                Console.WriteLine($"Plaat met dikte: {gipsplaatPrijzen[i, 0]}cm = {gipsplaatPrijzen[i, 1]} euro");
            }

            Console.WriteLine("\nGeef de plaatdikte die u wilt(in cm): ");       //gipsplaat kiezen
            gipsplaatDikte = int.Parse(Console.ReadLine());
            gipsplaatPrijs = gipsplaatPrijzen[(gipsplaatDikte - 2), 1];

            Console.WriteLine($"\nDit is de prijs van de plaat die u koos: {gipsplaatPrijs} euro"); //debuggen: prijs laten zien van gekozen plaat

        }


        //kostBerekening
        public void Kosten() {

            double kosten;
            double kostenBtw;
            double premie;

            kosten = (((
                ((muurKost + gipsplaatPrijs) * (1 - (extraKortingDiensten / 100)))
                + dakKost ) * (1 - (kortingDiensten /100 ))) 
                + afstandsKost) * (1 - (extraKortingDiensten2/100));


            kostenBtw = (kosten * ((btw/100)+1));

            premie = (kostenBtw * 0.95) - 200 ;


            //Examen gevraagde:

            //Totaal kost zonder btw:
            Console.WriteLine($"\n\n\nDe totale kost zonder btw is: {Math.Round(kosten, 2)} euro.");

            //De vervoerskost
            Console.WriteLine($"De vervoerskost bedraagt: {Math.Round(afstandsKost, 2)} euro.");

            //BTW prijs
            Console.WriteLine($"De BTW bedraagt: {btw}%");

            //Totaal kost met btw:
            Console.WriteLine($"De totale kost met btw is: {Math.Round(kostenBtw, 2)} euro.");

            //Prijs met de premie bij:
            Console.WriteLine($"De totale prijs met de premie van de overheid is: {Math.Round(premie, 2)} euro.\n\n\n");

        }


        //kortingen
        public void Kortingen() {

            Console.WriteLine($"Korting bij minstens 2 diensten: {kortingDiensten}%");
            Console.WriteLine($"Korting bij muurisolatie en gipsplaten: {extraKortingDiensten}%");
            Console.WriteLine($"Korting in september, oktober of november {extraKortingDiensten2}%");

            bool conditieMaand = maand == "april" || maand == "mei";
            Console.WriteLine($"Gipsplaat korting in de maanden april of mei: {conditieMaand}");
        }

        //debugMethode

        public void DebugMethode() {
            
            Kortingen();

        
        }


        //oppervlakteBerekening
        public double opvBerekening() {
            return lengte*breedte;
        }


    }
}
