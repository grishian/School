using System;
using System.Collections.Generic;
using System.Text;

namespace Kinderboerderij
{
    class Boerderij
    {
        //fields and properties
        public ConsoleMethods specialMethods = new ConsoleMethods();

        public Zone[] zones = new Zone[30];
        public int zoneCounter = 0;
        public double totaleKostAlleZones = 0;

        public Bezoeker[] bezoekers = new Bezoeker[200];
        public int bezoekerCounter = 0;
        public double totaleKostAlleBoekers = 0;

        public Verzorger[] verzorgers = new Verzorger[15];
        public int verzorgerCounter = 0;




        //constructors

        //methods

            //hier all de bezoekers afgaan.
        public void BoerderijToonBezoekers()
        {
            specialMethods.ForegroundYellow();
            for (int i = 0; i < bezoekerCounter; i++)
            {
                Console.WriteLine(bezoekers[i].ToonBezoeker()); ;
            }
        }

        //eventueel de totaalprijs van bezoekers?
        public double BoerderijTotaalprijsBezoekers()
        {
            specialMethods.ForegroundRed();
            for (int i = 0; i < bezoekerCounter; i++)
            {
                totaleKostAlleBoekers += bezoekers[i].bezoekerPrijs;
            }

            return totaleKostAlleBoekers;
        }

        //hier alle zones afgaan.
        public void BoerderijToonZones()
        {
            specialMethods.ForegroundYellow();
            Console.WriteLine("Alle aangemaakte zones: \n");
            for (int i = 0; i < zoneCounter; i++)
            {
                Console.WriteLine("  " + zones[i].ZoneInfo());

            }
        }

            //hier de totale kost van alle zones samen

        public double TotaalKostAlleZones()
        {
            specialMethods.ForegroundRed();
            for (int i = 0; i < zoneCounter; i++)
            {
                totaleKostAlleZones += zones[i].prijsVoederInZone;
            }
            return Math.Round(totaleKostAlleZones,2);
        }

            //hier de verzorgers opsommen

        public void BoerderijToonVerzorgers()
        {
            specialMethods.ForegroundYellow();
            for (int i = 0; i < verzorgerCounter; i++)
            {
                verzorgers[i].verzorgerInfo();
            }
        }




    }
}
