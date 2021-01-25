using System;
using System.Collections.Generic;
using System.Text;

namespace Operatoroverloading
{
    class Breuk
    {
        private int numerator;
        private int denominator;

        public Breuk(int numerator, int denominator)
        {
            this.numerator = numerator;
            this.denominator = denominator;
        }

        public static Breuk operator+(Breuk frac1, Breuk frac2)
        {
            int product1 = frac1.numerator * frac2.denominator;
            int product2 = frac2.numerator * frac1.denominator;
            return new Breuk(product1 + product2, frac1.denominator * frac2.denominator);
        }

        public override string ToString()
        {
            string show = numerator.ToString() + "/" + denominator.ToString();
            return show;
        }
    }
}
