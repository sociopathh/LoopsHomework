/*Task 7
 * Write a program that reads a number N and calculates 
 * the sum of the first N members of the sequence of Fibonacci: 0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144, 233, 377, …*/

using System;

class FibonacciFirstNSum
    {
        static void Main()
        {
            Console.Write("Enter N: ");
            ulong n = ulong.Parse(Console.ReadLine());

            ulong firstN = 1;
            ulong secondN = 0;
            ulong thirdN = 0;
            ulong sum = 0;

            for (ulong i = 0; i <= n; i++)
            {
                thirdN = firstN + secondN;
                firstN = secondN;
                secondN = thirdN;
                Console.WriteLine(i + ": " + thirdN);
                sum += thirdN;
            }
            Console.WriteLine("The Sum is: {0}", sum);
        }
    }

