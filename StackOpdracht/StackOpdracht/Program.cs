using System;
using System.Collections;
using System.Collections.Generic;


namespace StackOpdracht
{
    class Program
    {
        static void Main(string[] args)
        {


            //aanmaken/declaratie

            Stack mijnStack = new Stack();
            Stack testStack1 = new Stack(222);
            Stack testStack2 = new Stack(testStack1);


            //elementen toevoegen:
            Console.WriteLine("We voegen volgende elementen toe:\n" +
                "- \"hallo\"\n" +
                "- false\n" +
                "- getallen 0 tot 90(met sprongen van 10)\n" +
                "- de variabele \"getal1\"");

            int getal1 = 55000;

            mijnStack.Push("hallo");
            mijnStack.Push(false);
            mijnStack.Push(getal1);

            for (int i = 0; i < 10; i++)
            {
                mijnStack.Push(i * 10);
            }
            //printen1:
            PrintStack(mijnStack);

            //elementen zoeken met contains(obj)
            Console.WriteLine("we zoeken volgende woorden:");

            Console.WriteLine("Bevat de stack het woord: \"hallo\" ?");
            Console.WriteLine(mijnStack.Contains("hallo"));

            Console.WriteLine("Bevat de stack het woord: \"japan\" ?");
            Console.WriteLine(mijnStack.Contains("japan"));

            Console.WriteLine("Bevat de stack het getal: \"10\" ?");
            Console.WriteLine(mijnStack.Contains(10));

            //elementen verwijderen:
            //clear, pop
            Console.WriteLine("\n\n\nwe verwijderen 2 elementen uit de stack door tweemaal Pop() te doen.");

            mijnStack.Pop();
            mijnStack.Pop();

            //printen2
            PrintStack(mijnStack);

            Console.WriteLine("\n\n\nWe verwijderen alle elmenten uit de stack door Clear() te doen.");
            mijnStack.Clear();

            //printen3
            PrintStack(mijnStack);


            //sorteren, eerst wat random input toevoegen
            mijnStack.Push("belegerd");
            mijnStack.Push(5);
            mijnStack.Push(true);
            mijnStack.Push("test");
            mijnStack.Push(false);
            mijnStack.Push("Xander");
            mijnStack.Push(3);
            mijnStack.Push("nog wa tekst");
            mijnStack.Push(false);
            mijnStack.Push(100);
            mijnStack.Push(12);
            mijnStack.Push("abracadabra");
            mijnStack.Push(true);

            PrintStack(mijnStack);

            //sorteermethode
            SortStack(mijnStack);
            PrintStack(mijnStack);

        }


        public static void SortStack(Stack stack)
        {
            List<bool> boolList = new List<bool>();
            List<int> intList = new List<int>();
            List<string> stringList = new List<string>();

            int stackLength = stack.Count;

            for (int i = 0; i < stackLength; i++)
            {
                if (stack.Peek().GetType() == true.GetType())
                {
                    boolList.Add((bool)stack.Pop());
                }
                else if (stack.Peek().GetType() == "string".GetType())
                {
                    stringList.Add((string)stack.Pop());
                }
                else if (stack.Peek().GetType() == 0.GetType())
                {
                    intList.Add((int)stack.Pop());
                }
            }

            stringList.Sort();
            for (int i = stringList.Count-1; i >= 0 ; i--)
              {
                  stack.Push(stringList[i]);
              }
            intList.Sort();
            for (int i = intList.Count-1; i >=0 ; i--)
              {
                  stack.Push(intList[i]);
              }
            boolList.Sort();
            for (int i = boolList.Count-1; i >=0 ; i--)
              {
                  stack.Push(boolList[i]);
              }

        }

        public static void PrintStack(Stack stack)
        {
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine($"\nInformatie over de stack:\n");
            Console.ForegroundColor = ConsoleColor.Green;
            int index = 1;
            foreach (Object o in stack)
            {
                Console.WriteLine($"Object op plaats {index}: {o}");
                index++;
            }
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine($"\nDeze stack bevat {stack.Count} objecten.\n\n");
            Console.ResetColor();
        }

    }
}
