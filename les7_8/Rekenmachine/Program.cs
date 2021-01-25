using Rekenmachine.methods;
using System;

namespace Rekenmachine
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welke bewerking wil je doen?\n" +
                "Je hebt de keuze tussen:\n" +
                "optelling\n" +
                "aftrekking\n" +
                "vermenigvuldiging\n" +
                "deling\n" +
                "dubbele\n" +
                "helft\n" +
                "even\n" +
                "oneven\n");

            string bewerking = Console.ReadLine();

            switch (bewerking) {

                case "optelling":
                    Console.WriteLine(Calculator.som());
                    break;
                case "aftrekking":
                    Console.WriteLine(Calculator.verschil());
                    break;
                case "vermenigvuldiging":
                    Console.WriteLine(Calculator.vermenigvuldiging());
                    break;
                case "deling":
                    Console.WriteLine(Calculator.deling());
                    break;
                case "dubbele":
                    Console.WriteLine(Calculator.dubbel());
                    break;
                case "helft":
                    Console.WriteLine(Calculator.helft());
                    break;
                case "even":
                    Console.WriteLine(Calculator.even());
                    break;
                case "oneven":
                    Console.WriteLine(Calculator.oneven());
                    break;


                default:
                    Console.WriteLine("hmmm dat is foute input");
                    break;
                        
            }
        }
    }
}
