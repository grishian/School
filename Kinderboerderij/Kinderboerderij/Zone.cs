using System;

namespace Kinderboerderij
{
    class Zone
    {
        //fields and properties
        public Dier[] dieren = new Dier[50];

        public int aantalDieren = 0;
        private string zoneNaam { get; set; } 
        private Verzorger zoneVerzorger { get; set; }
        private double zoneOppervlakte { get; set; } //in vierkante meter
        private int zoneCapaciteit { get; set; }
        public int zoneDierId { get; set; }
        private Boerderij zoneBoerderij;

        private ConsoleMethods specialMethods = new ConsoleMethods();

        public double prijsVoederInZone { get; set; }


        //constructors
        public Zone(Boerderij boerderij)
        {
            zoneNaam = "Naamloos";
            zoneVerzorger = new Verzorger(boerderij);
            zoneOppervlakte = 0;
            zoneCapaciteit = 0;

            this.zoneBoerderij = boerderij;
            boerderij.zones[boerderij.zoneCounter] = this;
            boerderij.zoneCounter++;
        }

        public Zone(string naam, Verzorger verzorger, double oppervlakte, int capaciteit, Boerderij boerderij)
        {
            zoneNaam = naam;
            zoneVerzorger = verzorger;
            zoneOppervlakte = oppervlakte;
            zoneCapaciteit = capaciteit;

            this.zoneBoerderij = boerderij;
            boerderij.zones[boerderij.zoneCounter] = this;
            boerderij.zoneCounter++;


        }

        //methods
        public void KindVan(Dier ouder, int aantal)
        {
            RandomDieren randomNiewDier = new RandomDieren();

            

            for (int i = 0; i < aantal; i++)
            {
                double nieuwEtenPerDag = randomNiewDier.RandomEten(ouder.dierEtenPerDag);
                Dier kind = new Dier(randomNiewDier.RandomName(), ouder.dierSoort, ouder.dierZone, randomNiewDier.RandomLeeftijd(), ouder.dierVoedsel, nieuwEtenPerDag);

            }

        }

        public void VoegDierToe(Dier dier)
        {
            if (aantalDieren <= 50)
            {
                dieren[aantalDieren] = dier;
                aantalDieren++;
            }
            else
            {
                Console.WriteLine("De zone zit vol. Kan geen dier meer toegvoegen.");
            }
        }
        public string ZoneInfo()
        {
            specialMethods.Foreground(ConsoleColor.Blue);
            return string.Format($"Zone: \"{zoneNaam}\" met een capaciteit van {zoneCapaciteit} dieren en een oppervlakte van {zoneOppervlakte}m^2.     Verzorger: {zoneVerzorger.verzorgerVoornaam}\n");
            //Console.ResetColor(); zal niet uitgevoerd worden aangezien "return"
        }

        public void ZoneAlleDierInfo()
        {
            for (int i = 0; i < aantalDieren; i++)
            {
                Console.WriteLine(dieren[i].DierInfo());
            }
        }

        public string ZoneDierVoederKostTotaal()
        {
            specialMethods.Foreground(ConsoleColor.Red);
            prijsVoederInZone = 0;

            for (int i = 0; i < aantalDieren; i++)
            {
                prijsVoederInZone += dieren[i].dierVoedsel.voedselKostprijs * dieren[i].dierEtenPerDag;
            }


            return string.Format($"De totale voederkost in de zone: \"{zoneNaam}\" bedraagt: {Math.Round(prijsVoederInZone,2)} euro voor 1 dag.");
        }
    }
}
