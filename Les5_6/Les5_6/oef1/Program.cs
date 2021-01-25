using System;

namespace Les5_6
{
    class Program
    {
        // boeteprogramma
        static void Main(string[] args)
        {

            int standaardBoete = 53;
            int nieuweBoete;

            Console.WriteLine("Hoe snel ging die?");

            int snelheid = int.Parse(Console.ReadLine());

            if (snelheid > 60 && snelheid <61)
            {
                Console.WriteLine("Ja das een boete ze: " + standaardBoete + " euro");
            }
            else if (snelheid > 61 && snelheid < 70) {

                nieuweBoete = standaardBoete + 11 * (snelheid - 61);

                Console.WriteLine("Ja das een boete ze: " + nieuweBoete + " euro");

            }
            else if (snelheid > 71 && snelheid <= 80)
            {
                nieuweBoete = standaardBoete + 11 * (snelheid - 61);

                Console.WriteLine("Ja das een boete ze: " + nieuweBoete + " euro\n" +
                    "met mogelijk een rijverbod!");
            }
            else if (snelheid > 80)
            {
                nieuweBoete = standaardBoete + 11 * (snelheid - 61);

                Console.WriteLine("Ja das een boete ze: 80 - 4000 euro boi, met een rijverbod van: \n" +
                    "8 dagen tot 5 jaar :/ ");
            }
            else { Console.WriteLine("nee das geen boete"); }
        }
    }
}
