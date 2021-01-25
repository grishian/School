using OpdrachtProgrammeren.methods;
using System;

namespace OpdrachtProgrammeren
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Welkom. \n\n- Als u minstens 2 diensten bij ons neemt krijgt u 5% korting " +
                "op al de genomen diensten.\n\n" +
                "- De btw wordt berekend op de leeftijd van uw huis. \n" +
                "   - huizen ouder dan 25 jaar bedragen 6% btw\n" +
                "   - huizen jonger dan 25 jaar bedragen 21% btw\n\n" +
                "- Extra kortingen: \n" +
                "   - Bij aankoop van muurisolatie en gipsplaat krijgt u 5% extra korting op deze werken.\n" +
                "   - Klanten die werken uitvoeren in de maanden september, oktober of november krijgen een extra korting van 5%\n" +
                "   - De gipsplaat met dikte 6cm kost in de maanden april en mei 55 euro in plaats van 59 euro\n" +
                "   - Op de totaal prijs krijgt de klant van de overheid een premie van 200 euro + 5%\n" +
                "       - Dit betekent concreet: het is mogelijk dat u meer geld krijgt dan u uitgeeft.\n");

            Methods bestelling = new Methods();

            bestelling.VraagLeeftijdHuis();
            bestelling.MaandKeuze();
            bestelling.AfstandsKostBerekening();
            bestelling.VraagDiensten();
            bestelling.DienstenUitvoeren();
            bestelling.Kosten();
            bestelling.DebugMethode();

        }
    }
}
