using System;

namespace Array1
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] array1 = new int[10]; //gebruiker
            int[] array2 = new int[10] { 5,2,3,8,7,4,6,5,4,2}; //code invoeren
            int[] array3 = new int[10]; //beide arrays opgeteld

            for (int i = 0; i < array1.Length; i++)
            {
                Console.Write($"plaats {i + 1}: ");
                array1[i] = Convert.ToInt32(Console.ReadLine());
            }

            for (int i = 0; i < array3.Length; i++)
            {
                array3[i] = array1[i] + array2[i];
            }

            for (int i = 0; i < array3.Length; i++)
            {
                Console.WriteLine($"array1 :{array1[i]} + array2 :{array2[i]} = array3 :{array3[i]} ");
            }



        }
    }
}
