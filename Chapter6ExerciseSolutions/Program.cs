// Chapter 6 Exercises Solutions

using System;
using System.Threading;
using System.Globalization;
using System.Linq;
using System.Collections.Generic;
using System.Numerics;

namespace Chapter6ExercisesSolutions
{

    class MainClass
    {

        public static void Main(string[] args)
        {

            // Chapter 6 Exercises Solutions

            // Exercise 4
            Console.WriteLine("Tell me cards");


            // Exercise 3
            /*
            int smallestNumber = Int32.MinValue;
            int largerstNumber = Int32.MaxValue;
            int countOfNumbers = int.Parse(Console.ReadLine());
            int enteredNumber = 0;

            for(int i = 0; i < countOfNumbers; i++)
            {
                enteredNumber = int.Parse(Console.ReadLine());
                if (i == 0 && enteredNumber > smallestNumber && enteredNumber <largerstNumber)
                {
                    smallestNumber = enteredNumber;
                    largerstNumber = enteredNumber;
                    Console.WriteLine("Smallest number = " + smallestNumber);
                    Console.WriteLine("Largest number = " + largerstNumber);
                }
                else if(i > 0 && enteredNumber>smallestNumber && enteredNumber>largerstNumber)
                {
                    largerstNumber = enteredNumber;
                    Console.WriteLine("Smallest number = " + smallestNumber);
                    Console.WriteLine("Largest number = " + largerstNumber);
                }
                else if (i > 0 && enteredNumber > smallestNumber && enteredNumber < largerstNumber)
                {
                    Console.WriteLine("Smallest number = " + smallestNumber);
                    Console.WriteLine("Largest number = " + largerstNumber);
                }
                else if (i > 0 && enteredNumber < smallestNumber && enteredNumber < largerstNumber)
                {
                    smallestNumber = enteredNumber;
                    Console.WriteLine("Smallest number = " + smallestNumber);
                    Console.WriteLine("Largest number = " + largerstNumber);
                }
                else
                {
                    Console.WriteLine("Smallest number = " + smallestNumber);
                    Console.WriteLine("Largest number = " + largerstNumber);
                }

            }
            Console.Read();
            */

            // Exercise 2
            /*
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                if (i % 3 == 0 && i % 7 == 0)
                {
                    
                }
                else
                {
                    Console.Write(" " + i);
                }
            }
            Console.Read();
            */

            // Exercise 1

            // Solution 3 Do-while loop
            /*
            int n = int.Parse(Console.ReadLine());

            int i = 1;

            do
            {
                Console.Write(" " + i);
                i++;

            } while (i <= n);
            Console.Read();
            */

            // Solution 2 While loop
            /*
            int n = int.Parse(Console.ReadLine());

            int i = 1;
            while(i <= n)
            {
                Console.Write(" " + i);
                i++;
            }
            Console.Read();
            */

            // Solution 1 For loop
            /*
            int n = int.Parse(Console.ReadLine());

            for(int i = 1; i <= n; i++)
            {
                Console.Write(" " + i);
            }
            Console.Read();
            */
            
        }
    }
}




