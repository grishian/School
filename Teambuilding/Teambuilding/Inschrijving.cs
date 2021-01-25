using System;
using System.Collections;
using System.Text;

namespace Teambuilding
{
    class Inschrijving
    {
        //fields and properties
        private ArrayList inschrijving = new ArrayList(); //misschien List gebruiken, hmm gewoon ene die meerdere soorten objecten kan houden
        public Persoon p;
        public Activiteit a;
        private DateTime d;

        //ctor's
        public Inschrijving(Persoon p, Activiteit a, DateTime d)
        {

            this.p = p;
            this.a = a;
            this.d = d;

            a.inschrijvingenBijActiviteit.Add(this);
            Activiteit.staticInschrijvingenLijst.Add(this);

            inschrijving.Add(p);
            inschrijving.Add(a);
            inschrijving.Add(d);
        }

        //methods
        public override string ToString()
        {
            return string.Format($"- Persoon: {p.voornaam} {p.achternaam}\n" +
                $"- Activiteit: {a.naam}\n" +
                $"- Datum: {d.ToString()}\n");
        }

    }
}
