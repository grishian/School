using System;
using System.Collections.Generic;
using System.Text;

namespace Operatoroverloading
{
    class Rekening
    {
        private string naam;
        private double debet;
        private double credit;

        public Rekening()
        {
            naam = "Nog geen naam";
            debet = 0.0;
            credit = 0.0;
        }
        public Rekening(string naam, double debet, double credit)
        {
            this.naam = naam;
            this.debet = debet;
            this.credit = credit;
        }
        public string getNaam() { return naam; }
        public double getdebet() { return debet; }
        public double getCredit() { return credit; }

        public void setNaam(string naam) { this.naam = naam; }
        public void setDebet(double debet) { this.debet = debet; }
        public void setCredit(double credit) { this.credit = credit; }

        public void drukRekeningInfo()
        {
            Console.WriteLine($"{naam} heeft {debet} euor debet en {credit} euro credit");
        }

        public static Rekening operator+ (Rekening a, Rekening b)
        {
            Rekening rek = new Rekening();
            rek.debet = a.debet + b.debet;
            rek.credit = a.credit + b.credit;
            return rek;
        }
    }
}
