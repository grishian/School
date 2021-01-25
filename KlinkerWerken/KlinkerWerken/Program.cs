using System;

namespace KlinkerWerken
{
    class Program
    {
        static void Main(string[] args)
        {

            char letter;
            double prijsPerVierkanteMeter;
            double afstand;
            double afstandsPrijs;
            string figuur = "";
            double basis;
            double hoogte;
            double zijde;
            double oppervlakte;
            double prijsPerUur = 30;
            double prijsKlinkersTot;



            Console.WriteLine("Met welke klinkers wilt u werken?\n" +
                "Types:             Prijs per m^2 ex btw:\n" +
                "- A = klein        8 euro\n" +
                "- B = middelmatig  10 euro\n" +
                "- C = Groot        12 euro\n");

            Console.WriteLine("Vul de juiste letter in(hoofdletter):");

            letter = char.Parse(Console.ReadLine());

            if (letter == 'A')
            {
                prijsPerVierkanteMeter = 8;
            }
            else if (letter == 'B')
            {
                prijsPerVierkanteMeter = 10;
            }
            else
            {
                prijsPerVierkanteMeter = 12;
            }


            Console.WriteLine("\nHoe ver moeten we ons verplaatsen(km)?: ");
            afstand = double.Parse(Console.ReadLine());

            if (afstand < 10)
            {
                afstandsPrijs = 5;
            }
            else if (afstand > 10)
            {
                afstandsPrijs = 5 * (afstand * 0.2);
            }
            else
            {
                afstandsPrijs = 10 * (afstand * 0.25);
            }

            double berekenOppervlakVierkant(double zijde)
            {
                return zijde * zijde;
            }

            double berekenOppervlakRechthoek(double basis, double hoogte)
            {
                return basis * hoogte;
            }

            Console.WriteLine("\nWilt u een vierkantig oppervlak doen of een rechthoeking oppervlak?(vierkant/rechthoek):");
            figuur = Console.ReadLine();

            if (figuur == "rechthoek")
            {
                Console.WriteLine("Wat is de basis?: ");
                basis = double.Parse(Console.ReadLine());
                Console.WriteLine("Wat is de hoogte?: ");
                hoogte = double.Parse(Console.ReadLine());

                oppervlakte = berekenOppervlakRechthoek(basis, hoogte);
            }
            else
            {
                Console.WriteLine("Geef een zijde van het vierkant: ");
                zijde = double.Parse(Console.ReadLine());

                oppervlakte = berekenOppervlakVierkant(zijde);
            }

            void Uitkomst(double oppervlakteFiguur, double afstandTotLocatie)
            {

                prijsKlinkersTot = (oppervlakteFiguur / 10) * 30 * prijsPerVierkanteMeter;

                Console.WriteLine(String.Format($"\n{oppervlakte} m^2 klinkers: \n" +
                    $"Aantal oppervlak klinkers type {letter}: {oppervlakte}\n\n" +
                    $"Prijs ex btw(werk en klinkers): {prijsKlinkersTot} euro.\n" +
                    $"Verplatingskost: {afstandsPrijs} euro.\n" +
                    $"Prijs incl. btw: {prijsKlinkersTot * 1.21} euro.\n\n" +
                    $"Prijs incl btw + verplaatsingskost (geen btwafname bij verplaatsing): {((prijsKlinkersTot * 1.21) + afstandsPrijs)} euro."
                    ));
            }

            Uitkomst(oppervlakte, afstand);

        }
    }
}
