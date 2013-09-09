﻿/*Task 12
 * Write a program that reads from the console a positive integer number N (N < 20) and outputs a matrix */

using System;

class NumberMatrix
{
    static void Main()
    {
        Console.Write("Enter N: ");
        int n = int.Parse(Console.ReadLine());

        if (n < 20)
        {
            int number = 1;

            for (int column = 1; column <= n; column++)
            {
                number = column;
                for (int row = 1; row <= n; row++)
                {

                    Console.Write(number);
                    number++;
                }

                Console.WriteLine();
            }
        }
        else
        {
            Console.WriteLine("Your number should be smaller than 20!");
        }
    }
}