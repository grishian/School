using System;
using System.Collections.Generic;

namespace Teambuilding
{
    class Activiteit
    {
        //fields and properties
        public string naam { get; set; }
        public bool indoor { get; set; }
        public Begeleider begeleider { get; set; }
        public double prijs { get; set; }

        static public List<Activiteit> activiteiten = new List<Activiteit>();

        public List<Inschrijving> inschrijvingenBijActiviteit = new List<Inschrijving>();
        public static List<Inschrijving> staticInschrijvingenLijst = new List<Inschrijving>();

        //ctor's
        public Activiteit()
        {
            naam = "";
            indoor = false;

            activiteiten.Add(this);

        }
        public Activiteit(bool indoor, Begeleider begeleider, double prijs)
        {
            this.indoor = indoor;
            this.begeleider = begeleider;
            this.prijs = prijs;

            activiteiten.Add(this);
        }

        public static void ZoekIetsOp(Object o)
        {
            //Console.WriteLine(typeof(Begeleider));
            //Console.WriteLine(o.GetType());

            
            if (o.GetType().Equals(typeof(Begeleider)))
            {
                Begeleider o2 = (Begeleider)o;

                Console.WriteLine($"\nInfo begeleider: \n{o.ToString()}\n");
                //attesten weergeven
                Console.WriteLine("Uitgebreide attesten lijst:");
                o2.ShowAttests();
                Console.WriteLine();

            }
            else if (o.GetType().Equals(typeof(Deelnemer)))
            {
                //neemt deel aan
                //inschrijvingenlijst afgaan
                int index = 1;
                foreach (Inschrijving inschrijving in staticInschrijvingenLijst)
                {

                    if (o.Equals(inschrijving.p))
                    {

                        //geef al de informatie over deelnemer
                        Console.WriteLine($"Inschrijving {index} van:");
                        index++;
                        Console.WriteLine($"\nInfo deelnemer: \n{o.ToString()}\n");
                        //geef al de activiteiten die de deelnemer doet
                        Console.WriteLine(inschrijving.ToString());
                    }
                }

                
            }
            else if (o.GetType().Equals(typeof(Muurklimmen)) || o.GetType().Equals(typeof(Duiken)) || o.GetType().Equals(typeof(ParachuteSpringen))) //is er een makkelijke manier om de parent te vinden? .Parent() ofzo?
            {

                Activiteit o2 = (Activiteit)o;

                //al de mensen die deelnemen
                Console.WriteLine("Al de mensen die deelnemen aan deze activiteit:\n");
                Console.WriteLine($"{o2}:\nInschrijvingen:\n");

                foreach (Inschrijving inschrijving in o2.inschrijvingenBijActiviteit)
                {
                    Console.WriteLine((o2.inschrijvingenBijActiviteit.IndexOf(inschrijving) + 1) + "\n" + inschrijving.p.voornaam + " " + inschrijving.p.achternaam);
                }
            }

        }

    }
}
