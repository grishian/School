using System;

namespace Amitacheck
{

    class Program
    {
        static void Main(string[] args)
        {
            

            Console.WriteLine("Geef getal in waarvan je de maaltafels wilt.");

            double testtt = double.Parse(Console.ReadLine());

            for (int i = 0; i < 20; i++)
            {

                Console.WriteLine($"{testtt} * {i} = {testtt*i}");


            }

        }





    }
}




