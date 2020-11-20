using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace TestOneArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] scores = { 90, 70, 50, 80, 60, 85 };
            Console.Write("Please enter the value you want to search: ");
            int value = Convert.ToInt32(Console.ReadLine());

            bool isSearch = false;

            for (int index = 0; index < scores.Length; index++)
            {
                if (scores[index] == value)
                {
                    isSearch = true;
                    Console.Write($"Found value: {value} the index is: {index}");
                    break;
                }
            }

            if (!isSearch)
            {
                Console.Write($"The value {value} was not found");
            }
        }
    }
}
