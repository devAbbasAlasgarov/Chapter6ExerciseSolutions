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

            // Exercise 1

            // Solution 3 Do-while loop

            int n = int.Parse(Console.ReadLine());

            int i = 1;

            do
            {
                Console.Write(" " + i);
                i++;

            } while (i <= n);
            Console.Read();

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




