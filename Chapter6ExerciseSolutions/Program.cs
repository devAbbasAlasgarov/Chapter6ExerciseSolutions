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

            // Exercise 8


            // Exercise 7
            // Calculating N!*K!/(N-K)! Program

            // Solution 2
            // N! * K! / (N - K)! =  (N! / (K! * (N - K)!)) * K! * K!
            
            long N = int.Parse(Console.ReadLine());
            long K = int.Parse(Console.ReadLine());
            long factorialK = 1;
            long specialFormula = 1;
            double result = 0;

            for(long i = N-K+1; i <= N; i++)
            {
                specialFormula = specialFormula * i;
            }

            for (long i = 1; i <= K; i++)
            {
                factorialK = factorialK * i;
            }
            result = specialFormula * factorialK;
            Console.WriteLine(factorialK);
            Console.WriteLine(result);
            Console.Read();
            

            // Solution 1
            /*
            long N = int.Parse(Console.ReadLine());
            long K = int.Parse(Console.ReadLine());
            long factorialN = 1;
            long factorialK = 1;
            long factorialNminusK = 1;
            long result = 0;

            for(long i = 1; i <= N; i++)
            {
                factorialN = factorialN * i;
            }
            for (long i = 1; i <= K; i++)
            {
                factorialK = factorialK * i;
            }
            for (long i = 1; i <= N-K; i++)
            {
                factorialNminusK = factorialNminusK * i;
            }
            result = factorialN * factorialK / factorialNminusK;
            Console.WriteLine(result);
            Console.Read();
            */

            // Exercise 6
            // Calculating N!/K! Program
            /*
            int N = int.Parse(Console.ReadLine());
            int K = int.Parse(Console.ReadLine());
            int result = 1;

            for(int i = K+1; i <= N; i++)
            {
                result = result * i;
                
            }
            Console.WriteLine(result);
            
            Console.Read();
            */

            // Exercise 5
            // Sum of Fibbonacci numbers
            /*
            int N = int.Parse(Console.ReadLine());
            int[] array = new int[N] ;
            array[0] = 0;
            array[1] = 1;
            int sumOfFibonacciNumbers = 1;
            Console.WriteLine("Fibonacci numbers: ");
            Console.Write("{0} ", array[0]);
            Console.Write("{0} ", array[1]);

            for (int i = 2; i < N; i++)
            {
                array[i] = array[i-1] + array[i-2];
                Console.Write(array[i] + " ");
                sumOfFibonacciNumbers = sumOfFibonacciNumbers + array[i];
            }
            Console.WriteLine("\nSum of first {0} fibonacci numbers is {1}",
                                N, sumOfFibonacciNumbers);
            Console.Read();

            */

            // Exercise 4
            /*
             Number the cards from 2 to 14 (these numbers will match
             the cards 2, 3, 4, 5, 6, 7, 8, 9, 10, J, Q, K, A).
             Number the suits from 1 to 4 (1 – club, 2 – diamond,
             3 – heart and 4 – spades). Now you can use the two
             nested loops and print each of the cards with two
             switch statements.
             */
            /*
            for (int suitNumber = 1; suitNumber <= 4; suitNumber++)
            {
                switch (suitNumber)
                {

                        case 1:
                        for (int cardNumber = 1; cardNumber <= 13; cardNumber++)
                        {
                            switch (cardNumber)
                            {
                                case 1:
                                    Console.WriteLine("club 2");
                                    break;
                                case 2:
                                    Console.WriteLine("club 3");
                                    break;
                                case 3:
                                    Console.WriteLine("club 4");
                                    break;
                                case 4:
                                    Console.WriteLine("club 5");
                                    break;
                                case 5:
                                    Console.WriteLine("club 6");
                                    break;
                                case 6:
                                    Console.WriteLine("club 7");
                                    break;
                                case 7:
                                    Console.WriteLine("club 8");
                                    break;
                                case 8:
                                    Console.WriteLine("club 9");
                                    break;
                                case 9:
                                    Console.WriteLine("club 10");
                                    break;
                                case 10:
                                    Console.WriteLine("club J");
                                    break;
                                case 11:
                                    Console.WriteLine("club Q");
                                    break;
                                case 12:
                                    Console.WriteLine("club K");
                                    break;
                                case 13:
                                    Console.WriteLine("club A");
                                    break;
                            }
                        }
                        break;


                        case 2:
                        for (int cardNumber = 1; cardNumber <= 13; cardNumber++)
                        {
                            switch (cardNumber)
                            {
                                case 1:
                                    Console.WriteLine("diamond 2");
                                    break;
                                case 2:
                                    Console.WriteLine("diamond 3");
                                    break;
                                case 3:
                                    Console.WriteLine("diamond 4");
                                    break;
                                case 4:
                                    Console.WriteLine("diamond 5");
                                    break;
                                case 5:
                                    Console.WriteLine("diamond 6");
                                    break;
                                case 6:
                                    Console.WriteLine("diamond 7");
                                    break;
                                case 7:
                                    Console.WriteLine("diamond 8");
                                    break;
                                case 8:
                                    Console.WriteLine("diamond 9");
                                    break;
                                case 9:
                                    Console.WriteLine("diamond 10");
                                    break;
                                case 10:
                                    Console.WriteLine("diamond J");
                                    break;
                                case 11:
                                    Console.WriteLine("diamond Q");
                                    break;
                                case 12:
                                    Console.WriteLine("diamond K");
                                    break;
                                case 13:
                                    Console.WriteLine("diamond A");
                                    break;
                            }
                        }
                        break;


                        case 3:
                        for (int cardNumber = 1; cardNumber <= 13; cardNumber++)
                        {
                            switch (cardNumber)
                            {
                                case 1:
                                    Console.WriteLine("heart 2");
                                    break;
                                case 2:
                                    Console.WriteLine("heart 3");
                                    break;
                                case 3:
                                    Console.WriteLine("heart 4");
                                    break;
                                case 4:
                                    Console.WriteLine("heart 5");
                                    break;
                                case 5:
                                    Console.WriteLine("heart 6");
                                    break;
                                case 6:
                                    Console.WriteLine("heart 7");
                                    break;
                                case 7:
                                    Console.WriteLine("heart 8");
                                    break;
                                case 8:
                                    Console.WriteLine("heart 9");
                                    break;
                                case 9:
                                    Console.WriteLine("heart 10");
                                    break;
                                case 10:
                                    Console.WriteLine("heart J");
                                    break;
                                case 11:
                                    Console.WriteLine("heart Q");
                                    break;
                                case 12:
                                    Console.WriteLine("heart K");
                                    break;
                                case 13:
                                    Console.WriteLine("heart A");
                                    break;
                            }
                        }
                        break;


                        case 4:
                        for (int cardNumber = 1; cardNumber <= 13; cardNumber++)
                        {
                            switch (cardNumber)
                            {
                                case 1:
                                    Console.WriteLine("spades 2");
                                    break;
                                case 2:
                                    Console.WriteLine("spades 3");
                                    break;
                                case 3:
                                    Console.WriteLine("spades 4");
                                    break;
                                case 4:
                                    Console.WriteLine("spades 5");
                                    break;
                                case 5:
                                    Console.WriteLine("spades 6");
                                    break;
                                case 6:
                                    Console.WriteLine("spades 7");
                                    break;
                                case 7:
                                    Console.WriteLine("spades 8");
                                    break;
                                case 8:
                                    Console.WriteLine("spades 9");
                                    break;
                                case 9:
                                    Console.WriteLine("spades 10");
                                    break;
                                case 10:
                                    Console.WriteLine("spades J");
                                    break;
                                case 11:
                                    Console.WriteLine("spades Q");
                                    break;
                                case 12:
                                    Console.WriteLine("spades K");
                                    break;
                                case 13:
                                    Console.WriteLine("spades A");
                                    break;
                            }
                        }
                        break;
                        
                }
                
            }
            Console.Read();
            */

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




