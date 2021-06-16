using System;
using System.Collections.Generic;

namespace ArraysAndLists
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO:

            // Create an int Array and populate numbers 1-10


            int[] numbers = new int[10];

            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = i + 1;

            }

            List<int> evens = new List<int>();

            List<int> odds = new List<int>();


            foreach(var number in numbers)
            {
                if(number % 2 == 0)
                {
                    evens.Add(number);
                }
                else
                {
                    odds.Add(number);
                }
            }


            Console.WriteLine("Even numbers");
            foreach(var even in evens)
            {
                Console.WriteLine(even);
            }

            Console.WriteLine("Odd numbers");
            foreach(var odd in odds)
            {
                Console.WriteLine(odd);
            }

            /* Create two Lists of type int.
             * Name one List "evens"
             * Name the other List "odds"
             */

            /* Using either a foreach or for loop,
             * nest an if statement to check to see
             *  if a number is even or odd.
             * Then add those numbers to either the evens List
             * or the odds List
             */

            /* Now using foeach or for loops,
             * display each List of even and odd numbers
             *
             * Try to be creative in your display
             */
        }
    }
}
