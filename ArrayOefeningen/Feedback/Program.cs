using System;

namespace Feedback
{
    class Program
    {
        static void Main(string[] args)
        {

            /* Maak een array waarin 6 punten worden ingeven op  20 . Geef de volgende feedback aan de student.
< 30  % zware onvoldoende
< 50 % onvoldoende
< 60 % voldoende
<75 %  goed
<90 % zeer goed
>90 % uitstekend. */


            double[] punten = new double[6];
            double gemiddelde;
            double totaal = 0;

            for (int i = 0; i < punten.Length; i++)
            {
                punten[i] = double.Parse(Console.ReadLine());
                totaal =+ punten[i];
            }

            gemiddelde = totaal / 6;




        }
    }
}
