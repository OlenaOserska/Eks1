//Завдання №1
using System;

namespace Projekt_Oserska
{
    class MainClass
    {
        public static void Main(string[] args)
        {
										
            Console.Write("Enter the number of digits in the array: ");
            int digits = int.Parse(Console.ReadLine());
            int[] array = new int[digits];
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write($"\nEnter the numbers {i}:\t");
                array[i] = int.Parse(Console.ReadLine());
            }
            int min = array[0];
            int max = array[0];

            foreach (int item in array)
            {
                if (min > item)
                {
                    min = item;
                }
                if (max < item)
                {
                    max = item;
                }
            }
            Console.WriteLine("minimum value: " + min);
            Console.WriteLine("maximum value: " + max);
        }
    }
}
